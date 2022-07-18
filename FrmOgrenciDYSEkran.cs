using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;

namespace dershaneOtomasyon
{
    public partial class FrmOgrenciDYSEkran : Form
    {
        public FrmOgrenciDYSEkran()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        public static string duyuru1;
        public static string duyuru2;
        public static string duyuru3;
        public static string ad;
        private void öğretmenEMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_OgrenciMailEkrani ogrencimailekrani = new frm_OgrenciMailEkrani();
            ogrencimailekrani.Show();
        }

        private void notEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void matematikToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_ogrenci_testler_matematik ogrenci_test_mat = new frm_ogrenci_testler_matematik();
            ogrenci_test_mat.Show();

        }

        private void kimyaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_ogrenci_testler_kimya ogrenci_test_kim = new frm_ogrenci_testler_kimya();
            ogrenci_test_kim.Show();
        }

        private void fizikToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_ogrenci_testler_fızık ogrenci_test_fız = new frm_ogrenci_testler_fızık();
            ogrenci_test_fız.Show();
        }

        private void biyolojiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_ogrenci_testler_bıyolojı ogrenci_Testler_bıy = new frm_ogrenci_testler_bıyolojı();
            ogrenci_Testler_bıy.Show();
        }

        private void tarihToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_ogrenci_testler_tarıh ogrenci_Testler_tar = new frm_ogrenci_testler_tarıh();
            ogrenci_Testler_tar.Show();
        }

        private void coğrafyaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_ogrencı_testler_cog ogrencı_Testler_cog = new frm_ogrencı_testler_cog();
            ogrencı_Testler_cog.Show();
        }

        private void türkçeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_ogrencı_testler_tur ogrencı_testler_tur = new frm_ogrencı_testler_tur();
            ogrencı_testler_tur.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToLongTimeString();
        }
        void ad_Al()
        {
            SqlCommand oku = new SqlCommand("select * from tbl_ogrenci where kullaniciAdi='" + ogrenciGirisEkrani.kullanici + "' ", baglan.baglanti());
            SqlDataReader dr = oku.ExecuteReader();
            while (dr.Read())
            {
                ad = (dr["ograd"] + " " + dr["ogrsad"]);
                lblkullaniciadi.Text = ad;
            }
        }
        private void FrmOgrenciDYSEkran_Load(object sender, EventArgs e)
        {
            ad_Al();
            lblduyuru1.Text = duyuru1;
            lblduyuru2.Text = duyuru2;
            lblduyuru3.Text = duyuru3;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void testSonucuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ogrenc_testler_sonucu frm_Ogrenc_Testler_Sonucu = new frm_ogrenc_testler_sonucu();
            frm_Ogrenc_Testler_Sonucu.Show();
        }

        private void matematikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ogrenci_ders_tekrar_matematik frm_Ogrenci_Ders_Tekrar_Matematik = new frm_ogrenci_ders_tekrar_matematik();
            frm_Ogrenci_Ders_Tekrar_Matematik.Show();
        }

        private void denemeSınavıSonucuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void devamsızlığımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ogrenci_devamsızlıgım frm_Ogrenci_Devamsızlıgım = new frm_ogrenci_devamsızlıgım();
            frm_Ogrenci_Devamsızlıgım.Show();
        }

        private void fizikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ogrenci_ders_tekrar_fizik frm_Ogrenci_Ders_Tekrar_Fizik = new frm_ogrenci_ders_tekrar_fizik();
            frm_Ogrenci_Ders_Tekrar_Fizik.Show();
        }

        private void kimyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ogrenci_ders_tekrar_kimya frm_Ogrenci_Ders_Tekrar_Kimya = new frm_ogrenci_ders_tekrar_kimya();
            frm_Ogrenci_Ders_Tekrar_Kimya.Show();
        }

        private void biyolojiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ogrenci_ders_tekrar_biyoloji frm_Ogrenci_Ders_Tekrar_Biyoloji = new frm_ogrenci_ders_tekrar_biyoloji();
            frm_Ogrenci_Ders_Tekrar_Biyoloji.Show();
        }

        private void tarihToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ogrenci_ders_tekrar_tarih frm_Ogrenci_Ders_Tekrar_Tarih = new frm_ogrenci_ders_tekrar_tarih();
            frm_Ogrenci_Ders_Tekrar_Tarih.Show();
        }

        private void coğrafyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ogrenci_ders_tekrar_cog frm_Ogrenci_Ders_Tekrar_Cog = new frm_ogrenci_ders_tekrar_cog();
            frm_Ogrenci_Ders_Tekrar_Cog.Show();
        }

        private void türkçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ogrenci_ders_tekrar_tur frm_Ogrenci_Ders_Tekrar_Tur = new frm_ogrenci_ders_tekrar_tur();
            frm_Ogrenci_Ders_Tekrar_Tur.Show();
        }

        private void oturumuKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ogrenci_sifre_degis sifre_Degis = new frm_ogrenci_sifre_degis();
            sifre_Degis.Show();
        }

        private void onlineTestlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dersProgramıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ogrenci_Ders_programi frm_Yonetici_Ogrenci_Ders_Programı = new frm_ogrenci_Ders_programi();
            frm_Yonetici_Ogrenci_Ders_Programı.Show();
        }
    }
}
