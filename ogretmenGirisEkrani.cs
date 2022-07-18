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
    public partial class OgretmenGirisEkrani : Form
    {
        public OgretmenGirisEkrani()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        public static string kullaniciAdi;
        public static string sifre;
        public static string mail;
        void ogretmenGiris()
        {
            SqlCommand giris = new SqlCommand("select * from tbl_ogretmen where kulllaniciAdi = '" + txtkullanici.Text + "' and sifre='" + txtsifre.Text + "'", baglan.baglanti());
            SqlDataReader oku = giris.ExecuteReader();
            if (oku.Read())
            {
                FrmOgretmenDYSEkran ogrtmenekran = new FrmOgretmenDYSEkran();
                ogrtmenekran.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı !!! ", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        void mail_al()
        {

            SqlCommand oku = new SqlCommand("select ogretmen_mail from tbl_ogretmen where kullLaniciAdi='"+txtkullanici.Text+"'", baglan.baglanti());
            SqlDataReader dr = oku.ExecuteReader();
            while (dr.Read())
            {
                mail = dr["ogretmen_mail"].ToString();
            }
        }
        private void yoneticigiris_Click(object sender, EventArgs e)
        {
            ogrenciGirisEkrani.ActiveForm.Hide();
            kullaniciAdi = txtkullanici.Text;
            sifre = txtsifre.Text;
            ogretmenGiris();
            mail_al();
        }

        private void OgretmenGirisEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}
