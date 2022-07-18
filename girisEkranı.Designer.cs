
namespace dershaneOtomasyon
{
    partial class GirisEkranı
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkranı));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.YoneticiGiris = new System.Windows.Forms.Button();
            this.OgretmenGirisi = new System.Windows.Forms.Button();
            this.OgrenciGirisi = new System.Windows.Forms.Button();
            this.VeliGirisi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 78);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "GİRİŞ EKRANI ";
            // 
            // YoneticiGiris
            // 
            this.YoneticiGiris.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.YoneticiGiris.Image = ((System.Drawing.Image)(resources.GetObject("YoneticiGiris.Image")));
            this.YoneticiGiris.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.YoneticiGiris.Location = new System.Drawing.Point(68, 139);
            this.YoneticiGiris.Name = "YoneticiGiris";
            this.YoneticiGiris.Size = new System.Drawing.Size(232, 66);
            this.YoneticiGiris.TabIndex = 1;
            this.YoneticiGiris.Text = "         YÖNETİCİ GİRİŞİ";
            this.YoneticiGiris.UseVisualStyleBackColor = true;
            this.YoneticiGiris.Click += new System.EventHandler(this.YoneticiGiris_Click);
            // 
            // OgretmenGirisi
            // 
            this.OgretmenGirisi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OgretmenGirisi.Image = ((System.Drawing.Image)(resources.GetObject("OgretmenGirisi.Image")));
            this.OgretmenGirisi.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.OgretmenGirisi.Location = new System.Drawing.Point(68, 225);
            this.OgretmenGirisi.Name = "OgretmenGirisi";
            this.OgretmenGirisi.Size = new System.Drawing.Size(232, 66);
            this.OgretmenGirisi.TabIndex = 2;
            this.OgretmenGirisi.Text = "             ÖĞRETMEN GİRİŞİ";
            this.OgretmenGirisi.UseVisualStyleBackColor = true;
            this.OgretmenGirisi.Click += new System.EventHandler(this.OgretmenGirisi_Click);
            // 
            // OgrenciGirisi
            // 
            this.OgrenciGirisi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OgrenciGirisi.Image = ((System.Drawing.Image)(resources.GetObject("OgrenciGirisi.Image")));
            this.OgrenciGirisi.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.OgrenciGirisi.Location = new System.Drawing.Point(366, 139);
            this.OgrenciGirisi.Name = "OgrenciGirisi";
            this.OgrenciGirisi.Size = new System.Drawing.Size(232, 66);
            this.OgrenciGirisi.TabIndex = 3;
            this.OgrenciGirisi.Text = "            ÖĞRENCİ GİRİŞİ";
            this.OgrenciGirisi.UseVisualStyleBackColor = true;
            this.OgrenciGirisi.Click += new System.EventHandler(this.OgrenciGirisi_Click);
            // 
            // VeliGirisi
            // 
            this.VeliGirisi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VeliGirisi.Image = ((System.Drawing.Image)(resources.GetObject("VeliGirisi.Image")));
            this.VeliGirisi.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.VeliGirisi.Location = new System.Drawing.Point(366, 225);
            this.VeliGirisi.Name = "VeliGirisi";
            this.VeliGirisi.Size = new System.Drawing.Size(232, 66);
            this.VeliGirisi.TabIndex = 4;
            this.VeliGirisi.Text = "            VELİ GİRİŞİ";
            this.VeliGirisi.UseVisualStyleBackColor = true;
            this.VeliGirisi.Click += new System.EventHandler(this.VeliGirisi_Click);
            // 
            // GirisEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(663, 391);
            this.Controls.Add(this.VeliGirisi);
            this.Controls.Add(this.OgrenciGirisi);
            this.Controls.Add(this.OgretmenGirisi);
            this.Controls.Add(this.YoneticiGiris);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "GirisEkranı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DERSHANE YÖNETİM SİSTEMİ GİRİŞ EKRANI";
            this.Load += new System.EventHandler(this.GirisEkranı_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button YoneticiGiris;
        private System.Windows.Forms.Button OgretmenGirisi;
        private System.Windows.Forms.Button OgrenciGirisi;
        private System.Windows.Forms.Button VeliGirisi;
    }
}

