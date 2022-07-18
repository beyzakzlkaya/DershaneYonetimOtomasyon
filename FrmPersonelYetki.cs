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
    public partial class FrmPersonelYetki : Form
    {
        public FrmPersonelYetki()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmdb;
        public static string personeller;       
        private void listele()
        {
            SqlCommand listele = new SqlCommand("select * from personel", baglan.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void temizle()
        {
            txtad.Text = " ";
            txtperid.Text = " ";
        }
        
        void sil() 
        {
            SqlCommand sil = new SqlCommand("delete personel where idno='" + txtperid.Text + "'", baglan.baglanti());// öğrenci numarasına göre silme işlemi
            sil.ExecuteNonQuery();
            MessageBox.Show("Kayıt Silindi");
            listele();
        }
        private void FrmPersonelYetki_Load(object sender, EventArgs e)
        {
            listele();
            da = new SqlDataAdapter("Select * from personel", baglan.baglanti());
            cmdb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "personel");
            dataGridView1.DataSource = ds.Tables[0];
        }   
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand ara = new SqlCommand("select * from personel where personelAd like'%"+txtad.Text+"%'",baglan.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(ara);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            txtad.Text = "";
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtperid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        private void btnlistele_Click(object sender, EventArgs e)
        {
            listele();
        }
        private void btnguncelle_Click_1(object sender, EventArgs e)
        {
            da.Update(ds, "personel");
            MessageBox.Show("Kayıt güncellendi");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            sil();
            temizle();
        }

        
    }
}
