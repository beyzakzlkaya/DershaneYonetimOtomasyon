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
    public partial class frm_yonetici_sınıf_kontenjan_durumları : Form
    {
        public frm_yonetici_sınıf_kontenjan_durumları()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        public static int sayisal,sozel,esitagirlik;
        public void sinif_kontenjan_oku()
        {
            SqlCommand kontenjan_sayisal = new SqlCommand("select count(*) from tbl_ogrenci where sinif='Sayısal'", baglan.baglanti());
            SqlDataReader dr = kontenjan_sayisal.ExecuteReader();
            while (dr.Read())
            {
                sayisal = int.Parse(dr[0].ToString());
                lblsayisal.Text = sayisal.ToString();
            }
            SqlCommand kontenjan_esita = new SqlCommand("select count(*) from tbl_ogrenci where sinif='Eşit Ağırlık'", baglan.baglanti());
            SqlDataReader dr1 = kontenjan_esita.ExecuteReader();
            while (dr1.Read())
            {
                esitagirlik = int.Parse(dr1[0].ToString());
                lblesitagirlik.Text = esitagirlik.ToString();
            }
            SqlCommand kontenjan_sozel = new SqlCommand("select count(*) from tbl_ogrenci where sinif='Sözel'", baglan.baglanti());
            SqlDataReader dr2 = kontenjan_sozel.ExecuteReader();
            while (dr2.Read())
            {
                sozel = int.Parse(dr2[0].ToString());
                lblsozel.Text = sozel.ToString();
            }
            progressBar1.Value = sayisal;
            progressBar2.Value = esitagirlik;
            progressBar3.Value = sozel;
        }

       
        
      
 
        private void frm_yonetici_sınıf_kontenjan_durumları_Load(object sender, EventArgs e)
        {
            sinif_kontenjan_oku();
        }

     
    }
}
