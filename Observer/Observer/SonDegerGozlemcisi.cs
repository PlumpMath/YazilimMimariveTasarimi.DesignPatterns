using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer
{
    public class SonDegerGozlemcisi:IObserver
    {
        public void Update(double YeniDeger)
        {
            MessageBox.Show("Guncelleme Oldu yeni deger: "+YeniDeger);
        }

        
    }
}
