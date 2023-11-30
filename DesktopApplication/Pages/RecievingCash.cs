using DesktopApplication.RecievingAmount;
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

namespace DesktopApplication.Pages
{
    public partial class RecievingCash : DevExpress.XtraEditors.XtraForm
    {
        HttpClient client = connection.GetConnection();
        public RecievingCash()
        {
            InitializeComponent();
        }
        public static bool recievingbtncheck;
        private void Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CashReceiving_Click(object sender, EventArgs e)
        {
            if (StartOpration.daywise)
            {
                Guid check = StartOpration.id;
                var data = Global.getData.Find(x => x.Id == check);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Global.token);
                ReceivingAmountCommand receivingAmountCommand = new ReceivingAmountCommand();
                receivingAmountCommand.Id = data.Id;
                receivingAmountCommand.Amount = data.CarryCash;
                receivingAmountCommand.UserName = data.UserName;
                receivingAmountCommand.Password = Loginpg.setPassword;
                receivingAmountCommand.Reason = data.reason;
                var response2 = client.PostAsJsonAsync<ReceivingAmountCommand>("Product/ReceivingCash", receivingAmountCommand).Result;
                var isDayStart = response2.Content.ReadAsAsync<dynamic>().Result;
                if (response2.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    recievingbtncheck = true;
                }
            }
            else if (!StartOpration.daywise)
            {
                Guid check = StartOpration.id;
                var data = Global.daywise.Find(x => x.Id == check);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Global.token);
                ReceivingAmountCommand receivingAmountCommand = new ReceivingAmountCommand();
                receivingAmountCommand.Id = data.Id;
                receivingAmountCommand.Amount = data.CarryCash;
                receivingAmountCommand.UserName = data.UserName;
                receivingAmountCommand.Password = Loginpg.setPassword;
                receivingAmountCommand.Reason = data.reason;
                var response2 = client.PostAsJsonAsync<ReceivingAmountCommand>("Product/ReceivingCash", receivingAmountCommand).Result;
                var isDayStart = response2.Content.ReadAsAsync<dynamic>().Result;
                if (response2.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    recievingbtncheck = true;
                }
            }
            this.Dispose();
        }

        private void RecievingCash_Load(object sender, EventArgs e)
        {
            Guid check = StartOpration.id;
            var data = Global.daywise.Find(x => x.Id == check);
            if (data == null)
            {
                var data1 = Global.getData.Find(x => x.Id == check);
                CashAmount.Text = data1.CarryCash.ToString();
            }
            else
            {
                CashAmount.Text = data.CarryCash.ToString();
            }


        }

        private void Password_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (Password.Text != Loginpg.setPassword)
            {
                CashReceiving.Enabled = false;
            }
            else
            {
                CashReceiving.Enabled = true;
            }
        }
    }
}