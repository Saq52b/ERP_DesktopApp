using DesktopApplication.Pages;
using DevExpress.XtraBars;
using DevExpress.XtraWaitForm;
using Microsoft.Diagnostics.Tracing.StackSources;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace DesktopApplication
{
    public partial class DashBord : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private readonly IUserComponent _userComponent;
        HttpClient client = connection.GetConnection();
        public DashBord()
        {
            InitializeComponent();
        }

        private void StartOprationsub_Click(object sender, EventArgs e)
        {

        }

        private void ReportsSubSO_Click(object sender, EventArgs e)
        {

        }

        private void ProductRegistration_Click(object sender, EventArgs e)
        {

        }

        private void Warehouses_Click(object sender, EventArgs e)
        {

        }

        private void StartOprationsub_Click_1(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new StartOpration() { Dock = DockStyle.Fill });
        }

        private void Left_ItemClick(object sender, ItemClickEventArgs e)
        {
            TopMenubarbar.Visible = false;
            SideBar.Visible = true;
            SideBar.Dock = DockStyle.Left;
        }

        private void Right_ItemClick(object sender, ItemClickEventArgs e)
        {
            TopMenubarbar.Visible = false;
            SideBar.Visible = true;
            SideBar.Dock = DockStyle.Right;
        }

        private void Top_ItemClick(object sender, ItemClickEventArgs e)
        {
            SideBar.Visible = false;
            TopMenubarbar.Visible = true;
            TopMenubarbar.Dock = DockStyle.Top;
        }

        private void Bottom_ItemClick(object sender, ItemClickEventArgs e)
        {
            SideBar.Visible = false;
            TopMenubarbar.Visible = true;
            TopMenubarbar.Dock = DockStyle.Bottom;
        }

        private void ReportsSubSO_Click_1(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new CommingSoon() { Dock = DockStyle.Fill });
        }


        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new CommingSoon() { Dock = DockStyle.Fill });

        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new CommingSoon() { Dock = DockStyle.Fill });
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new CommingSoon() { Dock = DockStyle.Fill });
        }

        private void ExpenseSetup_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new CommingSoon() { Dock = DockStyle.Fill });
        }

        private void DailyExpense_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new DailyExpense() { Dock = DockStyle.Fill });
        }
        private readonly IUserComponent userComponent;
        private void barLargeButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Global.token);
             var response = client.PostAsJsonAsync<bool>("account/logout" ,true ).Result;
            // Application.Exit();
            //Application.Restart();
            //System.Diagnostics.Process.Start(Application.ExecutablePath);
            this.Dispose();
            Application.Restart();
            Loginpg log = new Loginpg(userComponent);
            log.Show();
            this.Close();
            //Environment.Exit(0);
        }

        private void DashBord_Load(object sender, EventArgs e)
        {

        }

        private void DashBord_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void DashBord_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
