using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace dershaneOtomasyon
{
    public partial class FrmOgrenciKayitlari : Form
    {
        public FrmOgrenciKayitlari()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmdb;
        void Listele()
        {
            SqlCommand listele = new SqlCommand("select * from tbl_ogrenci", baglan.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void sil()
        {
            //  dataGridView1.CurrentRow.Cells[0].Value.ToString()
            SqlCommand sil = new SqlCommand("delete tbl_ogrenci where ogrid='" + txtogrno.Text + "'", baglan.baglanti());// öğrenci numarasına göre silme işlemi
            sil.ExecuteNonQuery();
            MessageBox.Show("Kayıt Silindi");
            Listele();
        }
        private void FrmOgrenciKayitlari_Load(object sender, EventArgs e)
        {
            Listele();
            
            da = new SqlDataAdapter("Select * from tbl_ogrenci", baglan.baglanti());
            cmdb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "tbl_ogrenci");
            dataGridView1.DataSource = ds.Tables[0];

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand ara = new SqlCommand("select * from tbl_ogrenci where ograd like'%" + txtograd.Text + "%'", baglan.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(ara);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            txtograd.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Listele();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            sil();
            SqlCommand trigger = new SqlCommand("enable trigger tr_Silinenogrenci on tbl_ogrenci", baglan.baglanti());
            trigger.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(trigger);
            DataTable dt = new DataTable();
            da.Fill(dt);
            FrmKaydiSilinenler.veri=dt.ToString();
            Listele();
            //SqlCommand triggerpasif = new SqlCommand("disable trigger tr_Silinenogrenci on tbl_ogrenci", baglan.baglanti());
            //triggerpasif.ExecuteNonQuery();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            da.Update(ds, "tbl_ogrenci");
            MessageBox.Show("Kayıt güncellendi");
        }

            private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtograd.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + " " + dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtogrno.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
