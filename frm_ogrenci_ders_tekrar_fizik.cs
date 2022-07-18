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
    public partial class frm_ogrenci_ders_tekrar_fizik : Form
    {
        public frm_ogrenci_ders_tekrar_fizik()
        {
            InitializeComponent();
        }

        private void btnmadde_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=2LDlNtwfsG8&list=PLEZNrXIQh9YomSFQInCUY01htFKVx5QyI&index=2");
        }

        private void btnhareket_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=o-5OrfaA74o&list=PLEZNrXIQh9YomSFQInCUY01htFKVx5QyI&index=4");
        }

        private void btnkuvvet_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=XZtn4T7TvzI&list=PLEZNrXIQh9YomSFQInCUY01htFKVx5QyI&index=5");
        }

        private void btnis_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=mJdWnWM31jo&list=PLEZNrXIQh9YomSFQInCUY01htFKVx5QyI&index=6");
        }

        private void btnkaldırma_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=fp7d5xwZSBI&list=PLEZNrXIQh9YomSFQInCUY01htFKVx5QyI&index=11");
        }

        private void btnelektro_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=OMZd9kWYo9A&list=PLEZNrXIQh9YomSFQInCUY01htFKVx5QyI&index=13");
        }

        private void btnoptik_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=CBu9djibfuQ&list=PLEZNrXIQh9YomSFQInCUY01htFKVx5QyI&index=17");
        }

        private void btndalga_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=ZPViRtxWBnk&list=PLEZNrXIQh9YomSFQInCUY01htFKVx5QyI&index=20");
        }
    }
}
