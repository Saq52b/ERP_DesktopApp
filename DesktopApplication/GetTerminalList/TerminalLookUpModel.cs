using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesktopApplication.GetTerminal
{
    public class TerminalLookUpModel { 
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string MACAddress { get; set; }
        public string IPAddress { get; set; }
        public bool isActive { get; set; }
        public string PrinterName { get; set; }

    }
}
