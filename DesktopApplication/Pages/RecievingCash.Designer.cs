namespace DesktopApplication.Pages
{
    partial class RecievingCash
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.CashReceiving = new DevExpress.XtraEditors.SimpleButton();
            this.Close = new DevExpress.XtraEditors.SimpleButton();
            this.Password = new DevExpress.XtraEditors.TextEdit();
            this.CashAmount = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CashAmount.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(84)))), ((int)(((byte)(125)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(442, 32);
            this.panelControl1.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelControl1.Size = new System.Drawing.Size(118, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "CashReceiving";
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.CashReceiving);
            this.panelControl2.Controls.Add(this.Close);
            this.panelControl2.Controls.Add(this.Password);
            this.panelControl2.Controls.Add(this.CashAmount);
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(442, 212);
            this.panelControl2.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(64, 114);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(67, 14);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Password: ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(64, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 14);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "ReceivedCash:";
            // 
            // CashReceiving
            // 
            this.CashReceiving.Enabled = false;
            this.CashReceiving.Location = new System.Drawing.Point(234, 161);
            this.CashReceiving.Name = "CashReceiving";
            this.CashReceiving.Size = new System.Drawing.Size(90, 23);
            this.CashReceiving.TabIndex = 3;
            this.CashReceiving.Text = "CashReceiving";
            this.CashReceiving.Click += new System.EventHandler(this.CashReceiving_Click);
            // 
            // Close
            // 
            this.Close.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(84)))), ((int)(((byte)(125)))));
            this.Close.Appearance.Options.UseBackColor = true;
            this.Close.Location = new System.Drawing.Point(330, 161);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 2;
            this.Close.Text = "Close";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Password
            // 
            this.Password.EditValue = "";
            this.Password.Location = new System.Drawing.Point(159, 113);
            this.Password.Name = "Password";
            this.Password.Properties.UseSystemPasswordChar = true;
            this.Password.Size = new System.Drawing.Size(246, 20);
            this.Password.TabIndex = 1;
            this.Password.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.Password_EditValueChanging);
            // 
            // CashAmount
            // 
            this.CashAmount.Enabled = false;
            this.CashAmount.Location = new System.Drawing.Point(159, 70);
            this.CashAmount.Name = "CashAmount";
            this.CashAmount.Size = new System.Drawing.Size(246, 20);
            this.CashAmount.TabIndex = 0;
            // 
            // RecievingCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 210);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecievingCash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecievingCash";
            this.Load += new System.EventHandler(this.RecievingCash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CashAmount.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton CashReceiving;
        private DevExpress.XtraEditors.SimpleButton Close;
        private DevExpress.XtraEditors.TextEdit Password;
        private DevExpress.XtraEditors.TextEdit CashAmount;
    }
}