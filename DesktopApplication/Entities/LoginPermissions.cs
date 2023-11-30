using System;

namespace DesktopApplication
{
    public class LoginPermissions
    {
        public Guid UserId { get; set; }
        public bool ChangePriceDuringSale { get; set; }
        public bool GiveDicountDuringSale { get; set; }
        public bool ViewCounterDetails { get; set; }
        public bool TransferCounter { get; set; }
        public bool CloseCounter { get; set; }
        public bool HoldCounter { get; set; }
        public bool CloseDay { get; set; }
        public bool StartDay { get; set; }
        public bool ProcessSaleReturn { get; set; }
        public bool DailyExpenseList { get; set; }
        public bool InvoiceWoInventory { get; set; }
        public bool IsTouchInvoice { get; set; }
        public bool AllowAll { get; set; }
        public bool PermissionToStartExpenseDay { get; set; }
        public bool IsSupervisor { get; set; }
        public bool IsInquiryHandler { get; set; }
        public string TouchScreen { get; set; }
        public bool TemporaryCashReceiver { get; set; }
        public bool TemporaryCashIssuer { get; set; }
        public bool TemporaryCashRequester { get; set; }
        public bool IsExpenseAccount { get; set; }
        public decimal Days { get; set; }
        public decimal Limit { get; set; }
    }
}
