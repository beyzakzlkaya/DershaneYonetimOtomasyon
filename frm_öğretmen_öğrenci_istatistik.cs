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
    public partial class frm_öğretmen_öğrenci_istatistik : Form
    {
        public frm_öğretmen_öğrenci_istatistik()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
     

        private void frm_öğretmen_öğrenci_istatistik_Load(object sender, EventArgs e)
        {
            SqlCommand ogretmen = new SqlCommand("select count(*) from tbl_ogretmen",baglan.baglanti());
            SqlDataReader oku = ogretmen.ExecuteReader();           
            while (oku.Read())
            {
                lblogretmen.Text = oku[0].ToString();
            }
            SqlCommand ogrenci = new SqlCommand("select count(*) from tbl_ogrenci", baglan.baglanti());
            SqlDataReader oku1 = ogrenci.ExecuteReader();
            while (oku1.Read())
            {
                lblogrenci.Text = oku1[0].ToString();
            }

            chart1.Series["KİŞİ SAYISI"].Points.AddXY("Öğrenci", lblogrenci.Text);
            chart1.Series["KİŞİ SAYISI"].Points.AddXY("Öğretmen", lblogretmen.Text);
        }

      
    }
}
