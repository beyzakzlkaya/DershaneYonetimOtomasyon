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
    public partial class frm_ogrenci_taksit_fatura : Form
    {
        public frm_ogrenci_taksit_fatura()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        public static int miktar;
        private void frm_ogrenci_taksit_fatura_Load(object sender, EventArgs e)
        {
            lbltarih.Text = frm_yonetici_ogrenci_taksit_odeme.odemetrh;
            lblbirim.Text = frm_yonetici_ogrenci_taksit_odeme.toplam;
            lbltoplam.Text = frm_yonetici_ogrenci_taksit_odeme.toplam;
            lblaciklama.Text = frm_yonetici_ogrenci_taksit_odeme.aciklama;
            lblad.Text = frm_yonetici_ogrenci_taksit_odeme.ograd;
            lblislemyapan.Text = frm_yonetici_ogrenci_taksit_odeme.calisan;
            lblodemesekli.Text = frm_yonetici_ogrenci_taksit_odeme.odemesekli;
            lblkursturu.Text = frm_yonetici_ogrenci_taksit_odeme.kurstur;
            lblmiktar.Text = "1";
            miktar = Convert.ToInt32(lblmiktar.Text);

           

            SqlCommand id = new SqlCommand("select * from tbl_ogr_taksit", baglan.baglanti());
            id.CommandType = CommandType.Text;
            SqlDataReader oku;
            oku = id.ExecuteReader();
            while (oku.Read())
            {
                string id1 = (oku["fisid"]).ToString();
                lblfatura.Text = id1;
            }
            
        }

     
    }
}
