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
using System.IO;

namespace dershaneOtomasyon
{
    public partial class FrmOgrenciKayit : Form
    {
        public FrmOgrenciKayit()
        {
            InitializeComponent();
            txtadres.Height = 100;
          
        }

        Baglanti baglan = new Baglanti();
        public string DosyaYolu;
        public static string fiyat;
        public static string sinif;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaogrn = new OpenFileDialog();
            dosyaogrn.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Tüm Dosyalar |*.*";
            dosyaogrn.Title = "Öğrenci Resmi Seç ";
            dosyaogrn.ShowDialog();
            DosyaYolu = dosyaogrn.FileName;
            pictureBox1.ImageLocation = DosyaYolu;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;//pictureboxın değerini boşaltır
        }
        string klasor_hedef = @"C:\Users\beyza\OneDrive\Masaüstü\dershane_gönder\dershane_gönder\dershane_son\dershane_son\bin\ImageProje\";//image klasörünün hedef yolu
        void kaydet()
        {
            SqlCommand ekle = new SqlCommand("insert into tbl_ogrenci (ogrtc,ograd,ogrsad,cinsiyet,dgmTrh,ogrtel,email," + 
                "anneAd,babaAd,annetel,babatel,veli_mail,veli_yakinlik,adres,donem,kayitTrh,sinif,kursTur,baslangicTrh,bitisTrh," + 
                "danisman,odemesekli,odemetaksit,odencektutar,foto,kullaniciAdi,sifre,velikullaniciAdi,velisifre) values " +
                "(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17,@p18,@p19,@p20,@p21,@p22,@p23," + 
                "@p24,@p25,@p26,@p27,@p28,@p29)",baglan.baglanti());

            ekle.Parameters.AddWithValue("@p1", msktc.Text);
            ekle.Parameters.AddWithValue("@p2",txtograd.Text);
            ekle.Parameters.AddWithValue("@p3", txtogrsad.Text);
            ekle.Parameters.AddWithValue("@p4", comboBox1.SelectedItem.ToString());
            ekle.Parameters.AddWithValue("@p5", dtdgmtrh.Value);
            ekle.Parameters.AddWithValue("@p6", msktel.Text);
            ekle.Parameters.AddWithValue("@p7", txtogrmail.Text);
            ekle.Parameters.AddWithValue("@p8", txtannead.Text);
            ekle.Parameters.AddWithValue("@p9", txtbabaad.Text);
            ekle.Parameters.AddWithValue("@p10", mskannetel.Text);
            ekle.Parameters.AddWithValue("@p11", mskbabatel.Text);
            ekle.Parameters.AddWithValue("@p12", txtvelimail.Text);
            ekle.Parameters.AddWithValue("@p13", txtveliyakinlik.Text);
            ekle.Parameters.AddWithValue("@p14", txtadres.Text);
            ekle.Parameters.AddWithValue("@p15", cmbdonem.Text);
            ekle.Parameters.AddWithValue("@p16", dtkayittrh.Value);
            ekle.Parameters.AddWithValue("@p17", cmbsinif.Text);
            ekle.Parameters.AddWithValue("@p18", cmbkurstur.Text);
            ekle.Parameters.AddWithValue("@p19", dtbaslangictrh.Value);
            ekle.Parameters.AddWithValue("@p20", dtbitistrh.Value);
            ekle.Parameters.AddWithValue("@p21", cmbdanisman.Text);
            ekle.Parameters.AddWithValue("@p22", cmbodeme.Text);
            ekle.Parameters.AddWithValue("@p23", frm_ogrenci_kredikarti.aylik);
            ekle.Parameters.AddWithValue("@p24", frm_ogrenci_kredikarti.odenecek);
            //resim ekleme

            FileStream fs = new FileStream(DosyaYolu, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] fotolar = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();
            ekle.Parameters.Add("@p25", SqlDbType.Image, fotolar.Length).Value = fotolar;//veritabanı türünü ifade ettikten sonra dizi uzunluğunu aldık değer olduğunu belirtip fotoya atatık
            File.Copy(DosyaYolu, klasor_hedef + Path.GetFileName(DosyaYolu));//resmi klasöre atma

            ekle.Parameters.AddWithValue("@p26", txtKullaniciAdi.Text);
            ekle.Parameters.AddWithValue("@p27", txtsifre.Text);
            ekle.Parameters.AddWithValue("@p28", txtvelikullanici.Text);
            ekle.Parameters.AddWithValue("@p29", txtvelisifre.Text);

            ekle.ExecuteNonQuery(); 
            MessageBox.Show("Kayıt Gerçekleşti");
        }
        private void temizle()
        {
            txtadres.Text = " ";
            txtannead.Text = " ";
            txtbabaad.Text = " ";
            txtfiyat.Text = " ";
            txtograd.Text = " ";
            txtogrmail.Text= " ";
            txtogrsad.Text = " ";
            txtvelimail.Text = " ";
            txtveliyakinlik.Text = " ";
            cmbdanisman.Text = " ";
            cmbdonem.Text = " ";
            cmbkurstur.Text = " ";
            cmbodeme.Text = " ";
            cmbsinif.Text = " ";
            msktc.Text = " ";
            mskannetel.Text = " ";
            mskbabatel.Text = " ";
            msktel.Text = " ";
            pictureBox1.Image = null;
            comboBox1.Text = " ";
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            kaydet();
        }
        private void cmbkurstur_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand al = new SqlCommand("select kurs_fiyat from tbl_kurs_fiyatlar where kurs_adi=@p1", baglan.baglanti());
            al.Parameters.AddWithValue("@p1", cmbkurstur.Text);
            SqlDataReader oku = al.ExecuteReader();
            while (oku.Read())
            {
                txtfiyat.Text = oku[0].ToString();
            }
            fiyat = txtfiyat.Text;
        }
        private void FrmOgrenciKayit_Load(object sender, EventArgs e)
        {
            lblkaydeden.Text = YoneticiGirisEkran.kullanici;
            SqlCommand id = new SqlCommand("select * from tbl_ogrenci", baglan.baglanti());
            id.CommandType = CommandType.Text;
            SqlDataReader oku;
            oku = id.ExecuteReader();
            while (oku.Read())
            {
                lblogrno.Text = (oku["ogrid"]).ToString();
            }
            SqlCommand ogrtmnAl = new SqlCommand("select * from tbl_ogretmen", baglan.baglanti());
            ogrtmnAl.CommandType = CommandType.Text;
            SqlDataReader oku1;
            oku1 = ogrtmnAl.ExecuteReader();
            while (oku1.Read())
            {
                cmbdanisman.Items.Add(oku1["ogretmen_ad"].ToString()+" "+ oku1["ogretmen_sad"].ToString());
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
       
        private void cmbodeme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbodeme.SelectedIndex == 0)
            {
                frm_ogrenci_kredikarti kredi_karti = new frm_ogrenci_kredikarti();
                kredi_karti.Show();
            }
            if (cmbodeme.SelectedIndex == 1)
            {
                frm_ogrenci_kredikarti kredi_karti = new frm_ogrenci_kredikarti();
                kredi_karti.Show();
            }
            if (cmbodeme.SelectedIndex == 2)
            {
                frm_ogrenci_kredikarti kredi_karti = new frm_ogrenci_kredikarti();
                kredi_karti.Show();
            }

        }
    }
}
