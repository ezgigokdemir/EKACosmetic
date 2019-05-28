using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EKAKozmetik
{
    public partial class YeniUye : Form
    {
        Helper helper = new Helper();

        public YeniUye()
        {
            InitializeComponent();
            kayitBtn.BackColor = Color.FromArgb(33, 133, 199);
        }

        private void kayitBtn_Click(object sender, EventArgs e)
        {
            if (isimEkleTxt.Text == "" || soyisimEkleTxt.Text == "" || tlfnEkleMTxt.Text == "" || mailEkleTxt.Text == "" || sifreEkleTxt.Text == "" || adresEkleRTxt.Text == "")
            {
                MessageBox.Show("Tüm bilgileri eksiksiz giriniz.");
            }
            else
            {
                helper.AddUye(isimEkleTxt.Text, soyisimEkleTxt.Text, tlfnEkleMTxt.Text, mailEkleTxt.Text, sifreEkleTxt.Text, adresEkleRTxt.Text);
                MessageBox.Show("Kayıt başarılı bir şekilde yapıldı.");
            }
        }
    }
}
