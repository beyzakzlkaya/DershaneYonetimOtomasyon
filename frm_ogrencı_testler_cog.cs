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
    public partial class frm_ogrencı_testler_cog : Form
    {
        public frm_ogrencı_testler_cog()
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
                richTextBox1.Text = "Gerçek sıcaklık ile indirgenmiş sıcaklık arasındaki fark yükselti ile doğru orantılıdır. Buna göre, aşağıda verilen kentlerden hangisinde gerçek sıcaklık ile indirgenmiş sıcaklık arasındaki fark daha azdır?";
                btna.Text = "İzmir";
                btnb.Text = "Uşak";
                btnc.Text = "Erzurum";
                btnd.Text = "Konya";
                btne.Text = "Malatya";
                label14.Text = "İzmir";
            }
            else if (soruno == 2)
            {
                richTextBox1.Text = "1800 m yüksekliğindeki bir yerde hava sıcaklığı 10° C olarak ölçülmüştür.Aynı anda diğer şartlar eşitse deniz seviyesinde hava sıcaklığı kaç °C dir?";
                btna.Text = "-3";
                btnb.Text = "0";
                btnc.Text = "9";
                btnd.Text = "1";
                btne.Text = "19";
                label14.Text = "19";
            }
            else if (soruno == 3)
            {
                richTextBox1.Text = "Amerika kıtasının aynı enlem üzerindeki doğu ve batı kıyıları arasında 10°C lik sıcaklık farkı ölçülmüştür. Bu farklılığın temel nedeni aşağıdakilerden hangisidir?";
                btna.Text = "Karasallık";
                btnb.Text = "Yükselti";
                btnc.Text = "Denizellik";
                btnd.Text = "Okyanus Kalıntısı";
                btne.Text = "Ekvatora uzaklık";
                label14.Text = "Okyanus Kalıntısı";
            }
            else if (soruno == 4)
            {
                richTextBox1.Text = "Akdeniz Bölgesi'nde dağların güney yamaçlarındaki sebzeler kuzey yamaçlarından daha önce olgunlaşır. Bu durumun yaşanmasında aşağıdakilerden hangisinin etkili olduğu söylenebilir?";
                btna.Text = "Bakı";
                btnb.Text = "Eğim";
                btnc.Text = "Yükselti";
                btnd.Text = "Eksen eğikliği";
                btne.Text = "Eksen Hareketi";
                label14.Text = "Bakı";
            }
            else if (soruno == 5)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi bir bölgedeki kadın-erkek nüfus dengesini daha az etkiler?";
                btna.Text = "Savaşlar";
                btnb.Text = "Göç Vermesi";
                btnc.Text = "Askeri Bölge";
                btnd.Text = "Doğumlar";
                btne.Text = "Göç olması";
                label14.Text = "Doğumlar";
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

        private void frm_ogrencı_testler_cog_Load(object sender, EventArgs e)
        {
            label16.Visible = false;
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btne.Enabled = false;
            label14.Visible = false;
            btnbaslat.Enabled = true;
            richTextBox1.Text = " Coğrafya Testine Hazır Mısın ? Cevabın EVET ise Başlayalım O Zaman :) BAŞARILAR :))";
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
