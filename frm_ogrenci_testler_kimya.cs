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
    public partial class frm_ogrenci_testler_kimya : Form
    {
        public frm_ogrenci_testler_kimya()
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
            label16.Visible = false;
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
                richTextBox1.Text = "Etanol,aseton,aminoasit,glikoz gibi karbon bileşiklerinin yapısı ile bu bileşiklerin etkileşimlerini ve sanayideki kullanım alanlarını inceleyen bilim dalı aşağıdakilerden hangisidir ?"; 
                btna.Text = "İnorganik Kimya";
                btnb.Text = "Analitik Kimya";
                btnc.Text = "Biyokimya";
                btnd.Text = "Adli Kimya";
                btne.Text = "Organik Kimya";
                label14.Text = "Organik Kimya";
            }
            else if (soruno == 2)
            {
                richTextBox1.Text = "Vücudumuzdaki bir hastalığın teşhisi veya görülmekte olan bir tedavinin takibi için yapılan kan tahlilleri aşağıda verilen bilim dallarından hangisinin uğraş alanıdır ?";
                btna.Text = "Organik Kimya";
                btnb.Text = "Biyokimya";
                btnc.Text = "Fizikokimya";
                btnd.Text = "İnorganik Kimya";
                btne.Text = "Analitik Kimya";
                label14.Text = "Biyokimya";
            }
            else if (soruno == 3)
            {
                richTextBox1.Text = "Aşağıdaki maddelerden hangisinin tanecikleri arasında sadece London kuvveti bulunur ?";
                btna.Text = "H2O(s)";
                btnb.Text = "Cu(k)";
                btnc.Text = "N2(s)";
                btnd.Text = "NH3(s)";
                btne.Text = "Elmas";
                label14.Text = "N2(s)";
            }
            else if (soruno == 4)
            {
                richTextBox1.Text = "Aşağıda verilen elementlerden hangisi ametal değildir ?";
                btna.Text = "Cıva(Hg)";
                btnb.Text = "İyot(I)";
                btnc.Text = "Fosfor(P)";
                btnd.Text = "Brom(Br)";
                btne.Text = "Klor(Cl)";
                label14.Text = "Cıva(Hg)";
            }
            else if (soruno == 5)
            {
                richTextBox1.Text = "Günümüzde kullanılan periyodik sistemde elementler, aşağıdaki niceliklerden hangisine göre sıralanmıştır ?";
                btna.Text = "Nötron Sayısı";
                btnb.Text = "Atom Ağırlığı";
                btnc.Text = "Atom Numarası";
                btnd.Text = "Atom Hacmi";
                btne.Text = "İzotop Sayısı";
                label14.Text = "Atom Numarası";
            }
            else if (soruno >= 5)
            {
                MessageBox.Show("Tebrikler Testiniz btimiştir :) Cevaplarınızı öğrenmek için Bitir Butonuna basınız.");
                timer1.Stop();
            }
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

        private void btnbitir_Click(object sender, EventArgs e)
        {
            
            timer1.Stop();
            MessageBox.Show("Tebrikler Testiniz btimiştir :) Doğru Sayısı=" + dogru + "" + " " + " Yanlış Sayınız=" + yanlis + "");
            noAl();
            veritabaninaEkle();
        }

        private void frm_ogrenci_testler_kimya_Load(object sender, EventArgs e)
        {
            label16.Visible = false;
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btne.Enabled = false;
            label14.Visible = false;
            btnbaslat.Enabled = true;
            richTextBox1.Text = " Kimya Testine Hazır Mısın ? Cevabın EVET ise Başlayalım O Zaman :) BAŞARILAR :))";
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
