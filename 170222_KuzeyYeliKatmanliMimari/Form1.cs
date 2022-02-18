using KuzeyYeliEntity;
using KuzeyYeliORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _170222_KuzeyYeliKatmanliMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Urunler.listele();
            cmbKategoriler.DataSource = Kategoriler.listele();
            cmbKategoriler.DisplayMember = "KategoriAdi";
            cmbKategoriler.DisplayMember = "KategoriID";

            cmbTedarikciler.DataSource =Tedarikciler.listele();
            cmbTedarikciler.DisplayMember = "SirketAdi";
            cmbTedarikciler.ValueMember = "TedarikciID";
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            Kategori k = new Kategori();
            k.Show();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Urun u = new Urun();
            u.UrunAdi = txtUrunAd.Text;
            u.Stok = (int)nudStok.Value;
            u.Fiyat = nudFiyat.Value;
            u.KategoriID = (int)cmbKategoriler.SelectedValue;
            u.TedarikciID = (int)cmbTedarikciler.SelectedValue;
            bool sonuc = Urunler.Ekle(u);
            if (sonuc)
            {      
                MessageBox.Show("Kayıt başarılı bir şekilde eklendi.");
                dataGridView1.DataSource = Urunler.listele();
            }
         
            else
                MessageBox.Show("Kayıt eklenirken hata oluştu.");


        }
    }
}
