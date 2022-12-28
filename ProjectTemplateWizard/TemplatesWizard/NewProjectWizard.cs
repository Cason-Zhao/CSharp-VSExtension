using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatesWizard
{
    public class NewProjectWizard : IWizard
    {
        #region Fields & Properties

        private DTE _dte = null;

        private int _TargetTemplateType = 0;

        private TemplateTypeHelper _TemplateHelper;

        private EventLog _EventLog = new EventLog();

        #endregion

        public void BeforeOpeningFile(ProjectItem projectItem)
        {
            //throw new NotImplementedException();
        }


        public void ProjectFinishedGenerating(Project project)
        {
            try
            {
                CreateProjectX(TemplateTypeEnum.Business);
                CreateProjectX(TemplateTypeEnum.DalFactory);
                CreateProjectX(TemplateTypeEnum.Win);
                CreateProjectX(TemplateTypeEnum.Web);
                CreateProjectX(TemplateTypeEnum.Wap);
                CreateProjectX(TemplateTypeEnum.WebApi);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"({nameof(ProjectFinishedGenerating)})Template: {_TargetTemplateType}." + ex.Message + ex.StackTrace);

                
                //_EventLog.Source = $"{nameof(NewProjectWizard)}.{nameof(ProjectFinishedGenerating)}";
                _EventLog.WriteEntry("项目创建失败，原因:" + ex.Message);
            }
        }

        void CreateProjectX(TemplateTypeEnum templateType)
        {
            if ((_TargetTemplateType & (int)templateType) == (int)templateType)
            {
                CreateProject(templateType);
            }
        }

        void CreateProject(TemplateTypeEnum templateType)
        {
            var helper = _TemplateHelper.Clone(templateType);
            try
            {
                _dte.Solution.AddFromTemplate(helper.TemplatePath, helper.ProjectPath, helper.ProjectName);
                var x = _dte.ActiveSolutionProjects;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"({nameof(CreateProject)})Template: {_TargetTemplateType}." + ex.Message + ex.StackTrace);
            }
        }

        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {
            //throw new NotImplementedException();
        }

        public void RunFinished()
        {
            //throw new NotImplementedException();
        }

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            try
            {
                _dte = automationObject as DTE;

                var projectName = replacementsDictionary["$safeprojectname$"];

                var solutionDir = System.IO.Path.GetDirectoryName(replacementsDictionary["$destinationdirectory$"]);

                var templateDir = System.IO.Path.GetDirectoryName(customParams[0] as string);

                var dialog = new FMChoose(); 
                if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                {
                    throw new WizardBackoutException();
                }
                _TargetTemplateType = dialog.TargetType;

                _TemplateHelper = new TemplateTypeHelper(solutionDir, templateDir, projectName);
            }
            catch (Exception)
            {
                //if (Directory.Exists(_solutionDir))

                //    Directory.Delete(_solutionDir, true);
                //throw;
            }
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }
}
