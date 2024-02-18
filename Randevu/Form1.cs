using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Randevu randevu;

        List<Randevu> randevuListesi=new List<Randevu>();

        private void Form1_Load(object sender, EventArgs e)
        {
            randevuListesi.Add(new Randevu(1, "Medine Kanat", "05327894125", "Kardiyoloji", new DateTime(2023, 12, 18), true));
            randevuListesi.Add(new Randevu(2, "Dilan Kaya", "05329825467", "Ağız ve Diş Sağlığı", new DateTime(2023, 12, 20), false));
            randevuListesi.Add(new Randevu(3, "Hiranur Kulakçı", "05359871200", "Endokrinoloji", new DateTime(2024, 1, 12), true));
            randevuListesi.Add(new Randevu(4, "Sedef Şirin", "05057841214", "Cildiye", new DateTime(2023, 12, 27), true));
            randevuListesi.Add(new Randevu(5, "Elif Torun", "05414143298", "Ortopedi", new DateTime(2023, 12, 20), true));
            randevuListesi.Add(new Randevu(6, "Meryem Ertaş", "05055662211", "Kardiyoloji", new DateTime(2023, 12, 23), false));


            dgvListe.DataSource = randevuListesi.ToList();

        }

        private void dgvListe_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvListe.CurrentRow.Cells["id"].Value.ToString();
            txtAdSoyad.Text = dgvListe.CurrentRow.Cells["adSoyad"].Value.ToString();
            txtTelefon.Text = dgvListe.CurrentRow.Cells["telefon"].Value.ToString();
            cmbPoliklinik.Text = dgvListe.CurrentRow.Cells["poliklinik"].Value.ToString();
            dtpTarih.Value = (DateTime)dgvListe.CurrentRow.Cells["tarih"].Value;
            chkSigorta.Checked = (bool)dgvListe.CurrentRow.Cells["sigorta"].Value;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(txtId.Text);
            string adsoyad = txtAdSoyad.Text;
            string telefon=txtTelefon.Text;
            string poliklinik = cmbPoliklinik.Text;
            DateTime tarih=dtpTarih.Value;
            bool sigorta=chkSigorta.Checked;

            Randevu yeniRandevu=new Randevu(id, adsoyad, telefon, poliklinik, tarih, sigorta);

            randevuListesi.Add(yeniRandevu);
            dgvListe.DataSource = randevuListesi.ToList();


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilenSatir = dgvListe.SelectedRows[0];

            Randevu secilenRandevu=secilenSatir.DataBoundItem as Randevu;
            
            

            DialogResult result= MessageBox.Show("Seçilen randevu silinsin mi?","Randevu Sil",MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                randevuListesi.Remove(secilenRandevu);
            }

            dgvListe.DataSource = randevuListesi.ToList();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilenSatir = dgvListe.SelectedRows[0];

            Randevu secilenRandevu = secilenSatir.DataBoundItem as Randevu;

            int id = Convert.ToInt32(txtId.Text);
            string adsoyad = txtAdSoyad.Text;
            string telefon = txtTelefon.Text;
            string poliklinik = cmbPoliklinik.Text;
            DateTime tarih = dtpTarih.Value;
            bool sigorta = chkSigorta.Checked;

            secilenRandevu.Id = id;
            secilenRandevu.AdSoyad = adsoyad;
            secilenRandevu.Telefon = telefon;
            secilenRandevu.Poliklinik = poliklinik;
            secilenRandevu.Tarih = tarih;
            secilenRandevu.Sigorta = sigorta;

            dgvListe.DataSource = null;
            dgvListe.DataSource=randevuListesi.ToList();


        }


    }
}
