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
    public partial class frmdersekle : Form
    {
        public frmdersekle()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        void listele()
        {
            SqlCommand listele = new SqlCommand("select * from tbl_dersler", baglan.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("insert into tbl_dersler (ders_adi) values (@p1)", baglan.baglanti());
            ekle.Parameters.AddWithValue("@p1",textBox1.Text);
            ekle.ExecuteNonQuery();
            MessageBox.Show("Ders Kaydı Gerçekleşti");
            listele();
        }

        private void frmdersekle_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("delete tbl_dersler where idno='"+textBox2.Text+"'", baglan.baglanti());
            sil.ExecuteNonQuery();
            MessageBox.Show("Ders Kaydı Gerçekleşti");
            listele();
        }
    }
}
