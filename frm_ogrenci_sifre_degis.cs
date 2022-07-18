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
    public partial class frm_ogrenci_sifre_degis : Form
    {
        public frm_ogrenci_sifre_degis()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
       
        void guncelle()
        {
            SqlCommand guncelle = new SqlCommand("update tbl_ogrenci set sifre = @p1 where kullaniciAdi = '" + txtkullanici.Text + "'",baglan.baglanti());
            guncelle.Parameters.AddWithValue("@p1",txtyenisifre.Text);
            guncelle.ExecuteNonQuery();
        }
        void temizle()
        {
            txtkullanici.Text = " ";
            txtyenisifre.Text = " ";
            txteskisifre.Text = " ";
        }
        private void frm_ogrenci_sifre_degis_Load(object sender, EventArgs e)
        {
            txtkullanici.Text = ogrenciGirisEkrani.kullanici;
            txteskisifre.Text = ogrenciGirisEkrani.sifre;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            guncelle();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
