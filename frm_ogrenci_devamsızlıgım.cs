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
    public partial class frm_ogrenci_devamsızlıgım : Form
    {
        public frm_ogrenci_devamsızlıgım()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        public int ogrno;

        public void listele()
        {
            SqlCommand listele = new SqlCommand("select * from tbl_ogr_devamsizlik where ogrNo='"+ogrno+"'", baglan.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
  

        private void frm_ogrenci_devamsızlıgım_Load(object sender, EventArgs e)
        {
        
            //ogradSoyad
            SqlCommand ogrencial = new SqlCommand("select * from tbl_ogrenci where kullaniciAdi='"+ogrenciGirisEkrani.kullanici+"'", baglan.baglanti());
            ogrencial.CommandType = CommandType.Text;
            SqlDataReader dr;
            dr = ogrencial.ExecuteReader();
            while (dr.Read())
            {
                lblad.Text=(dr["ograd"]+" "+ dr["ogrsad"]);
            }
            //ogrno
            SqlCommand ogrencino = new SqlCommand("select * from tbl_ogrenci where kullaniciAdi='"+ogrenciGirisEkrani.kullanici+"'", baglan.baglanti());
            ogrencino.CommandType = CommandType.Text;
            SqlDataReader dr1;
            dr1 = ogrencino.ExecuteReader();
            while (dr1.Read())
            {
                ogrno=Convert.ToInt32(dr1["ogrid"]);
                lblno.Text = ogrno.ToString();
            }
            listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
