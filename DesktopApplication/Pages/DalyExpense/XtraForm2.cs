using DesktopApplication.GetDAilyExpense;
using DesktopApplication.Model;
using DevExpress.XtraEditors;
using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace DesktopApplication.Pages.DalyExpense
{
    public partial class XtraForm2 : DevExpress.XtraEditors.XtraForm
    {
        HttpClient client = connection.GetConnection();
        public XtraForm2()
        {
            InitializeComponent();
        }

        private void XtraForm2_Load(object sender, EventArgs e)
        {
             var Expense = Global.modelWiseClaims.Find(x => x.TokenName == "Expenses");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Expense.Token);
            var response = client.GetAsync("Company/AutoGenerateCode").Result;
            Expenseno.Text = response.Content.ReadAsStringAsync().Result;
            //PurchaseBillLookUpModel
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Expense.Token);
            response = client.GetAsync("Purchase/PurchaseBillList?isDropDown=" + true).Result;
            var expenses = JsonConvert.DeserializeObject<PagedResult<List<PurchaseBillLookUpModel>>>(response.Content.ReadAsStringAsync().Result);
            // List<Person> people = new List<Person>();
            var localResult = expenses.Results;
            List<string> dropdata = localResult.Where(x => x.RegistrationNo != null && x.BillerAccount != null)
                                                .Select(x => x.RegistrationNo + " / " + x.BillerAccount+" / "+x.Date)
                                                .ToList();
            foreach (var item in dropdata)
            {
                Bills.Properties.Items.Add(item);
            }
             Expense = Global.modelWiseClaims.Find(x => x.TokenName == "Expenses");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Expense.Token);
             response = client.GetAsync("Accounting/GetCOA?isDropdown="+true+"&companyId="+Global.CompanyId).Result;
           // AccountTemplateListModel account = response.Content.ReadAsAsync<AccountTemplateListModel>().Result;
            string data = response.Content.ReadAsStringAsync().Result;
            AccountTemplateListModel account = JsonConvert.DeserializeObject<AccountTemplateListModel>(data);
           
            foreach (var item in account.AccountTypes)
            {

           }
         //   List<string> val=data.Where(x=>x.)
        }
        public class AccountTemplateListModel {
            public IList<AccountTypeLookupModel> AccountTypes { get; set; }
        }
        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}