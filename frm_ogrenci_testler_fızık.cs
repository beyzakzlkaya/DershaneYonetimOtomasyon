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
    public partial class frm_ogrenci_testler_fızık : Form
    {
        public frm_ogrenci_testler_fızık()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        public static int soruno = 0, dogru = 0, yanlis = 0;
        public static int zaman = 60;
        public string no;
        void noAl()
        {
            SqlCommand oku = new SqlCommand("select * from tbl_ogrenci where kullaniciAdi='" + ogrenciGirisEkrani.kullanici + "' ", baglan.baglanti());
            SqlDataReader dr = oku.ExecuteReader();
            while (dr.Read())
            {
                no = (dr["ogrid"].ToString());
            }
        }
        void veritabaninaEkle()
        {
            SqlCommand ekle = new SqlCommand("insert into tbl_sorular (ogrid,ogradsad,testAdi,dogruSayisi,yanlisSayisi,sure) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglan.baglanti());
            ekle.Parameters.AddWithValue("@p1", no);
            ekle.Parameters.AddWithValue("@p2", FrmOgrenciDYSEkran.ad);
            ekle.Parameters.AddWithValue("@p3", label16.Text);
            ekle.Parameters.AddWithValue("@p4", label9.Text);
            ekle.Parameters.AddWithValue("@p5", label11.Text);
            ekle.Parameters.AddWithValue("@p6", label12.Text);
            ekle.ExecuteNonQuery();
        }

        private void btnbaslat_Click(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            btnbaslat.Text = "İLERİ";
            btna.Enabled = true;
            btnb.Enabled = true;
            btnc.Enabled = true;
            btnd.Enabled = true;
            btne.Enabled = true;
            label14.Visible = false;

            soruno++;
            label7.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi fiziğin alt alanlarından değildir ?"; 
                btna.Text = "Termodinamik";
                btnb.Text = "Astronomi";
                btnc.Text = "Elektromanyetizma";
                btnd.Text = "Mekanik";
                btne.Text = "Optik";
                label14.Text = "Astronomi";
            }
            else if (soruno == 2)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi maddeler için ayırtedici özelliklerden değildir?";
                btna.Text = "Özkütle";
                btnb.Text = "Öz Isı";
                btnc.Text = "Isı Sığası";
                btnd.Text = "Genleşme Kat.";
                btne.Text = "Özdirenç";
                label14.Text = "Isı Sığası";
            }
            else if (soruno == 3)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi enerji birimi değildir?";
                btna.Text = "kg.m2/s2";
                btnb.Text = "Newton.metre";
                btnc.Text = "kwh";
                btnd.Text = "coulomb.volt";
                btne.Text = "N/t";
                label14.Text = "N/t";
            }
            else if (soruno == 4)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi yenilenebilir enerji kaynağı değildir?";
                btna.Text = "Rüzgar E.";
                btnb.Text = "Nükleer E.";
                btnc.Text = "Solar E.";
                btnd.Text = "Jeotarmal E.";
                btne.Text = "Hidrolik E.";
                label14.Text = "Nükleer E.";
            }
            else if (soruno == 5)
            {
                richTextBox1.Text = "Aşağıdaki atom ya da iyonlardan hangisine Bohr atom modeli uygulanamaz? (ZH=1; ZHe=2; ZLi=3; ZBe=4)";
                btna.Text = "1H";
                btnb.Text = "Be+3";
                btnc.Text = "Li+2";
                btnd.Text = "He+";
                btne.Text = "Li+";
                label14.Text = "He+";
            }
            else if (soruno >= 5)
            {
                MessageBox.Show("Tebrikler Testiniz btimiştir :) Cevaplarınızı öğrenmek için Bitir Butonuna basınız.");
                timer1.Stop();
            }
        }

        private void btnbitir_Click(object sender, EventArgs e)
        {
            
            timer1.Stop();
            MessageBox.Show("Tebrikler Testiniz btimiştir :) Doğru Sayısı=" + dogru + "" + " " + " Yanlış Sayınız=" + yanlis + "");
            noAl();
            veritabaninaEkle();
        }

        private void btna_Click(object sender, EventArgs e)
        {

            if (btna.Text == label14.Text)
            {
                dogru++;
                label9.Text = dogru.ToString();
                label14.Visible = true;
            }
            else
            {
                yanlis++;
                label11.Text = yanlis.ToString();
                label14.Visible = true;
            }
        }

        private void btnb_Click(object sender, EventArgs e)
        {

            if (btnb.Text == label14.Text)
            {
                dogru++;
                label9.Text = dogru.ToString();
                label14.Visible = true;
            }
            else
            {
                yanlis++;
                label11.Text = yanlis.ToString();
                label14.Visible = true;
            }
        }

        private void btnc_Click(object sender, EventArgs e)
        {

            if (btnc.Text == label14.Text)
            {
                dogru++;
                label9.Text = dogru.ToString();
                label14.Visible = true;
            }
            else
            {
                yanlis++;
                label11.Text = yanlis.ToString();
                label14.Visible = true;
            }
        }

        private void btnd_Click(object sender, EventArgs e)
        {

            if (btnd.Text == label14.Text)
            {
                dogru++;
                label9.Text = dogru.ToString();
                label14.Visible = true;
            }
            else
            {
                yanlis++;
                label11.Text = yanlis.ToString();
                label14.Visible = true;
            }
        }

        private void btne_Click(object sender, EventArgs e)
        {

            if (btne.Text == label14.Text)
            {
                dogru++;
                label9.Text = dogru.ToString();
                label14.Visible = true;
            }
            else
            {
                yanlis++;
                label11.Text = yanlis.ToString();
                label14.Visible = true;
            }
        }     

        private void frm_ogrenci_testler_fızık_Load(object sender, EventArgs e)
        {

            label16.Visible = false;
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btne.Enabled = false;
            label14.Visible = false;
            btnbaslat.Enabled = true;
            richTextBox1.Text = " Fizik Testine Hazır Mısın ? Cevabın EVET ise Başlayalım O Zaman :) BAŞARILAR :))";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman--;
            Convert.ToInt32(label12.Text);
            label12.Text = zaman.ToString();
            if (zaman == 0)
            {
                label12.Text = "Süre Doldu";
                timer1.Stop();
            }
        }
    }
}
