using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EKAKozmetik
{
    public partial class Admin : Form
    {
        public static string manager = ConfigurationManager.ConnectionStrings["ekaConnection"].ConnectionString;
        Helper helper = new Helper();
        
              public Admin()
        {
            InitializeComponent();
        }
        private string dosyayolu;
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void burunler_Click(object sender, EventArgs e)
        {
             dataGridView2.DataSource = helper.GetListAllUrun();
             groupBox3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = helper.GetListAllSiparis();
            groupBox3.Visible = false;
            groupBox1.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            dosyayolu = dosya.FileName.ToString();
            //txtresim.Text = dosyayolu;
            pictureBox1.ImageLocation = dosyayolu;
        }

        private void burunekle_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(dosyayolu, FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fs);

            byte[] resimm = br.ReadBytes((int)fs.Length);
            string resim = Convert.ToBase64String(resimm);
            txtresim.Text = resim;
            br.Close();

            fs.Close();

            Helper H = new Helper();
            double fiyat = Convert.ToDouble(tfiyat.Text);
            int adet = Convert.ToInt32(tadet.Text);
            bool sonuc = H.AddUrun(tisim.Text, fiyat, adet, resim, Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(comboBox1.SelectedValue), tbarkotno.Text);
            if (sonuc == true)
            {
                MessageBox.Show("İşlem Başarılı");
                dataGridView2.DataSource = H.GetListAllUrun();
                tisim.Text = "";
                tadet.Text = "";
                tfiyat.Text = "";
                tbarkotno.Text = "";
                txtresim.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
            }
            else
            {
                MessageBox.Show("İşlem Başarısız");
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eKADatabaseDataSet1.Kategori' table. You can move, or remove it, as needed.
            this.kategoriTableAdapter.Fill(this.eKADatabaseDataSet1.Kategori);
            // TODO: This line of code loads data into the 'eKADatabaseDataSet.Marka' table. You can move, or remove it, as needed.
            this.markaTableAdapter.Fill(this.eKADatabaseDataSet.Marka);
            groupBox1.Visible = false;
            groupBox3.Visible = false;
        }

        
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void burunguncelle_Click(object sender, EventArgs e)
        {
           
            if (dataGridView2.SelectedRows.Count == 1)
            {                                                            
               
                double fiyat = Convert.ToDouble(tfiyat.Text);
                int adet = Convert.ToInt32(tadet.Text);
                FileStream fs = new FileStream(dosyayolu, FileMode.Open, FileAccess.Read);

                BinaryReader br = new BinaryReader(fs);

                byte[] resimm = br.ReadBytes((int)fs.Length);
                string resim = Convert.ToBase64String(resimm);
                txtresim.Text = resim;
                br.Close();
                fs.Close();



                int UrunID = Convert.ToInt32(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value);
                Helper H = new Helper();
                bool sonuc = H.UpdateUrun(UrunID,tisim.Text,fiyat,adet, resim, Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(comboBox1.SelectedValue), tbarkotno.Text);
                    if (sonuc == true)
                  {
                       MessageBox.Show("Güncelleme işlemi gerçekleşti");
                       dataGridView2.DataSource = H.GetListAllUrun();
                    tisim.Text = "";
                    tadet.Text = "";
                    tfiyat.Text = "";
                    tbarkotno.Text = "";
                    txtresim.Text = "";
                    comboBox1.Text = "";
                    comboBox2.Text = "";

                }
                  else
                    {
                       MessageBox.Show("Güncelleme işlemi gerçekleştirilemedi !!");
                   }
                }
            }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                 tisim.Text = dataGridView2.SelectedRows[0].Cells["Isim"].Value.ToString();
                 string secim = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[7].Value.ToString();
                 comboBox1.SelectedValue = secim;
                 tfiyat.Text = dataGridView2.SelectedRows[0].Cells["Fiyat"].Value.ToString();
                 txtresim.Text = dataGridView2.SelectedRows[0].Cells["UrunFoto"].Value.ToString();
                 string secim1 = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[6].Value.ToString();
                 comboBox2.SelectedValue = secim1;
                 tbarkotno.Text = dataGridView2.SelectedRows[0].Cells["BarkodNo"].Value.ToString();
                 tadet.Text = dataGridView2.SelectedRows[0].Cells["Adet"].Value.ToString();
             }
        }

        private void bsil_Click(object sender, EventArgs e)
        {

            if (dataGridView2.SelectedRows.Count == 1)
            {
                int UrunID = Convert.ToInt32(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value);
                Helper H = new Helper();
                bool sonuc = H.Delete(UrunID);
                if (sonuc == true)
                {
                    MessageBox.Show("Silme işlemi gerçekleşti");
                    dataGridView2.DataSource = H.GetListAllUrun();
                }
                else
                {
                    MessageBox.Show("Silme işlemi gerçekleştiremedi");
                }
            }
        }

        private void tfiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tadet_TextChanged(object sender, EventArgs e)
        {

        }

        private void tadet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void bkargoguncelle_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = helper.GetListAllUye();
            groupBox1.Visible = false;
            groupBox3.Visible = false;
        }

        private void tfiyat_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(tfiyat.Text) <= 0 )
                {
                    MessageBox.Show("Ürün Fiyatı 0 dan büyük olmalı");
                    tfiyat.Text = "";
                    tfiyat.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Ürün Fiyatı boş geçilemez,Lütfen sayısal bir değer girin");
                tfiyat.Text = "";
                tfiyat.Focus();
            }
        }

        private void tadet_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(tadet.Text) <= 0)
                {
                    MessageBox.Show("Ürün Adeti 0'dan büyük bir değer olmalı");
                    tadet.Text = "";
                    tadet.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Ürün Fiyatı boş geçilemez,Lütfen sayısal bir değer girin");
                tadet.Text = "";
                tadet.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string text = textBox2.Text.ToString();
            //dataGridView2.DataSource = helper.SelectUrun(text);
        }

        private void bkargoguncel_Click(object sender, EventArgs e)
        {
            Helper H = new Helper();
            int SprID = Convert.ToInt32(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value);
            bool sonuc = H.UpdateSiparisKargo(SprID,ckargodurumu.Text);
            if (sonuc == true)
            {
                MessageBox.Show("Kargo Durumunda Güncelleme işlemi gerçekleşti");
                dataGridView2.DataSource = H.GetListAllSiparis();
               

            }
            else
            {
                MessageBox.Show("Kargo Durumu Güncelleme işlemi gerçekleştirilemedi !!");
            }
        }
    }
        
    }

