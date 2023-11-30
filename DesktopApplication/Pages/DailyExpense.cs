using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using DevExpress.Office;
using System.Web.Helpers;
using static DesktopApplication.Pages.DayStart;
using DevExpress.XtraEditors.Filtering.Templates;
using DevExpress.XtraNavBar;
using DesktopApplication.Pages.DalyExpense;

namespace DesktopApplication.Pages
{
    public partial class DailyExpense : DevExpress.XtraEditors.XtraUserControl
    {
        HttpClient client = connection.GetConnection();
        public DailyExpense()
        {
            InitializeComponent();
        }
        public object GetDailyExpense(string status,DateTime fromdate, DateTime todate) {
            var daystartclaim = Global.modelWiseClaims.Find(x => x.TokenName == "Expenses");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", daystartclaim.Token);
            var response = client.GetAsync("Company/DailyExpenseList?status="+status + "&pageNumber=" + 1 + "&fromDate=" + fromdate + "&toDate=" + todate + "&totalAmount=" + 0).Result;
            var expenses = JsonConvert.DeserializeObject<PagedResult<List<DailyExpenseLookUpModel>>>(response.Content.ReadAsStringAsync().Result);
            return expenses.Results;
        }
       private void DailyExpense_Load(object sender, EventArgs e)
        {
            PPanel.Visible = false;
            localparam.status = "Draft";
            localparam.fromdate = (DateTime)FromDate.EditValue;
            localparam.todate = (DateTime)ToDate.EditValue;
            ExpenseList.DataSource = GetDailyExpense(localparam.status, localparam.fromdate, localparam.todate);
        }
        public static class localparam
        {
            public static string status { get; set; }
            public static DateTime fromdate { get; set;}
            public static DateTime todate { get; set;}
        }


        private void ToDate_EditValueChanged(object sender, EventArgs e)
        {
            localparam.todate = (DateTime)ToDate.EditValue;
            ExpenseList.DataSource = GetDailyExpense(localparam.status, localparam.fromdate, localparam.todate);

           
        }

        private void FromDate_EditValueChanged(object sender, EventArgs e)
        {
            localparam.fromdate = (DateTime)FromDate.EditValue;
            ExpenseList.DataSource = GetDailyExpense(localparam.status, localparam.fromdate, localparam.todate);

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DPanel.Visible = true;
            PPanel.Visible = false;
            localparam.status = "Draft";
            localparam.fromdate = (DateTime)FromDate.EditValue;
            localparam.todate = (DateTime)ToDate.EditValue;
            ExpenseList.DataSource = GetDailyExpense(localparam.status, localparam.fromdate, localparam.todate);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
         DPanel.Visible = false;
            PPanel.Visible = true; 
            localparam.status = "Approved";
            localparam.fromdate = (DateTime)FromDate.EditValue;
            localparam.todate = (DateTime)ToDate.EditValue;
            ExpenseList.DataSource = GetDailyExpense(localparam.status, localparam.fromdate, localparam.todate);

        }

        private void Add_CheckedChanged(object sender, EventArgs e)
        {
            XtraForm2 ae = new XtraForm2();
            ae.Show();

        }
    }
}
