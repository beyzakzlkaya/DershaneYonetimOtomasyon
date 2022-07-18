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
    public partial class frm_ogrenci_ders_tekrar_cog : Form
    {
        public frm_ogrenci_ders_tekrar_cog()
        {
            InitializeComponent();
        }

        private void btninsan_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=lnX2RrtTaYg&list=PLatGE2NfKm5GX4T0mHKoKxxS_I2fYxy-T&index=1");
        }

        private void btndunya_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=Ow9_fJg5oK8&list=PLatGE2NfKm5GX4T0mHKoKxxS_I2fYxy-T&index=3");
        }

        private void btnkoordinat_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=rW6gVSrVrxo&list=PLatGE2NfKm5GX4T0mHKoKxxS_I2fYxy-T&index=5");
        }

        private void btnkonum_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=WzBTik6OrZY&list=PLatGE2NfKm5GX4T0mHKoKxxS_I2fYxy-T&index=6");
        }

        private void btnsicaklik_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=KfVYZXu7nFU&list=PLatGE2NfKm5GX4T0mHKoKxxS_I2fYxy-T&index=11");
        }

        private void btnbasinc_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=pTrBTftLVe4&list=PLatGE2NfKm5GX4T0mHKoKxxS_I2fYxy-T&index=12");
        }

        private void btnnem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=uWAv4JGp5Vk&list=PLatGE2NfKm5GX4T0mHKoKxxS_I2fYxy-T&index=13");
        }

        private void btnyeryuzu_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=AqaXln-x0T4&list=PLatGE2NfKm5GX4T0mHKoKxxS_I2fYxy-T&index=14");
        }
    }
}
