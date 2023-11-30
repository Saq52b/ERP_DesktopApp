namespace DesktopApplication
{
    partial class Loginpg
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginpg));
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.error = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.Loginbtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Pass = new DevExpress.XtraEditors.TextEdit();
            this.User = new DevExpress.XtraEditors.TextEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.User.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl5
            // 
            this.panelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl5.ContentImage = ((System.Drawing.Image)(resources.GetObject("panelControl5.ContentImage")));
            this.panelControl5.Controls.Add(this.error);
            this.panelControl5.Controls.Add(this.simpleButton2);
            this.panelControl5.Controls.Add(this.simpleButton1);
            this.panelControl5.Controls.Add(this.labelControl4);
            this.panelControl5.Controls.Add(this.Loginbtn);
            this.panelControl5.Controls.Add(this.labelControl3);
            this.panelControl5.Controls.Add(this.labelControl2);
            this.panelControl5.Controls.Add(this.labelControl1);
            this.panelControl5.Controls.Add(this.Pass);
            this.panelControl5.Controls.Add(this.User);
            resources.ApplyResources(this.panelControl5, "panelControl5");
            this.panelControl5.Name = "panelControl5";
            // 
            // error
            // 
            this.error.Appearance.ForeColor = System.Drawing.Color.Red;
            this.error.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(this.error, "error");
            this.error.Name = "error";
            // 
            // simpleButton2
            // 
            resources.ApplyResources(this.simpleButton2, "simpleButton2");
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            resources.ApplyResources(this.simpleButton1, "simpleButton1");
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl4.Appearance.Font")));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(this.labelControl4, "labelControl4");
            this.labelControl4.Name = "labelControl4";
            // 
            // Loginbtn
            // 
            this.Loginbtn.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Loginbtn.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.Loginbtn.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("Loginbtn.Appearance.Font")));
            this.Loginbtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.Loginbtn.Appearance.Options.UseBackColor = true;
            this.Loginbtn.Appearance.Options.UseBorderColor = true;
            this.Loginbtn.Appearance.Options.UseFont = true;
            this.Loginbtn.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(this.Loginbtn, "Loginbtn");
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl3.Appearance.Font")));
            this.labelControl3.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.labelControl3, "labelControl3");
            this.labelControl3.Name = "labelControl3";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl2.Appearance.Font")));
            this.labelControl2.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.labelControl2, "labelControl2");
            this.labelControl2.Name = "labelControl2";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl1.Appearance.Font")));
            this.labelControl1.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // Pass
            // 
            resources.ApplyResources(this.Pass, "Pass");
            this.Pass.Name = "Pass";
            this.Pass.Properties.PasswordChar = '*';
            this.Pass.Properties.UseSystemPasswordChar = true;
            // 
            // User
            // 
            resources.ApplyResources(this.User, "User");
            this.User.Name = "User";
            this.User.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.User.Properties.Appearance.Options.UseBackColor = true;
            this.User.Properties.Appearance.Options.UseImage = true;
            this.User.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Loginpg
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.Controls.Add(this.panelControl5);
            this.DoubleBuffered = true;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Loginpg.IconOptions.Image")));
            this.Name = "Loginpg";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            this.panelControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.User.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.SimpleButton Loginbtn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit Pass;
        private DevExpress.XtraEditors.TextEdit User;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl error;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}