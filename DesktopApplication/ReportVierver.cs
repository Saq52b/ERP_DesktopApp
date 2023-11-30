using System;
using DesktopApplication.Reports;
using DevExpress.XtraPrinting.Preview;

namespace DesktopApplication
{
    public partial class ReportVierver : DevExpress.XtraEditors.XtraForm
    {
        public ReportVierver()
        {
            InitializeComponent();
        }

        private void ReportVierver_Load(object sender, EventArgs e)
        {
            var dend=new Dayend();
            RViewer.DocumentSource = dend;
            RViewer.InitiateDocumentCreation();
        }
    }
}