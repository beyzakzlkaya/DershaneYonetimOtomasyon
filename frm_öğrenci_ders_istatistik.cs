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
    public partial class frm_öğrenci_ders_istatistik : Form
    {
        public frm_öğrenci_ders_istatistik()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        public static string ogrenci;
        public static string dersg;
        private void frm_öğrenci_ders_istatistik_Load(object sender, EventArgs e)
        {
            SqlCommand ogretmen = new SqlCommand("select count(*) from tbl_ogrenci", baglan.baglanti());
            SqlDataReader oku = ogretmen.ExecuteReader();
            while (oku.Read())
            {
                lblogrenci.Text = oku[0].ToString();
                ogrenci = lblogrenci.Text;
            }
            SqlCommand ders = new SqlCommand("select count(*) from tbl_dersler", baglan.baglanti());
            SqlDataReader oku1 = ders.ExecuteReader();
            while (oku1.Read())
            {
                lblders.Text = oku1[0].ToString();
            }
            //ogrenci = lblogrenci.Text;
            dersg = lblders.Text;
            chart1.Series["KAYIT"].Points.AddXY("Ders", lblders.Text);
            chart1.Series["KAYIT"].Points.AddXY("Öğrenci", lblogrenci.Text);
        }
    }
}
