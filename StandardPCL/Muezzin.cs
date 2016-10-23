using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardPCL
{
    public class Muezzin
    {
        public string Callout() { return "Hello";  }

        public string GetCurrentTime()
        {
            return DateTimeOffset.Now.TimeOfDay.ToString();
        }
    }


}
