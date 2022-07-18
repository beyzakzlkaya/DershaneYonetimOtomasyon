using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dershaneOtomasyon
{
    public partial class GirisEkranı : Form
    {
        public GirisEkranı()
        {
            InitializeComponent();
        }

        private void YoneticiGiris_Click(object sender, EventArgs e)
        {
            YoneticiGirisEkran yg = new YoneticiGirisEkran();
            yg.Show();
        }

        private void OgretmenGirisi_Click(object sender, EventArgs e)
        {
            OgretmenGirisEkrani ogrtg = new OgretmenGirisEkrani();
            ogrtg.Show();
        }

        private void OgrenciGirisi_Click(object sender, EventArgs e)
        {
            ogrenciGirisEkrani ogrncg = new ogrenciGirisEkrani();
            ogrncg.Show();
        }

        private void VeliGirisi_Click(object sender, EventArgs e)
        {
            veliGirisEkrani vg = new veliGirisEkrani();
            vg.Show();
        }

        private void GirisEkranı_Load(object sender, EventArgs e)
        {

        }
    }
}
