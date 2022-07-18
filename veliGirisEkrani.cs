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
    public partial class veliGirisEkrani : Form
    {
        public veliGirisEkrani()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        public static string kullanici;
        public static string sifre;
        public static string mail;
        void veliGiris()
        {

            SqlCommand giris = new SqlCommand("select * from tbl_ogrenci where velikullaniciAdi = '" + txtkullanici.Text + "' and velisifre='" + txtsifre.Text + "'", baglan.baglanti());
            SqlDataReader oku = giris.ExecuteReader();
            if (oku.Read())
            {
                FrmVeliDYSEkran veligrs = new FrmVeliDYSEkran();
                veligrs.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı !!! ", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void mail_al()
        { 
            SqlCommand oku = new SqlCommand("select veli_mail from tbl_ogrenci where velikulLaniciAdi='" + txtkullanici.Text + "'", baglan.baglanti());
            SqlDataReader dr = oku.ExecuteReader();
            while (dr.Read())
            {
                mail = dr["veli_mail"].ToString();
            }
        }

        private void yoneticigiris_Click(object sender, EventArgs e)
        {
            veliGirisEkrani.ActiveForm.Hide();
            kullanici = txtkullanici.Text;
            sifre = txtsifre.Text;
            veliGiris();
            mail_al();
        }

        private void veliGirisEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}
