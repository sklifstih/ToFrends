using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToFrends
{
    interface IBio
    {
        object City { get; set; }
        object Country { get; set; }
        string Request { get; set; }
        object Ideas { get; set; }

    }
}
