using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dershaneOtomasyon
{
    public partial class frm_ogrenci_kredikarti : Form
    {
        public frm_ogrenci_kredikarti()
        {
            InitializeComponent();
        }
      
        public static int aylik;
        public static int tutar;
        public static int odenecek;
        private void frm_ogrenci_kredikarti_Load(object sender, EventArgs e)
        {
            tutar = int.Parse(FrmOgrenciKayit.fiyat);
            txtfiyat.Text = tutar.ToString();
            lblaylik.Text = tutar.ToString();
            odenecek = int.Parse(lblaylik.Text);
        }   
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            aylik = Convert.ToInt32(comboBox1.Text);
            if (comboBox1.SelectedIndex == 0)
            {
                odenecek = tutar /3;
                lblaylik.Text=odenecek.ToString();
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                odenecek = tutar / 6;
                lblaylik.Text = odenecek.ToString();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                odenecek = tutar / 9;
                lblaylik.Text = odenecek.ToString();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                odenecek = tutar / 12;
                lblaylik.Text = odenecek.ToString();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

      
    }
}
