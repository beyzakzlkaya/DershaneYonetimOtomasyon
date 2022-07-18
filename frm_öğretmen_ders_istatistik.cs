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
    public partial class frm_öğretmen_ders_istatistik : Form
    {
        public frm_öğretmen_ders_istatistik()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        private void frm_öğretmen_ders_istatistik_Load(object sender, EventArgs e)
        {
            SqlCommand ogretmen = new SqlCommand("select count(*) from tbl_ogretmen", baglan.baglanti());
            SqlDataReader oku = ogretmen.ExecuteReader();
            while (oku.Read())
            {
                lblogretmen.Text = oku[0].ToString();
            }
            SqlCommand ders = new SqlCommand("select count(*) from tbl_dersler", baglan.baglanti());
            SqlDataReader oku1 = ders.ExecuteReader();
            while (oku1.Read())
            {
                lblders.Text = oku1[0].ToString();
            }
            chart1.Series["AKTİF KAYIT"].Points.AddXY("Ders", lblders.Text);
            chart1.Series["AKTİF KAYIT"].Points.AddXY("Öğretmen", lblogretmen.Text);
        }
    }
}
