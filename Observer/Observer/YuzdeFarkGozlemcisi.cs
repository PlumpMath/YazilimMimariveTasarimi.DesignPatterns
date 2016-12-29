using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer
{
    public class YuzdeFarkGozlemcisi:IObserver
    {
        public void Update(double YeniDeger)
        {
            double fark = 10;
            MessageBox.Show("Güncelleme oldu. Fark: " + fark);
        }
    }
}
