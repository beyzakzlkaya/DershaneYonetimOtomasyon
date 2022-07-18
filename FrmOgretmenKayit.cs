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
    public partial class FrmOgretmenKayit : Form
    {
        public FrmOgretmenKayit()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        public string DosyaYolu;
        string klasor_hedef = @"C:\Users\beyza\OneDrive\Masaüstü\dershane_gönder\dershane_gönder\dershane_son\dershane_son\bin\ImageProje\";
        void temizle()
        {
            msktc.Text = " ";
            txtad.Text = " ";
            txtsad.Text = " ";
            cmbcinsiyet.Text = " ";
            cmbdurum.Text = " ";
            cmbBrans.Text = " ";
            cmbders1.Text = " ";
            cmbsinif.Text = " ";
            cmbogrenimDurum.Text = " ";
            cmbokul.Text= " ";
            txtiban.Text = " ";
            msktel.Text = " ";
            txtmail.Text = " ";
            txtadres.Text = " ";
            txtaciklama.Text = " ";
            txtKullaniciAdi.Text = " ";
            txtsifre.Text = " ";
;        }
        void ekle() 
        {
            SqlCommand ekle = new SqlCommand("insert into tbl_ogretmen (tcno,ogretmen_ad,ogretmen_sad,cinsiyet,durum,brans,verdigi_ders,sinif,ogrenimDurum,okul,ibanNo,ogretmen_tel,ogretmen_mail,dgmTarih,ogretmen_adres,acıklama,kulllaniciAdi,sifre,foto) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17,@p18,@p19)", baglan.baglanti());
            ekle.Parameters.AddWithValue("@p1",msktc.Text);
            ekle.Parameters.AddWithValue("@p2", txtad.Text);
            ekle.Parameters.AddWithValue("@p3", txtsad.Text);
            ekle.Parameters.AddWithValue("@p4", cmbcinsiyet.Text);
            ekle.Parameters.AddWithValue("@p5", cmbdurum.Text);
            ekle.Parameters.AddWithValue("@p6", cmbBrans.Text);
            ekle.Parameters.AddWithValue("@p7", cmbders1.Text);
            ekle.Parameters.AddWithValue("@p8", cmbsinif.Text);
            ekle.Parameters.AddWithValue("@p9", cmbogrenimDurum.Text);
            ekle.Parameters.AddWithValue("@p10", cmbokul.Text);
            ekle.Parameters.AddWithValue("@p11", txtiban.Text);
            ekle.Parameters.AddWithValue("@p12", msktel.Text);
            ekle.Parameters.AddWithValue("@p13", txtmail.Text);
            ekle.Parameters.AddWithValue("@p14", dtDgmtarih.Value);
            ekle.Parameters.AddWithValue("@p15", txtadres.Text);
            ekle.Parameters.AddWithValue("@p16", txtaciklama.Text);
            ekle.Parameters.AddWithValue("@p17", txtKullaniciAdi.Text);
            ekle.Parameters.AddWithValue("@p18", txtsifre.Text);

            FileStream fs = new FileStream(DosyaYolu, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] fotolar = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();
            ekle.Parameters.Add("@p19", SqlDbType.Image, fotolar.Length).Value = fotolar;//veritabanı türünü ifade ettikten sonra dizi uzunluğunu aldık değer olduğunu belirtip fotoya atatık
            File.Copy(DosyaYolu, klasor_hedef + Path.GetFileName(DosyaYolu));//resmi klasöre atma

            ekle.ExecuteNonQuery();
            MessageBox.Show("Kayıt İşlemi Gerçekleşti");
            temizle();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaogrtmn = new OpenFileDialog();
            dosyaogrtmn.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Tüm Dosyalar |*.*";
            dosyaogrtmn.Title = "Öğretmen Resmi Seç ";
            dosyaogrtmn.ShowDialog();
            DosyaYolu = dosyaogrtmn.FileName;
            pictureBox1.ImageLocation = DosyaYolu;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            ekle();
        }
        void listeleSinif()
        {
            SqlCommand komut = new SqlCommand("select * from tbl_sinif", baglan.baglanti());
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbsinif.Items.Add(dr["sinifadi"]);
            }
        }
        private void FrmOgretmenKayit_Load(object sender, EventArgs e)
        {
            lblkaydenen.Text = YoneticiGirisEkran.kullanici;
            listeleSinif();
        }
    }
}
