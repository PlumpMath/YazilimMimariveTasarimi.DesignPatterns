using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimariveTasarimiOdevi2
{
    public class Adaptor:IDusman
    {
        DusmanRobotu dusmanrobotu;
        public Adaptor(DusmanRobotu _dusmanrobotu)
        {
            this.dusmanrobotu = _dusmanrobotu;
        }
        public void SilahKullan()
        {
            dusmanrobotu.YumrukAt();
        }
        public void Hizlan()
        {
            dusmanrobotu.Yuru();
        }
        public void DusmanAdi()
        {
            dusmanrobotu.RobotIsim();
        }
    }
}
