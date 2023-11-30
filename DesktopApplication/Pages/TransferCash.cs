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
using static DesktopApplication.Pages.DayStart;

namespace DesktopApplication.Pages
{
    public partial class TransferCash : DevExpress.XtraEditors.XtraForm
    {
        private readonly IUserComponent _userComponent;
        HttpClient client = connection.GetConnection();
        public TransferCash()
        {
            InitializeComponent();
        }

        private void TransferCash_Load(object sender, EventArgs e)
        {
            var daystartclaim = Global.modelWiseClaims.Find(x => x.TokenName == "DayStart");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", daystartclaim.Token);
            var openingbalance = client.GetAsync("Product/OpeningBalance?counterId=" + Global.CounterId).Result;
            var getbalance = openingbalance.Content.ReadAsAsync<OpeningBalanceLookUpModel>().Result;
            CCU.Text = Global.LoginUserName;
            DT.Text = getbalance.Date.ToString();
            CC.Text = Global.daystart.CounterCode;
            OC.Text=getbalance.OpeningBalance.ToString();
            TCS.Text = getbalance.TotalCash.ToString();
            BT.Text = getbalance.Bank.ToString();
           E.Text = getbalance.DraftExpense.ToString();
            TI_.Text=getbalance.TotalInvoices.ToString();
            CinH.Text= getbalance.CashInHand.ToString();
            UserName.Text= Global.LoginUserName;
            Password.Text=Loginpg.setPassword.ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void start_Click(object sender, EventArgs e)
        {

            DayStartVm dyStartVm = new DayStartVm();
            dyStartVm.Date = DateTime.Now;
            dyStartVm.FromTime = DateTime.Now;
            dyStartVm.LocationId = Global.CompanyId;
            dyStartVm.OpeningCash = decimal.Parse(CinH.Text);
            dyStartVm.CounterId = (Guid)Global.CounterId;
            dyStartVm.IsActive = IsActive;
            dyStartVm.IsOpenDay = Global.IsOpenDay;
            dyStartVm.IsFirstUser = true;
            dyStartVm.Id = (Guid)Global.daystart.DayStartId;
            dyStartVm.IsExpenseDay = (bool)Global.IsExpenseDay;
            dyStartVm.IsSupervisorLogin = Global.IsSupervisor;
            dyStartVm.User = UserName.Text;
            dyStartVm.Password = Password.Text;
            dyStartVm.SaleId = Guid.Parse(Global.UserId);
            dyStartVm.VerifyCash = decimal.Parse(verifycash.Text);
            var daystartclaim = Global.modelWiseClaims.Find(x => x.TokenName == "DayStart");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", daystartclaim.Token);
            try
            {
                var response = client.PostAsJsonAsync<DayStartVm>("Product/SaveDayStart?isDayStart=" + false, dyStartVm).Result;

                if (response.IsSuccessStatusCode == true)
                {
                    var daystart = response.Content.ReadAsAsync<GetResult>().Result;
                    Global.dayStartLookupModel = daystart.Result;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Day Don't Exist");
            }
            Loginpg form = new Loginpg(_userComponent);
            form.ShowDialog();
            ReportVierver rv = new ReportVierver();
            rv.Show();
            this.Hide();
        }

    }
}