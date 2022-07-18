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
    public partial class FrmKaydiSilinenler : Form
    {
        public FrmKaydiSilinenler()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        public static string veri;
        void Listele()
        {
            SqlCommand listele = new SqlCommand("select * from tbl_Silinenogrenci", baglan.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void FrmKaydiSilinenler_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = veri;
            Listele();
        }
       /* void ara()
        {
            SqlCommand ara = new SqlCommand("select * from tbl_Silinenogrenci where ogr_ad like'%" + textBox1.Text + "%'", baglan.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(ara);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }*/
        
    }
}
