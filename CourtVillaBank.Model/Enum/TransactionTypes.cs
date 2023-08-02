using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtVillaBank.Model.Enum
{
    public enum TransactionTypes
    {
        [Description ("Deposit")]
        Deposit =1,
        [Description ("WithDrawal")]
        WithDrawal =2,
        [Description ("Transfer")]
        Transfer =3,
            

    }
}
