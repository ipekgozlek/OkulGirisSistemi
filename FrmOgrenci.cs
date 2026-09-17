using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace BonusProje
{
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        SqlConnection baglanti = new SqlConnection("Server=.\\SQLEXPRESS;Database=BonusOkul;Trusted_Connection=True;TrustServerCertificate=True;");

        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();

        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from TBLKULUPLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "KULUPAD";
            comboBox1.ValueMember = "KULUPID";
            comboBox1.DataSource = dt;
            baglanti.Close();



        }
        string c = "";
        private void BtnEkle_Click(object sender, EventArgs e)
        {


            if (comboBox1.Text == "")
            {
                MessageBox.Show("Lütfen sınıf seçiniz.");
                return;
            }

            ds.OgrenciEkle(TxtAd.Text, TxtSoyad.Text, byte.Parse(comboBox1.SelectedValue.ToString()), c);
            MessageBox.Show("Öğrenci ekleme yapıldı");
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            ds.OgrenciSil(int.Parse(TxtID.Text));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() == "Kız")
            {
                radioButton1.Checked = true;
            }

            if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() == "Erkek")
            {
                radioButton2.Checked = true;
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            ds.OgrenciGuncelle(TxtAd.Text, TxtSoyad.Text, byte.Parse(comboBox1.SelectedValue.ToString()), c, int.Parse(TxtID.Text));

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                c = "Kız";
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton2.Checked == true)
            {
                c = "Erkek";
            }
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource =  ds.OgrenciGetir(TxtAra.Text);
        }
    }
}
