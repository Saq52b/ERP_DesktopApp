using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DesktopApplication
{
    public enum PartiallyInvoices
    {
        [Display(Name = "UnPaid")]
        UnPaid = 1,
        [Display(Name = "Partially")]
        Partially = 2,
        [Display(Name = "Fully")]
        Fully = 3,
    }
}
