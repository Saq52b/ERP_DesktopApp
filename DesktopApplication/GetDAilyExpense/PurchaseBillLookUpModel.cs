using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApplication.GetDAilyExpense
{
    public class PurchaseBillLookUpModel
    {
        public Guid? BillerId { get; set; }
        public Guid Id { get; set; }
        public string Date { get; set; }
        public string DueDate { get; set; }
        public string RegistrationNo { get; set; }
        public string Narration { get; set; }
        public string BillerAccount { get; set; }
        public string BillerAccountAr { get; set; }
        public ApprovalStatus ApprovalStatus { get; set; }
        public PartiallyInvoices PartiallyInvoices { get; set; }

        public decimal NetAmount { get; set; }
        public decimal RemainingAmount { get; set; }
    }
}
