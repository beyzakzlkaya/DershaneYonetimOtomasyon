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
    public partial class frm_ogrenci_testler_tarıh : Form
    {
        public frm_ogrenci_testler_tarıh()
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
                richTextBox1.Text = "Domuzlar Körfezi çıkarması aşağıdakilerden hangisine yapılmıştır ?";
                btna.Text = "ABD";
                btnb.Text = "İran";
                btnc.Text = "Küba";
                btnd.Text = "Nikaragua";
                btne.Text = "Fransa";
                label14.Text = "Küba";
            }
            else if (soruno == 2)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi Hindistan ile Pakistan arasında bölünmüş olarak günümüzde varlığını sürdüren bir sorundur ?";
                btna.Text = "Tibet";
                btnb.Text = "Vietnam";
                btnc.Text = "Karaçi";
                btnd.Text = "Keşmir";
                btne.Text = "Bangladeş";
                label14.Text = "Keşmir";
            }
            else if (soruno == 3)
            {
                richTextBox1.Text = "Atatürk, 'Bilelim ki, ulusal benliğini bilmeyen milletler başka milletlere yem olurlar.' demiştir.Atatürk bu sözüyle aşağıdaki ilkelerden öncelikle hangisinin önemini vurgulamaktadır ? ";
                btna.Text = "Laiklik";
                btnb.Text = "Devletçilik";
                btnc.Text = "Milliyetçilik";
                btnd.Text = "İnkılapçılık";
                btne.Text = "Cumhuriyetçilik";
                label14.Text = "Milliyetçilik";
            }
            else if (soruno == 4)
            {
                richTextBox1.Text = "Atatürk bir konuşmasında, “Vatan kesinlikle esenliğe kavuşacak, millet kesinlikle mutlu olacaktır.” ifadelerini kullanmıştır.Bu sözler Atatürk’ün hangi yönünü öne çıkarmaktadır ? ";
                btna.Text = "Fedakarlık";
                btnb.Text = "Hukuka Saygı";
                btnc.Text = "Barışseverlik";
                btnd.Text = "Ümitsizliğe yer vermeme";
                btne.Text = "İnsan ve insanlık sevgisi";
                label14.Text = "Ümitsizliğe yer vermeme";
            }
            else if (soruno == 5)
            {
                richTextBox1.Text = "Osmanlı Devleti, Rusya ile Avrupa arasında yer alan Lehistan’ı kontrol edebilmek için Rusya ile askeri mücadelelere girişmiştir. Osmanlı Devleti’nin bu politikasının, Lehistan’ın hangi özelliği ile ilgili olduğu savunulabilir ? ";
                btna.Text = "Mezhep Farklılığı";
                btnb.Text = "Kültürel yapı";
                btnc.Text = "Ticari ilişki";
                btnd.Text = "Dini yapı";
                btne.Text = "Coğrafi konum";
                label14.Text = "Coğrafi konum";
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

        private void frm_ogrenci_testler_tarıh_Load(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btne.Enabled = false;
            label14.Visible = false;
            btnbaslat.Enabled = true;
            richTextBox1.Text = " Tarih Testine Hazır Mısın ? Cevabın EVET ise Başlayalım O Zaman :) BAŞARILAR :))";
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
