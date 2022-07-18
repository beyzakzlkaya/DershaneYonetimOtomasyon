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
    public partial class frm_ogretmen_ders_programi : Form
    {
        public frm_ogretmen_ders_programi()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        public static string ad;
        void listele()
        {
            SqlCommand dersProgrami = new SqlCommand("select * from tbl_ogrenci_dersProgrami where sinif='" + ad + "'", baglan.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(dersProgrami);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void sinifAl()
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

        private void frm_ogretmen_ders_programi_Load(object sender, EventArgs e)
        {
            sinifAl();
            listele();
        }
    }
}
