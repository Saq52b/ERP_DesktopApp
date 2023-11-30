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

namespace DesktopApplication.Pages.WareHouse
{
    public partial class WareHouse : DevExpress.XtraEditors.XtraUserControl
    {
        HttpClient client = connection.GetConnection();
        public WareHouse()
        {
            InitializeComponent();
        }

        private void WareHouse_Load(object sender, EventArgs e)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Global.token);
            var response = client.GetAsync("Company/GetWarehouseInformation?companyId ="+Global.CompanyId).Result;
            //   Company / GetWarehouseInformation ? companyId = 00000000 - 0000 - 00
        }
    }
}
