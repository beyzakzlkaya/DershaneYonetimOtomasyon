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
    public partial class frm_ogretmen_maas_fatura : Form
    {
        public frm_ogretmen_maas_fatura()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        
        private void frm_ogretmen_maas_fatura_Load(object sender, EventArgs e)
        {
            lblTc.Text = frmOgretmenMaas.Tc;
            lbliban.Text = frmOgretmenMaas.iban;
            lbltarih.Text = frmOgretmenMaas.odemetrh;
            lblbirimfiyat.Text = frmOgretmenMaas.toplamtutar;
            lblaciklama.Text = frmOgretmenMaas.aciklama;
            lblad.Text = frmOgretmenMaas.calisan;
            lbltoplamtutar.Text=(1*int.Parse(lblbirimfiyat.Text)).ToString();

            SqlCommand id = new SqlCommand("select * from tbl_ogretmen_maas", baglan.baglanti());
            id.CommandType = CommandType.Text;
            SqlDataReader oku;
            oku = id.ExecuteReader();
            while (oku.Read())
            {
                lblfatura.Text = (oku["fisid"]).ToString();
            }
        }

     
    }
}
