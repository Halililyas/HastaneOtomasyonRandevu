using Hastane_Otomasyonu.Metotlar;
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

namespace Hastane_Otomasyonu
{
    public partial class Randevu_Panel : Form
    {
        /*
         "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;"
         
        Server=myServerAddress => Server ismi.102-26\\SQLDERS gibi
        Database=myDataBase => üzerinde çalışılcak veri tabanı adı. HastaneDB gibi
        User Id=myUsername => veri tabanı kurulumu sırasında otomatik olarakv verilen ve en yetkili kişi olan SA olacak.
        Password=1; => kurulumö yapılırken belirlenen şifre
         
         //SqlConnection connection = new SqlConnection(connectionString); //Sqlconnection sınıfından instance almış olduk.(Nesne türettik.)

            //try
            //{
            //    connection.Open();
            //    MessageBox.Show($"{connection.State} Bağlantı başarılı");
            //}
            //catch(SqlException ex)
            //{
            //    MessageBox.Show($"{ex}");
            //}
         */
       
        Randevu_Islemleri ri = new Randevu_Islemleri();
        Klinik_Islemleri ki = new Klinik_Islemleri();
        Doktor_Islemleri di = new Doktor_Islemleri();
        public Randevu_Panel()
        {
            InitializeComponent();
        }

        private void Randevu_Panel_Load(object sender, EventArgs e)
        {
            di.DoktorListele(cmbDoktor);
            ki.KlinikListele(cmbKlinik);
            ri.Listeleme(dgRandevular);


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {






        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string hastaad = txtAd.Text;

            DateTime randevutarihi = dtRandevuTarihi.Value;

            ri.Ekle(hastaad,randevutarihi);
            ri.Listeleme(dgRandevular);



        }
        public void Listele()
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            ri.RandevuSilme(id);
            ri.Listeleme(dgRandevular);
        }

        private void txtSikayet_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
