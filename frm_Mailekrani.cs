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
    public partial class frm_Mailekrani : Form
    {
        
       
        public frm_Mailekrani()
        {
            InitializeComponent();
            
        }
        Baglanti baglan = new Baglanti();

        public static string velimail;
        public static string velimailsifre;

        public void button1_Click(object sender, EventArgs e)
        {
           
            velimail = txtmail.Text;
            velimailsifre = txtsifre.Text;
            frm_VeliogretmenMail ogretmenmailgonder = new frm_VeliogretmenMail();
            ogretmenmailgonder.Show();

        }

        private void frm_Mailekrani_Load(object sender, EventArgs e)
        {
            txtmail.Text = veliGirisEkrani.mail;
        }
    }
}
