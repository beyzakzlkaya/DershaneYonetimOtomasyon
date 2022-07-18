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
    public partial class frm_velı_odeme : Form
    {
        public frm_velı_odeme()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        public string ay;
        public static string ograd;
        public static string aciklama;
        public static string ogrtc;
        public static string kurstur;
        public static string odemesekli;
        public static string toplam;
        public static string odemetrh;
        public static string fisid;
        void listele()
        {
            SqlCommand listele = new SqlCommand("select ogrid,ogrtc,ograd,ogrsad,kursTur,odemesekli,odemetaksit,odencektutar from tbl_ogrenci where velikullaniciAdi=@p1", baglan.baglanti());
            listele.Parameters.AddWithValue("@p1", veliGirisEkrani.kullanici);
            SqlDataAdapter da = new SqlDataAdapter(listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void frm_velı_odeme_Load(object sender, EventArgs e)
        {
            lblogrid.Visible = false;
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblogrid.Text= dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            msktc.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtadsoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + " " + dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtkurs.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbodeme.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtay.Text= dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txttutar.Text=dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }
        void kaydetTaksit()
        {
            SqlCommand kaydet = new SqlCommand("insert into tbl_ogr_taksit (ograd,ogrtc,toplam,odemesekli,odemetrh,aciklama) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglan.baglanti());
            kaydet.Parameters.AddWithValue("@p1", txtadsoyad.Text);
            kaydet.Parameters.AddWithValue("@p2", msktc.Text);
            kaydet.Parameters.AddWithValue("@p3", txttutar.Text);
            kaydet.Parameters.AddWithValue("@p4", cmbodeme.Text);
            kaydet.Parameters.AddWithValue("@p5", dateTimePicker1.Value);
            kaydet.Parameters.AddWithValue("@p6", txtaciklama.Text);
            kaydet.ExecuteNonQuery();
        }
        void ode()
        {
            if (cmbodeme.SelectedIndex == 1 || cmbodeme.SelectedIndex == 2)
            {
                SqlCommand guncelle = new SqlCommand("update tbl_ogrenci set odemetaksit=@p1 where ogrid=@p2 ", baglan.baglanti());

                int taksit = Convert.ToInt32(txtay.Text);
                int dusen = taksit - 1;
                guncelle.Parameters.AddWithValue("@p1", dusen);
                guncelle.Parameters.AddWithValue("@p2", lblogrid.Text);
                guncelle.ExecuteNonQuery();

                Oku();
                kaydetTaksit();
                listele();
                temizle();
            }
        }
        void temizle()
        {
            txtadsoyad.Text = " ";
            txtay.Text = " ";
            txtkurs.Text = " ";
            txttutar.Text = " ";
            cmbodeme.Text = " ";
        }
        public void Oku()
        {
            SqlCommand oku = new SqlCommand("select odemetaksit from tbl_ogrenci where odemesekli='KREDİ KARTI'", baglan.baglanti());
            SqlDataReader dr =oku.ExecuteReader();
            while (dr.Read())
            {
                ay = dr["odemetaksit"].ToString();
                txtay.Text = ay.ToString();
            }
        }
        private void btnode_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fatura Oluşturuluyor", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            aciklama = txtaciklama.Text;
            ogrtc = msktc.Text;
            ograd = txtadsoyad.Text;
            odemetrh = dateTimePicker1.Value.ToString();
            kurstur = txtkurs.Text;
            toplam = txttutar.Text;
            odemesekli = cmbodeme.Text;
            ode();
            frm_veli_ogrenci_taksit_odeme_fatura frm_Veli_Ogrenci_Taksit_Odeme_Fatura = new frm_veli_ogrenci_taksit_odeme_fatura();
            frm_Veli_Ogrenci_Taksit_Odeme_Fatura.Show();

        }
    }
}
