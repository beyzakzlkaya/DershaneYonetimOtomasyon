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
    public partial class frm_ogretmenMail : Form
    {
        public frm_ogretmenMail()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();

        public static string ogretmenmail;
        public static string ogretmenmailsifre;

        private void button1_Click(object sender, EventArgs e)
        {
            ogretmenmail = txtmail.Text;
            ogretmenmailsifre = txtsifre.Text;
            frm_ogretmen_ogr_mailgonder ogretmenOgrenci = new frm_ogretmen_ogr_mailgonder();
            ogretmenOgrenci.Show();

        }

        private void frm_ogretmenMail_Load(object sender, EventArgs e)
        {
            txtmail.Text = OgretmenGirisEkrani.mail;
        }
    }
}
