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
    public partial class frm_yönetici_ogrenci_devamsızlık : Form
    {
        public frm_yönetici_ogrenci_devamsızlık()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        public int id;
        
        void listele()
        {
            
            SqlCommand siniflistele = new SqlCommand("select * from tbl_ogr_devamsizlik where sinif='"+cmbsinif.Text+"'", baglan.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(siniflistele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void sinifAl()
        {
            //sinifGetir
            SqlCommand sinifal = new SqlCommand("select * from tbl_sinif", baglan.baglanti());
            sinifal.CommandType = CommandType.Text;
            SqlDataReader dr;
            dr = sinifal.ExecuteReader();
            while (dr.Read())
            {
                cmbsinif.Items.Add(dr["sinifadi"]);
            }
        }
        public static string sorgucumlesi;
        void guncelle()
        {
            
            if (radioButton1.Checked == true) 
            {
                sorgucumlesi = "update tbl_ogr_devamsizlik set devamsizlikTrh = @p1 ,izinli='" + " " + "', devamsız='" + lbldurum.Text + "'  where ogrNo='"+dataGridView1.CurrentRow.Cells[0].Value+"'";  
            }
            else 
            {
                sorgucumlesi = "update tbl_ogr_devamsizlik set devamsizlikTrh = @p1 ,izinli='" + lbldurum.Text + "', devamsız='"+" "+"'  where ogrNo='"+dataGridView1.CurrentRow.Cells[0].Value+"'"; 
            }
            SqlCommand guncelle = new SqlCommand(sorgucumlesi, baglan.baglanti());

            DateTime date = dateTimePicker1.Value;
            guncelle.Parameters.AddWithValue("@p1", date);

            guncelle.ExecuteNonQuery();
            listele();
            MessageBox.Show(" Devamsızlık İşlemi Başarıyla Tamamlandı");
        }
        private void frm_yönetici_ogrenci_devamsızlık_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dershaneYonetimDataSet.tbl_ogr_devamsizlik' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_ogr_devamsizlikTableAdapter.Fill(this.dershaneYonetimDataSet.tbl_ogr_devamsizlik);

            lbldurum.Visible = false;
            listele();
            sinifAl();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listele();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) { lbldurum.Text = "Devamsız"; }
            else { lbldurum.Text = "İzinli"; }
            guncelle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //SqlCommand guncelle = new SqlCommand("update tbl_ogr_devamsizlik set devamsizlikTrh=@p1 ,devamsız=@p2 ,izinli=@p3 where id='" + dataGridView1.CurrentRow.Cells[0] + "'", baglan.baglanti());
            //guncelle.Parameters.AddWithValue("@p1", dateTimePicker1.Value);
            //guncelle.Parameters.AddWithValue("@p2", dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
            //guncelle.Parameters.AddWithValue("@p3", dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
            //guncelle.ExecuteNonQuery();
            //listele();
            //MessageBox.Show(" Devamsızlık İşlemi Başarıyla Tamamlandı");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //lbldurum.Text = "Devamsız";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //lbldurum.Text = "İzinli";
        }
    }
    }
