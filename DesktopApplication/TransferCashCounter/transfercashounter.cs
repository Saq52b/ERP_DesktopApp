using System;
using System.ComponentModel;



namespace DesktopApplication.TransferCashCounter
{
    public class transfercashounter
    {
        public string Date { get; set; }
        public string TransferTime { get; set; }
        public string CounterName { get; set; }
        public string TransferBy { get; set; }
        public string TransferTo { get; set; }
        public decimal OpeningCash { get; set; }
       
        public decimal CashInHand { get; set; }
        public string CreditReason { get; set; }
        public decimal Expense { get; set; }
        public decimal Bank { get; set; }
    }
}
