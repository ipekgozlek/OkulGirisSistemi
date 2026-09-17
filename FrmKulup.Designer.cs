namespace BonusProje
{
    partial class FrmKulup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKulup));
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            TxtKulupID = new TextBox();
            TxtKulupAd = new TextBox();
            BtnListele = new Button();
            BtnGuncelle = new Button();
            Ekle = new Button();
            BtnSil = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(176, 20);
            label1.TabIndex = 0;
            label1.Text = "KULÜP İŞLEMLERİ PANELİ";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(530, 188);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 253);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 2;
            label2.Text = "KULÜP ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(140, 288);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 3;
            label3.Text = "KULÜP ADI";
            // 
            // TxtKulupID
            // 
            TxtKulupID.Enabled = false;
            TxtKulupID.Location = new Point(239, 246);
            TxtKulupID.Name = "TxtKulupID";
            TxtKulupID.Size = new Size(125, 27);
            TxtKulupID.TabIndex = 4;
            // 
            // TxtKulupAd
            // 
            TxtKulupAd.Location = new Point(239, 288);
            TxtKulupAd.Name = "TxtKulupAd";
            TxtKulupAd.Size = new Size(125, 27);
            TxtKulupAd.TabIndex = 5;
            // 
            // BtnListele
            // 
            BtnListele.BackColor = SystemColors.GradientInactiveCaption;
            BtnListele.FlatStyle = FlatStyle.Flat;
            BtnListele.Location = new Point(104, 340);
            BtnListele.Name = "BtnListele";
            BtnListele.Size = new Size(94, 29);
            BtnListele.TabIndex = 6;
            BtnListele.Text = "Listele";
            BtnListele.UseVisualStyleBackColor = false;
            BtnListele.Click += BtnListele_Click;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.BackColor = SystemColors.GradientInactiveCaption;
            BtnGuncelle.FlatStyle = FlatStyle.Flat;
            BtnGuncelle.Location = new Point(296, 340);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(94, 29);
            BtnGuncelle.TabIndex = 7;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = false;
            BtnGuncelle.Click += BtnGuncelle_Click;
            // 
            // Ekle
            // 
            Ekle.BackColor = SystemColors.GradientInactiveCaption;
            Ekle.FlatStyle = FlatStyle.Flat;
            Ekle.Location = new Point(104, 384);
            Ekle.Name = "Ekle";
            Ekle.Size = new Size(94, 29);
            Ekle.TabIndex = 8;
            Ekle.Text = "Ekle";
            Ekle.UseVisualStyleBackColor = false;
            Ekle.Click += Ekle_Click_1;
            // 
            // BtnSil
            // 
            BtnSil.BackColor = SystemColors.GradientInactiveCaption;
            BtnSil.FlatStyle = FlatStyle.Flat;
            BtnSil.Location = new Point(296, 384);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(94, 29);
            BtnSil.TabIndex = 9;
            BtnSil.Text = "Sil";
            BtnSil.UseVisualStyleBackColor = false;
            BtnSil.Click += BtnSil_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(545, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
            pictureBox1.MouseHover += pictureBox1_MouseHover;
            // 
            // FrmKulup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(589, 425);
            Controls.Add(pictureBox1);
            Controls.Add(BtnSil);
            Controls.Add(Ekle);
            Controls.Add(BtnGuncelle);
            Controls.Add(BtnListele);
            Controls.Add(TxtKulupAd);
            Controls.Add(TxtKulupID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmKulup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmKulup";
            Load += FrmKulup_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private TextBox TxtKulupID;
        private TextBox TxtKulupAd;
        private Button BtnListele;
        private Button BtnGuncelle;
        private Button Ekle;
        private Button BtnSil;
        private PictureBox pictureBox1;
    }
}