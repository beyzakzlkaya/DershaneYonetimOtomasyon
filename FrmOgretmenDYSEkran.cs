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
    public partial class FrmOgretmenDYSEkran : Form
    {
        public FrmOgretmenDYSEkran()
        {
            InitializeComponent();
        }
        public static string al;
        public static string duyuru1;
        public static string duyuru2;
        public static string duyuru3;
        Baglanti baglan = new Baglanti();
        private void öğrenciİleİletişimeGeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ogretmenMail ogretmenogrencimail = new frm_ogretmenMail();
            ogretmenogrencimail.Show();
        }

        private void veliİleİletişimeGeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ogretmenVeliMail ogretmenvelimail = new frm_ogretmenVeliMail();
            ogretmenvelimail.Show();
        }

        private void yoklamaGirdisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ogretmen_yoklama frm_Ogretmen_Yoklama = new frm_ogretmen_yoklama();
            frm_Ogretmen_Yoklama.Show();
        }

        private void sınıflarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ogretmen_sinif_listele listele = new frm_ogretmen_sinif_listele();
            listele.Show();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        void ad_Al()
        {
            SqlCommand oku = new SqlCommand("select * from tbl_ogretmen where kulllaniciAdi='"+OgretmenGirisEkrani.kullaniciAdi+"' ", baglan.baglanti());
            SqlDataReader dr = oku.ExecuteReader();
            while (dr.Read())
            {
                lblad.Text=(dr["ogretmen_ad"] + " " + dr["ogretmen_sad"]);
            }
        }
        void brans()
        {
            SqlCommand oku = new SqlCommand("select * from tbl_ogretmen where kulllaniciAdi='" + OgretmenGirisEkrani.kullaniciAdi + "' ", baglan.baglanti());
            SqlDataReader dr = oku.ExecuteReader();
            while (dr.Read())
            {
                lblbrans.Text = dr["brans"].ToString();
            }
        }
        private void FrmOgretmenDYSEkran_Load(object sender, EventArgs e)
        {
          
            ad_Al();
            brans();
            lblduyuru1.Text = duyuru1;
            lblduyuru2.Text = duyuru2;
            lblduyuru3.Text = duyuru3;
            al = frm_ogretmen_ogrenciDurumu.ad;
        }

        private void oturumuKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ogretmen_sifre_degis ogretmen_Sifre_Degis = new frm_ogretmen_sifre_degis();
            ogretmen_Sifre_Degis.Show();
        }
        private void yatanMaaşToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ogretmen_yatan_maas yatan_Maas = new frm_ogretmen_yatan_maas();
            yatan_Maas.Show();
        }

        private void öğrenciDurumlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ogretmen_ogrenciDurumu ogretmen_OgrenciDurumu = new frm_ogretmen_ogrenciDurumu();
            ogretmen_OgrenciDurumu.Show();
        }

        private void dersProgramıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ogretmen_ders_programi ders_Programi = new frm_ogretmen_ders_programi();
            ders_Programi.Show();
        }
    }
}
