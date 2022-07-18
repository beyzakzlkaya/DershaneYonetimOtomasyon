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
    public partial class frm_ogrenci_ders_tekrar_kimya : Form
    {
        public frm_ogrenci_ders_tekrar_kimya()
        {
            InitializeComponent();
        }

        private void btnkimya_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=EALUEDmHh-Y&list=PLatGE2NfKm5EVUQJTxT0SZuEshhXxyZMN&index=1");
        }

        private void btnatom_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=f7J1hGaMa-I&list=PLatGE2NfKm5EVUQJTxT0SZuEshhXxyZMN&index=4");
        }

        private void btnatomyapi_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=17lXwEFOrQA&list=PLatGE2NfKm5EVUQJTxT0SZuEshhXxyZMN&index=5");
        }

        private void btnperiyodik_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=nQioqJe4-II&list=PLatGE2NfKm5EVUQJTxT0SZuEshhXxyZMN&index=9");
        }

        private void btngucluetki_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=ZLm1dZLPDzs&list=PLatGE2NfKm5EVUQJTxT0SZuEshhXxyZMN&index=14");
        }

        private void btnmetalik_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=IGbg215g0XU&list=PLatGE2NfKm5EVUQJTxT0SZuEshhXxyZMN&index=18");
        }

        private void btnhidrojen_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=RZ_7rdYNimg&list=PLatGE2NfKm5EVUQJTxT0SZuEshhXxyZMN&index=19");
        }

        private void btnmaddehal_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=FQuKClM3GsA&list=PLatGE2NfKm5EVUQJTxT0SZuEshhXxyZMN&index=21");
        }
    }
}
