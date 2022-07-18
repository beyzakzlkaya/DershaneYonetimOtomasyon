
namespace dershaneOtomasyon
{
    partial class frm_veli_sifre_degis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtyenisifre = new System.Windows.Forms.TextBox();
            this.txteskisifre = new System.Windows.Forms.TextBox();
            this.txtkullanici = new System.Windows.Forms.TextBox();
            this.lblyeni = new System.Windows.Forms.Label();
            this.lbleskisifre = new System.Windows.Forms.Label();
            this.lblkullanici = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(140, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Şifre Yenile";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(223, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 26;
            this.button3.Text = "İptal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(132, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 33);
            this.button1.TabIndex = 25;
            this.button1.Text = "Şifre Değiş";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtyenisifre
            // 
            this.txtyenisifre.Location = new System.Drawing.Point(144, 196);
            this.txtyenisifre.Multiline = true;
            this.txtyenisifre.Name = "txtyenisifre";
            this.txtyenisifre.Size = new System.Drawing.Size(154, 26);
            this.txtyenisifre.TabIndex = 24;
            // 
            // txteskisifre
            // 
            this.txteskisifre.Location = new System.Drawing.Point(144, 150);
            this.txteskisifre.Multiline = true;
            this.txteskisifre.Name = "txteskisifre";
            this.txteskisifre.Size = new System.Drawing.Size(154, 26);
            this.txteskisifre.TabIndex = 23;
            // 
            // txtkullanici
            // 
            this.txtkullanici.Location = new System.Drawing.Point(144, 109);
            this.txtkullanici.Multiline = true;
            this.txtkullanici.Name = "txtkullanici";
            this.txtkullanici.Size = new System.Drawing.Size(154, 26);
            this.txtkullanici.TabIndex = 22;
            // 
            // lblyeni
            // 
            this.lblyeni.AutoSize = true;
            this.lblyeni.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblyeni.Location = new System.Drawing.Point(75, 199);
            this.lblyeni.Name = "lblyeni";
            this.lblyeni.Size = new System.Drawing.Size(61, 15);
            this.lblyeni.TabIndex = 21;
            this.lblyeni.Text = "Yeni Şifre :";
            // 
            // lbleskisifre
            // 
            this.lbleskisifre.AutoSize = true;
            this.lbleskisifre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbleskisifre.Location = new System.Drawing.Point(77, 152);
            this.lbleskisifre.Name = "lbleskisifre";
            this.lbleskisifre.Size = new System.Drawing.Size(59, 15);
            this.lbleskisifre.TabIndex = 20;
            this.lbleskisifre.Text = "Eski Şifre :";
            // 
            // lblkullanici
            // 
            this.lblkullanici.AutoSize = true;
            this.lblkullanici.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkullanici.Location = new System.Drawing.Point(59, 111);
            this.lblkullanici.Name = "lblkullanici";
            this.lblkullanici.Size = new System.Drawing.Size(79, 15);
            this.lblkullanici.TabIndex = 19;
            this.lblkullanici.Text = "Kullanıcı Adı :";
            // 
            // frm_veli_sifre_degis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 323);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtyenisifre);
            this.Controls.Add(this.txteskisifre);
            this.Controls.Add(this.txtkullanici);
            this.Controls.Add(this.lblyeni);
            this.Controls.Add(this.lbleskisifre);
            this.Controls.Add(this.lblkullanici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_veli_sifre_degis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Değiş";
            this.Load += new System.EventHandler(this.frm_veli_sifre_degis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtyenisifre;
        private System.Windows.Forms.TextBox txteskisifre;
        private System.Windows.Forms.TextBox txtkullanici;
        private System.Windows.Forms.Label lblyeni;
        private System.Windows.Forms.Label lbleskisifre;
        private System.Windows.Forms.Label lblkullanici;
    }
}