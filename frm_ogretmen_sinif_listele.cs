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
    public partial class frm_ogretmen_sinif_listele : Form
    {
        public frm_ogretmen_sinif_listele()
        {
            InitializeComponent();
        }

        Baglanti baglan = new Baglanti();
        public string sinif;
        public string ad;

        void sinifal()
        {
            SqlCommand sinif = new SqlCommand("select * from tbl_ogretmen where kulllaniciAdi='" + OgretmenGirisEkrani.kullaniciAdi + "'", baglan.baglanti());
            sinif.CommandType = CommandType.Text;
            SqlDataReader dr;
            dr = sinif.ExecuteReader();
            while (dr.Read())
            {
                ad = (dr["sinif"].ToString());
            }
        }
        void listele()
        {
            SqlCommand ogrenciListele = new SqlCommand("select ogrid,ogrtc,ograd,ogrsad,email,sinif,kursTur from tbl_ogrenci where sinif='"+ad+"'", baglan.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(ogrenciListele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;           
        }
        
        private void frm_ogretmen_sinif_listele_Load(object sender, EventArgs e)
        {
            sinifal();
            //sinif = frm_ogretmen_ogrenciDurumu.ad;
            listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}