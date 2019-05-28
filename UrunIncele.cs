using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EKAKozmetik.Model;

namespace EKAKozmetik
{
    public partial class UrunIncele : Form
    {
        Helper helper = new Helper();
        Uye uye = new Uye();
        DataTable tablo = new DataTable();
        List<string> urunSepet = new List<string>();
        public static int toplamAdet;
        public static int toplamFiyat;


        public UrunIncele()
        {
            InitializeComponent();
            ktgAdiLbl.ForeColor = Color.FromArgb(33, 133, 199);
            urunFiyatLbl1.ForeColor = Color.FromArgb(33, 133, 199);
            urunFiyatLbl2.ForeColor = Color.FromArgb(33, 133, 199);
            urunFiyatLbl3.ForeColor = Color.FromArgb(33, 133, 199);

            tablo.Columns.Add("Isim");
            tablo.Columns.Add("Fiyat");
            tablo.Columns.Add("Adet");
            tablo.Columns.Add("Stok");
        }

        private void sptEkleBtn_Click(object sender, EventArgs e)
        {
            SepeteEkle(urunIsimLbl1.Text, urunFiyatLbl1.Text, idLbl1.Text);
        }

        public void SepeteEkle(string text, string text2, string text3)
        {
            if (tablo.Rows.Count == 0)
            {
                DataRow row = tablo.NewRow();
                row["Isim"] = text;
                row["Fiyat"] = text2;
                row["Adet"] = "1";
                row["Stok"] = text3;
                tablo.Rows.Add(row);
                dataGridSepet.DataSource = tablo;
                urunSepet.Add(row["Isim"].ToString());
            }
            else
            {
                for (int i = 0; i < tablo.Rows.Count; i++)
                {
                    if (!urunSepet.Contains(text))
                    {
                        DataRow row = tablo.NewRow();
                        row["Isim"] = text;
                        row["Fiyat"] = text2;
                        row["Adet"] = "1";
                        row["Stok"] = text3;
                        tablo.Rows.Add(row);
                        dataGridSepet.DataSource = tablo;
                        urunSepet.Add(row["Isim"].ToString());
                    }
                }
            }
        }

        public void addData(int id)
        {
            markaDataGrid.DataSource = helper.GetListMarkaIsim(id);
            for (int i = 0; i < markaDataGrid.Columns.Count; i++)
            {
                if (i == 1)
                    continue;
                else
                    markaDataGrid.Columns[i].Visible = false;
            }
        }

        private void markaDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int markaID = Convert.ToInt32(markaDataGrid.Rows[markaDataGrid.CurrentRow.Index].Cells["MarkaID"].Value);

                var adet = helper.GetListUrunByMarka(markaID, "Adet");
                idLbl1.Text = adet[0].ToString();
                idLbl2.Text = adet[1].ToString();
                idLbl3.Text = adet[2].ToString();

                var isimler = helper.GetListUrunByMarka(markaID, "Isim");
                urunIsimLbl1.Text = isimler[0].ToString();
                urunIsimLbl2.Text = isimler[1].ToString();
                urunIsimLbl3.Text = isimler[2].ToString();

                var fiyat = helper.GetListUrunByMarka(markaID, "Fiyat");
                urunFiyatLbl1.Text = fiyat[0].ToString();
                urunFiyatLbl2.Text = fiyat[1].ToString();
                urunFiyatLbl3.Text = fiyat[2].ToString();
            }
            catch (Exception)
            {

            }
        }

        private void sptEkleBtn2_Click(object sender, EventArgs e)
        {
            SepeteEkle(urunIsimLbl2.Text, urunFiyatLbl2.Text, idLbl2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int alinanAdet = Convert.ToInt32(dataGridSepet.Rows[dataGridSepet.CurrentRow.Index].Cells["Adet"].Value);
            if (alinanAdet > 0)
            {
                alinanAdet--;
            }

            dataGridSepet.Rows[dataGridSepet.CurrentRow.Index].Cells["Adet"].Value = alinanAdet.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int stok = Convert.ToInt32(dataGridSepet.Rows[dataGridSepet.CurrentRow.Index].Cells["Stok"].Value);
            int alinanAdet = Convert.ToInt32(dataGridSepet.Rows[dataGridSepet.CurrentRow.Index].Cells["Adet"].Value);

            if (alinanAdet < stok)
            {
                alinanAdet++;
            }
            dataGridSepet.Rows[dataGridSepet.CurrentRow.Index].Cells["Adet"].Value = alinanAdet.ToString();
        }

        private void sptEkleBtn3_Click(object sender, EventArgs e)
        {
            SepeteEkle(urunIsimLbl3.Text, urunFiyatLbl3.Text, idLbl3.Text);
        }

        private void alsVrsTamamlaBtn_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            Odeme odeme = new Odeme();
            UyeLogin uyeLogin = new UyeLogin();

            if (Convert.ToInt32(UyeLogin.uyeBilgi[0]) == 0)
            {
                this.Visible = false;
                uyeLogin.Top = 170;
                uyeLogin.TopLevel = false;
                uyeLogin.Show();
                this.Controls.Add(uyeLogin);
            }
            else
            {
                odeme.Top = 170;
                odeme.TopLevel = false;
                odeme.Show();
                anaSayfa.Controls.Add(odeme);
                anaSayfa.Show();
                string id = null;
                var data = helper.GetListUyeById(Convert.ToInt32(UyeLogin.uyeBilgi[0]));
                foreach (var item in data)
                {
                    bool result = helper.UpdateUye(item.ID, item.Isim, item.Soyisim, item.Telefon, item.Mail, item.Sifre, item.Adres, "5");
                    if (result == true)
                    {
                        odeme.LabelDegistir(item.Isim, item.Soyisim, item.Sifre, item.Telefon, item.Mail, item.Adres);
                        ((Label)anaSayfa.Controls["uyeOlLbl"]).Text = item.Isim + " " + item.Soyisim;
                        ((Label)anaSayfa.Controls["uyeLoginLbl"]).Text = "Hoşgeldiniz";
                        id = item.ID.ToString();
                    }
                    else
                    {
                        MessageBox.Show("İşlem başarısız.");
                    }
                }
                for (int i = 0; i < tablo.Rows.Count; i++)
                {
                    toplamAdet += Convert.ToInt32(tablo.Rows[i]["Adet"]);
                    int a = Convert.ToInt32(tablo.Rows[i]["Adet"]) * Convert.ToInt32(tablo.Rows[i]["Fiyat"]);
                    toplamFiyat += a;
                }
                odeme.veriGonder(toplamAdet.ToString(), toplamFiyat.ToString());
            }
        }
    }
}
