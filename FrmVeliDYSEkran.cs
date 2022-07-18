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
namespace dershaneOtomasyon
{
    public partial class FrmVeliDYSEkran : Form
    {
        public FrmVeliDYSEkran()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        public static string duyuru1;
        public static string duyuru2;
        public static string duyuru3;
       
        private void öğrencilerimToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Veliogrencilerim veli_ogrencilerim = new frm_Veliogrencilerim();
            veli_ogrencilerim.Show();
        }

        private void öğretmenEMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Mailekrani mailgiris = new frm_Mailekrani();
            mailgiris.Show();
        }

        private void devamsızlıklığıGörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_velı_devamsızlıgı_gor frm_Velı_Devamsızlıgı_Gor = new frm_velı_devamsızlıgı_gor();
            frm_Velı_Devamsızlıgı_Gor.Show();
        }

        private void ödemeDurumumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_yonetıcı_ogrencı_odeme_bılgısı frm_Yonetıcı_Ogrencı_Odeme_Bılgısı = new frm_yonetıcı_ogrencı_odeme_bılgısı();
            frm_Yonetıcı_Ogrencı_Odeme_Bılgısı.Show();
        }

        private void görüşmelerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void ödemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_velı_odeme frm_Velı_Odeme = new frm_velı_odeme();
            frm_Velı_Odeme.Show();
        }

        private void genelDurumuGörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_velı_genel_durumu frm_Velı_Genel_Durumu = new frm_velı_genel_durumu();
            frm_Velı_Genel_Durumu.Show();
        }

        private void oturumuKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_veli_sifre_degis veli_Sifre_Degis = new frm_veli_sifre_degis();
            veli_Sifre_Degis.Show();
        }
        void ad_Al()
        {
            SqlCommand oku = new SqlCommand("select * from tbl_ogrenci where velikullaniciAdi='" + veliGirisEkrani.kullanici + "' ", baglan.baglanti());
            SqlDataReader dr = oku.ExecuteReader();
            while (dr.Read())
            {
                velikullanici.Text = (dr["velikullaniciAdi"].ToString());
            }
        }
        private void FrmVeliDYSEkran_Load(object sender, EventArgs e)
        {
            ad_Al();
            lblduyuru1.Text = duyuru1;
            lblduyuru2.Text = duyuru2;
            lblvduyuru3.Text = duyuru3;
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label16.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
