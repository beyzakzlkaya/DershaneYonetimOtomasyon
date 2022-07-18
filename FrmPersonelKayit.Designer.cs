
namespace dershaneOtomasyon
{
    partial class FrmPersonelKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonelKayit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbdepartman = new System.Windows.Forms.ComboBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.txtbanka = new System.Windows.Forms.TextBox();
            this.txtpersad = new System.Windows.Forms.TextBox();
            this.txtperad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.grpKisisel = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.grpisBilgileri = new System.Windows.Forms.GroupBox();
            this.cmbengelDurum = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbengelDerece = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbpergrup = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.grpİletisim = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.mskceptel = new System.Windows.Forms.MaskedTextBox();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grpmaas = new System.Windows.Forms.GroupBox();
            this.txtiban = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtucret = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbcalismaTip = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.cmbcins = new System.Windows.Forms.ComboBox();
            this.cmbdurum = new System.Windows.Forms.ComboBox();
            this.cmbsehir = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.grpKisisel.SuspendLayout();
            this.grpisBilgileri.SuspendLayout();
            this.grpİletisim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpmaas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-8, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 77);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "PERSONEL KAYIT";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(49, 71);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 15);
            this.label16.TabIndex = 56;
            this.label16.Text = "İşe Giriş Tarihi :";
            // 
            // cmbdepartman
            // 
            this.cmbdepartman.FormattingEnabled = true;
            this.cmbdepartman.Items.AddRange(new object[] {
            "Hizmetli",
            "Güvenlik ",
            "Müdür Yardımcısı",
            "İnsan Kaynakları",
            "Müdür ",
            ""});
            this.cmbdepartman.Location = new System.Drawing.Point(140, 33);
            this.cmbdepartman.Name = "cmbdepartman";
            this.cmbdepartman.Size = new System.Drawing.Size(121, 25);
            this.cmbdepartman.TabIndex = 53;
            // 
            // msktc
            // 
            this.msktc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktc.Location = new System.Drawing.Point(114, 31);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(121, 23);
            this.msktc.TabIndex = 52;
            // 
            // txtbanka
            // 
            this.txtbanka.Location = new System.Drawing.Point(121, 83);
            this.txtbanka.Name = "txtbanka";
            this.txtbanka.Size = new System.Drawing.Size(121, 20);
            this.txtbanka.TabIndex = 49;
            // 
            // txtpersad
            // 
            this.txtpersad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtpersad.Location = new System.Drawing.Point(114, 87);
            this.txtpersad.Name = "txtpersad";
            this.txtpersad.Size = new System.Drawing.Size(121, 23);
            this.txtpersad.TabIndex = 47;
            // 
            // txtperad
            // 
            this.txtperad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtperad.Location = new System.Drawing.Point(114, 59);
            this.txtperad.Name = "txtperad";
            this.txtperad.Size = new System.Drawing.Size(121, 23);
            this.txtperad.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(70, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 15);
            this.label11.TabIndex = 43;
            this.label11.Text = "Banka :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(25, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 15);
            this.label10.TabIndex = 42;
            this.label10.Text = "Doğum Tarihi :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(68, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 41;
            this.label9.Text = "Şehir :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(29, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 38;
            this.label6.Text = "Departman/Birim :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(52, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 37;
            this.label5.Text = "Cinsiyet :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(61, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 36;
            this.label4.Text = "Soyadı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(76, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 35;
            this.label3.Text = "Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "T.C. Kimlik No  : ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 205);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 23);
            this.dateTimePicker1.TabIndex = 59;
            // 
            // grpKisisel
            // 
            this.grpKisisel.Controls.Add(this.cmbdurum);
            this.grpKisisel.Controls.Add(this.cmbcins);
            this.grpKisisel.Controls.Add(this.cmbsehir);
            this.grpKisisel.Controls.Add(this.msktc);
            this.grpKisisel.Controls.Add(this.dateTimePicker1);
            this.grpKisisel.Controls.Add(this.label14);
            this.grpKisisel.Controls.Add(this.label2);
            this.grpKisisel.Controls.Add(this.label3);
            this.grpKisisel.Controls.Add(this.label4);
            this.grpKisisel.Controls.Add(this.label5);
            this.grpKisisel.Controls.Add(this.label9);
            this.grpKisisel.Controls.Add(this.label10);
            this.grpKisisel.Controls.Add(this.txtperad);
            this.grpKisisel.Controls.Add(this.txtpersad);
            this.grpKisisel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpKisisel.Location = new System.Drawing.Point(12, 81);
            this.grpKisisel.Name = "grpKisisel";
            this.grpKisisel.Size = new System.Drawing.Size(346, 271);
            this.grpKisisel.TabIndex = 60;
            this.grpKisisel.TabStop = false;
            this.grpKisisel.Text = "Kişisel Bilgiler";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(58, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 15);
            this.label14.TabIndex = 61;
            this.label14.Text = "Durum :";
            // 
            // grpisBilgileri
            // 
            this.grpisBilgileri.Controls.Add(this.cmbengelDurum);
            this.grpisBilgileri.Controls.Add(this.label18);
            this.grpisBilgileri.Controls.Add(this.cmbengelDerece);
            this.grpisBilgileri.Controls.Add(this.label17);
            this.grpisBilgileri.Controls.Add(this.cmbpergrup);
            this.grpisBilgileri.Controls.Add(this.label15);
            this.grpisBilgileri.Controls.Add(this.dateTimePicker2);
            this.grpisBilgileri.Controls.Add(this.cmbdepartman);
            this.grpisBilgileri.Controls.Add(this.label6);
            this.grpisBilgileri.Controls.Add(this.label16);
            this.grpisBilgileri.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpisBilgileri.Location = new System.Drawing.Point(12, 369);
            this.grpisBilgileri.Name = "grpisBilgileri";
            this.grpisBilgileri.Size = new System.Drawing.Size(346, 197);
            this.grpisBilgileri.TabIndex = 61;
            this.grpisBilgileri.TabStop = false;
            this.grpisBilgileri.Text = "İş Bilgileri";
            // 
            // cmbengelDurum
            // 
            this.cmbengelDurum.FormattingEnabled = true;
            this.cmbengelDurum.Items.AddRange(new object[] {
            "İştime Engelli",
            "Görme Engelli",
            "Zihinsel Engelli",
            "Ortopedik Engelli",
            "Yok"});
            this.cmbengelDurum.Location = new System.Drawing.Point(139, 123);
            this.cmbengelDurum.Name = "cmbengelDurum";
            this.cmbengelDurum.Size = new System.Drawing.Size(122, 25);
            this.cmbengelDurum.TabIndex = 66;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(44, 128);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 15);
            this.label18.TabIndex = 65;
            this.label18.Text = "Engel Durumu :";
            // 
            // cmbengelDerece
            // 
            this.cmbengelDerece.FormattingEnabled = true;
            this.cmbengelDerece.Items.AddRange(new object[] {
            "%80",
            "%60",
            "%40",
            "Yok"});
            this.cmbengelDerece.Location = new System.Drawing.Point(140, 154);
            this.cmbengelDerece.Name = "cmbengelDerece";
            this.cmbengelDerece.Size = new System.Drawing.Size(122, 25);
            this.cmbengelDerece.TabIndex = 64;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(45, 159);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 15);
            this.label17.TabIndex = 63;
            this.label17.Text = "Engel Derecesi :";
            // 
            // cmbpergrup
            // 
            this.cmbpergrup.FormattingEnabled = true;
            this.cmbpergrup.Items.AddRange(new object[] {
            "Normal Çalışan",
            "Part-Time Çalışan"});
            this.cmbpergrup.Location = new System.Drawing.Point(140, 94);
            this.cmbpergrup.Name = "cmbpergrup";
            this.cmbpergrup.Size = new System.Drawing.Size(122, 25);
            this.cmbpergrup.TabIndex = 62;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(39, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 15);
            this.label15.TabIndex = 61;
            this.label15.Text = "Personel Grubu :";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker2.Location = new System.Drawing.Point(139, 65);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(187, 23);
            this.dateTimePicker2.TabIndex = 57;
            // 
            // grpİletisim
            // 
            this.grpİletisim.Controls.Add(this.label27);
            this.grpİletisim.Controls.Add(this.txtmail);
            this.grpİletisim.Controls.Add(this.label19);
            this.grpİletisim.Controls.Add(this.mskTel);
            this.grpİletisim.Controls.Add(this.mskceptel);
            this.grpİletisim.Controls.Add(this.txtadres);
            this.grpİletisim.Controls.Add(this.label20);
            this.grpİletisim.Controls.Add(this.label21);
            this.grpİletisim.Controls.Add(this.label22);
            this.grpİletisim.Location = new System.Drawing.Point(387, 81);
            this.grpİletisim.Name = "grpİletisim";
            this.grpİletisim.Size = new System.Drawing.Size(354, 244);
            this.grpİletisim.TabIndex = 62;
            this.grpİletisim.TabStop = false;
            this.grpİletisim.Text = "İletişim Bilgileri";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(296, 256);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(70, 13);
            this.label27.TabIndex = 75;
            this.label27.Text = "Kullanıcı Adı :";
            // 
            // txtmail
            // 
            this.txtmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmail.Location = new System.Drawing.Point(176, 197);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(172, 23);
            this.txtmail.TabIndex = 84;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(123, 200);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 15);
            this.label19.TabIndex = 83;
            this.label19.Text = "E-Mail :";
            // 
            // mskTel
            // 
            this.mskTel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTel.Location = new System.Drawing.Point(176, 40);
            this.mskTel.Mask = "(999) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(100, 23);
            this.mskTel.TabIndex = 82;
            // 
            // mskceptel
            // 
            this.mskceptel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskceptel.Location = new System.Drawing.Point(176, 69);
            this.mskceptel.Mask = "(999) 000-0000";
            this.mskceptel.Name = "mskceptel";
            this.mskceptel.Size = new System.Drawing.Size(100, 23);
            this.mskceptel.TabIndex = 74;
            // 
            // txtadres
            // 
            this.txtadres.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadres.Location = new System.Drawing.Point(176, 105);
            this.txtadres.Multiline = true;
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(172, 85);
            this.txtadres.TabIndex = 71;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(12, 72);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(158, 15);
            this.label20.TabIndex = 64;
            this.label20.Text = "Cep Telefonu(1.Dereceden) : ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(127, 108);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(43, 15);
            this.label21.TabIndex = 65;
            this.label21.Text = "Adres :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(88, 43);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(82, 15);
            this.label22.TabIndex = 70;
            this.label22.Text = "Cep Telefonu :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(868, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(868, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 66;
            this.button1.Text = "Gözat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(949, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 67;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // grpmaas
            // 
            this.grpmaas.Controls.Add(this.txtiban);
            this.grpmaas.Controls.Add(this.label25);
            this.grpmaas.Controls.Add(this.label24);
            this.grpmaas.Controls.Add(this.txtucret);
            this.grpmaas.Controls.Add(this.label13);
            this.grpmaas.Controls.Add(this.cmbcalismaTip);
            this.grpmaas.Controls.Add(this.label8);
            this.grpmaas.Controls.Add(this.txtbanka);
            this.grpmaas.Controls.Add(this.label11);
            this.grpmaas.Location = new System.Drawing.Point(387, 364);
            this.grpmaas.Name = "grpmaas";
            this.grpmaas.Size = new System.Drawing.Size(354, 169);
            this.grpmaas.TabIndex = 70;
            this.grpmaas.TabStop = false;
            this.grpmaas.Text = "Maaş Bilgileri";
            // 
            // txtiban
            // 
            this.txtiban.Location = new System.Drawing.Point(121, 113);
            this.txtiban.Name = "txtiban";
            this.txtiban.Size = new System.Drawing.Size(215, 20);
            this.txtiban.TabIndex = 88;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25.Location = new System.Drawing.Point(70, 130);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(0, 15);
            this.label25.TabIndex = 87;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.Location = new System.Drawing.Point(75, 115);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(40, 15);
            this.label24.TabIndex = 86;
            this.label24.Text = "IBAN :";
            // 
            // txtucret
            // 
            this.txtucret.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtucret.Location = new System.Drawing.Point(121, 54);
            this.txtucret.Name = "txtucret";
            this.txtucret.Size = new System.Drawing.Size(121, 23);
            this.txtucret.TabIndex = 85;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(74, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "Ücret :";
            // 
            // cmbcalismaTip
            // 
            this.cmbcalismaTip.FormattingEnabled = true;
            this.cmbcalismaTip.Items.AddRange(new object[] {
            "Part-Time",
            "Süreli",
            "Süresiz",
            "Haftalık"});
            this.cmbcalismaTip.Location = new System.Drawing.Point(121, 29);
            this.cmbcalismaTip.Name = "cmbcalismaTip";
            this.cmbcalismaTip.Size = new System.Drawing.Size(121, 21);
            this.cmbcalismaTip.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(38, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Çalışma Tipi :";
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(868, 528);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(185, 35);
            this.btnkaydet.TabIndex = 71;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // cmbcins
            // 
            this.cmbcins.FormattingEnabled = true;
            this.cmbcins.Items.AddRange(new object[] {
            "KADIN",
            "ERKEK"});
            this.cmbcins.Location = new System.Drawing.Point(113, 115);
            this.cmbcins.Name = "cmbcins";
            this.cmbcins.Size = new System.Drawing.Size(121, 25);
            this.cmbcins.TabIndex = 65;
            // 
            // cmbdurum
            // 
            this.cmbdurum.FormattingEnabled = true;
            this.cmbdurum.Items.AddRange(new object[] {
            "EVLİ",
            "BEKAR"});
            this.cmbdurum.Location = new System.Drawing.Point(113, 145);
            this.cmbdurum.Name = "cmbdurum";
            this.cmbdurum.Size = new System.Drawing.Size(121, 25);
            this.cmbdurum.TabIndex = 66;
            // 
            // cmbsehir
            // 
            this.cmbsehir.FormattingEnabled = true;
            this.cmbsehir.Items.AddRange(new object[] {
            "ORDU",
            "İSTANBUL",
            "ANKARA",
            "RİZE",
            "TRABZON",
            "SAMSUN",
            "GAZİANTEP",
            "MUĞLA",
            "ANTALYA",
            "EDİRNE",
            "TEKİRDAĞ",
            "GİRESUN",
            "HAKKARİ",
            "BİNGÖL",
            "BİTLİS",
            "İZMİR",
            "ELAZIĞ",
            "ÇANAKKALE",
            "KAYSERİ",
            "NİĞDE",
            "UŞAK",
            "NEVŞEHİR",
            "HATAY ",
            "ADANA",
            "KONYA"});
            this.cmbsehir.Location = new System.Drawing.Point(114, 175);
            this.cmbsehir.Name = "cmbsehir";
            this.cmbsehir.Size = new System.Drawing.Size(121, 25);
            this.cmbsehir.TabIndex = 64;
            // 
            // FrmPersonelKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 577);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.grpmaas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpİletisim);
            this.Controls.Add(this.grpisBilgileri);
            this.Controls.Add(this.grpKisisel);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPersonelKayit";
            this.Text = "Personel Kayıt";
            this.Load += new System.EventHandler(this.FrmPersonelKayit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpKisisel.ResumeLayout(false);
            this.grpKisisel.PerformLayout();
            this.grpisBilgileri.ResumeLayout(false);
            this.grpisBilgileri.PerformLayout();
            this.grpİletisim.ResumeLayout(false);
            this.grpİletisim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpmaas.ResumeLayout(false);
            this.grpmaas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbdepartman;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.TextBox txtbanka;
        private System.Windows.Forms.TextBox txtpersad;
        private System.Windows.Forms.TextBox txtperad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox grpKisisel;
        private System.Windows.Forms.GroupBox grpisBilgileri;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbpergrup;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox grpİletisim;
        private System.Windows.Forms.ComboBox cmbengelDerece;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbengelDurum;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.MaskedTextBox mskceptel;
        private System.Windows.Forms.TextBox txtadres;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox grpmaas;
        private System.Windows.Forms.TextBox txtiban;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtucret;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbcalismaTip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cmbdurum;
        private System.Windows.Forms.ComboBox cmbcins;
        private System.Windows.Forms.ComboBox cmbsehir;
    }
}