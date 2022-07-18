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
    public partial class ogrenciGirisEkrani : Form
    {
        public ogrenciGirisEkrani()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        public static string kullanici;
        public static string sifre;
        public static string mail;
        void ogrenciGiris()
        {

            SqlCommand giris = new SqlCommand("select * from tbl_ogrenci where kullaniciAdi = '" + txtkullanici.Text + "' and sifre='" + txtsifre.Text + "'", baglan.baglanti());
            SqlDataReader oku = giris.ExecuteReader();
            if (oku.Read())
            {
                FrmOgrenciDYSEkran ogrekran = new FrmOgrenciDYSEkran();
                ogrekran.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı !!! ", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void mail_al()
        {

            SqlCommand oku = new SqlCommand("select email from tbl_ogrenci where kullaniciAdi='" + txtkullanici.Text + "'", baglan.baglanti());
            SqlDataReader dr = oku.ExecuteReader();
            while (dr.Read())
            {
                mail = dr["email"].ToString();
            }
        }
        private void yoneticigiris_Click(object sender, EventArgs e)
        {           
            ogrenciGirisEkrani.ActiveForm.Hide();
            kullanici = txtkullanici.Text;
            sifre = txtsifre.Text;
            ogrenciGiris();
            mail_al();
        }

        private void ogrenciGirisEkrani_Load(object sender, EventArgs e)
        {

        }
    }
    }

