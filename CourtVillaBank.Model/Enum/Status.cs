using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtVillaBank.Model.Enum
{
    public enum Status
    {
        [Description("Successfull")]
        Successfull,
        [Description("Error")]
        Error,
        [Description("Pending")]
        Pending,
        [Description("Failed")]
        Failed

    }
}
