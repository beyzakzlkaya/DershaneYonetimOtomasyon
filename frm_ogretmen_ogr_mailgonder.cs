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
    public partial class frm_ogretmen_ogr_mailgonder : Form
    {
        public frm_ogretmen_ogr_mailgonder()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        void listele()
        {
            SqlCommand listele = new SqlCommand("select  ograd,ogrsad,email from tbl_ogrenci", baglan.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void frm_ogretmen_ogr_mailgonder_Load(object sender, EventArgs e)
        {
            
            listele();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();//mail işlemi
            SmtpClient sc = new SmtpClient();
            sc.Credentials = new System.Net.NetworkCredential(frm_ogretmenMail.ogretmenmail, frm_ogretmenMail.ogretmenmailsifre);
            sc.Port = 587;
            sc.Host = " smtp.gmail.com";
            sc.EnableSsl = true;
            mail.From = new MailAddress(frm_ogretmenMail.ogretmenmail);
            for (int i = 0; i < lst_ogrenci.Items.Count; i++)
            {
                mail.To.Add(lst_ogrenci.Items[i].ToString());
            }
            mail.Subject = txtkonu.Text;
            mail.Body = txtmesaj.Text;
            sc.Send(mail);
            MessageBox.Show("Mail Gönderildi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secim = lst_ogrenci.SelectedIndex;
            if (secim != -1)
            {
                lst_ogrenci.Items.RemoveAt(secim);
            }
            else
            {
                MessageBox.Show("Seçim Yapın!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lst_ogrenci.Items.Add(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
        }
    }
}
