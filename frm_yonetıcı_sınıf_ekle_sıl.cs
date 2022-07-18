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
    public partial class frm_yonetıcı_sınıf_ekle_sıl : Form
    {
        public frm_yonetıcı_sınıf_ekle_sıl()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        void listele()
        {
            SqlCommand siniflistele = new SqlCommand("select * from tbl_sinif",baglan.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(siniflistele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void sinifEkle()
        {
            SqlCommand sinifekle = new SqlCommand("insert into tbl_sinif (sinifadi,sinifsayisi) values (@p1,@p2)", baglan.baglanti());
            sinifekle.Parameters.AddWithValue("@p1",txtsinifadi.Text);
            sinifekle.Parameters.AddWithValue("@p2", txtkontenjan.Text);
            sinifekle.ExecuteNonQuery();
            MessageBox.Show("Sınıf Eklendi");
            listele();
        }
        void sinifSil()
        {
            SqlCommand sinifsil = new SqlCommand("delete tbl_sinif where sinifid='" + txtsinifid.Text + "'", baglan.baglanti());
            sinifsil.ExecuteNonQuery();
            MessageBox.Show("Sınıf Silindi");
            listele();
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            sinifEkle();
        }
        private void btnsil_Click(object sender, EventArgs e)
        {
            sinifSil();
            txtsinifid.Text = " ";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtsinifid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void frm_yonetıcı_sınıf_ekle_sıl_Load(object sender, EventArgs e)
        {
            listele();
            dataGridView1.Columns[0].Visible = false;
        }
    }
}
