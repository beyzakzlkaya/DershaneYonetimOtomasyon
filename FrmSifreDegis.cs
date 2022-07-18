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
    public partial class FrmSifreDegis : Form
    {
        public FrmSifreDegis()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();

        void guncelle()
        {
            SqlCommand guncelle = new SqlCommand("update tbl_yonetici_giris set sifre = @p1 where kullaniciAdi = '" + txtkullanici.Text + "'", baglan.baglanti());
            guncelle.Parameters.AddWithValue("@p1", txtyenisifre.Text);
            guncelle.ExecuteNonQuery();
        }
        void temizle()
        {
            txtkullanici.Text = " ";
            txtyenisifre.Text = " ";
            txteskisifre.Text = " ";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            guncelle();
        }

        private void FrmSifreDegis_Load(object sender, EventArgs e)
        {
            txtkullanici.Text = YoneticiGirisEkran.kullanici;
            txteskisifre.Text = YoneticiGirisEkran.sifre;
        }
    }
}
