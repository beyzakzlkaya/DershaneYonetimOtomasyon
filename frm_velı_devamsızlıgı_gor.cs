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
    public partial class frm_velı_devamsızlıgı_gor : Form
    {
        public frm_velı_devamsızlıgı_gor()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        
        void devamsizlik()
        {
            SqlCommand listele = new SqlCommand("select * from tbl_ogr_devamsizlik where ogrNo='" + cmbogrenci.Text + "'", baglan.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void frm_velı_devamsızlıgı_gor_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_ogrenci where velikullaniciAdi='" + veliGirisEkrani.kullanici + "'", baglan.baglanti());
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbogrenci.Items.Add(dr["ogrid"]);
            }
        }

        private void cmbogrenci_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand al = new SqlCommand("select * from tbl_ogrenci where ogrid=@p1", baglan.baglanti());
            al.Parameters.AddWithValue("@p1", cmbogrenci.Text);
            SqlDataReader oku = al.ExecuteReader();
            while (oku.Read())
            {
                label2.Text = (oku["ograd"].ToString()+" "+oku["ogrsad"].ToString());
              
            }
            devamsizlik();
        }
    }
}
