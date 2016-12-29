using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika
{
    public class SavasFabrikası
    {
        public Savas savasaraclariuret(string yenisavasaraci)
        {
            if (yenisavasaraci == "Gemi")
            {
                return new Gemi();
            }
            else if (yenisavasaraci=="Helikopter")
            {
                return new Helikopter();
            }
            else if (yenisavasaraci=="Tank")
            {
                return new Tank();
            }
            else return null;
        }
    }
}
