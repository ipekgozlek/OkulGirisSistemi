namespace BonusProje
{
    partial class FrmOgrenci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrenci));
            pictureBox1 = new PictureBox();
            BtnSil = new Button();
            BtnEkle = new Button();
            BtnGuncelle = new Button();
            BtnListele = new Button();
            TxtAd = new TextBox();
            TxtID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            TxtSoyad = new TextBox();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label6 = new Label();
            TxtAra = new TextBox();
            BtnAra = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(672, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // BtnSil
            // 
            BtnSil.BackColor = SystemColors.GradientInactiveCaption;
            BtnSil.FlatStyle = FlatStyle.Flat;
            BtnSil.Location = new Point(260, 310);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(94, 29);
            BtnSil.TabIndex = 31;
            BtnSil.Text = "Sil";
            BtnSil.UseVisualStyleBackColor = false;
            BtnSil.Click += BtnSil_Click;
            // 
            // BtnEkle
            // 
            BtnEkle.BackColor = SystemColors.GradientInactiveCaption;
            BtnEkle.FlatStyle = FlatStyle.Flat;
            BtnEkle.Location = new Point(68, 310);
            BtnEkle.Name = "BtnEkle";
            BtnEkle.Size = new Size(94, 29);
            BtnEkle.TabIndex = 30;
            BtnEkle.Text = "Ekle";
            BtnEkle.UseVisualStyleBackColor = false;
            BtnEkle.Click += BtnEkle_Click;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.BackColor = SystemColors.GradientInactiveCaption;
            BtnGuncelle.FlatStyle = FlatStyle.Flat;
            BtnGuncelle.Location = new Point(260, 266);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(94, 29);
            BtnGuncelle.TabIndex = 29;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = false;
            BtnGuncelle.Click += BtnGuncelle_Click;
            // 
            // BtnListele
            // 
            BtnListele.BackColor = SystemColors.GradientInactiveCaption;
            BtnListele.FlatStyle = FlatStyle.Flat;
            BtnListele.Location = new Point(68, 266);
            BtnListele.Name = "BtnListele";
            BtnListele.Size = new Size(94, 29);
            BtnListele.TabIndex = 28;
            BtnListele.Text = "Listele";
            BtnListele.UseVisualStyleBackColor = false;
            BtnListele.Click += BtnListele_Click;
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(536, 301);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(125, 27);
            TxtAd.TabIndex = 27;
            // 
            // TxtID
            // 
            TxtID.Enabled = false;
            TxtID.Location = new Point(536, 259);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(125, 27);
            TxtID.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(467, 301);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 25;
            label3.Text = "ADI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(411, 266);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 24;
            label2.Text = "OGRENCI ID:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(685, 188);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(25, 12);
            label1.Name = "label1";
            label1.Size = new Size(194, 20);
            label1.TabIndex = 22;
            label1.Text = "ÖĞRENCİ İŞLEMLERİ PANELİ";
            // 
            // TxtSoyad
            // 
            TxtSoyad.Enabled = false;
            TxtSoyad.Location = new Point(536, 343);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(125, 27);
            TxtSoyad.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(437, 385);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 34;
            label4.Text = "KULÜBÜ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(445, 350);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 33;
            label5.Text = "SOYAD:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(536, 382);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 28);
            comboBox1.TabIndex = 36;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.ForeColor = SystemColors.ButtonFace;
            radioButton1.Location = new Point(536, 430);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(50, 24);
            radioButton1.TabIndex = 37;
            radioButton1.TabStop = true;
            radioButton1.Text = "Kız";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = SystemColors.ButtonHighlight;
            radioButton2.Location = new Point(592, 430);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(65, 24);
            radioButton2.TabIndex = 38;
            radioButton2.TabStop = true;
            radioButton2.Text = "Erkek";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(437, 432);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 39;
            label6.Text = "CİNSİYET:";
            // 
            // TxtAra
            // 
            TxtAra.Location = new Point(58, 408);
            TxtAra.Name = "TxtAra";
            TxtAra.Size = new Size(149, 27);
            TxtAra.TabIndex = 41;
            // 
            // BtnAra
            // 
            BtnAra.BackColor = SystemColors.GradientInactiveCaption;
            BtnAra.FlatStyle = FlatStyle.Flat;
            BtnAra.Location = new Point(234, 406);
            BtnAra.Name = "BtnAra";
            BtnAra.Size = new Size(94, 29);
            BtnAra.TabIndex = 42;
            BtnAra.Text = "Ara";
            BtnAra.UseVisualStyleBackColor = false;
            BtnAra.Click += BtnAra_Click;
            // 
            // FrmOgrenci
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(726, 508);
            Controls.Add(BtnAra);
            Controls.Add(TxtAra);
            Controls.Add(label6);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(comboBox1);
            Controls.Add(TxtSoyad);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(BtnSil);
            Controls.Add(BtnEkle);
            Controls.Add(BtnGuncelle);
            Controls.Add(BtnListele);
            Controls.Add(TxtAd);
            Controls.Add(TxtID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmOgrenci";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmOgrenci";
            Load += FrmOgrenci_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BtnSil;
        private Button BtnEkle;
        private Button BtnGuncelle;
        private Button BtnListele;
        private TextBox TxtAd;
        private TextBox TxtID;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox TxtSoyad;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label6;
        private TextBox TxtAra;
        private Button BtnAra;
    }
}