using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimMimariveTasarimiOdevi2
{
    public class DusmanTank:IDusman
    {
        public void SilahKullan()
        {
            MessageBox.Show("Dusman Tanki Silah Kullaniyor!");       
        }

        public void Hizlan()
        {
            MessageBox.Show("Dusman Tanki Hizlaniyor!");
        }

        public void DusmanAdi()
        {
             MessageBox.Show("Dusman Tanki YZM2116");
        }

    
    }
}
