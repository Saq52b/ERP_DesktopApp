using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApplication.Entities
{

    public class GetTerminalLook
    {
        public  Guid Id { get; set; }
        public  string Code { get; set; }
        public  string MACAddress { get; set; }
        public  string IPAddress { get; set; }
        public  bool isActive { get; set; }
        public  string PrinterName { get; set; }
    }
}
