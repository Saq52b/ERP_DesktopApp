using DesktopApplication.Model;
using DesktopApplication.TransferCashCounter;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace DesktopApplication.Pages
{
    public partial class StartOpration : DevExpress.XtraEditors.XtraUserControl
    {
        HttpClient client = connection.GetConnection();
        public StartOpration()
        {
            InitializeComponent();
        }

        private void StartOpration_Load(object sender, EventArgs e)
        {

           if (Global.CounterId ==Guid.Empty)
                {
                    RePrint.Visible = false;
                    EndOpration.Enabled = false;
                }
                else
                {
                    RePrint.Visible = true;
                    EndOpration.Enabled = false;
                }
            
            check();

            OpeningCashsummary.Text = Global.daystart.OpeningCash.ToString();
            CashInHandsummary.Text = Global.daystart.CashInHand.ToString();
            Expensesummary.Text = Global.daystart.Expense.ToString();
            Banksummary.Text = Global.daystart.Bank.ToString();
        }
        public void check()
        
        {

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Global.token);
            var response2 = client.GetAsync("Product/IsDayStart?userId=" + Global.UserId + "&employeeId=" + Global.EmployeeId + "&isSupervisor=" + true).Result;
            var isDayStart = response2.Content.ReadAsAsync<IsDayStartLookupModel>().Result;
            Global.daystart = isDayStart;

            var InactiveCashCounter = Global.daystart.InacticeDayStarts
                .Select(item => new GetData
                {
                    Id= item.Id,
                    Date = item.Date,
                    StartTime = item.FromTime,
                    Counter = item.CounterName,
                    UserName = item.StartTerminalFor,
                    Supervisor = item.SuperVisorName,
                    CarryCash = item.CarryCash,
                    OpeningCash = item.OpeningCash,
                    CashInHand = item.CashInHand,
                    Expense = item.ExpenseCash,
                    EndTime = item.ToTime,
                    EndUser = item.DayEndUser,
                    ReceivingAmount = item.ReceivingAmount,
                    reason=item.Reason,
                })
                .ToList();
           Global.getData = InactiveCashCounter;
            IACC.DataSource = InactiveCashCounter;
            InactiveCashCounter = Global.daystart.DayWiseList
                .SelectMany(list => list)
                .Select(item => new GetData
                {
                    Id = item.Id,
                    Date = item.Date,
                    StartTime = item.FromTime,
                    Counter = item.CounterName,
                    UserName = item.StartTerminalFor,
                    Supervisor = item.SuperVisorName,
                    CarryCash = item.CarryCash,
                    OpeningCash = item.OpeningCash,
                    CashInHand = item.CashInHand,
                    Expense = item.ExpenseCash,
                    EndTime = item.ToTime,
                    EndUser = item.DayEndUser,
                    ReceivingAmount = item.ReceivingAmount,
                    reason = item.Reason,
                })
                .ToList();
            Global.daywise = InactiveCashCounter;
            DayWiseGrid.DataSource = InactiveCashCounter;
            //active cash counter
            var ActiveCashCounter = Global.daystart.DayStarts
    .Select(item => new ActiveCashCounterLookUp
    {
        id=item.Id,
        Date = item.Date,
        cashcounter = item.StartTerminalFor,
        User = item.DayStartUser,
        OpeningCash = item.OpeningCash,
        TotalSale = item.TotalCash,
        Expense = item.ExpenseCash,
        CashinHand = item.CashInHand,
        bank=item.BankExpense

    }).ToList();
            
            Global.acc = ActiveCashCounter;
            Active_Cash_Counter.DataSource = Global.acc;
            //transfer cash counter
          var  TransferCashCounter = Global.daystart.TransferHistories
    .Select(item => new transfercashounter
    {
        Date = item.Date,
        CounterName = item.CounterName,
        TransferBy = item.StartTerminalBy,
        TransferTo = item.StartTerminalFor,
        Bank = item.BankAmount,
        TransferTime = item.FromTime,
        OpeningCash = item.OpeningCash,
        CashInHand = item.CashInHand,
    })
    .ToList();
            Global.TransferCashCounter = TransferCashCounter;
            TransferCashCounterGrid.DataSource = TransferCashCounter;
            if (Global.daystart.IsDayStart)
            {
                RePrint.Visible= false;
                TCC.Enabled = true;
                DayStartbtn.Enabled = false;
                EndOpration.Enabled = true;
            }
            else
            {
                DayStartbtn.Enabled = true;
                EndOpration.Enabled = false;
                TCC.Enabled = false;
            }

        }
        private void DayStart_Click(object sender, EventArgs e)
        {
            DayStart ds = new DayStart();
            ds.ShowDialog();
            check();
        }

        private void EndOpration_Click(object sender, EventArgs e)
        {
            DayEnd dayEnd=new DayEnd();
            dayEnd.ShowDialog();
            check();
        }

        private void RePrint_Click(object sender, EventArgs e)
        {
            ReportVierver rv = new ReportVierver();
            rv.Show();
        }

        private void TCC_Click(object sender, EventArgs e)
        {
            TransferCash TC=new TransferCash();
            TC.Show();
        }

        private void IACC_Click(object sender, EventArgs e)
        {

        }
        public void isrecievecash(int[] selRows)
        {
            var data = Global.daystart.InacticeDayStarts;

            foreach (var item in data)
            {
                if (item.IsReceived)
                {
                    Actionbutton.Buttons[selRows[0]].Enabled = false;
                }
                else
                {
                    Actionbutton.Buttons[selRows[0]].Enabled = true;
                }
            }
        }
        public static Guid id;
        public static string counter;
        public static char checkcounter;
        public static bool daywise = true;
        private void repositoryItemButtonEdit1_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            int[] selRows = ((GridView)IACC.MainView).GetSelectedRows();
            var obj = (GetData)(((GridView)IACC.MainView).GetRow(selRows[0]));
            daywise = true;
            id = obj.Id;
            RecievingCash r = new RecievingCash();
            r.Show();
            var data = Global.daystart.InacticeDayStarts;

        }

        private void viewbtn_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            checkcounter ='i';
            int[] selRows = ((GridView)IACC.MainView).GetSelectedRows();
            var obj = (GetData)(((GridView)IACC.MainView).GetRow(selRows[0]));
            id = obj.Id;
            ViewInActiveCashCounter vacc = new ViewInActiveCashCounter();
            vacc.Show();
        }

        private void ACCVIEW_Click(object sender, EventArgs e)
        {
            checkcounter='a';
            int[] selRows = ((GridView)Active_Cash_Counter.MainView).GetSelectedRows();
            var obj = (ActiveCashCounterLookUp)(((GridView)Active_Cash_Counter.MainView).GetRow(selRows[0]));
            id = obj.id;
            counter = obj.cashcounter;
            ViewInActiveCashCounter vacc = new ViewInActiveCashCounter();
            vacc.Show();
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            checkcounter = 'd';
            int[] selRows = ((GridView)DayWiseGrid.MainView).GetSelectedRows();
            var obj = (GetData)(((GridView)DayWiseGrid.MainView).GetRow(selRows[0]));
            id = obj.Id;
            ViewInActiveCashCounter vacc = new ViewInActiveCashCounter();
            vacc.Show();
        }

        private void Recieveing_btn_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            daywise = false;
            int[] selRows = ((GridView)DayWiseGrid.MainView).GetSelectedRows();
            var obj = (GetData)(((GridView)DayWiseGrid.MainView).GetRow(selRows[0]));
            id = obj.Id;
            RecievingCash r = new RecievingCash();
            r.Show();
            var data = Global.daystart.InacticeDayStarts;
        }
    }
}
