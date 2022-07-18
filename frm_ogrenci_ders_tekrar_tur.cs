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
    public partial class frm_ogrenci_ders_tekrar_tur : Form
    {
        public frm_ogrenci_ders_tekrar_tur()
        {
            InitializeComponent();
        }

        private void btniletisim_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=_Bu65SpPHR4&list=PLatGE2NfKm5Gj1dVXdshS1DwbPuODp7F-&index=2");
        }

        private void btnyazim_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=GhkjOisviZc&list=PLatGE2NfKm5Gj1dVXdshS1DwbPuODp7F-&index=5");
        }

        private void btnisim_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=mJ6BiFDDHbk&list=PLatGE2NfKm5Gj1dVXdshS1DwbPuODp7F-&index=6");
        }

        private void btnnoktalama_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=52OFIa0qX-k&list=PLatGE2NfKm5Gj1dVXdshS1DwbPuODp7F-&index=7");
        }

        private void btnsifat_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=D2G_uTLBkFk&list=PLatGE2NfKm5Gj1dVXdshS1DwbPuODp7F-&index=11");
        }

        private void btnunlem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=LuP0Hbzw4E0&list=PLatGE2NfKm5Gj1dVXdshS1DwbPuODp7F-&index=15");
        }

        private void btnzamir_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=u-uUf_TLvfk&list=PLatGE2NfKm5Gj1dVXdshS1DwbPuODp7F-&index=22");
        }

        private void btnfiil_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=nY42cMv3mhY&list=PLatGE2NfKm5Gj1dVXdshS1DwbPuODp7F-&index=27");
        }
    }
}
