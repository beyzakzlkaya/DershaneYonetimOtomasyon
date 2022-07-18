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
    public partial class frm_ogrenci_Ders_programi : Form
    {
        public frm_ogrenci_Ders_programi()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        public static string ad;
        void listele()
        {
            SqlCommand ogrenciListele = new SqlCommand("select * from tbl_ogrenci_dersProgrami where sinif='" + ad + "'", baglan.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(ogrenciListele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void sinifAl()
        {
            SqlCommand sinif = new SqlCommand("select * from tbl_ogrenci where kullaniciAdi='" + ogrenciGirisEkrani.kullanici + "'", baglan.baglanti());
            sinif.CommandType = CommandType.Text;
            SqlDataReader dr;
            dr = sinif.ExecuteReader();
            while (dr.Read())
            {
                ad = (dr["sinif"].ToString());
            }
        }

        private void frm_ogrenci_Ders_programi_Load(object sender, EventArgs e)
        {
            sinifAl();
            listele();
        }
    }
}
