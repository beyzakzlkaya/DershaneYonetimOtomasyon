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
    public partial class frmOgretmenKayitlari : Form
    {
        public frmOgretmenKayitlari()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmdb;
        void listele()
        {
            SqlCommand listele = new SqlCommand("select * from tbl_ogretmen", baglan.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void ara()
        {
            SqlCommand ara = new SqlCommand("select * from tbl_ogretmen where ogretmen_ad like'%" + txtad.Text + "%'", baglan.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(ara);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            txtad.Text = " ";
        }
        void sil()
        {
            SqlCommand sil = new SqlCommand("delete tbl_ogretmen where idno='" + txtperid.Text + "'", baglan.baglanti());// öğrenci numarasına göre silme işlemi
            sil.ExecuteNonQuery();
            MessageBox.Show("Kayıt Silindi");
            listele();
        }
        void guncelle()
        {
           
            listele();
            MessageBox.Show("Güncelleme İşlemi Başarıyla Tamamlandı");
        }

        private void frmOgretmenKayitlari_Load(object sender, EventArgs e)
        {
            listele();

            da = new SqlDataAdapter("Select * from tbl_ogretmen", baglan.baglanti());
            cmdb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "tbl_ogretmen");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ara();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            sil();
            SqlCommand trigger = new SqlCommand("enable trigger tr_Silinenogretmen on tbl_ogretmen", baglan.baglanti());
            trigger.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(trigger);
            DataTable dt = new DataTable();
            da.Fill(dt);
            FrmKaydiSilinenler.veri = dt.ToString();
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtperid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtad.Text= dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()+" "+ dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            da.Update(ds, "tbl_ogretmen");
            MessageBox.Show("Kayıt güncellendi");
        }
    }
}
