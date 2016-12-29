using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decodeer
{
   public class SutluOlsun:KahveDecoder
    {
       public SutluOlsun(IKahve k):base(k)
       {

       }
        public override double FiyatBul()
        {
            return base.FiyatBul() + 0.32;
        }
    }
}
