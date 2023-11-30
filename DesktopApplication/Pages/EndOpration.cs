using System;
using System.Data.Entity.Core;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static DesktopApplication.Pages.DayStart;

namespace DesktopApplication.Pages
{
    public partial class DayEnd : DevExpress.XtraEditors.XtraForm
    {
        public static DateTime end_time;
        HttpClient client = connection.GetConnection();
        public DayEnd()
        {
            InitializeComponent();
        }

    
    
        private void Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public virtual string Caption { get; set; }
        public static decimal? cashinhand;
        public static decimal? total;
        public static decimal? VAT;
        private void DayEnd_Load(object sender, EventArgs e)

        {

            var daystartclaim = Global.modelWiseClaims.FirstOrDefault(x => x.TokenName == "DayStart");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", daystartclaim.Token);
            var response = client.GetAsync("Product/OpeningBalance?counterId=" + Global.CounterId).Result;
            var openingBalanceLookUpModel = response.Content.ReadAsAsync<OpeningBalanceLookUpModel>().Result;
            Global.openingBalanceLookUpModels = openingBalanceLookUpModel;
            var daystart = Global.daystart;
            var GetModuleWiseClaims = Global.openingBalanceLookUpModels;
            cinh.Text = GetModuleWiseClaims.CashInHand.ToString("0.##");
            User.Text = Global.LoginUserName;
            Password.Text=Loginpg.setPassword;
            CCU.Text = Global.LoginUserName;
            DT.Text = GetModuleWiseClaims.Date;
            CC.Text = GetModuleWiseClaims.TerminalCode;
            E.Text=GetModuleWiseClaims.DraftExpense.ToString();
            OC.Text=GetModuleWiseClaims.OpeningCash.ToString();
            TVAT.Text = GetModuleWiseClaims.TotalVat.ToString();
            cashinh.Text=GetModuleWiseClaims.CashInHand.ToString() ;
            bankdtl.DataSource = GetModuleWiseClaims.BankDetails;
            double? sum = GetModuleWiseClaims.BankDetails.Sum(g => Convert.ToDouble(g.TotalAmount));
            BankTotal.Text=sum.ToString();
            total = decimal.Parse(BankTotal.Text);
            TotalLablePanel.Text= "Total Sale (Sales+Bank=) " + sum.ToString();
            cashinhand = decimal.Parse(cinh.Text);
            VAT = GetModuleWiseClaims.TotalVat;
            var  bank=GetModuleWiseClaims.BankDetails;
            Global.bankDetailLookUpModels= bank.ToList();
            
        }

        private void Close_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            
        }
        public void check()
        {
            try
            {
                if (cinh.Text != "")
                {
                    decimal cashinhand = decimal.Parse(cinh.Text);
                    cashinhand = decimal.Round(cashinhand, 2);
                    if (cashinhand.ToString("0.##") == VCash.Text || cinh.Text == VCash.Text)
                    {
                        EndOpration.Enabled = true;
                        Reason.Visible = false;
                        reasonBox.Visible = false;
                    }
                    else
                    {
                        if (VCash.Text != null)
                        {
                            Reason.Visible = true;
                            reasonBox.Visible = true;
                        }
                    }

                }
            }
            catch (ObjectNotFoundException ex)
            {
                throw new ApplicationException("Terminal Not Selected" + ex);
            }
        }
        private void EndOpration_Click(object sender, EventArgs e)
        {
            
            DayStartVm dyStartVm = new DayStartVm();
            dyStartVm.Date = DateTime.Now;
            dyStartVm.FromTime = DateTime.Now;
            dyStartVm.LocationId = Global.CompanyId;
            dyStartVm.OpeningCash = decimal.Parse(cinh.Text);
            dyStartVm.CounterId = (Guid)Global.CounterId;
            dyStartVm.IsActive = IsActive;
            dyStartVm.IsOpenDay = Global.IsOpenDay;
            dyStartVm.IsFirstUser = true;
            dyStartVm.Id= (Guid)Global.daystart.DayStartId;
            dyStartVm.IsExpenseDay = (bool)Global.IsExpenseDay;
            dyStartVm.IsSupervisorLogin = Global.IsSupervisor;
            dyStartVm.User = Global.LoginUserName.ToString();
            dyStartVm.Password = Password.Text;
            dyStartVm.SaleId = Guid.Parse(Global.UserId);
            dyStartVm.VerifyCash = decimal.Parse(VCash.Text);
            dyStartVm.CarryCash= decimal.Parse(Ctransfer.Text);
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
            end_time = DateTime.Now;

            ReportVierver rv=new ReportVierver();
            rv.Show();
            this.Hide();
            
        }

        private void VCash_EditValueChanged(object sender, EventArgs e)
        {
            check();
        }

        private void NextDayOC_EditValueChanged(object sender, EventArgs e)
        {
            try {
                decimal CT = decimal.Parse(cinh.Text) - decimal.Parse(NextDayOC.Text);
                Ctransfer.Text = Convert.ToString(CT);

            }
            catch(Exception ex)
            {

            }
            }
        private void VCash_Click(object sender, EventArgs e)
        {
           if( VCash.Text == "0")
            {
                VCash.Text = string.Empty;
            }
        }

        private void NextDayOC_Click(object sender, EventArgs e)
        {
            if (NextDayOC.Text =="0") {
                NextDayOC.Text = string.Empty;
            }
           
        }

        private void CTransfer_EditValueChanged(object sender, EventArgs e)
        {
            Ctransfer.Text = Convert.ToString(decimal.Parse(cinh.Text) - decimal.Parse(NextDayOC.Text));
        }
    }
}