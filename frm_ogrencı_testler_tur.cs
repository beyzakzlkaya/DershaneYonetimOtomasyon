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
    public partial class frm_ogrencı_testler_tur : Form
    {
        public frm_ogrencı_testler_tur()
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
                richTextBox1.Text = "İşledikleri konu bakımından benzer olan şiir türleri aşağıdakilerden hangisinde birlikte verilmiştir?";
                btna.Text = "Epik-Lirik-Satirik";
                btnb.Text = "Taşlanma-Hicviye-Satirik";
                btnc.Text = "Koşma-Lirik-Dramatik";
                btnd.Text = "Didaktik-Epik-Lirik";
                btne.Text = "Lirik-Dramatik-Trajedi";
                label14.Text = "Taşlanma-Hicviye-Satirik";
            }
            else if (soruno == 2)
            {
                richTextBox1.Text = "'Kötü'sözcüğü aşağıdakilerin hangisinde ötekilerden farklı bir görevde kullanılmıştır ?";
                btna.Text = "Kötü komşu insanı mal sahibi yapar.";
                btnb.Text = "Kötü haber tez duyulur.";
                btnc.Text = "Kötü söz söyleme eşine ağı katar aşına.";
                btnd.Text = "Kötü gözle bakmamak gerekir kimseye.";
                btne.Text = "Kötü günümde yanımda olmadı dostum dediğim";
                label14.Text = "Kötü söz söyleme eşine ağı katar aşına.";
            }
            else if (soruno == 3)
            {
                richTextBox1.Text = "Ünlü sanatçı, yaşadığı deneyimlerini okurlarıyla paylaştığı son yapıtını oldukça samimi, içten bir söyleyişle kaleme almış. Bu cümlede gereksiz yere kullanılmış sözcükler aşağıdakilerin hangisinde bir arada verilmiştir ? ";
                btna.Text = "yaşadığı-deneyimlerini";
                btnb.Text = "okurlarıyla-oldukça";
                btnc.Text = "yaşadığı-samimi";
                btnd.Text = "okurlarıyla-içten";
                btne.Text = "oldukça-söyleyişle";
                label14.Text = "yaşadığı-samimi";
            }
            else if (soruno == 4)
            {
                richTextBox1.Text = "Bulut bulut düşünceler içinde vatanım Her şey, her şey seni sevmekte Elbet üstünde yaşamak kadar güzeldir Uğrunda ölmek de.Bu dizelerde aşağıdakilerden hangisi yoktur ? ";
                btna.Text = "Ünlem";
                btnb.Text = "Zamir";
                btnc.Text = "Sıfat";
                btnd.Text = "Bağlaç";
                btne.Text = "Edat";
                label14.Text = "Ünlem";
            }
            else if (soruno == 5)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi yapısı bakımından basit cümledir? ";
                btna.Text = "Koltuğa minder koyunca rahat oturabildi.";
                btnb.Text = "Havalar iyice soğumadan yayladan ayrılalım.";
                btnc.Text = "Sınav başvurularında dikkatli olun,dedi.";
                btnd.Text = "Her ayrıntıyı elindeki bir kağıda not aldı.";
                btne.Text = "Çok yorgundu,eve gelince hemen uyudu.";
                label14.Text = "Her ayrıntıyı elindeki bir kağıda not aldı.";
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

        private void frm_ogrencı_testler_tur_Load(object sender, EventArgs e)
        {
            label16.Visible = false;
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btne.Enabled = false;
            label14.Visible = false;
            btnbaslat.Enabled = true;
            richTextBox1.Text = " Türkçe Testine Hazır Mısın ? Cevabın EVET ise Başlayalım O Zaman :) BAŞARILAR :))";
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
