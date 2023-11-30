using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApplication.Model
{
    public class GetData
    {
        public Guid Id { get; set; }
        public string Date { get; set; }
        public string StartTime { get; set; }
        public string Counter { get; set; }
        public string UserName { get; set; }
        public string Supervisor { get; set; }
        public decimal CarryCash { get; set; }
        public decimal OpeningCash { get; set; }
        public decimal CashInHand { get; set; }
        public decimal Expense { get; set; }
        public string EndTime { get; set; }
        public string EndUser { get; set; }
        public decimal ReceivingAmount { get; set; }
        public string reason { get; set; }
    }
}
