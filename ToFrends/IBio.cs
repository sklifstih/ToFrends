using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToFrends
{
    internal interface IBio
    {
        string Name { get; }
        object City { get; }
        object Country { get; }
        string Request { get; }
        object Ideas { get; }

    }
}
