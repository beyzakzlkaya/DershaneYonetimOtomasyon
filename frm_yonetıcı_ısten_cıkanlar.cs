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
    public partial class frm_yonetıcı_ısten_cıkanlar : Form
    {
        public frm_yonetıcı_ısten_cıkanlar()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        public static string veri;
        void Listele()
        {
            SqlCommand listele = new SqlCommand("select * from tbl_Silinenogretmen", baglan.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void frm_yonetıcı_ısten_cıkanlar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = veri;
            Listele();
        }
        private void btnara_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
