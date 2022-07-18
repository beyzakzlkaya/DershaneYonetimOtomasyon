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
    public partial class frm_yonetıcı_velı_odeme_gecmısı : Form
    {
        public frm_yonetıcı_velı_odeme_gecmısı()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        void listele()
        {
            SqlCommand listele = new SqlCommand("select * from tbl_ogr_taksit", baglan.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void aratc()
        {
            SqlCommand ara = new SqlCommand("select * from tbl_ogr_taksit where ogrtc like'%" + msktc.Text + "%'", baglan.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(ara);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            msktc.Text = "";
        }
        private void btnara_Click(object sender, EventArgs e)
        {
            aratc();
        }

        private void frm_yonetıcı_velı_odeme_gecmısı_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
