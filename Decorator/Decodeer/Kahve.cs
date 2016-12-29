using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decodeer
{
    public class Kahve:KahveDecoder
    {

        public double FiyatBul()
        {
            return base.FiyatBul() + 0.50;
        }
    }
}
