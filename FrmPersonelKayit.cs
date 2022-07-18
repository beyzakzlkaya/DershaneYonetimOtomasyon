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
    public partial class FrmPersonelKayit : Form
    {
        public FrmPersonelKayit()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        public string DosyaYolu;
        string klasor_hedef = @"C:\Users\beyza\OneDrive\Masaüstü\dershane_gönder\dershane_gönder\dershane_son\dershane_son\bin\ImageProje\";
        void kaydet() 
        {
            SqlCommand ekle = new SqlCommand("insert into personel (tcno,personelAd,personelSad,cinsiyet,durum,sehir,dgmTrh,personeltel,telefonNo,adres,mail,departman,isegrstrh,personelGrup,engelDurum,engelDerece,calismaTip,maas,banka,iban,foto) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17,@p18,@p19,@p20,@p21)", baglan.baglanti());
            ekle.Parameters.AddWithValue("@p1", msktc.Text);
            ekle.Parameters.AddWithValue("@p2", txtperad.Text);
            ekle.Parameters.AddWithValue("@p3", txtpersad.Text);
            ekle.Parameters.AddWithValue("@p4", cmbcins.Text);
            ekle.Parameters.AddWithValue("@p5", cmbdurum.Text);
            ekle.Parameters.AddWithValue("@p6", cmbsehir.Text);
            ekle.Parameters.AddWithValue("@p7", dateTimePicker1.Value);
            ekle.Parameters.AddWithValue("@p8", mskTel.Text);
            ekle.Parameters.AddWithValue("@p9", mskceptel.Text);
            ekle.Parameters.AddWithValue("@p10", txtadres.Text);
            ekle.Parameters.AddWithValue("@p11", txtmail.Text);
            ekle.Parameters.AddWithValue("@p12", cmbdepartman.Text);
            ekle.Parameters.AddWithValue("@p13", dateTimePicker2.Value);
            ekle.Parameters.AddWithValue("@p14", cmbpergrup.Text);
            ekle.Parameters.AddWithValue("@p15", cmbengelDurum.Text);
            ekle.Parameters.AddWithValue("@p16", cmbengelDerece.Text);
            ekle.Parameters.AddWithValue("@p17", cmbcalismaTip.Text);
            ekle.Parameters.AddWithValue("@p18", txtucret.Text);
            ekle.Parameters.AddWithValue("@p19", txtbanka.Text);
            ekle.Parameters.AddWithValue("@p20", txtiban.Text);

            FileStream fs = new FileStream(DosyaYolu, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] fotolar = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();
            ekle.Parameters.Add("@p21", SqlDbType.Image, fotolar.Length).Value = fotolar;//veritabanı türünü ifade ettikten sonra dizi uzunluğunu aldık değer olduğunu belirtip fotoya atatık
            File.Copy(DosyaYolu, klasor_hedef + Path.GetFileName(DosyaYolu));
            ekle.ExecuteNonQuery();
            MessageBox.Show("Kayıt Gerçekleşti");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Tüm Dosyalar |*.*";
            dosya.Title = "Personel Resmi Seç ";
            dosya.ShowDialog();
            DosyaYolu = dosya.FileName;
            pictureBox1.ImageLocation = DosyaYolu;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            kaydet();
        }
        private void FrmPersonelKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
