
using Microsoft.AspNetCore.Identity;
using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApplication.Model
{
    internal class ApplicationUsers: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid CompanyId { get; set; }
        public Guid? EmployeeId { get; set; }
        public Guid? TerminalId { get; set; }
        public string ImagePath { get; set; }
        public bool IsActive { get; set; }
        public bool IsProceed { get; set; }
    }
}
