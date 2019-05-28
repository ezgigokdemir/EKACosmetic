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
    public partial class AdminLogin : Form
    {
        Admin admin = new Admin();

        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (adminIsimTxt.Text =="admin" && sifreIsimTxt.Text=="123")
            {
                 admin.Show();
                
            }
            else
            {
                MessageBox.Show("Bilgiler hatalı.");
            }
        }
    }
}
