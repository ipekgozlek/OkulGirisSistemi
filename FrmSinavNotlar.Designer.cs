namespace BonusProje
{
    partial class FrmSinavNotlar
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
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            TxtSinav1 = new TextBox();
            label5 = new Label();
            TxtID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            TxtSinav2 = new TextBox();
            label1 = new Label();
            TxtSinav3 = new TextBox();
            label4 = new Label();
            TxtProje = new TextBox();
            label6 = new Label();
            TxtOrtalama = new TextBox();
            label7 = new Label();
            TxtDurum = new TextBox();
            label8 = new Label();
            BtnHesapla = new Button();
            BtnGuncelle = new Button();
            BtnTemizle = new Button();
            BtnAra = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 210);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(798, 242);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(137, 53);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 28);
            comboBox1.TabIndex = 47;
            // 
            // TxtSinav1
            // 
            TxtSinav1.Enabled = false;
            TxtSinav1.Location = new Point(137, 91);
            TxtSinav1.Name = "TxtSinav1";
            TxtSinav1.Size = new Size(125, 27);
            TxtSinav1.TabIndex = 46;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(47, 94);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 44;
            label5.Text = "SINAV 1:";
            // 
            // TxtID
            // 
            TxtID.Location = new Point(137, 11);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(125, 27);
            TxtID.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(64, 53);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 41;
            label3.Text = "DERS:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(19, 18);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 40;
            label2.Text = "OGRENCI ID:";
            // 
            // TxtSinav2
            // 
            TxtSinav2.Enabled = false;
            TxtSinav2.Location = new Point(137, 137);
            TxtSinav2.Name = "TxtSinav2";
            TxtSinav2.Size = new Size(125, 27);
            TxtSinav2.TabIndex = 49;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(47, 139);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 48;
            label1.Text = "SINAV 2:";
            // 
            // TxtSinav3
            // 
            TxtSinav3.Enabled = false;
            TxtSinav3.Location = new Point(137, 177);
            TxtSinav3.Name = "TxtSinav3";
            TxtSinav3.Size = new Size(125, 27);
            TxtSinav3.TabIndex = 51;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(47, 176);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 50;
            label4.Text = "SINAV 3:";
            // 
            // TxtProje
            // 
            TxtProje.Enabled = false;
            TxtProje.Location = new Point(392, 14);
            TxtProje.Name = "TxtProje";
            TxtProje.Size = new Size(125, 27);
            TxtProje.TabIndex = 53;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(318, 14);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 52;
            label6.Text = "PROJE:";
            // 
            // TxtOrtalama
            // 
            TxtOrtalama.Enabled = false;
            TxtOrtalama.Location = new Point(392, 56);
            TxtOrtalama.Name = "TxtOrtalama";
            TxtOrtalama.Size = new Size(125, 27);
            TxtOrtalama.TabIndex = 55;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(283, 56);
            label7.Name = "label7";
            label7.Size = new Size(88, 20);
            label7.TabIndex = 54;
            label7.Text = "ORTALAMA:";
            // 
            // TxtDurum
            // 
            TxtDurum.Enabled = false;
            TxtDurum.Location = new Point(392, 104);
            TxtDurum.Name = "TxtDurum";
            TxtDurum.Size = new Size(125, 27);
            TxtDurum.TabIndex = 57;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(306, 104);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 56;
            label8.Text = "DURUM:";
            // 
            // BtnHesapla
            // 
            BtnHesapla.Location = new Point(644, 30);
            BtnHesapla.Name = "BtnHesapla";
            BtnHesapla.Size = new Size(94, 29);
            BtnHesapla.TabIndex = 58;
            BtnHesapla.Text = "HESAPLA";
            BtnHesapla.UseVisualStyleBackColor = true;
            BtnHesapla.Click += BtnHesapla_Click;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.Location = new Point(644, 65);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(94, 29);
            BtnGuncelle.TabIndex = 59;
            BtnGuncelle.Text = "GÜNCELLE";
            BtnGuncelle.UseVisualStyleBackColor = true;
            BtnGuncelle.Click += BtnGuncelle_Click;
            // 
            // BtnTemizle
            // 
            BtnTemizle.Location = new Point(644, 104);
            BtnTemizle.Name = "BtnTemizle";
            BtnTemizle.Size = new Size(94, 29);
            BtnTemizle.TabIndex = 60;
            BtnTemizle.Text = "TEMİZLE";
            BtnTemizle.UseVisualStyleBackColor = true;
            // 
            // BtnAra
            // 
            BtnAra.Location = new Point(644, 139);
            BtnAra.Name = "BtnAra";
            BtnAra.Size = new Size(94, 29);
            BtnAra.TabIndex = 61;
            BtnAra.Text = "ARA";
            BtnAra.UseVisualStyleBackColor = true;
            BtnAra.Click += BtnAra_Click;
            // 
            // FrmSinavNotlar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnAra);
            Controls.Add(BtnTemizle);
            Controls.Add(BtnGuncelle);
            Controls.Add(BtnHesapla);
            Controls.Add(TxtDurum);
            Controls.Add(label8);
            Controls.Add(TxtOrtalama);
            Controls.Add(label7);
            Controls.Add(TxtProje);
            Controls.Add(label6);
            Controls.Add(TxtSinav3);
            Controls.Add(label4);
            Controls.Add(TxtSinav2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(TxtSinav1);
            Controls.Add(label5);
            Controls.Add(TxtID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSinavNotlar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSinavNotlar";
            Load += FrmSinavNotlar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private TextBox TxtSinav1;
        private Label label5;
        private TextBox TxtID;
        private Label label3;
        private Label label2;
        private TextBox TxtSinav2;
        private Label label1;
        private TextBox TxtSinav3;
        private Label label4;
        private TextBox TxtProje;
        private Label label6;
        private TextBox TxtOrtalama;
        private Label label7;
        private TextBox TxtDurum;
        private Label label8;
        private Button BtnHesapla;
        private Button BtnGuncelle;
        private Button BtnTemizle;
        private Button BtnAra;
    }
}