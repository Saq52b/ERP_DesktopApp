using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApplication.RecievingAmount
{
    public class ReceivingAmountCommand 
    {
        public decimal Amount { get; set; }
        public string Reason { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public Guid Id { get; set; }
    }
    }
