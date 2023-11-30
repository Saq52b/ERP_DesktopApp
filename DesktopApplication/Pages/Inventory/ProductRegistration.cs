using DesktopApplication.Model;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Model;
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

namespace DesktopApplication.Pages.Inventory
{
    public partial class ProductRegistration : DevExpress.XtraEditors.XtraUserControl
    {
        HttpClient client = connection.GetConnection();
        public ProductRegistration()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

            //  Product/ProductInventoryDetailQuery
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProductRegistration_Load(object sender, EventArgs e)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Global.token);
            var response = client.GetAsync("Product/ProductMasterList?isActive =" + false+ "&pageNumber ="+1).Result;

           // Product / ProductMasterList ? isActive = false & pageNumber = 1 & searchTerm =
        }
    }
}
