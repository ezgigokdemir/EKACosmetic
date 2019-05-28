using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EKAKozmetik.Model;

namespace EKAKozmetik
{
    public partial class UyeLogin : Form
    {
        Uye uye = new Uye();
        YeniUye yeniUye = new YeniUye();
        Odeme odeme = new Odeme();
        public static string[] uyeBilgi = new string[2];

        public UyeLogin()
        {
            InitializeComponent();
            girisBtn.BackColor = Color.FromArgb(33, 133, 199);
        }

        private void girisBtn_Click(object sender, EventArgs e)
        {
            IdGetir();
        }

        public void IdGetir()
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            Helper helper = new Helper();
            var data = helper.GetListAllUye();
            foreach (var item in data)
            {
                if (mailGirisTxt.Text == item.Mail && sifreGirisTxt.Text == item.Sifre)
                {
                    uye.ID = item.ID;
                    anaSayfa.LabelDegistir(item.Isim + " " + item.Soyisim, "Hoşgeldiniz", item.ID.ToString());
                    ((Label)anaSayfa.Controls["cikislbl"]).Visible = true;
                    uyeBilgi[0] = item.ID.ToString();
                    uyeBilgi[1] = sifreGirisTxt.Text;
                    this.Visible = false;
                }
            }
        }
    }
}
