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
    public partial class frmOgretmenMaas : Form
    {
        public frmOgretmenMaas()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        public static string aciklama;
        public static string calisan;
        public static string toplamtutar;
        public static string odemetrh;
        public static string iban;
        public static string Tc;
        public static string fisidno;
        public void ode()
        {
            SqlCommand kaydet= new SqlCommand("insert into tbl_ogretmen_maas (ogretmenTc,ogretmenad,toplam,odemetrh) values (@p1,@p2,@p3,@p4)", baglan.baglanti());
            kaydet.Parameters.AddWithValue("@p1", txttc.Text);
            kaydet.Parameters.AddWithValue("@p2", txtcalisan.Text);
            kaydet.Parameters.AddWithValue("@p3", txtTutar.Text);
            kaydet.Parameters.AddWithValue("@p4", dateTimePicker2.Value);
            kaydet.ExecuteNonQuery();
        }
        void listele() 
        {
            SqlCommand listele = new SqlCommand("select * from tbl_ogretmen", baglan.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void Gizle()
        {         
            dataGridView1.Columns["cinsiyet"].Visible = false;
            dataGridView1.Columns["durum"].Visible = false;
            dataGridView1.Columns["brans"].Visible = false;
            dataGridView1.Columns["verdigi_ders"].Visible = false;
            dataGridView1.Columns["ogrenimDurum"].Visible = false;
            dataGridView1.Columns["okul"].Visible = false;
            dataGridView1.Columns["ogretmen_tel"].Visible = false;
            dataGridView1.Columns["dgmTarih"].Visible = false;
            dataGridView1.Columns["ogretmen_adres"].Visible = false;
            dataGridView1.Columns["acıklama"].Visible = false;
            dataGridView1.Columns["idno"].Visible = false;
            dataGridView1.Columns["foto"].Visible = false;
            dataGridView1.Columns["kulllaniciAdi"].Visible = false;
            dataGridView1.Columns["sifre"].Visible = false;

        }
        void temizle()
        {
            txtmail.Text = " ";
            txtiban.Text = " ";
            txtaciklama.Text = " ";
            txtcalisan.Text = " ";
            txtTutar.Text = " ";
            txttc.Text = " ";
        }
        private void frmOgretmenMaas_Load(object sender, EventArgs e)
        {
            listele();
            Gizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            ode();
            MessageBox.Show("Fatura Oluşturuluyor", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmOgretmenMaas.ActiveForm.Hide();
            aciklama = txtaciklama.Text;
            calisan = txtcalisan.Text;
            toplamtutar = txtTutar.Text;
            odemetrh = dateTimePicker2.Value.ToString();
            iban = txtiban.Text;
            Tc = txttc.Text;
            frm_ogretmen_maas_fatura ogretmen_fatura=new frm_ogretmen_maas_fatura();
            ogretmen_fatura.Show();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txttc.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtcalisan.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + " " + dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtiban.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            txtmail.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
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

        private void btnvazgec_Click(object sender, EventArgs e)
        {
            temizle();
        }

       
    }
}
