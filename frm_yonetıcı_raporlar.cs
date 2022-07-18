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
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace dershaneOtomasyon
{
    public partial class frm_yonetıcı_raporlar : Form
    {
        public frm_yonetıcı_raporlar()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        private void frm_yonetıcı_raporlar_Load(object sender, EventArgs e)
        {
            lblgider.Text = frm_yonetıcı_gelır_gırısı.giderVeri;
            lblgelirmiktar.Text = frm_yonetıcı_gelır_gırısı.gelirVeri;
            lblkasa.Text = frm_yonetıcı_gelır_gırısı.kasaVeri;
            SqlCommand ogretmen = new SqlCommand("select count(*) from tbl_ogretmen", baglan.baglanti());
            SqlDataReader oku = ogretmen.ExecuteReader();
            while (oku.Read())
            {
                lblogretmensayisi.Text = oku[0].ToString();
            }
            SqlCommand sinif = new SqlCommand("select count(*) from tbl_sinif", baglan.baglanti());
            SqlDataReader oku1 = sinif.ExecuteReader();
            while (oku1.Read())
            {
                lblsinif.Text = oku1[0].ToString();
            }
            SqlCommand ders = new SqlCommand("select count(*) from tbl_dersler", baglan.baglanti());
            SqlDataReader oku2 = ders.ExecuteReader();
            while (oku2.Read())
            {
                lblders.Text = oku2[0].ToString();
            }
            SqlCommand ogrenci = new SqlCommand("select count(*) from tbl_ogrenci", baglan.baglanti());
            SqlDataReader oku3 = ogrenci.ExecuteReader();
            while (oku3.Read())
            {
                lblogrencisayisi.Text = oku3[0].ToString();
            }
            SqlCommand personel = new SqlCommand("select count(*) from personel", baglan.baglanti());
            SqlDataReader oku4 = personel.ExecuteReader();
            while (oku4.Read())
            {
                lblpersonel.Text = oku4[0].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\beyza\OneDrive\Masaüstü\Rapor.Pdf", FileMode.Create);
            iTextSharp.text.Document rapor = new iTextSharp.text.Document();
            PdfWriter.GetInstance(rapor,fs);
            rapor.AddAuthor("DERSHANE YÖNETİM SİSTEMİ");
            rapor.AddCreationDate();
            rapor.AddCreator("Dershane Yöneticisi");
            rapor.AddSubject(" Dershane Raporu");
            
            if (rapor.IsOpen() == false)
            {
                rapor.Open();
            }
            string v = (rapor.Add(new Paragraph(label1.Text)) + " " + rapor.Add(new Paragraph(lblogretmensayisi.Text)));
            string v1 = (rapor.Add(new Paragraph(label3.Text)) +" " + rapor.Add(new Paragraph(lblogrencisayisi.Text)));
            string v2 = (rapor.Add(new Paragraph(label4.Text)) + " " + rapor.Add(new Paragraph(lblpersonel.Text)));
            string v3 = (rapor.Add(new Paragraph(label5.Text)) + " " + rapor.Add(new Paragraph(lblders.Text)));
            string v4 = (rapor.Add(new Paragraph(label6.Text)) + " " + rapor.Add(new Paragraph(lblsinif.Text)));
            string v5 = (rapor.Add(new Paragraph(label7.Text)) + " " + rapor.Add(new Paragraph(lblgelirmiktar.Text)));
            string v6 = (rapor.Add(new Paragraph(label8.Text)) + " " + rapor.Add(new Paragraph(lblgider.Text)));
            string v7 = (rapor.Add(new Paragraph(label9.Text)) + " " + rapor.Add(new Paragraph(lblkasa.Text)));
            rapor.Close();
            MessageBox.Show("PDF Oluşturuldu","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
