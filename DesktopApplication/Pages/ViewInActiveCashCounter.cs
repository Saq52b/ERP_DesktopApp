using DesktopApplication.Model;
using DevExpress.Utils.Extensions;
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
    public partial class ViewInActiveCashCounter : DevExpress.XtraEditors.XtraForm
    {
        HttpClient client = connection.GetConnection();
        public ViewInActiveCashCounter()
        {
            InitializeComponent();
        }
        double? sum;
        private void ViewInActiveCashCounter_Load(object sender, EventArgs e)
        {
            var InactiveCashCounter = Global.daystart.InacticeDayStarts;
            var activeCashCounter = Global.daystart.DayStarts;
            var daywise = Global.daystart.DayWiseList;
            if (StartOpration.checkcounter == 'i')
            {
                foreach (var item in InactiveCashCounter)
                {
                    if (item.Id == StartOpration.id)
                    {
                        CashCU.Text = item.StartTerminalBy;
                        DateTime.Text = item.FromTime;
                        CC.Text = item.CounterName;
                        oc.Text = item.OpeningCash.ToString();
                        cs.Text = item.TotalCash.ToString();
                        Exp.Text = item.ExpenseCash.ToString();
                        cinh.Text = item.CashInHand.ToString();
                        if (item.BankDetails == null)
                        {
                            titlebank.Dispose();
                            BankDtl.Dispose();
                        }
                        else
                        {
                            BankDtl.DataSource = item.BankDetails;
                            try
                            {
                                sum = item.BankDetails.Sum(g => Convert.ToDouble(g.TotalAmount));
                            }
                            catch { }
                            total.Text = "Total Sale (Sales+Bank=) " + sum.ToString();
                        }
                    }

                }
            }
            else if (StartOpration.checkcounter == 'a')
            {
                foreach (var item in activeCashCounter)
                {
                    if (item.CounterName == StartOpration.counter)
                    {
                        CashCU.Text = item.StartTerminalBy;
                        DateTime.Text = item.FromTime;
                        CC.Text = item.CounterName;
                        oc.Text = item.OpeningCash.ToString();
                        cs.Text = item.TotalCash.ToString();
                        Exp.Text = item.ExpenseCash.ToString();
                        cinh.Text = item.CashInHand.ToString();
                        if (item.BankDetails == null)
                        {
                            BankDtl.Visible = false;
                        }
                        else
                        {
                            BankDtl.DataSource = item.BankDetails;
                            try
                            {
                                sum = item.BankDetails.Sum(g => Convert.ToDouble(g.TotalAmount));
                            }
                            catch { }
                            total.Text = "Total Sale (Sales+Bank=) " + sum.ToString();
                        }
                    }

                }
            }
            else if (StartOpration.checkcounter=='d')
            {
                foreach (var data in daywise)
                {
                    foreach (var item in data)
                    {
                        if (item.Id == StartOpration.id)
                        {
                            CashCU.Text = item.DayEndUser;
                            DateTime.Text = item.ToTime;
                            CC.Text = item.CarryCash.ToString();
                            oc.Text = item.OpeningCash.ToString();
                            cs.Text = item.CarryCash.ToString();
                            Exp.Text = item.ExpenseCash.ToString();
                            cinh.Text = item.CashInHand.ToString();
                            BankDtl.DataSource = item.BankDetails.ToList();
                            double? sum = item.BankDetails.Sum(g => Convert.ToDouble(g.TotalAmount));
                             total.Text = "Total Sale (Sales+Bank=) " + sum.ToString();
                        }
                    }
                }
            }
            // var tR = isDayStart.InacticeDayStarts.Find(item => item.Id == StartOpration.id);

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}