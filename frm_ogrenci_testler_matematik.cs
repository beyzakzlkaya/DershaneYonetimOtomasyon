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
    public partial class frm_ogrenci_testler_matematik : Form
    {
        public frm_ogrenci_testler_matematik()
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
            SqlCommand ekle = new SqlCommand("insert into tbl_sorular (ogrid,ogradsad,testAdi,dogruSayisi,yanlisSayisi,sure) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglan.baglanti());
            ekle.Parameters.AddWithValue("@p1",no);
            ekle.Parameters.AddWithValue("@p2",FrmOgrenciDYSEkran.ad);
            ekle.Parameters.AddWithValue("@p3",label17.Text);
            ekle.Parameters.AddWithValue("@p4",label9.Text);
            ekle.Parameters.AddWithValue("@p5",label11.Text);
            ekle.Parameters.AddWithValue("@p6",label12.Text);
            ekle.ExecuteNonQuery();
        }
        
       
        private void btnbitir_Click(object sender, EventArgs e)
        {
            
            timer1.Stop();
            MessageBox.Show("Tebrikler Testiniz btimiştir :) Doğru Sayısı=" + dogru + "" + " " + " Yanlış Sayınız=" + yanlis + "");
            noAl();
            veritabaninaEkle();
            
            // yeniden_coz.Text = "BAŞLAT";
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
                richTextBox1.Text = "Kirazın kilogramını K TL’den, muzun kilogramını ise M TL’den satan bir manava gelen bir müşteri, 3 kg kiraz ve 3 kg muz alıp manava 30 TL veriyor. Sonrasında manav ile müşteri arasında aşağıdaki konuşma geçiyor.Manav: “Hiç bozuk param yok. Bunun yerine 1 kg kiraz daha vereyim.Müşteri: “Daha fazla kiraz istemiyorum.Bunun yerine bana 1 kg muz daha ver, ben de sana 3 TL daha vereyim.Buna göre, toplamı kaçtır ?"; btna.Text = "7";
                btnb.Text = "7,5 ";
                btnc.Text = "8 ";
                btnd.Text = "8,5 ";
                btne.Text = "9";
                label14.Text = "9";
            }
            else if (soruno == 2)
            {
                richTextBox1.Text = "1234 x 9998 çarpımının rakamlar toplamı kaçtır?";
                btna.Text = "24";
                btnb.Text = "25";
                btnc.Text = "26";
                btnd.Text = "27";
                btne.Text = "28";
                label14.Text = "26";
            }
            else if (soruno == 3)
            {
                richTextBox1.Text = "3 kız ve 3 erkek öğrenci kızlar yan yana olmak şartıyla düz bir sıra halinde kaç değişik şekilde sıralanabilir ?";
                btna.Text = "360";
                btnb.Text = "288";
                btnc.Text = "144";
                btnd.Text = "480";
                btne.Text = "720";
                label14.Text = "144";
            }
            else if (soruno == 4)
            {
                richTextBox1.Text = "a ve b asal sayılarının toplamı 39 olduğuna göre, kaç farklı (a,b) ifadesi yazılabilir ?";
                btna.Text = "0";
                btnb.Text = "2";
                btnc.Text = "6";
                btnd.Text = "10";
                btne.Text = "19";
                label14.Text = "2";
            }
            else if (soruno == 5)
            {
                richTextBox1.Text = "iki basamaklı rakamları farklı 4 doğal sayının toplamı 327 olduğuna göre bu sayılardan en küçüğü en az kaçtır ?";
                btna.Text = "35";
                btnb.Text = "34";
                btnc.Text = "33";
                btnd.Text = "32";
                btne.Text = "30";
                label14.Text = "34";
            }
            else if (soruno>=5)
            {
                MessageBox.Show("Tebrikler Testiniz btimiştir :) Cevaplarınızı öğrenmek için Bitir Butonuna basınız.");
                timer1.Stop();
            }
        }

        private void btna_Click(object sender, EventArgs e)
        {
           
            if (btna.Text==label14.Text)
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
        private void frm_ogrenci_testler_matematik_Load(object sender, EventArgs e)
        {

            label17.Visible = false;
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btne.Enabled = false;
            label14.Visible = false;
            btnbaslat.Enabled = true;
            richTextBox1.Text = " Matemetik Testine Hazır Mısın ? Cevabın EVET ise Başlayalım O Zaman :) BAŞARILAR :))";
        }
    }
}
