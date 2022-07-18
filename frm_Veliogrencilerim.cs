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
    public partial class frm_Veliogrencilerim : Form
    {
        public frm_Veliogrencilerim()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        void listele()
        {
            SqlCommand listele = new SqlCommand("select ogrid,ograd,ogrsad,sinif,kursTur from tbl_ogrenci where velikullaniciAdi='"+veliGirisEkrani.kullanici+"'", baglan.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void frm_Veliogrencilerim_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
