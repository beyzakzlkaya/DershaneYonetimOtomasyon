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
    public partial class frm_ogretmenVeliMail : Form
    {
        public frm_ogretmenVeliMail()
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
                frm_ogretmenveliMailgonder velimailgonder = new frm_ogretmenveliMailgonder();
                velimailgonder.Show();
        }

        private void frm_ogretmenVeliMail_Load(object sender, EventArgs e)
        {
            txtmail.Text = OgretmenGirisEkrani.mail;
        }
    }
}
