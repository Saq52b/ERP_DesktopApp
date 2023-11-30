namespace DesktopApplication.Pages
{
    partial class DailyExpense
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyExpense));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ExpenseList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Add = new DevExpress.XtraEditors.CheckButton();
            this.Close = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.PPanel = new DevExpress.XtraEditors.PanelControl();
            this.DPanel = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Approved = new DevExpress.XtraEditors.SimpleButton();
            this.Draft = new DevExpress.XtraEditors.SimpleButton();
            this.ToDate = new DevExpress.XtraEditors.DateEdit();
            this.FromDate = new DevExpress.XtraEditors.DateEdit();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.labelControl1.Size = new System.Drawing.Size(102, 31);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "List of Expense";
            // 
            // ExpenseList
            // 
            this.ExpenseList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpenseList.Location = new System.Drawing.Point(0, 108);
            this.ExpenseList.MainView = this.gridView1;
            this.ExpenseList.Name = "ExpenseList";
            this.ExpenseList.Size = new System.Drawing.Size(870, 310);
            this.ExpenseList.TabIndex = 1;
            this.ExpenseList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.ExpenseList;
            this.gridView1.Name = "gridView1";
            // 
            // Add
            // 
            this.Add.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Add.Appearance.Options.UseFont = true;
            this.Add.Appearance.Options.UseForeColor = true;
            this.Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Add.ImageOptions.Image")));
            this.Add.Location = new System.Drawing.Point(1, 9);
            this.Add.Name = "Add";
            this.Add.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.Add.Size = new System.Drawing.Size(75, 26);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add";
            this.Add.CheckedChanged += new System.EventHandler(this.Add_CheckedChanged);
            // 
            // Close
            // 
            this.Close.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Appearance.ForeColor = System.Drawing.Color.Red;
            this.Close.Appearance.Options.UseFont = true;
            this.Close.Appearance.Options.UseForeColor = true;
            this.Close.Location = new System.Drawing.Point(82, 9);
            this.Close.Name = "Close";
            this.Close.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.Close.Size = new System.Drawing.Size(75, 26);
            this.Close.TabIndex = 3;
            this.Close.Text = "Close";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.panelControl4);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(870, 48);
            this.panelControl1.TabIndex = 6;
            // 
            // panelControl4
            // 
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl4.Controls.Add(this.Add);
            this.panelControl4.Controls.Add(this.Close);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl4.Location = new System.Drawing.Point(710, 0);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(160, 48);
            this.panelControl4.TabIndex = 4;
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.PPanel);
            this.panelControl2.Controls.Add(this.DPanel);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.Approved);
            this.panelControl2.Controls.Add(this.Draft);
            this.panelControl2.Controls.Add(this.ToDate);
            this.panelControl2.Controls.Add(this.FromDate);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 48);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(870, 60);
            this.panelControl2.TabIndex = 7;
            // 
            // PPanel
            // 
            this.PPanel.Appearance.BackColor = System.Drawing.SystemColors.HotTrack;
            this.PPanel.Appearance.Options.UseBackColor = true;
            this.PPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PPanel.Location = new System.Drawing.Point(89, 55);
            this.PPanel.Name = "PPanel";
            this.PPanel.Size = new System.Drawing.Size(75, 2);
            this.PPanel.TabIndex = 11;
            // 
            // DPanel
            // 
            this.DPanel.Appearance.BackColor = System.Drawing.SystemColors.HotTrack;
            this.DPanel.Appearance.Options.UseBackColor = true;
            this.DPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.DPanel.Location = new System.Drawing.Point(4, 55);
            this.DPanel.Name = "DPanel";
            this.DPanel.Size = new System.Drawing.Size(75, 2);
            this.DPanel.TabIndex = 10;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(640, 16);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "To Date";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(422, 16);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "From Date";
            // 
            // Approved
            // 
            this.Approved.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Approved.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.Approved.Appearance.Options.UseBackColor = true;
            this.Approved.Appearance.Options.UseBorderColor = true;
            this.Approved.Location = new System.Drawing.Point(88, 34);
            this.Approved.Name = "Approved";
            this.Approved.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.Approved.Size = new System.Drawing.Size(75, 23);
            this.Approved.TabIndex = 7;
            this.Approved.Text = "Post";
            this.Approved.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // Draft
            // 
            this.Draft.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.Draft.Appearance.Options.UseBorderColor = true;
            this.Draft.Location = new System.Drawing.Point(3, 34);
            this.Draft.Name = "Draft";
            this.Draft.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.Draft.Size = new System.Drawing.Size(75, 23);
            this.Draft.TabIndex = 6;
            this.Draft.Text = "Draft";
            this.Draft.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // ToDate
            // 
            this.ToDate.EditValue = new System.DateTime(2023, 2, 2, 16, 55, 7, 0);
            this.ToDate.Location = new System.Drawing.Point(692, 15);
            this.ToDate.Name = "ToDate";
            this.ToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ToDate.Properties.DisplayFormat.FormatString = "";
            this.ToDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ToDate.Properties.EditFormat.FormatString = "";
            this.ToDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ToDate.Properties.MaskSettings.Set("mask", "");
            this.ToDate.Size = new System.Drawing.Size(160, 20);
            this.ToDate.TabIndex = 5;
            this.ToDate.EditValueChanged += new System.EventHandler(this.ToDate_EditValueChanged);
            // 
            // FromDate
            // 
            this.FromDate.EditValue = new System.DateTime(2022, 1, 1, 16, 54, 7, 0);
            this.FromDate.Location = new System.Drawing.Point(489, 15);
            this.FromDate.Name = "FromDate";
            this.FromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FromDate.Properties.DisplayFormat.FormatString = "";
            this.FromDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.FromDate.Properties.EditFormat.FormatString = "";
            this.FromDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.FromDate.Properties.MaskSettings.Set("mask", "");
            this.FromDate.Properties.TodayDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.FromDate.Size = new System.Drawing.Size(141, 20);
            this.FromDate.TabIndex = 4;
            this.FromDate.EditValueChanged += new System.EventHandler(this.FromDate_EditValueChanged);
            // 
            // panelControl3
            // 
            this.panelControl3.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 418);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(870, 60);
            this.panelControl3.TabIndex = 8;
            // 
            // DailyExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ExpenseList);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl3);
            this.Name = "DailyExpense";
            this.Size = new System.Drawing.Size(870, 478);
            this.Load += new System.EventHandler(this.DailyExpense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl ExpenseList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.CheckButton Add;
        private DevExpress.XtraEditors.SimpleButton Close;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton Approved;
        private DevExpress.XtraEditors.SimpleButton Draft;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl PPanel;
        private DevExpress.XtraEditors.PanelControl DPanel;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit ToDate;
        private DevExpress.XtraEditors.DateEdit FromDate;
    }
}
