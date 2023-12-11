using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDBCalculation.Application.Util
{
    public static class Utility
    {
        public static double GetIRAliquot(int period)
        {
            return period switch
            {
                <= 6 => 22.5,
                <= 12 => 20,
                <= 24 => 17.5,
                > 24 => 15
            };
        }
    }
}
