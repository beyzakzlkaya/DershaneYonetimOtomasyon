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
    public partial class YoneticiDYSEkran : Form
    {
        public YoneticiDYSEkran()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        private void öğrenciKayıtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmOgrenciKayit ogrkayit = new FrmOgrenciKayit();
            ogrkayit.Show();
        }

        private void öğrenciKayıtlarıVeAramaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmOgrenciKayitlari listele = new FrmOgrenciKayitlari();
            listele.Show();
        }

        private void öğretmenKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgretmenKayit ogrtmnKayit = new FrmOgretmenKayit();
            ogrtmnKayit.Show();
        }

        private void oturumuKapatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void yeniPersonelKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonelKayit prslKayit = new FrmPersonelKayit();
            prslKayit.Show();
        }

        private void personelListesiVeYetkileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonelYetki prsnlyetki = new FrmPersonelYetki();
            prsnlyetki.Show();
        }

        private void şifreDeğiştirmeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmSifreDegis sifredgs = new FrmSifreDegis();
            sifredgs.Show();
        }
        private void kaydıSilinenlerToolStripMenuItem1_Click(object sender, EventArgs e)
        { 
            FrmKaydiSilinenler kayitSlnen = new FrmKaydiSilinenler();
            kayitSlnen.Show();
        }
        private void dersEkleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdersekle dersekle = new frmdersekle();
            dersekle.Show();
        }
        private void öğretmenKayıtlarıVeAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOgretmenKayitlari ogretmenKayitlari = new frmOgretmenKayitlari();
            ogretmenKayitlari.Show();
        }

        private void öğretmenMaaşBilgisiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmOgretmenMaas ogrtmMaas = new frmOgretmenMaas();
            ogrtmMaas.Show();
        }

        private void tekEMailGönderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_ogrencitekmail ogrencitekli = new frm_ogrencitekmail();
            ogrencitekli.Show();
        }

        private void topluEMailGönderToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_ogrenci_toplu_mail ogrencitoplumail = new frm_ogrenci_toplu_mail();
            ogrencitoplumail.Show();
        }

        private void tekEMailGönderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ogretmentekmail ogretmentekli = new frm_ogretmentekmail();
            ogretmentekli.Show();
        }

        private void topluEMailGönderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_ogretmen_toplu_mail ogretmentoplumail = new frm_ogretmen_toplu_mail();
            ogretmentoplumail.Show();
        }

        private void tekEMailGönderToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_velitekmail velitekmail = new frm_velitekmail();
            velitekmail.Show();
        }

        private void topluEMailGönderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_velitoplumail velitoplumail = new frm_velitoplumail();
            velitoplumail.Show();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_hakkında hakkinda = new frm_hakkında();
            hakkinda.Show();
        }
        void ad_Al()
        {
            SqlCommand oku = new SqlCommand("select * from tbl_yonetici_giris where kullaniciAdi='" + YoneticiGirisEkran.kullanici + "' ", baglan.baglanti());
            SqlDataReader dr = oku.ExecuteReader();
            while (dr.Read())
            {
                label6.Text = (dr["kullaniciAdi"].ToString());
            }
        }
        private void YoneticiDYSEkran_Load(object sender, EventArgs e)
        {
            ad_Al();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label16.Text = DateTime.Now.ToLongTimeString();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            label16.Text = DateTime.Now.ToLongTimeString();
        }

        private void öğretmenÖğrenciToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_öğretmen_öğrenci_istatistik öö_istatistik = new frm_öğretmen_öğrenci_istatistik();
            öö_istatistik.Show();
        }

        private void öğretmenDersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_öğretmen_ders_istatistik öd_istatistik = new frm_öğretmen_ders_istatistik();
            öd_istatistik.Show();
        }

        private void öğrenciSınıfToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_öğrenci_sınıf_istatistik ös_istatistik = new frm_öğrenci_sınıf_istatistik();
            ös_istatistik.Show();
        }

        private void öğrenciDersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_öğrenci_ders_istatistik öde_istatistik = new frm_öğrenci_ders_istatistik();
            öde_istatistik.Show();
        }

        private void devamsızlıkTakibiToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_yönetici_ogrenci_devamsızlık yntc_ögr_dvmszlk = new frm_yönetici_ogrenci_devamsızlık();
            yntc_ögr_dvmszlk.Show();
        }

        private void grubaGöreHaftalıkDersProgramıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_yonetici_ogrenci_ders_programı frm_Yonetici_Ogrenci_Ders_Programı = new frm_yonetici_ogrenci_ders_programı();
            frm_Yonetici_Ogrenci_Ders_Programı.Show();
        }

        private void grubaGöreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_yonetici_sınıf_kontenjan_durumları frm_Yonetici_Sınıf_Kontenjan_Durumları = new frm_yonetici_sınıf_kontenjan_durumları();
            frm_Yonetici_Sınıf_Kontenjan_Durumları.Show();

        }

        private void eMailToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void maaşDurumuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_yonetıcı_ogretmen_maas_durumu frm_Yonetıcı_Ogretmen_Maas_Durumu = new frm_yonetıcı_ogretmen_maas_durumu();
            frm_Yonetıcı_Ogretmen_Maas_Durumu.Show();

        }

        private void eMailToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void iştenÇıkanlarListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_yonetıcı_ısten_cıkanlar frm_Yonetıcı_Isten_Cıkanlar = new frm_yonetıcı_ısten_cıkanlar();
            frm_Yonetıcı_Isten_Cıkanlar.Show();
        }

   
        private void ödemeGeçmişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_yonetıcı_velı_odeme_gecmısı frm_Yonetıcı_Velı_Odeme_Gecmısı = new frm_yonetıcı_velı_odeme_gecmısı();
            frm_Yonetıcı_Velı_Odeme_Gecmısı.Show();
        }

      

        private void gelirGirişiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_yonetıcı_gelır_gırısı frm_Yonetıcı_Gelır_Gırısı = new frm_yonetıcı_gelır_gırısı();
            frm_Yonetıcı_Gelır_Gırısı.Show();
        }       

        private void raporlarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
          frm_yonetıcı_raporlar frm_Yonetıcı_Raporlar = new frm_yonetıcı_raporlar();
            frm_Yonetıcı_Raporlar.Show();
        }
        private void öğrenciÖdemeAlmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_yonetici_ogrenci_taksit_odeme ogrenci_odeme = new frm_yonetici_ogrenci_taksit_odeme();
            ogrenci_odeme.Show();
        }
        private void kasaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void öğretmenMaaşBilgisiYATIRILANLARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ogretmen_maas_bilgisi frm_Ogretmen_Maas_Bilgisi = new frm_ogretmen_maas_bilgisi();
            frm_Ogretmen_Maas_Bilgisi.Show();
        }

        private void sınıfEkleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_yonetıcı_sınıf_ekle_sıl frm_Yonetıcı_Sınıf_Ekle_Sıl = new frm_yonetıcı_sınıf_ekle_sıl();
            frm_Yonetıcı_Sınıf_Ekle_Sıl.Show();
        }
        private void btnveli_Click_1(object sender, EventArgs e)
        {
            if (cmbveli.SelectedIndex == 0)
            {
                lblveli1.Text = txtveli.Text;
                txtveli.Text = " ";
                cmbveli.Text = " ";
            }
            else if (cmbveli.SelectedIndex == 1)
            {
                lblveli2.Text = txtveli.Text;
                txtveli.Text = " ";
                cmbveli.Text = " ";
            }
            else if (cmbveli.SelectedIndex == 2)
            {
                lblveli2.Text = txtveli.Text;
                txtveli.Text = " ";
                cmbveli.Text = " ";
            }
        }
      
        private void btnveligonder1_Click(object sender, EventArgs e)
        {
            FrmVeliDYSEkran.duyuru1=lblveli1.Text;
        }

        private void btnveligonder2_Click(object sender, EventArgs e)
        {
            FrmVeliDYSEkran.duyuru2 = lblveli2.Text;
        }

        private void btnveligonder3_Click(object sender, EventArgs e)
        {
            FrmVeliDYSEkran.duyuru3 = lblveli2.Text;
        }

        private void btnogretmen_Click(object sender, EventArgs e)
        {
            if (cmbogretmen.SelectedIndex == 0)
            {
                lblogretmen1.Text = txtogretmen.Text;
                txtogretmen.Text = " ";
                cmbogretmen.Text = " ";
            }
            else if (cmbogretmen.SelectedIndex == 1)
            {
                lblogretmen2.Text = txtogretmen.Text;
                txtogretmen.Text = " ";
                cmbogretmen.Text = " ";
            }
            else if (cmbogretmen.SelectedIndex == 2)
            {
                lblogretmen3.Text = txtogretmen.Text;
                txtogretmen.Text = " ";
                cmbogretmen.Text = " ";
            }
        }

        private void btnnogretmen1_Click(object sender, EventArgs e)
        {
            FrmOgretmenDYSEkran.duyuru1 = lblogretmen1.Text;
        }

        private void btnogretmen2_Click(object sender, EventArgs e)
        {
            FrmOgretmenDYSEkran.duyuru2 = lblogretmen2.Text;
        }

        private void btnogretmen3_Click(object sender, EventArgs e)
        {
            FrmOgretmenDYSEkran.duyuru3 = lblogretmen3.Text;
        }

        private void btnogrenci1_Click(object sender, EventArgs e)
        {
            FrmOgrenciDYSEkran.duyuru1 = lblogrenci1.Text;
        }

        private void btnogrenci2_Click(object sender, EventArgs e)
        {
            FrmOgrenciDYSEkran.duyuru2 = lblogrenci2.Text;
        }

        private void btnogrenci3_Click(object sender, EventArgs e)
        {
            FrmOgrenciDYSEkran.duyuru3 = lblogrenci3.Text;
        }

        private void btnogrenci_Click(object sender, EventArgs e)
        {
            if (cmbogrenci.SelectedIndex == 0)
            {
                lblogrenci1.Text = txtogrenci.Text;
                txtogrenci.Text = " ";
                cmbogrenci.Text = " ";
            }
            else if (cmbogrenci.SelectedIndex == 1)
            {
                lblogrenci2.Text = txtogrenci.Text;
                txtogrenci.Text = " ";
                cmbogrenci.Text = " ";
            }
            else if (cmbogrenci.SelectedIndex == 2)
            {
                lblogrenci3.Text = txtogrenci.Text;
                txtogrenci.Text = " ";
                cmbogrenci.Text = " ";
            }
        }

        private void sınıfListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_yonetici_sinif_listesi sinif_Listesi = new frm_yonetici_sinif_listesi();
            sinif_Listesi.Show();
        }

        private void öğrenciİşlemleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

    }
    }
    

