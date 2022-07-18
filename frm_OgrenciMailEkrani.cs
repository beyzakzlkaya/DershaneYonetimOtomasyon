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
    public partial class frm_OgrenciMailEkrani : Form
    {
        public frm_OgrenciMailEkrani()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();

        public static string velimail;
        public static string velimailsifre;

        private void button1_Click(object sender, EventArgs e)
        {
            velimail = txtmail.Text;
            velimailsifre = txtsifre.Text;
            frm_OgrenciOgretmenMail ogretmenMail = new frm_OgrenciOgretmenMail();
            ogretmenMail.Show();
        }

        private void frm_OgrenciMailEkrani_Load(object sender, EventArgs e)
        {
            txtmail.Text = ogrenciGirisEkrani.mail;
        }
    }
}
