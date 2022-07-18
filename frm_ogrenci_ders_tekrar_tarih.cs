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
    public partial class frm_ogrenci_ders_tekrar_tarih : Form
    {
        public frm_ogrenci_ders_tekrar_tarih()
        {
            InitializeComponent();
        }

        private void btnzaman_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=FkvHmQoKbeI&list=PLatGE2NfKm5HXKWqnuVL5Gd5nwf3VYpVm&index=1");
        }

        private void btninsanilk_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=R8zGCz4fNaA&list=PLatGE2NfKm5HXKWqnuVL5Gd5nwf3VYpVm&index=2");
        }

        private void btninsanvegoc_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=GeOR9JHvn4M&list=PLatGE2NfKm5HXKWqnuVL5Gd5nwf3VYpVm&index=4");
        }

        private void btndevlet_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=nXSkFOwMabw&list=PLatGE2NfKm5HXKWqnuVL5Gd5nwf3VYpVm&index=5");
        }

        private void btnkanun_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=w5D8IELuMw8&list=PLatGE2NfKm5HXKWqnuVL5Gd5nwf3VYpVm&index=6");
        }

        private void btnorta_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=aXVOhStakeU&list=PLatGE2NfKm5HXKWqnuVL5Gd5nwf3VYpVm&index=7");
        }

        private void btnturkizi_Click(object sender, EventArgs e)
        { 
            webBrowser1.Navigate("https://www.youtube.com/watch?v=cEleHGofWgM&list=PLatGE2NfKm5HXKWqnuVL5Gd5nwf3VYpVm&index=8");
        }

        private void btnboy_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=YQj1IDT7r28&list=PLatGE2NfKm5HXKWqnuVL5Gd5nwf3VYpVm&index=9");
        }
    }
}
