using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class HisseSenedi
    {
        private double doubledeger;
        List<IObserver> gozlemciler=new List<IObserver> ();

        public void GozlemciEkle(IObserver goz)
        {
            gozlemciler.Add(goz);
        }
        public void SetSondeger(double YeniDeger)
        {
            doubledeger = YeniDeger;
            GozlemciBilgilendir(YeniDeger);
            
        }
        void GozlemciBilgilendir(double YeniDeger)
        {
            foreach (IObserver item in gozlemciler)
            {
                item.Update(YeniDeger);
            }
        }

    }
}
