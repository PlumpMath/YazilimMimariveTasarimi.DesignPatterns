using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazılımMimariveTasarımıÖdevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         
        Resim rsm = new Resim();
        Video vdo = new Video();

        private void btnResimOynat_Click(object sender, EventArgs e)
        {
            
            Player p = new Player(rsm);
            MessageBox.Show(p.Play());
        }

        private void btnResimDurdur_Click(object sender, EventArgs e)
        {
            Player p = new Player(rsm);
            MessageBox.Show(p.Stop());
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox4.Text=textBox6.Text = "0";
            rsm.Ad = textBox1.Text;
            rsm.RenkDagilimi = textBox2.Text;
            rsm.ResmiCeken = textBox3.Text;

            vdo.Ad = textBox6.Text;
             vdo.ImdbPuani =Convert.ToInt32(textBox4.Text);
            vdo.Sure = uint.Parse(textBox6.Text);
        }

        private void btnVideoOynat_Click(object sender, EventArgs e)
        {
            Player p = new Player(vdo);
            MessageBox.Show(p.Play());
        }

        private void btnVideoDurdur_Click(object sender, EventArgs e)
        {
            Player p = new Player(vdo);
            MessageBox.Show(p.Stop());
        }

    }
}
