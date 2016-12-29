using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fabrika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Savas savasaleti=null;
            SavasFabrikası fabrika=new SavasFabrikası ();
            string aracismi="";
            if (radioButton1.Checked==true)
            {
                aracismi = "Tank";
            }
            else if (radioButton2.Checked==true)
            {
                aracismi = "Gemi";
            }
            else if (radioButton3.Checked==true)
            {
                aracismi = "Helikopter";
            }
            savasaleti = fabrika.savasaraclariuret(aracismi);
            savasaleti.IsimGoruntule();
            savasaleti.IsimliDeger();
            savasaleti.DegerGoster();
            
        }
    }
}
