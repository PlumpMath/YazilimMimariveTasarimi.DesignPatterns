using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer
{
    public partial class Form1 : Form
    {
        HisseSenedi hissesenedi = new HisseSenedi();
        SonDegerGozlemcisi sondegergoz = new SonDegerGozlemcisi();
        YuzdeFarkGozlemcisi yfgoz = new YuzdeFarkGozlemcisi();
        public Form1()
        { 
            hissesenedi.GozlemciEkle(sondegergoz);
            hissesenedi.GozlemciEkle(yfgoz);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hissesenedi.SetSondeger(5);
        }

    }
}
