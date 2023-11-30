using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApplication.Model
{
    public class AddUpdateDayEnd
    {
        //Get all variable in entity
        public Guid? Id { get; set; }
        public DateTime? Date { get; set; }
        public Guid SaleId { get; set; }
        public Guid CounterId { get; set; }
        public Guid LocationId { get; set; }
        public decimal CashInHand { get; set; }
        public decimal Bank { get; set; }
        public decimal Expense { get; set; }
        public decimal OpeningCash { get; set; }
        public decimal CarryCash { get; set; }
        public decimal VerifyCash { get; set; }
        public DateTime? FromTime { get; set; }
        public DateTime? ToTime { get; set; }
        public bool IsActive { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string EndTerminalBy { get; set; }
        public string EndTerminalFor { get; set; }

        public bool IsExpenseDay { get; set; }

        public bool IsSupervisor { get; set; }

        public string SupervisorPassword { get; set; }

        public string SupervisorName { get; set; }
        public string CreditReason { get; set; }
        public bool IsOpenDay { get; set; }
        public bool IsSupervisorTrans { get; set; }
        public decimal RemainingAmount { get; set; }

    }
}
