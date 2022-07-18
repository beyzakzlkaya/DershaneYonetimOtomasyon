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
    public partial class frm_yonetıcı_gelır_gırısı : Form
    {
        public frm_yonetıcı_gelır_gırısı()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        void listele()
        {
            SqlCommand listele = new SqlCommand("select * from tbl_gider_gelir", baglan.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void ekle()
        {
            SqlCommand ekle = new SqlCommand("insert into tbl_gider_gelir(tarih,islemTur,tutar,islem,gelirTl,giderTl,kasa) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglan.baglanti());
            ekle.Parameters.AddWithValue("@p1",dateTimePicker1.Value);
            ekle.Parameters.AddWithValue("@p2",txtislemTur.Text);
            ekle.Parameters.AddWithValue("@p3",txtTutar.Text);
            ekle.Parameters.AddWithValue("@p4",lblveri.Text);
            ekle.Parameters.AddWithValue("@p5", lblgelir.Text);
            ekle.Parameters.AddWithValue("@p6", lblgider.Text);
            ekle.Parameters.AddWithValue("@p7", lblkasa.Text);
            ekle.ExecuteNonQuery();
            OkuKasa();
            //toplamKasa
            Eklekasa = Convert.ToInt32(kasa) + Convert.ToInt32(txtTutar.Text);
            lblkasa.Text =Eklekasa.ToString();
           
            //gelir
            if (lblveri.Text == "GELİR")
            {
                OkuGelir();
                Eklegelir = Convert.ToInt32(gelir) + Convert.ToInt32(txtTutar.Text);
                lblgelir.Text = Eklegelir.ToString();
            }
            else if (lblveri.Text == "GİDER")
            {
                OkuGider();
                Eklegider = Convert.ToInt32(gider) + Convert.ToInt32(txtTutar.Text);
                lblgider.Text = Eklegider.ToString();
            }
            if (lblveri.Text == "GİDER")
            {
                OkuKasa();
                Eklekasa = Convert.ToInt32(kasa) - Convert.ToInt32(txtTutar.Text);
                lblkasa.Text = Eklekasa.ToString();
            }
        }
        public static int Eklegelir = 0;
        public static int Eklegider = 0;
        public static int Eklekasa=0;
        public string kasa;
        public string gider;
        public string gelir;
        public static string gelirVeri;
        public static string giderVeri ;
        public static string kasaVeri;
        public void OkuKasa()
        {
            SqlCommand kasaoku = new SqlCommand("select * from tbl_gider_gelir", baglan.baglanti());
            SqlDataReader dr = kasaoku.ExecuteReader();
            while (dr.Read())
            {
                kasa = dr["kasa"].ToString();
                lblkasa.Text = kasa.ToString();
            }
        }
        public void OkuGelir()
        {
            SqlCommand geliroku = new SqlCommand("select * from tbl_gider_gelir", baglan.baglanti());
            SqlDataReader dr = geliroku.ExecuteReader();
            while (dr.Read())
            {
                gelir = dr["gelirTl"].ToString();
                lblgelir.Text = gelir.ToString();
            }
        }
        public void OkuGider()
        {
            SqlCommand gideroku = new SqlCommand("select * from tbl_gider_gelir", baglan.baglanti());
            SqlDataReader dr = gideroku.ExecuteReader();
            while (dr.Read())
            {
                gider = dr["giderTl"].ToString();
                lblgider.Text = gider.ToString();
            }
        }
        private void frm_yonetıcı_gelır_gırısı_Load(object sender, EventArgs e)
        {
            lblveri.Visible = false;
            listele();
            OkuKasa();
            OkuGelir();
            OkuGider();
            kasaVeri = lblkasa.Text;
            giderVeri = lblgider.Text;
            gelirVeri = lblgelir.Text;
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            ekle();
            listele();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                lblveri.Text = "GELİR";
            }
            else if (radioButton2.Checked == true)
            {
                lblveri.Text = "GİDER";
            }
        }
    }
}
