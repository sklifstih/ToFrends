using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToFrends
{
    internal interface ISearch
    {
        public void ToSearch ();
        object GeoData { get; }

    }
}
