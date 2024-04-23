using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Deployment.Internal;

namespace Hastane_Otomasyonu.Metotlar
{
    public class Randevu_Islemleri
    {
        string connectionString = "Server = LAPTOP-CI2TQ0HV\\HALIL; Database = HastahaneDB; Uid = sa; Password =sanane123; TrustServerCertificate = True;";

        public void Listeleme(DataGridView dataGridView)
        {
            

            SqlConnection connection = new SqlConnection(connectionString); // Burda Bağlantı Cümlecini Yollamış olduk 
            connection.Open();

            string query = "Select * from Randevular"; //Tablodaki bütün sütunları getirmesi için * ifadesi kullanılıyor.

            DataTable dataTable = new DataTable();// Sql den gelen sorgu sonucu gelecek olan bilgiler tablo yapısını temsil eder (Gelen Veriyi Buraya Yükler)

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);// nesnesi oluşturulur. Bu nesne, belirtilen SQL sorgusunu ve bağlantıyı kullanarak veritabanından
                                                                           // veri almak için kullanılacaktır.

            adapter.Fill(dataTable);
            //adapter.Fill(dataTable) ifadesiyle, SqlDataAdapter nesnesi kullanılarak SQL sorgusundan dönen veriler,
            //oluşturulan DataTable nesnesine doldurulur.

            dataGridView.DataSource = dataTable;// DataGridView de Gösterilecek 

            connection.Close();
        }

        public void Ekle(string Hastaad,DateTime RandevuTarihi)
        {
            
            SqlConnection connection = new SqlConnection(connectionString);// Bağlantı Cümlesi Yollanır

            connection.Open(); // Bağlantı Açılır 

            string query = "Insert into Randevular (HastaAd,RandevuTarihi)values(@HastaAd,@RandevuTarihi) ";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@HastaAd", Hastaad);
            command.Parameters.AddWithValue("@RandevuTarihi", RandevuTarihi);
            

            command.ExecuteNonQuery(); //Veritabanında yapılan işlemlerin kaydedilmesi ve onaylanması için çalıştırılır.(Yazılan queryi sql üzerinde çalıştırır.)



            connection.Close();




        }
        public void RandevuSilme(int id)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            string query = $"Delete from Randevular where RandevuID={id}";

            SqlCommand command = new SqlCommand(query, connection);

            command.ExecuteNonQuery();

            connection.Close();  


        }



    }
}
