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
    public partial class frm_ogrenci_testler_bıyolojı : Form
    {
        public frm_ogrenci_testler_bıyolojı()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        public static int soruno = 0, dogru = 0, yanlis = 0;
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

        private void frm_ogrenci_testler_bıyolojı_Load(object sender, EventArgs e)
        {
            label16.Visible = false;
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btne.Enabled = false;
            label14.Visible = false;
            btnbaslat.Enabled = true;
            richTextBox1.Text = " Biyoloji Testine Hazır Mısın ? Cevabın EVET ise Başlayalım O Zaman :) BAŞARILAR :))";
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
                richTextBox1.Text = "Bitkilerde aşağıdakilerden hangisi kara yaşamına uyum sürecinde oluşan yapılardan biri değildir ?";
                btna.Text = "Spor";
                btnb.Text = "Kloroplast";
                btnc.Text = "Tohum";
                btnd.Text = "Gözenek";
                btne.Text = "Kütikula";
                label14.Text = "Kloroplast";
            }
            else if (soruno == 2)
            {
                richTextBox1.Text = "Bir enzimin yapısında, aşağıdakilerden hangisi kesinlikle bulunmaz?";
                btna.Text = "Amino asit";
                btnb.Text = "Mineral";
                btnc.Text = "Pepit bağı";
                btnd.Text = "Yağ asidi";
                btne.Text = "Vitamin";
                label14.Text = "Yağ asidi";
            }
            else if (soruno == 3)
            {
                richTextBox1.Text = "Enzimlerin substrata karşı özgül olmasını sağlayan molekül aşağıdakilerden hangisidir ?";
                btna.Text = "Karbonhidrat";
                btnb.Text = "Protein";
                btnc.Text = "Yağ";
                btnd.Text = "Mineral";
                btne.Text = "Vitamin";
                label14.Text = "Protein";
            }
            else if (soruno == 4)
            {
                richTextBox1.Text = "Bir hayvan hücresinde, enzim sentezi sonucunda aşağıdaki moleküllerden hangisinin miktarı artar?";
                btna.Text = "ATP";
                btnb.Text = "tRNA";
                btnc.Text = "Amino asit";
                btnd.Text = "Su";
                btne.Text = "mRNA";
                label14.Text = "Su";
            }
            else if (soruno == 5)
            {
                richTextBox1.Text = "Kan plazmasında anti-B antikoru bulunan bir anne ile anti-A antikoru bulunan bir babanın, aşağıdakilerin hangisinde verilen kan grubunda çocukları olamaz?";
                btna.Text = "A0";
                btnb.Text = "AB";
                btnc.Text = "B0";
                btnd.Text = "00";
                btne.Text = "BB";
                label14.Text = "BB";
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

        public static int zaman = 60;
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
