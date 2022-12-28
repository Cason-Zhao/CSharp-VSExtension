using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplatesWizard
{
    public partial class FMChoose : Form
    {
        public int TargetType
        {
            get
            {
                return
                    (ckbBLL.Checked ? (int)(TemplateTypeEnum.Business) : 0)
                    | (ckbDal.Checked ? (int)(TemplateTypeEnum.DalFactory) : 0)
                    | (ckbWin.Checked ? (int)(TemplateTypeEnum.Win) : 0)
                    | (ckbWeb.Checked ? (int)(TemplateTypeEnum.Web) : 0)
                    | (ckbWap.Checked ? (int)(TemplateTypeEnum.Wap) : 0)
                    | (ckbWebAPI.Checked ? (int)(TemplateTypeEnum.WebApi) : 0);
            }
        }

        public FMChoose()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
