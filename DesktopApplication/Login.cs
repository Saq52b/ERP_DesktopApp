using DesktopApplication.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Globalization;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace DesktopApplication
{

    public partial class Loginpg : DevExpress.XtraEditors.XtraForm
    {
        private readonly IUserComponent _userComponent;
        HttpClient client = connection.GetConnection();
        public Loginpg(IUserComponent userComponent)
        {
            HttpClient client = connection.GetConnection();
            _userComponent = userComponent;
            InitializeComponent();

        }
        public static string setUserName = "";
        public static string setPassword = "";
        private void Login_Load(object sender, EventArgs e)
        {
            panelControl5.Location = new Point(
           this.ClientSize.Width / 2 - panelControl5.Size.Width / 2,
           this.ClientSize.Height / 2 - panelControl5.Size.Height / 2);
            panelControl5.Anchor = AnchorStyles.None;
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            User.Text = "saudkhan";
            Pass.Text = "Tqode909#";
            if (User.Text == "" && Pass.Text == "" || User.Text=="" ||Pass.Text=="")
            {
                error.Visible = true;
            }
            else
            {

                _userComponent.ListingUsers(User.Text, Pass.Text);

                    error.Visible = false;
                    setUserName = User.Text;
                    setPassword = Pass.Text;
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Global.token);

                    var claims = client.GetAsync("Company/GetModuleWiseClaims").Result;
                if (!claims.IsSuccessStatusCode)
                {
                    error.Visible = true;
                }
                    var GetModuleWiseClaims = claims.Content.ReadAsAsync<List<ModelWiseClaim>>().Result;
                    if (GetModuleWiseClaims != null)
                    {
                        Global.modelWiseClaims = GetModuleWiseClaims;
                    }
                    var permissions = client.GetAsync("Company/GetCompanyPermission").Result;
                    var Getpermissions = permissions.Content.ReadAsAsync<List<ModuleRightLookUpModel>>().Result;
                    if (Getpermissions != null)
                    {
                        Global.moduleRightLookUpModels = Getpermissions;
                    }
                    var response = client.GetAsync("account/GetCompanySetupAccount").Result;
                    var GetCompanySetupAccount = response.Content.ReadAsAsync<GetCurrency>().Result;
                    if (GetCompanySetupAccount != null)
                    {
                        Global.currency = GetCompanySetupAccount;
                    }
                    try
                    {
                        response = client.GetAsync("account/GetUserPermission?id=" + Global.UserId).Result;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Access Denied!"+ex.HelpLink);
                    }
                    var GetUserPermission = response.Content.ReadAsAsync<LoginPermissions>().Result;
                    if (GetUserPermission != null)
                    {
                        Global.loginPermissions = GetUserPermission;
                    }
                    response = client.GetAsync("account/GetWhiteLabeling").Result;
                    var whiteLabeling = response.Content.ReadAsAsync<WhiteLabeling>().Result;
                    if (whiteLabeling != null)
                    {
                        Global.WhiteLabeling = whiteLabeling;
                    }
                    DashBord dashbord = new DashBord();
                    this.Hide();
                    dashbord.Show();
                
            }
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ara");

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
        }
    }
    public class InputModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}