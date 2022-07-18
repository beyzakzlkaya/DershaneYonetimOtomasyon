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
    public partial class frm_ogretmen_yatan_maas : Form
    {
        public frm_ogretmen_yatan_maas()
        {
            InitializeComponent();
        }

        Baglanti baglan = new Baglanti();
        void listele()
        {
            Tc_al();
            SqlCommand listele = new SqlCommand("select * from tbl_ogretmen_maas where ogretmenTc='"+Tc+"'", baglan.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public string Tc;
        void Tc_al()
        {
            SqlCommand tcal = new SqlCommand("select * from tbl_ogretmen where kulllaniciAdi='"+OgretmenGirisEkrani.kullaniciAdi+"'", baglan.baglanti());
            tcal.CommandType = CommandType.Text;
            SqlDataReader dr;
            dr = tcal.ExecuteReader();
            while (dr.Read())
            {
                Tc=(dr["tcno"].ToString());
            }
        }
        private void frm_ogretmen_yatan_maas_Load(object sender, EventArgs e)
        {
            listele();
        }

        
    }
}
