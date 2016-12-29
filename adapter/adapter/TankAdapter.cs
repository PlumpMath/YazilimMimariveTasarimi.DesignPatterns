using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter
{
    public class TankAdapter : ISavasAraclari
    {
        Tank tnk;
        public TankAdapter(Tank gelentank)
        {
            tnk = gelentank;
        }

        public void AtesEt()
        {
            tnk.Bombala();
        }

        public void Havalan()
        {
            tnk.NamluYonuDegistir();
        }

        public void ileriGit()
        {
            tnk.HaraketEt();
        }

        public void kullanici(string kullanici)
        {
            tnk.SoforIsmi(kullanici);
        }
    }
}
