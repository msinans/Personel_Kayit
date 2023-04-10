using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Sql komutlarını kullanmak için bu kütüphaneyi ekliyoruz

namespace Personel_Kayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-K4R9NTU;Initial Catalog=PersonelVeriTabani;Integrated Security=True"); // Global alanda sınıftan bir nesne türetiyoruz ki komutlarımızı kullanabilelim

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel); // Bu kod DataGriedView sihirbazı ile birlikte otomatik gelir
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open(); // öncelikle bağlantı açılır
            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (perad, PerSoyad, PerSehir, PerMaas, PerMeslek) values (@p1, @p2, @p3, @p4, @p5)", baglanti); // SqlCommand sınıfından nesne türettik, sonra "" içine sorguyu yazdık, p1 ve p2 olarak iki parametre tanımladık ki aşağıda tanımladığımız textBox alanı ile sütun adları arasında geçiş yapalım
            komut.Parameters.AddWithValue("@p1", txtAd.Text); // txtAd dan gelen değeri p1 e ata
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbSehir.Text);
            komut.Parameters.AddWithValue("@p4", mskMaas.Text);
            komut.Parameters.AddWithValue("@p5", txtMeslek.Text);
            komut.ExecuteNonQuery(); // ExecuteNonQuery insert, update, delete gibi tabloda değişiklik yapan komutlarda kullanılır. Sorguyu çalıştırır.
            baglanti.Close();
            MessageBox.Show("Personel Eklendi!");

        }
    }
}
