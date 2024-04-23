using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyonu
{
    public partial class Menu_Panel : Form
    {
        public Menu_Panel()
        {
            InitializeComponent();
        }

        private void Menu_Panel_Load(object sender, EventArgs e)
        {
       
         
          
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Panel login = new Login_Panel();
            login.Show();
        }

        private void RandevuBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Randevu_Panel randevu = new Randevu_Panel();
            randevu.Show();
        }
    }
}
