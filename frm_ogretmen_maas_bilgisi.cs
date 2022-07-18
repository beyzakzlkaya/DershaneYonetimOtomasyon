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
    public partial class frm_ogretmen_maas_bilgisi : Form
    {
        public frm_ogretmen_maas_bilgisi()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        void listele()
        {
            SqlCommand listele = new SqlCommand("select * from tbl_ogretmen_maas", baglan.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand ara = new SqlCommand("select * from tbl_ogretmen_maas where ogretmenad like'%" + txtad.Text + "%'", baglan.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(ara);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            txtad.Text = "";
        }

        private void frm_ogretmen_maas_bilgisi_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
