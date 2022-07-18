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
    public partial class frm_yonetıcı_ogrencı_odeme_bılgısı : Form
    {
        public frm_yonetıcı_ogrencı_odeme_bılgısı()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        void listele()
        {
            SqlCommand listele = new SqlCommand("select * from tbl_ogr_taksit where ograd='"+cmbogrenci.Text+"'", baglan.baglanti());
            listele.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void frm_yonetıcı_ogrencı_odeme_bılgısı_Load(object sender, EventArgs e)
        {
            //ogrenciGetir
            SqlCommand ogrencial = new SqlCommand("select * from tbl_ogrenci where velikullaniciAdi='"+veliGirisEkrani.kullanici+"'", baglan.baglanti());
            ogrencial.CommandType = CommandType.Text;
            SqlDataReader dr;
            dr = ogrencial.ExecuteReader();
            while (dr.Read())
            {
                cmbogrenci.Items.Add(dr["ograd"] + " " + dr["ogrsad"]);
            }

        }
        private void cmbogrenci_SelectedIndexChanged(object sender, EventArgs e)
        {
            listele();
        }
    }
}
