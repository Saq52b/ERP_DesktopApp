
using System;

namespace DesktopApplication
{
    public class ModuleRightLookUpModel 
    {
        public Guid PermissionId { get; set; }
        public string PermissionName { get; set; }
        public string PermissionCategory { get; set; }
        public Guid NobleModuleId { get; set; }
        public string Key { get; set; }
        public string ModuleDescription { get; set; }
        public string ModuleName { get; set; }
        public bool IsActive { get; set; }

    }
}
