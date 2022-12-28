
namespace TemplatesWizard
{
    partial class FMChoose
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ckbBLL = new System.Windows.Forms.CheckBox();
            this.ckbDal = new System.Windows.Forms.CheckBox();
            this.ckbWin = new System.Windows.Forms.CheckBox();
            this.ckbWeb = new System.Windows.Forms.CheckBox();
            this.ckbWap = new System.Windows.Forms.CheckBox();
            this.ckbWebAPI = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ckbBLL
            // 
            this.ckbBLL.AutoSize = true;
            this.ckbBLL.Location = new System.Drawing.Point(26, 22);
            this.ckbBLL.Name = "ckbBLL";
            this.ckbBLL.Size = new System.Drawing.Size(72, 16);
            this.ckbBLL.TabIndex = 0;
            this.ckbBLL.Text = "Business";
            this.ckbBLL.UseVisualStyleBackColor = true;
            // 
            // ckbDal
            // 
            this.ckbDal.AutoSize = true;
            this.ckbDal.Location = new System.Drawing.Point(26, 44);
            this.ckbDal.Name = "ckbDal";
            this.ckbDal.Size = new System.Drawing.Size(84, 16);
            this.ckbDal.TabIndex = 1;
            this.ckbDal.Text = "DalFactory";
            this.ckbDal.UseVisualStyleBackColor = true;
            // 
            // ckbWin
            // 
            this.ckbWin.AutoSize = true;
            this.ckbWin.Location = new System.Drawing.Point(143, 22);
            this.ckbWin.Name = "ckbWin";
            this.ckbWin.Size = new System.Drawing.Size(42, 16);
            this.ckbWin.TabIndex = 2;
            this.ckbWin.Text = "Win";
            this.ckbWin.UseVisualStyleBackColor = true;
            // 
            // ckbWeb
            // 
            this.ckbWeb.AutoSize = true;
            this.ckbWeb.Location = new System.Drawing.Point(143, 44);
            this.ckbWeb.Name = "ckbWeb";
            this.ckbWeb.Size = new System.Drawing.Size(42, 16);
            this.ckbWeb.TabIndex = 3;
            this.ckbWeb.Text = "Web";
            this.ckbWeb.UseVisualStyleBackColor = true;
            // 
            // ckbWap
            // 
            this.ckbWap.AutoSize = true;
            this.ckbWap.Location = new System.Drawing.Point(238, 22);
            this.ckbWap.Name = "ckbWap";
            this.ckbWap.Size = new System.Drawing.Size(42, 16);
            this.ckbWap.TabIndex = 4;
            this.ckbWap.Text = "Wap";
            this.ckbWap.UseVisualStyleBackColor = true;
            // 
            // ckbWebAPI
            // 
            this.ckbWebAPI.AutoSize = true;
            this.ckbWebAPI.Location = new System.Drawing.Point(238, 44);
            this.ckbWebAPI.Name = "ckbWebAPI";
            this.ckbWebAPI.Size = new System.Drawing.Size(60, 16);
            this.ckbWebAPI.TabIndex = 5;
            this.ckbWebAPI.Text = "WebAPI";
            this.ckbWebAPI.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(79, 82);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(165, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "创建";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(79, 111);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FMChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 139);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.ckbWebAPI);
            this.Controls.Add(this.ckbWap);
            this.Controls.Add(this.ckbWeb);
            this.Controls.Add(this.ckbWin);
            this.Controls.Add(this.ckbDal);
            this.Controls.Add(this.ckbBLL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FMChoose";
            this.Text = "选择类型";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbBLL;
        private System.Windows.Forms.CheckBox ckbDal;
        private System.Windows.Forms.CheckBox ckbWin;
        private System.Windows.Forms.CheckBox ckbWeb;
        private System.Windows.Forms.CheckBox ckbWap;
        private System.Windows.Forms.CheckBox ckbWebAPI;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}