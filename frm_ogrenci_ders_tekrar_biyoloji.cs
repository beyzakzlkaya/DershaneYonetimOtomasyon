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
    public partial class frm_ogrenci_ders_tekrar_biyoloji : Form
    {
        public frm_ogrenci_ders_tekrar_biyoloji()
        {
            InitializeComponent();
        }

        private void btncanli_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=LouYW_yEsdE&list=PLatGE2NfKm5G1pVuBDM0OreW4fVwMfcR8&index=1");
        }

        private void btnbiyoloji_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=vx2XiIp_YM8&list=PLatGE2NfKm5G1pVuBDM0OreW4fVwMfcR8&index=2");
        }

        private void btnyag_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=ORXqlWNok0A&list=PLatGE2NfKm5G1pVuBDM0OreW4fVwMfcR8&index=4");
        }

        private void btnenzim_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=xYLnrDRXtFE&list=PLatGE2NfKm5G1pVuBDM0OreW4fVwMfcR8&index=5");
        }

        private void btnvitamin_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=M8CkrZfv3IM&list=PLatGE2NfKm5G1pVuBDM0OreW4fVwMfcR8&index=6");
        }

        private void btnnükleik_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=5piNBDelW-E&list=PLatGE2NfKm5G1pVuBDM0OreW4fVwMfcR8&index=7");
        }

        private void btnatp_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=zWKBvgW2OTg&list=PLatGE2NfKm5G1pVuBDM0OreW4fVwMfcR8&index=8");
        }

        private void btnsitoplazma_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=t_dFmEC21bc&list=PLatGE2NfKm5G1pVuBDM0OreW4fVwMfcR8&index=12");
        }
    }
}
