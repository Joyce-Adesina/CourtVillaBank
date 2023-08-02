using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtVillaBank.Model.Enum
{
    public enum AccountType
    {
        [Description("Saving")]
        Saving,
        [Description("Current")]
        Current
    }
}
