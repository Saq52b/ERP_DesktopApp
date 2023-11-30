using System;
using System.Collections.Generic;
using System.Text;

namespace DesktopApplication
{
  public  class AccountTypeLookupModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string NameArabic { get; set; }
        public ICollection<CostCenterLookUpModel> CostCenter { get; set; }

    }
}
