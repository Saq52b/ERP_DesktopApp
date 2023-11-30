using DesktopApplication.Model;
using DevExpress.CodeParser;
using Microsoft.Graph;
using System;
using System.Collections.Generic;

using System.IdentityModel.Tokens.Jwt;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Windows.Forms;

namespace DesktopApplication
{

    public class UserComponents : IUserComponent
    {
        HttpClient client = connection.GetConnection();
        public void ListingUsers(string username, string password)
    {
            InputModel input = new InputModel();
            input.Email = username;
            input.Password = password;

            try
            {
                var claims = new List<Claim>();
                var response = client.PostAsJsonAsync<InputModel>("Account/login", input).Result;
                var login = response.Content.ReadAsAsync<LoginModel>().Result;
                if (login.Token == null)
                {
                }
                else
                {
                    var tokenval = new JwtSecurityToken(jwtEncodedString: login.Token.ToString());

                    foreach (var item in tokenval.Claims)
                    {
                        claims.Add(new Claim(item.Value, item.Type, item.ValueType));
                    }

                    Global.token = login.Token.ToString();
                    Global.CompanyId = login.CompanyId;
                    Global.Id = login.Id;
                    Global.EmployeeId = login.EmployeeId;
                    Global.CounterId = login.CounterId;
                    Global.UserId = login.UserId;
                    Global.UserName = login.UserName;
                    Global.FullName = login.FullName;
                    Global.RoleName = login.RoleName;
                    Global.ImagePath = login.ImagePath;
                    Global.PhoneNo = login.PhoneNo;
                    Global.TwoFactorEnabled = login.TwoFactorEnabled;
                    Global.EmailConfirmed = login.EmailConfirmed;
                    Global.IsMultiUnit = login.IsMultiUnit;
                    Global.IsProduction = login.IsProduction;
                    Global.InvoiceWoInventory = login.InvoiceWoInventory;
                    Global.UserRoleName = login.UserRoleName;
                    Global.IsTouchInvoice = login.IsTouchInvoice;
                    Global.IsDayStart = login.IsDayStart;
                    Global.PrintSizeA4 = login.PrintSizeA4;
                    Global.TermsInAr = login.TermsInAr;
                    Global.TermsInEng = login.TermsInEng;
                    Global.IsArea = login.IsArea;
                    Global.IsProceed = login.IsProceed;
                    Global.Arabic = login.Arabic;
                    Global.English = login.English;
                    Global.AllowAll = login.AllowAll;
                    Global.Terminal = login.Terminal;
                    Global.DayStart = login.DayStart;
                    Global.Step1 = login.Step1;
                    Global.Step2 = login.Step2;
                    Global.Step3 = login.Step3;
                    Global.Step4 = login.Step4;
                    Global.Step5 = login.Step5;
                    Global.IsExpenseDay = login.IsExpenseDay;
                    Global.TermsCondition = login.TermsCondition;
                    Global.WarehouseId = login.WarehouseId;
                    Global.LoginUserName = login.LoginUserName;
                    Global.CashVoucher = login.CashVoucher;
                    Global.ReturnDays = login.ReturnDays;
                    Global.IsOpenDay = login.IsOpenDay;
                    Global.IsTransferAllow = login.IsTransferAllow;
                    Global.IsSupervisor = login.IsSupervisor;
                    Global.IsPermissionToStartDay = login.IsPermissionToStartDay;
                    Global.IsPermissionToCloseDay = login.IsPermissionToCloseDay;
                    Global.DayStartTime = login.DayStartTime;
                    Global.TransferCounter = login.TransferCounter;
                    Global.IsMasterProductPermission = login.IsMasterProductPermission;
                    Global.PrinterName = login.PrinterName;
                    Global.IsHeaderFooter = login.IsHeaderFooter;
                    Global.NobleRole = login.NobleRole;
                    Global.SaleOrder = login.SaleOrder;
                    Global.InvoicePrint = login.InvoicePrint;
                    Global.SimpleInvoice = login.SimpleInvoice;
                    Global.SoInventoryReserve = login.SoInventoryReserve;
                    Global.IsBlindPrint = login.IsBlindPrint;
                    Global.IsDeliveryNote = login.IsDeliveryNote;
                    Global.AutoPaymentVoucher = login.AutoPaymentVoucher;
                    Global.PrintTemplate = login.PrintTemplate;
                    Global.IsForMedical = login.IsForMedical;
                    Global.IsExpenseAccount = login.IsExpenseAccount;
                    Global.SuperAdminDayStart = login.SuperAdminDayStart;
                    Global.BankDetail = login.BankDetail;
                    Global.OnPageLoadItem = login.OnPageLoadItem;
                    Global.TaxInvoiceLabel = login.TaxInvoiceLabel;
                    Global.BusinessLogo = login.BusinessLogo;
                    Global.BusinessNameArabic = login.BusinessNameArabic;
                    Global.BusinessNameEnglish = login.BusinessNameEnglish;
                    Global.BusinessTypeArabic = login.BusinessTypeArabic;
                    Global.BusinessTypeEnglish = login.BusinessTypeEnglish;
                    Global.CompanyNameArabic = login.CompanyNameArabic;
                    Global.CompanyNameEnglish = login.CompanyNameEnglish;
                    Global.TaxInvoiceLabelAr = login.TaxInvoiceLabelAr;
                    Global.SimplifyTaxInvoiceLabel = login.SimplifyTaxInvoiceLabel;
                    Global.SimplifyTaxInvoiceLabelAr = login.SimplifyTaxInvoiceLabelAr;
                    Global.OverWrite = login.OverWrite;
                    Global.TouchScreen = login.TouchScreen;
                    Global.IsPayment = login.IsPayment;
                    Global.IsNotPayment = login.IsNotPayment;
                    Global.TermAndConditionLength = login.TermAndConditionLength;
                    Global.Expiration = login.Expiration;
                    Global.claims = claims;
                }
            }
            catch (Exception ex)
            {

            }
        }

}
}
