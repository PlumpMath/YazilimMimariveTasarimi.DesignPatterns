using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fabrika
{
   public abstract class Savas
    {
        public string Isim { get; set; }
        public double Deger { get; set; }

       public void setIsim(string setIsim)
        {
            Isim =setIsim ;
        }
       public void setDeger(double setdeger)
       {
           Deger = setdeger;
       }
       public void IsimGoruntule()
        {
            MessageBox.Show("Isim " + Isim);       
        }
       public void DegerGoster()
       {
           MessageBox.Show("Deger " + Deger);
       }
       public void IsimliDeger()
       {
           MessageBox.Show("Isim :" + Isim + "Deger: " + Deger);
       }
    }
}
