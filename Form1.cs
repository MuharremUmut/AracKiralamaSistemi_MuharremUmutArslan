using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AracKiralama
{
    public partial class Form1 : Form
    {
        private List<string> AracListesi = new List<string>();
        private List<string> MusteriListesi = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAracBilgisi.Text))
            {
                AracListesi.Add(txtAracBilgisi.Text);
                lstAraclar.Items.Add(txtAracBilgisi.Text);
                txtAracBilgisi.Clear();
                MessageBox.Show("Araç eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Araç bilgisi boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMusteriBilgisi.Text))
            {
                MusteriListesi.Add(txtMusteriBilgisi.Text);
                lstMusteriler.Items.Add(txtMusteriBilgisi.Text);
                txtMusteriBilgisi.Clear();
                MessageBox.Show("Müşteri eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Müşteri bilgisi boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKirala_Click(object sender, EventArgs e)
        {
            if (lstAraclar.SelectedItem != null && lstMusteriler.SelectedItem != null)
            {
                string secilenArac = lstAraclar.SelectedItem.ToString();
                string secilenMusteri = lstMusteriler.SelectedItem.ToString();

                MessageBox.Show($"{secilenMusteri}, {secilenArac} aracını kiraladı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lstAraclar.Items.Remove(secilenArac);
                AracListesi.Remove(secilenArac);
            }
            else
            {
                MessageBox.Show("Lütfen bir araç ve bir müşteri seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
