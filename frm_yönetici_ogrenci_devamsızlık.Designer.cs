
namespace dershaneOtomasyon
{
    partial class frm_yönetici_ogrenci_devamsızlık
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lbldurum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.cmbsinif = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devamsızDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izinliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devamsizlikTrhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblogrdevamsizlikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dershaneYonetimDataSet = new dershaneOtomasyon.dershaneYonetimDataSet();
            this.tbl_ogr_devamsizlikTableAdapter = new dershaneOtomasyon.dershaneYonetimDataSetTableAdapters.tbl_ogr_devamsizlikTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblogrdevamsizlikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneYonetimDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sınıf Seç :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Devamsızlık Tarihi :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(493, 75);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(153, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.lbldurum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnkaydet);
            this.groupBox1.Controls.Add(this.cmbsinif);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(22, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 133);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Devamsızlık";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(573, 37);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 17);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "İzinli";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(496, 36);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Devamsız";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lbldurum
            // 
            this.lbldurum.AutoSize = true;
            this.lbldurum.Location = new System.Drawing.Point(307, 114);
            this.lbldurum.Name = "lbldurum";
            this.lbldurum.Size = new System.Drawing.Size(35, 13);
            this.lbldurum.TabIndex = 9;
            this.lbldurum.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Devamsızlık Durumu :";
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(573, 103);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(75, 23);
            this.btnkaydet.TabIndex = 5;
            this.btnkaydet.Text = "Düzenle";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbsinif
            // 
            this.cmbsinif.FormattingEnabled = true;
            this.cmbsinif.Location = new System.Drawing.Point(88, 58);
            this.cmbsinif.Name = "cmbsinif";
            this.cmbsinif.Size = new System.Drawing.Size(121, 21);
            this.cmbsinif.TabIndex = 4;
            this.cmbsinif.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrNoDataGridViewTextBoxColumn,
            this.ogrAdDataGridViewTextBoxColumn,
            this.ogrSadDataGridViewTextBoxColumn,
            this.sinifDataGridViewTextBoxColumn,
            this.devamsızDataGridViewTextBoxColumn,
            this.izinliDataGridViewTextBoxColumn,
            this.devamsizlikTrhDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblogrdevamsizlikBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(699, 261);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ogrNoDataGridViewTextBoxColumn
            // 
            this.ogrNoDataGridViewTextBoxColumn.DataPropertyName = "ogrNo";
            this.ogrNoDataGridViewTextBoxColumn.HeaderText = "Öğrenci No";
            this.ogrNoDataGridViewTextBoxColumn.Name = "ogrNoDataGridViewTextBoxColumn";
            // 
            // ogrAdDataGridViewTextBoxColumn
            // 
            this.ogrAdDataGridViewTextBoxColumn.DataPropertyName = "ogrAd";
            this.ogrAdDataGridViewTextBoxColumn.HeaderText = "Öğrenci Adı";
            this.ogrAdDataGridViewTextBoxColumn.Name = "ogrAdDataGridViewTextBoxColumn";
            // 
            // ogrSadDataGridViewTextBoxColumn
            // 
            this.ogrSadDataGridViewTextBoxColumn.DataPropertyName = "ogrSad";
            this.ogrSadDataGridViewTextBoxColumn.HeaderText = "Öğrenci Soyadı";
            this.ogrSadDataGridViewTextBoxColumn.Name = "ogrSadDataGridViewTextBoxColumn";
            // 
            // sinifDataGridViewTextBoxColumn
            // 
            this.sinifDataGridViewTextBoxColumn.DataPropertyName = "sinif";
            this.sinifDataGridViewTextBoxColumn.HeaderText = "Sınıf";
            this.sinifDataGridViewTextBoxColumn.Name = "sinifDataGridViewTextBoxColumn";
            // 
            // devamsızDataGridViewTextBoxColumn
            // 
            this.devamsızDataGridViewTextBoxColumn.DataPropertyName = "devamsız";
            this.devamsızDataGridViewTextBoxColumn.HeaderText = "Devamsız";
            this.devamsızDataGridViewTextBoxColumn.Name = "devamsızDataGridViewTextBoxColumn";
            this.devamsızDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // izinliDataGridViewTextBoxColumn
            // 
            this.izinliDataGridViewTextBoxColumn.DataPropertyName = "izinli";
            this.izinliDataGridViewTextBoxColumn.HeaderText = "İzinli";
            this.izinliDataGridViewTextBoxColumn.Name = "izinliDataGridViewTextBoxColumn";
            this.izinliDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // devamsizlikTrhDataGridViewTextBoxColumn
            // 
            this.devamsizlikTrhDataGridViewTextBoxColumn.DataPropertyName = "devamsizlikTrh";
            this.devamsizlikTrhDataGridViewTextBoxColumn.HeaderText = "Devamsızlık Tarihi";
            this.devamsizlikTrhDataGridViewTextBoxColumn.Name = "devamsizlikTrhDataGridViewTextBoxColumn";
            this.devamsizlikTrhDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tblogrdevamsizlikBindingSource
            // 
            this.tblogrdevamsizlikBindingSource.DataMember = "tbl_ogr_devamsizlik";
            this.tblogrdevamsizlikBindingSource.DataSource = this.dershaneYonetimDataSet;
            // 
            // dershaneYonetimDataSet
            // 
            this.dershaneYonetimDataSet.DataSetName = "dershaneYonetimDataSet";
            this.dershaneYonetimDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_ogr_devamsizlikTableAdapter
            // 
            this.tbl_ogr_devamsizlikTableAdapter.ClearBeforeFill = true;
            // 
            // frm_yönetici_ogrenci_devamsızlık
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 438);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_yönetici_ogrenci_devamsızlık";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Devamsızlık Gir";
            this.Load += new System.EventHandler(this.frm_yönetici_ogrenci_devamsızlık_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblogrdevamsizlikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneYonetimDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbsinif;
        private System.Windows.Forms.Button btnkaydet;
        private dershaneYonetimDataSet dershaneYonetimDataSet;
        private System.Windows.Forms.BindingSource tblogrdevamsizlikBindingSource;
        private dershaneYonetimDataSetTableAdapters.tbl_ogr_devamsizlikTableAdapter tbl_ogr_devamsizlikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devamsızDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izinliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devamsizlikTrhDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbldurum;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}