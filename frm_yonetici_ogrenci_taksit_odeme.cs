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
using System.Net.Mail;
namespace dershaneOtomasyon
{
    public partial class frm_yonetici_ogrenci_taksit_odeme : Form
    {
        public frm_yonetici_ogrenci_taksit_odeme()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        public string ay;
        public static string ograd;
        public static string aciklama;
        public static string calisan;
        public static string kurstur;
        public static string odemesekli;
        public static string toplam;
        public static string odemetrh;
        public static string fisid;
        public void listele()
        {
            SqlCommand listele = new SqlCommand("select ogrtc,ograd,ogrsad,kursTur,veli_mail,odemesekli,odencektutar,odemetaksit,ogrid from tbl_ogrenci", baglan.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void kaydetTaksit()
        {
            SqlCommand kaydet = new SqlCommand("insert into tbl_ogr_taksit (ograd,ogrtc,toplam,odemesekli,odemetrh,aciklama) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglan.baglanti());
            kaydet.Parameters.AddWithValue("@p1", txtograd.Text);
            kaydet.Parameters.AddWithValue("@p2", msktc.Text);
            kaydet.Parameters.AddWithValue("@p3", txtTutar.Text);
            kaydet.Parameters.AddWithValue("@p4", cmbodeme.Text);
            kaydet.Parameters.AddWithValue("@p5", dateTimePicker2.Value);
            kaydet.Parameters.AddWithValue("@p6", txtaciklama.Text);
            kaydet.ExecuteNonQuery();
        }
        public void ode()
        {
            if (cmbodeme.SelectedIndex == 1 || cmbodeme.SelectedIndex == 2)
            {
                SqlCommand guncelle = new SqlCommand("update tbl_ogrenci set odemetaksit=@p1 where ogrid=@p2 ", baglan.baglanti());              

                int taksit = Convert.ToInt32(txtay.Text);
                int dusen = taksit - 1;
                guncelle.Parameters.AddWithValue("@p1", dusen);
                guncelle.Parameters.AddWithValue("@p2", lbl_ogrid.Text);
                guncelle.ExecuteNonQuery();
           
                Oku();
                kaydetTaksit();
                listele();
                temizle();
            } 
        }
        void temizle()
        {
            txtmail.Text = "";
            txtaciklama.Text = "";
            txtograd.Text = "";
            txtTutar.Text = "";
            txtay.Text = "";
            cmbodeme.Text = "";
            cmbcalisan.Text = "";
            cmbkursad.Text = "";
        }
       public void Oku()
        {
            SqlCommand oku = new SqlCommand("select odemetaksit from tbl_ogrenci where odemesekli='KREDİ KARTI'", baglan.baglanti());
            SqlDataReader dr = oku.ExecuteReader();
            while (dr.Read())
            {
                ay = dr["odemetaksit"].ToString();
                txtay.Text = ay.ToString();
            }
        }
        private void frm_yonetici_ogrenci_taksit_odeme_Load(object sender, EventArgs e)
        {
            lbl_ogrid.Visible = false;
            listele();
            //ad,soyad
            SqlCommand oku = new SqlCommand("select * from personel", baglan.baglanti());
            oku.CommandType = CommandType.Text;
            SqlDataReader dr;
            dr = oku.ExecuteReader();
            while (dr.Read())
            {
                cmbcalisan.Items.Add(dr["personelAd"] + " " + dr["personelSad"]);
            }
            //kurs adı alma
            SqlCommand oku2 = new SqlCommand("select * from tbl_kurs_fiyatlar", baglan.baglanti());
            oku2.CommandType = CommandType.Text;
            SqlDataReader dr2;
            dr2 = oku2.ExecuteReader();
            while (dr2.Read())
            {
                cmbkursad.Items.Add(dr2["kurs_adi"]);
            }

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            msktc.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtograd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + " " + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbkursad.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtmail.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbodeme.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtTutar.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtay.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            lbl_ogrid.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (cmbodeme.SelectedIndex == 0)
                {
                      SqlCommand al = new SqlCommand("select kurs_fiyat from tbl_kurs_fiyatlar where kurs_adi=@p1", baglan.baglanti());
                      al.Parameters.AddWithValue("@p1", cmbkursad.Text);
                      SqlDataReader oku = al.ExecuteReader();
                      while (oku.Read())
                      {
                          txtTutar.Text = oku[0].ToString();
                      }
                }
            }

        private void btnvazgec_Click(object sender, EventArgs e)
        {
            temizle();   
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fatura Oluşturuluyor", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            aciklama = txtaciklama.Text;
            calisan = cmbcalisan.Text;
            ograd = txtograd.Text;
            odemetrh = dateTimePicker2.Value.ToString();
            kurstur = cmbkursad.Text;
            toplam = txtTutar.Text;
            odemesekli = cmbodeme.Text;
            ode();
            frm_ogrenci_taksit_fatura ogrenci_Taksit_Fatura = new frm_ogrenci_taksit_fatura();
            ogrenci_Taksit_Fatura.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();//mail işlemi
            SmtpClient sc = new SmtpClient();
            sc.Credentials = new System.Net.NetworkCredential("dershaneyonetimsistemi2021@gmail.com", "1A2vXb78t");
            sc.Port = 587;
            sc.Host = " smtp.gmail.com";
            sc.EnableSsl = true;
            mail.From = new MailAddress("dershaneyonetimsistemi2021@gmail.com");
            mail.To.Add(txtmail.Text);
            mail.Subject = "Maaş Maili";
            mail.Body = txtaciklama.Text;
            sc.Send(mail);
            MessageBox.Show("Mail Gönderildi");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
