using DesktopApplication.Model;
using DesktopApplication.TransferCashCounter;
using DevExpress.XtraGauges.Core.Model;
using DevExpress.XtraRichEdit.Fields;
using Focus.Business.CompanyLicences.Queries.GetCompanyAboutUsDetails;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Claims;
using System.Windows.Forms;

namespace DesktopApplication
{

    public static class Global
    {
        public static string Id { get; set; }
        public static Guid CompanyId { get; set; }
        public static Guid? EmployeeId { get; set; }
        public static Guid? CounterId { get; set; }
        public static string UserId { get; set; }
        public static string UserName { get; set; }
        public static string FullName { get; set; }
        public static string RoleName { get; set; }
        public static string ImagePath { get; set; }
        public static string PhoneNo { get; set; }
        public static object Token { get; set; }
        public static bool TwoFactorEnabled { get; set; }
        public static bool EmailConfirmed { get; set; }
        public static bool IsMultiUnit { get; set; }
        public static bool IsProduction { get; set; }
        public static bool InvoiceWoInventory { get; set; }
        public static string UserRoleName { get; set; }
        public static bool? IsTouchInvoice { get; set; }
        public static bool IsDayStart { get; set; }
        public static string PrintSizeA4 { get; set; }
        public static string TermsInAr { get; set; }
        public static string TermsInEng { get; set; }
        public static bool IsArea { get; set; }
        public static bool IsProceed { get; set; }
        public static bool Arabic { get; set; }
        public static bool English { get; set; }
        public static bool? AllowAll { get; set; }
        public static bool Terminal { get; set; }
        public static bool DayStart { get; set; }
        public static bool Step1 { get; set; }
        public static bool Step2 { get; set; }
        public static bool Step3 { get; set; }
        public static bool Step4 { get; set; }
        public static bool Step5 { get; set; }
        public static bool? IsExpenseDay { get; set; }
        public static bool TermsCondition { get; set; }
        public static Guid? WarehouseId { get; set; }
        public static string LoginUserName { get; set; }
        public static bool CashVoucher { get; set; }
        public static decimal? ReturnDays { get; set; }
        public static bool IsOpenDay { get; set; }
        public static bool IsTransferAllow { get; set; }
        public static bool IsSupervisor { get; set; }
        public static bool IsPermissionToStartDay { get; set; }
        public static bool IsPermissionToCloseDay { get; set; }
        public static string DayStartTime { get; set; }
        public static bool TransferCounter { get; set; }
        public static bool IsMasterProductPermission { get; set; }
        public static string PrinterName { get; set; }
        public static bool IsHeaderFooter { get; set; }
        public static string NobleRole { get; set; }
        public static string SaleOrder { get; set; }
        public static string InvoicePrint { get; set; }
        public static bool SimpleInvoice { get; set; }
        public static bool SoInventoryReserve { get; set; }
        public static bool IsBlindPrint { get; set; }
        public static bool IsDeliveryNote { get; set; }
        public static bool AutoPaymentVoucher { get; set; }
        public static bool InternationalPurchase { get; set; }
        public static bool PartiallyPurchase { get; set; }
        public static bool VersionAllow { get; set; }
        public static bool PurchaseOrder { get; set; }
        public static bool ExpenseToGst { get; set; }
        public static bool AutoPurchaseVoucher { get; set; }
        public static string PrintTemplate { get; set; }
        public static bool IsForMedical { get; set; }
        public static bool IsExpenseAccount { get; set; }
        public static bool SuperAdminDayStart { get; set; }
        public static bool BankDetail { get; set; }
        public static bool OnPageLoadItem { get; set; }
        public static List<CompanyOption> CompanyOptions { get; set; }
        public static string TaxInvoiceLabel { get; set; }
        public static string BusinessLogo { get; set; }
        public static string BusinessNameArabic { get; set; }
        public static string BusinessNameEnglish { get; set; }
        public static string BusinessTypeArabic { get; set; }
        public static string BusinessTypeEnglish { get; set; }
        public static string CompanyNameArabic { get; set; }
        public static string CompanyNameEnglish { get; set; }
        public static string TaxInvoiceLabelAr { get; set; }
        public static string SimplifyTaxInvoiceLabel { get; set; }
        public static string SimplifyTaxInvoiceLabelAr { get; set; }
        public static bool OverWrite { get; set; }
        public static string TouchScreen { get; set; }
        public static string Expiration { get; set; }
        public static bool IsPayment { get; set; }
        public static bool IsNotPayment { get; set; }
        public static bool TermAndConditionLength { get; set; }
        public static string token { get; set; }
        public static string Expire { get; set; }
        public static WhiteLabeling WhiteLabeling { get; set; }
        public static GetCurrency currency { get; set; }
        public static List<ModuleRightLookUpModel> moduleRightLookUpModels { get; set; }
        public static List<ModelWiseClaim> modelWiseClaims { get; set; }
        public static List<Claim> claims { get; set; }
        public static List<BankDetailLookUpModel> bankDetailLookUpModels { get; set; }
        public static  LoginPermissions loginPermissions { get; set; }
        public static AboutUsLookUpModel aboutUsLookUpModel { get; set; }
        public static DayStartLookupModel dayStartLookupModel { get; set; }
        public static List<ActiveCashCounterLookUp> acc { get; set; }
        public static IsDayStartLookupModel daystart { get; set; }
        public static List<AddUpdateDayEnd> addUpdateDayEnds { get; set; }
        public static List<GetData> getData { get; set; }
        public static List<GetData> daywise { get; set; }
        public static OpeningBalanceLookUpModel openingBalanceLookUpModels { get; set; }
        public static List<transfercashounter> TransferCashCounter { get; set; }
        
    }
    public static class connection
    {
        public static HttpClient GetConnection()
        {

            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:44318/api/");
            return httpClient;

        }
    }
    internal static class Program
    {


        public static string token = "";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var services = new ServiceCollection();

            services.AddScoped<Loginpg>();
            services.AddScoped<IUserComponent, UserComponents>();
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                Application.Run(serviceProvider.GetRequiredService< Loginpg> ());
            }
        }
    }
}
