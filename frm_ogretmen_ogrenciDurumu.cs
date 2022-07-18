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
    public partial class frm_ogretmen_ogrenciDurumu : Form
    {
        public frm_ogretmen_ogrenciDurumu()
        {
            InitializeComponent();
        }
        public static string ad;
        public static string id;

        Baglanti baglan = new Baglanti();
        void listele()
        {
            sinifal();
            SqlCommand ogrenciListele = new SqlCommand("select * from tbl_ogrenci where sinif='" + ad + "'", baglan.baglanti());
            ogrenciListele.CommandType = CommandType.Text;
            SqlDataReader dr;
            dr = ogrenciListele.ExecuteReader();
            while (dr.Read())
            {
                cmbad.Items.Add(dr["ogrid"].ToString());
                id = cmbad.Text;
            }
        }
        void dogruYanlisListele()
        {
            SqlCommand listele = new SqlCommand("select testAdi,dogruSayisi,yanlisSayisi from tbl_sorular where ogrid='" + cmbad.Text + "'", baglan.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void sureListele()
        {
            SqlCommand listele = new SqlCommand("select testAdi,sure from tbl_sorular where ogrid='" + cmbad.Text + "'", baglan.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        void sinifal()
        {
            SqlCommand sinif = new SqlCommand("select * from tbl_ogretmen where kulllaniciAdi='"+OgretmenGirisEkrani.kullaniciAdi+"'", baglan.baglanti());
            sinif.CommandType = CommandType.Text;
            SqlDataReader dr;
            dr = sinif.ExecuteReader();
            while (dr.Read())
            {
                ad=(dr["sinif"].ToString());
                lblss.Text = ad;
            }
        }
        private void frm_ogretmen_ogrenciDurumu_Load(object sender, EventArgs e)
        {
            lblss.Visible = false;
            listele();     
        }
        private void cmbad_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand al = new SqlCommand("select * from tbl_ogrenci where ogrid=@p1", baglan.baglanti());
            al.Parameters.AddWithValue("@p1", cmbad.Text);
            SqlDataReader oku = al.ExecuteReader();
            while (oku.Read())
            {
                lblad.Text = oku["ograd"].ToString();
                lblsad.Text = oku["ogrsad"].ToString();
                lblsinif.Text = oku["sinif"].ToString();
                lblalan.Text = oku["kursTur"].ToString();
            }
            dogruYanlisListele();
            sureListele();
        }

       
    }
}
