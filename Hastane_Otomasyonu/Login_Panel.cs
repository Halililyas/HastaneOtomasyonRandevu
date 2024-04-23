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
    public  partial class Login_Panel : Form
    {
        //int sayi = 0;
        public Login_Panel()
        {
            InitializeComponent();
          
        }

        private async void btnGiris_Click(object sender, EventArgs e)
        {
            //sayi += 1;
            //MessageBox.Show($"Sayi:{sayi}","Sayının Değeri"); //Ekranda ufak bir pencerede uyarı göstermek için kullanılır.
            Kilit_Kapali.Hide();



            
            //Simgenin görünmeme sorunun çöz.





            Menu_Panel menu = new Menu_Panel();

            
           
            this.Hide();
            
            menu.Show();
           


            
        }

        private void Login_Panel_Load(object sender, EventArgs e)
        {
            Kilit_Acik.Hide();
        }
        
    }
}
