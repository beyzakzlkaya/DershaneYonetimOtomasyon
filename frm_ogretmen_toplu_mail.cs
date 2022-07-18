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
    public partial class frm_ogretmen_toplu_mail : Form
    {
        public frm_ogretmen_toplu_mail()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        public string DosyaYolu;
        void listele()
        {
            SqlCommand listele = new SqlCommand("select ogretmen_ad,ogretmen_sad,ogretmen_mail from tbl_ogretmen", baglan.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void frm_ogretmen_toplu_mail_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void btnGonder_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();//mail işlemi
            SmtpClient sc = new SmtpClient();
            sc.Credentials = new System.Net.NetworkCredential("dershaneyonetimsistemi2021@gmail.com", "1A2vXb78t");
            sc.Port = 587;
            sc.Host = " smtp.gmail.com";
            sc.EnableSsl = true;
            mail.From = new MailAddress("dershaneyonetimsistemi2021@gmail.com");
            for (int i = 0; i < lst_ogretmenToplu_mail.Items.Count; i++)
            {
                mail.To.Add(lst_ogretmenToplu_mail.Items[i].ToString());
            }
            mail.Subject = txtkonu.Text;
            mail.Body = txtmesaj.Text;
            mail.Attachments.Add(new Attachment(DosyaYolu));
            sc.Send(mail);
            MessageBox.Show("Mail Gönderildi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secim = lst_ogretmenToplu_mail.SelectedIndex;
            if (secim != -1)
            {
                lst_ogretmenToplu_mail.Items.RemoveAt(secim);
            }
            else
            {
                MessageBox.Show("Seçim Yapın!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lst_ogretmenToplu_mail.Items.Add(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Title = "Dershane Yönetim Sistemi";
            dosya.ShowDialog();
            DosyaYolu = dosya.FileName;
            label5.Text = "Dosya Eklendi";
        }
    }
}
