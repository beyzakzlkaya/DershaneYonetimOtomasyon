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
    public partial class frm_öğrenci_sınıf_istatistik : Form
    {
        public frm_öğrenci_sınıf_istatistik()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        public static string sinif;
     

        private void frm_öğrenci_sınıf_istatistik_Load(object sender, EventArgs e)
        {
            SqlCommand ogrenci = new SqlCommand("select count(*) from tbl_ogrenci", baglan.baglanti());
            SqlDataReader oku = ogrenci.ExecuteReader();
            while (oku.Read())
            {
                lblogr.Text = oku[0].ToString();
            }
            SqlCommand ders = new SqlCommand("select count(*) from tbl_sinif", baglan.baglanti());
            SqlDataReader oku1 = ders.ExecuteReader();
            while (oku1.Read())
            {
                lblsinif.Text = oku1[0].ToString();
            }
            chart1.Series["SAY"].Points.AddXY("Sinif", lblsinif.Text);
            chart1.Series["SAY"].Points.AddXY("Öğrenci", lblogr.Text);
            sinif = lblsinif.Text;
        }

       
    }
}
