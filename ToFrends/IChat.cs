using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToFrends
{
    interface IChat
    {
        object Messang { get; set; }
        public object GetMessan();
        public void SendMessan();
        object Files { get; set; }

    }
}
