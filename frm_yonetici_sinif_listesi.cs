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
    public partial class frm_yonetici_sinif_listesi : Form
    {
        public frm_yonetici_sinif_listesi()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        void listele()
        {
            SqlCommand listele = new SqlCommand("select ogrid,ogrtc,ograd,ogrsad,cinsiyet,foto from tbl_ogrenci where sinif='" + cmbsinif.Text + "'", baglan.baglanti());
            listele.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void frm_yonetici_sinif_listesi_Load(object sender, EventArgs e)
        {
            //sinifGetir
            SqlCommand ogrencial = new SqlCommand("select * from tbl_sinif", baglan.baglanti());
            ogrencial.CommandType = CommandType.Text;
            SqlDataReader dr;
            dr = ogrencial.ExecuteReader();
            while (dr.Read())
            {
                cmbsinif.Items.Add(dr["sinifadi"]);
            }            
        }

        private void cmbsinif_SelectedIndexChanged(object sender, EventArgs e)
        {
            listele();
        }
    }
}
