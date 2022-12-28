using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TemplatesWizard
{
    public class SafeProjectGroupName : IWizard
    {
        public const string ParameterName = "$safeprojectgroupname$";

        static ThreadLocal<string> projectGroupName = new ThreadLocal<string>();

        bool IsRootWizard;

        public void BeforeOpeningFile(ProjectItem projectItem)
        {
        }

        public void ProjectFinishedGenerating(Project project)
        {
        }

        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {
        }

        public void RunFinished()
        {
            if(this.IsRootWizard)
            {
                projectGroupName.Value = null;
            }
        }

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            if(projectGroupName.Value == null)
            {
                var name = replacementsDictionary["$safeprojectname$"];
                if(name.EndsWith($".{TemplateTypeEnum.Business.GetName()}"))
                {
                    projectGroupName.Value = name.Replace($".{TemplateTypeEnum.Business.GetName()}", string.Empty);
                }
                else if (name.EndsWith($".{TemplateTypeEnum.DalFactory.GetName()}"))
                {
                    projectGroupName.Value = name.Replace($".{TemplateTypeEnum.DalFactory.GetName()}", string.Empty);
                }
                else if (name.EndsWith($".{TemplateTypeEnum.Win.GetName()}"))
                {
                    projectGroupName.Value = name.Replace($".{TemplateTypeEnum.Win.GetName()}", string.Empty);
                }
                else if (name.EndsWith($".{TemplateTypeEnum.Web.GetName()}"))
                {
                    projectGroupName.Value = name.Replace($".{TemplateTypeEnum.Web.GetName()}", string.Empty);
                }
                else if (name.EndsWith($".{TemplateTypeEnum.Wap.GetName()}"))
                {
                    projectGroupName.Value = name.Replace($".{TemplateTypeEnum.Wap.GetName()}", string.Empty);
                }
                else if (name.EndsWith($".{TemplateTypeEnum.WebApi.GetName()}"))
                {
                    projectGroupName.Value = name.Replace($".{TemplateTypeEnum.WebApi.GetName()}", string.Empty);
                }

                this.IsRootWizard = true;
            }

            replacementsDictionary[ParameterName] = projectGroupName.Value;
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }
}
