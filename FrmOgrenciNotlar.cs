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
    public partial class FrmOgrenciNotlar : Form
    {
        public FrmOgrenciNotlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=.\\SQLEXPRESS;Database=BonusOkul;Trusted_Connection=True;TrustServerCertificate=True;");
        public string numara;
       
        private void FrmOgrenciNotlar_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select OGRAD + ' ' + OGRSOYAD FROM TBLOGRENCILER WHERE OGRID=@P1",baglanti);
            komut2.Parameters.AddWithValue("@P1",numara);
            SqlDataReader dr=komut2.ExecuteReader();
            while (dr.Read())
            {
                string adSoyad= dr[0].ToString();
                this.Text = adSoyad;
            }

            

            baglanti.Close();


          

            SqlCommand komut = new SqlCommand("SELECT DERSAD,SINAV1,SINAV2,SINAV3,PROJE,ORTALAMA,DURUM FROM TBLNOTLAR INNER JOIN TBLDERSLER ON TBLNOTLAR.DERSID=TBLNOTLAR.DERSID WHERE OGRID=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", numara);
            //this.Text = numara.ToString(); // formun sol üstündeki başlık yazısı this.text oluyor
            SqlDataAdapter da= new SqlDataAdapter(komut);
            DataTable dt=new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
