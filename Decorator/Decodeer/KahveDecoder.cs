using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decodeer
{
    public abstract class KahveDecoder:IKahve
    {
        private IKahve dekoredilen;
        public KahveDecoder(IKahve dekoreedilecek)
        {
            this.dekoredilen=dekoreedilecek;
        }

    
    public double FiyatBul()
    {
return dekoredilen.FiyatBul();  
    }


        }
          }

