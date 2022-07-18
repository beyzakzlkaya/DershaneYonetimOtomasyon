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
    public partial class YoneticiGirisEkran : Form
    {
        public YoneticiGirisEkran()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        public static string kullanici;
        public static string sifre;
        void yoneticiGiris()
        {

            SqlCommand giris = new SqlCommand("select * from tbl_yonetici_giris where kullaniciAdi = '" + txtkullanici.Text + "' and sifre='" + txtsifre.Text + "'", baglan.baglanti());
            SqlDataReader oku = giris.ExecuteReader();
            if (oku.Read())
            {
                YoneticiDYSEkran yonetici = new YoneticiDYSEkran();
                yonetici.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı !!! ", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void YoneticiGiris_Click(object sender, EventArgs e)
        {
            YoneticiGirisEkran.ActiveForm.Hide();
            kullanici = txtkullanici.Text;
            sifre = txtsifre.Text;
            yoneticiGiris();     
        }

       
    }
}
