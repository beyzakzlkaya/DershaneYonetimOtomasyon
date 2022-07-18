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
    public partial class frm_velı_genel_durumu : Form
    {
        public frm_velı_genel_durumu()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        void dogruYanlisListele()
        {
            SqlCommand listele = new SqlCommand("select testAdi,dogruSayisi,yanlisSayisi from tbl_sorular where ogrid='" + cmbad.Text + "'", baglan.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void sureListele()
        {
            SqlCommand listele = new SqlCommand("select testAdi,sure from tbl_sorular where ogrid='" + cmbad.Text + "'", baglan.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        private void frm_velı_genel_durumu_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_ogrenci where velikullaniciAdi='"+veliGirisEkrani.kullanici+"'", baglan.baglanti());
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbad.Items.Add(dr["ogrid"]);
            }
        }
    
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

                SqlCommand al = new SqlCommand("select * from tbl_ogrenci where ogrid=@p1", baglan.baglanti());
                al.Parameters.AddWithValue("@p1", cmbad.Text);
                SqlDataReader oku = al.ExecuteReader();
                while (oku.Read())
                {
                    lblad.Text = oku["ograd"].ToString();
                    lblsad.Text = oku["ogrsad"].ToString();
                    lblsinif.Text = oku["sinif"].ToString();
                    lblalan.Text = oku["kursTur"].ToString();
                }
            //dogruYanlis
            dogruYanlisListele();
            //sure
            sureListele();
       
          
        }
    }
}
