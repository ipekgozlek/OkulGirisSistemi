using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace BonusProje
{
    public partial class FrmKulup : Form
    {
        public FrmKulup()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=.\\SQLEXPRESS;Database=BonusOkul;Trusted_Connection=True;TrustServerCertificate=True;");

        private void Ekle_Click_1(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO TBLKULUPLER (KULUPAD) VALUES (@P1)", baglanti);
            komut.Parameters.AddWithValue("@P1", TxtKulupAd.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kulüp listeye eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Liste();



        }

        void Liste()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLKULUPLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void FrmKulup_Load(object sender, EventArgs e)
        {
            Liste();

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            Liste();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.LightYellow;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtKulupID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            // datagrid in rows satırları içinde bunun e. satır indeksini al 0. hücredeki değerleri textbox ımıza yazdır
            TxtKulupAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();


        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from TBLKULUPLER where KULUPID=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", TxtKulupID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kulüp silme işlemi gerçekleşti");
            Liste();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLKULUPLER SET KULUPAD=@P1 WHERE KULUPID=@P2",baglanti);
            komut.Parameters.AddWithValue("@P1",TxtKulupAd.Text);
            komut.Parameters.AddWithValue("@P2",TxtKulupID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kulüp güncelleme işlemi gerçekleşti");
            Liste();
        }
    }
}
