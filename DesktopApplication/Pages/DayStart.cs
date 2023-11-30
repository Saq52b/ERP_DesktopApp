using DesktopApplication.Entities;
using DesktopApplication.GetTerminal;
using DevExpress.XtraReports.Templates;
using Iced.Intel;
using System;
using System.Collections.Generic;
using System.IdentityModel.Claims;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Windows.Forms;
using DesktopApplication.Model;
using JetBrains.Annotations;
using DevExpress.CodeParser;
using System.Drawing;
using System.Web.Helpers;
using Newtonsoft.Json;
using DevExpress.Accessibility;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using DevExpress.XtraEditors.ButtonsPanelControl;
using DevExpress.XtraEditors.Filtering.Templates;
using System.Web.WebPages;
using static DevExpress.CodeParser.CodeStyle.Formatting.Rules;
using System.Data.Entity.Core;
using System.Web.Mvc;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Security.Claims;
using Newtonsoft.Json.Linq;
using System.Diagnostics.PerformanceData;
using static DesktopApplication.Pages.StartOpration;

namespace DesktopApplication.Pages
{
    public partial class DayStart : DevExpress.XtraEditors.XtraForm
    {
        public static string ccn;
        public bool IsActive;
        public Guid counterid;
        bool enable_form1_button1;
        public bool Enable_form1_button1
        {
            get { return this.enable_form1_button1; }
            set { this.enable_form1_button1 = value; }
        }
        public static string openingcash;
        HttpClient client = connection.GetConnection();
        public DayStart()
        {

                 InitializeComponent();

        }
        private const int CS_DROPSHADOW = 0x20000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        private void panelControl3_Paint(object sender, PaintEventArgs e)
        {
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
        public static DateTime? CreateDate { get; set; }
        private void DayStart_Load(object sender, EventArgs e)
        {
            CreateDate = DateTime.Now;
            TerminalListModel terminalmodel = new TerminalListModel();
            Date_Time.Text = DateTime.Now.ToString("ddd,MMM dd yyyy HH:mm");
            User.Text = Loginpg.setUserName.ToString();
            Password.Text = Loginpg.setPassword.ToString();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Global.token);
            var response = client.GetAsync("Company/TerminalList?allShown=" + false + "&terminaltype=" + "CashCounter" + "&isselected=" + false).Result;
            var terminalList = response.Content.ReadAsAsync<DesktopApplication.GetTerminal.TerminalListModel>().Result;
            var GetTerminal = new List<GetTerminalLook>();
            foreach (var terminal in terminalList.Terminals)
            {
                CashCounterno.Properties.Items.Add(terminal.Code.ToString());
                GetTerminal.Add(new GetTerminalLook{ 
                    Id = terminal.Id,Code = terminal.Code, MACAddress = terminal.MACAddress,
                    IPAddress = terminal.IPAddress,PrinterName = terminal.PrinterName,isActive = terminal.isActive
                });   
            }
            GetTerminalList.GetTerminals = GetTerminal;
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Global.token);
            var response1 = client.GetAsync("Product/GetTerminalByUserId").Result;
            CashCounterUser.Text = Global.LoginUserName;
    }
        private  void CashCounterno_SelectedIndexChanged(object sender, EventArgs e)
        {
         var isCodeExist=   GetTerminalList.GetTerminals.FirstOrDefault(x => x.Code == CashCounterno.Text);
            counterid = isCodeExist.Id;
            IsActive = isCodeExist.isActive;
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Global.token);
            var response = client.GetAsync("Product/OpeningBalance?counterId=" + isCodeExist.Id + "&isOpeningCash=" + true).Result;
            var terminalList = response.Content.ReadAsAsync<OpeningBalanceLookUpModel>().Result;
            OpningCash.Text = terminalList.OpeningBalance.ToString("0.##");
            openingcash = OpningCash.Text;
        }

        private void OpningCash_EditValueChanged(object sender, EventArgs e)
        {
        }

        public static Guid SetCounterid = new Guid();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DayStartVm dyStartVm = new DayStartVm();
            dyStartVm.Date= DateTime.Now;
            dyStartVm.FromTime =DateTime.Now;
            dyStartVm.LocationId = Global.CompanyId;
            dyStartVm.OpeningCash = decimal.Parse(openingcash);
            dyStartVm.CounterId =counterid;
            dyStartVm.IsActive=IsActive;
            dyStartVm.IsOpenDay = Global.IsOpenDay;
            dyStartVm.IsFirstUser =true;
            dyStartVm.IsExpenseDay = (bool)Global.IsExpenseDay;
            dyStartVm.IsSupervisorLogin = Global.IsSupervisor;
            dyStartVm.User = Global.LoginUserName.ToString();
            dyStartVm.Password = Password.Text;
            dyStartVm.SaleId = Guid.Parse( Global.UserId);
            dyStartVm.VerifyCash=decimal.Parse(Verifycash.Text);
            var daystartclaim = Global.modelWiseClaims.Find(x => x.TokenName == "DayStart");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", daystartclaim.Token);
            var response = client.PostAsJsonAsync<DayStartVm>("Product/SaveDayStart?isDayStart=" + true, dyStartVm).Result;
           
            if (response.IsSuccessStatusCode == true) { 
            var daystart=response.Content.ReadAsAsync<GetResult>().Result;
                Global.dayStartLookupModel = daystart.Result;
            }
            else
            {
                MessageBox.Show("Terminal Already Assign!");
            }
           
            this.Hide();
 
        }

            public class GetResult
        {
            public bool IsSuccess { get; set; }
            public DayStartLookupModel Result { get; set; }
        }
        private void Verifycash_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (OpningCash.Text != "")
                {
                    decimal d = decimal.Parse(OpningCash.Text);
                    d = decimal.Round(d, 2);
                    if (d.ToString("0.##") == Verifycash.Text || OpningCash.Text == Verifycash.Text)
                    {
                        Start.Enabled = true;
                    }
                    else
                        Start.Enabled = false;
                }
           }
            catch (ObjectNotFoundException ex)
            {
                throw new ApplicationException("Terminal Not Selected"+ ex);
            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    public static class GetTerminalList
    {
        public static  IList<DesktopApplication.Entities.GetTerminalLook> GetTerminals { get; set; }
    }


}