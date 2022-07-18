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
    public partial class frm_yonetici_ogrenci_ders_programı : Form
    {
        public frm_yonetici_ogrenci_ders_programı()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmdb;
        public string ders;

        void listele()
        {
            SqlCommand siniflistele = new SqlCommand("select * from tbl_ogrenci_dersProgrami", baglan.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(siniflistele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        
        private void frm_yonetici_ogrenci_ders_programı_Load(object sender, EventArgs e)
        {

            ders = dataGridView1.SelectedCells.ToString();
            listele();
            dataGridView1.Columns[0].Visible = false;
            //sinifGetirme
            SqlCommand oku = new SqlCommand("select * from tbl_sinif", baglan.baglanti());
            oku.CommandType = CommandType.Text;
            SqlDataReader dr;
            dr = oku.ExecuteReader();
            while (dr.Read())
            {
                listBox1.Items.Add(dr["sinifadi"].ToString());
            }

            //dersEkle
            SqlCommand oku1 = new SqlCommand("select * from tbl_dersler", baglan.baglanti());
            oku.CommandType = CommandType.Text;
            SqlDataReader dr1;
            dr1 = oku1.ExecuteReader();
            while (dr1.Read())
            {
                listBox2.Items.Add(dr1["ders_adi"].ToString());
            }

            //guncelle
            da = new SqlDataAdapter("Select * from tbl_ogrenci_dersProgrami", baglan.baglanti());
            cmdb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "tbl_ogrenci_dersProgrami");
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void btnolustur_Click(object sender, EventArgs e)
        {
            da.Update(ds, "tbl_ogrenci_dersProgrami");
            MessageBox.Show("Ders Programı Oluşturuldu");
        }

        
    }

} 
