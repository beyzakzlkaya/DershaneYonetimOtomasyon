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
    public partial class frm_velitoplumail : Form
    {
        public frm_velitoplumail()

        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        void listele()
        {
            SqlCommand listele = new SqlCommand("select ograd,ogrsad,veli_mail,veli_yakinlik from tbl_ogrenci", baglan.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
 
        private void frm_velitoplumail_Load(object sender, EventArgs e)
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
            for (int i = 0; i < lst_Toplu_mail.Items.Count; i++)
            {
                mail.To.Add(lst_Toplu_mail.Items[i].ToString());
            }
            mail.Subject = txtkonu.Text;
            mail.Body = txtmesaj.Text;
            sc.Send(mail);
            MessageBox.Show("Mail Gönderildi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lst_Toplu_mail.Items.Add(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secim = lst_Toplu_mail.SelectedIndex;
            if (secim != -1)
            {
                lst_Toplu_mail.Items.RemoveAt(secim);
            }
            else
            {
                MessageBox.Show("Seçim Yapın!");
            }
        }
    }
}
