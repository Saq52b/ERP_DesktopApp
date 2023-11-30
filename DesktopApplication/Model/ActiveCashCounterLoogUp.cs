using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApplication.Model
{
    public  class ActiveCashCounterLookUp
    {
        public Guid id { get; set; }
        public  string Date { get; set; }
        public  string cashcounter { get; set; }
        public  string User { get; set; }
        public  decimal OpeningCash { get; set; }
        public  decimal TotalSale { get; set; }
        public  decimal Expense { get; set; }
        public  decimal CashinHand { get; set; }
        public  decimal bank { get; set; }
    }
}
