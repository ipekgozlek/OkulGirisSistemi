namespace BonusProje
{
    partial class FrmDersler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDersler));
            pictureBox1 = new PictureBox();
            BtnSil = new Button();
            BtnEkle = new Button();
            BtnGuncelle = new Button();
            BtnListele = new Button();
            TxtDersAd = new TextBox();
            TxtDersID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(497, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // BtnSil
            // 
            BtnSil.BackColor = SystemColors.GradientInactiveCaption;
            BtnSil.FlatStyle = FlatStyle.Flat;
            BtnSil.Location = new Point(248, 402);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(94, 29);
            BtnSil.TabIndex = 20;
            BtnSil.Text = "Sil";
            BtnSil.UseVisualStyleBackColor = false;
            BtnSil.Click += BtnSil_Click;
            // 
            // BtnEkle
            // 
            BtnEkle.BackColor = SystemColors.GradientInactiveCaption;
            BtnEkle.FlatStyle = FlatStyle.Flat;
            BtnEkle.Location = new Point(56, 402);
            BtnEkle.Name = "BtnEkle";
            BtnEkle.Size = new Size(94, 29);
            BtnEkle.TabIndex = 19;
            BtnEkle.Text = "Ekle";
            BtnEkle.UseVisualStyleBackColor = false;
            BtnEkle.Click += BtnEkle_Click;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.BackColor = SystemColors.GradientInactiveCaption;
            BtnGuncelle.FlatStyle = FlatStyle.Flat;
            BtnGuncelle.Location = new Point(248, 358);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(94, 29);
            BtnGuncelle.TabIndex = 18;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = false;
            BtnGuncelle.Click += BtnGuncelle_Click;
            // 
            // BtnListele
            // 
            BtnListele.BackColor = SystemColors.GradientInactiveCaption;
            BtnListele.FlatStyle = FlatStyle.Flat;
            BtnListele.Location = new Point(56, 358);
            BtnListele.Name = "BtnListele";
            BtnListele.Size = new Size(94, 29);
            BtnListele.TabIndex = 17;
            BtnListele.Text = "Listele";
            BtnListele.UseVisualStyleBackColor = false;
            BtnListele.Click += BtnListele_Click;
            // 
            // TxtDersAd
            // 
            TxtDersAd.Location = new Point(191, 306);
            TxtDersAd.Name = "TxtDersAd";
            TxtDersAd.Size = new Size(125, 27);
            TxtDersAd.TabIndex = 16;
            // 
            // TxtDersID
            // 
            TxtDersID.Enabled = false;
            TxtDersID.Location = new Point(191, 264);
            TxtDersID.Name = "TxtDersID";
            TxtDersID.Size = new Size(125, 27);
            TxtDersID.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(92, 306);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 14;
            label3.Text = "DERS ADI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(93, 271);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 13;
            label2.Text = "DERS ID";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(530, 188);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(168, 20);
            label1.TabIndex = 11;
            label1.Text = "DERS İŞLEMLERİ PANELİ";
            // 
            // FrmDersler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(549, 451);
            Controls.Add(pictureBox1);
            Controls.Add(BtnSil);
            Controls.Add(BtnEkle);
            Controls.Add(BtnGuncelle);
            Controls.Add(BtnListele);
            Controls.Add(TxtDersAd);
            Controls.Add(TxtDersID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmDersler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmDersler";
            Load += FrmDersler_Load;
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
        private TextBox TxtDersAd;
        private TextBox TxtDersID;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
    }
}