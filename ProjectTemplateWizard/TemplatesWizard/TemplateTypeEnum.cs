using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatesWizard
{
    public enum TemplateTypeEnum: int
    {
        Business = 1,
        DalFactory = 2,
        Win = 4,
        Web = 8,
        Wap = 16,
        WebApi = 32,
    }

    public static class TemplateTypeEnumExtension
    {
        public static string GetName(this TemplateTypeEnum key)
        {
            return Enum.GetName(typeof(TemplateTypeEnum), key);
        }

        public static string GetDirectory(this TemplateTypeEnum key)
        {
            switch(key)
            {
                case TemplateTypeEnum.Web:
                    return @"EngineURP.Web\Areas";
                case TemplateTypeEnum.Wap:
                    return @"EngineURP.WAP\Areas";
                case TemplateTypeEnum.WebApi:
                    return @"EngineURP.WebApi\Areas";
                default:
                    return "";
            }
        }
    }

    public class TemplateTypeHelper: ICloneable
    {
        public TemplateTypeEnum TemplateType { get; set; }

        public string SolutionDir { get; private set; }

        public string TemplateDir { get; private set; }

        public string InputProjectName { get; private set; }

        public string ProjectName { get { return $"{this.InputProjectName}.{this.TemplateType.GetName()}"; } }

        public virtual string ProjectPath { get { return Path.Combine(this.SolutionDir, this.TemplateType.GetDirectory(), this.InputProjectName, this.ProjectName); } }

        public virtual string TemplateName { get { return $"URP.{this.TemplateType.GetName()}"; } }

        public virtual string TemplatePath { get { return Path.Combine(Path.GetDirectoryName(this.TemplateDir), $"URP.Modules.zip\\{this.TemplateName}\\{this.TemplateName}.vstemplate");} }

        public TemplateTypeHelper(string solutionDir, string templateDir, string inputProjName)
        {
            this.SolutionDir = solutionDir;
            this.TemplateDir = templateDir;
            this.InputProjectName = inputProjName;
        }

        public TemplateTypeHelper Clone(TemplateTypeEnum templateType)
        {
            var result = (TemplateTypeHelper)this.Clone();
            result.TemplateType = templateType;

            return result;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
