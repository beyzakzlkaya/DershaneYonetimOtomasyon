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
    public partial class frm_ogrenc_testler_sonucu : Form
    {
        public frm_ogrenc_testler_sonucu()
        {
            InitializeComponent();
        }
        void biyoloji()
        {
            lblbiyolojidogru.Text = frm_ogrenci_testler_bıyolojı.dogru.ToString();
            lblbiyolojiyanlis.Text = frm_ogrenci_testler_bıyolojı.yanlis.ToString();
            surebiyoloji.Text = frm_ogrenci_testler_bıyolojı.zaman.ToString();
        }
        void Kimya()
        {
            lblkimyadogru.Text = frm_ogrenci_testler_kimya.dogru.ToString();
            lblkimyayanlis.Text = frm_ogrenci_testler_kimya.yanlis.ToString();
            surekimya.Text = frm_ogrenci_testler_kimya.zaman.ToString();
        }
        void fizik()
        {
            lblfizikdogru.Text = frm_ogrenci_testler_fızık.dogru.ToString();
            lblfizikyanlis.Text = frm_ogrenci_testler_fızık.yanlis.ToString();
            surefizik.Text = frm_ogrenci_testler_fızık.zaman.ToString();
        }
        void turkce()
        {
            lblturkcedogru.Text = frm_ogrencı_testler_tur.dogru.ToString();
            lblturkceyanlis.Text = frm_ogrencı_testler_tur.yanlis.ToString();
            suretur.Text = frm_ogrencı_testler_tur.zaman.ToString();
        }
        void matematik()
        {
            lblmatdogru.Text = frm_ogrenci_testler_matematik.dogru.ToString();
            lblmatyanlis.Text = frm_ogrenci_testler_matematik.yanlis.ToString();
            suremat.Text = frm_ogrenci_testler_matematik.zaman.ToString();
        }
        void tarih()
        {
            lbltarihodogru.Text = frm_ogrenci_testler_tarıh.dogru.ToString();
            lbltarihyanlis.Text = frm_ogrenci_testler_tarıh.yanlis.ToString();
            suretarih.Text = frm_ogrenci_testler_tarıh.zaman.ToString();
        }
        void cografya()
        {
            lblcogrfyadogru.Text = frm_ogrencı_testler_cog.dogru.ToString();
            lblcgrfyayanlis.Text = frm_ogrencı_testler_cog.yanlis.ToString();
            surecografya.Text = frm_ogrencı_testler_cog.zaman.ToString();
        }
        private void frm_ogrenc_testler_sonucu_Load(object sender, EventArgs e)
        {
            biyoloji();
            Kimya();
            fizik();
            matematik();
            tarih();
            turkce();
            cografya();

        }
    }
}
