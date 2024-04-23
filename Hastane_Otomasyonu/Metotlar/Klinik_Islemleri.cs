using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyonu.Metotlar
{
    public class Klinik_Islemleri
    {
        string connectionString = "Server = LAPTOP-CI2TQ0HV\\HALIL; Database = HastahaneDB; Uid = sa; Password =sanane123; TrustServerCertificate = True;";

        public void KlinikListele(ComboBox combobox)
        {
            SqlConnection connection = new SqlConnection(connectionString);// Sql Bağlantı Gerçekleşir Adonet Kullanımı 
            connection.Open(); // Open Diyerek Bağlantı Açılır 

            string query = "Select * from Klinikler"; // Sorgumuz 

            SqlCommand command = new SqlCommand(query,connection);// Burda Sorgumuzu ve bağlantımız yollarız 
            
            using(SqlDataReader reader=command.ExecuteReader())// Bu sınıfın sebebi şudur gelen verileri okuyabilmemiz için kullanırız 
            {
                while(reader.Read())
                //Read() metodu, SqlDataReader sınıfının bir öğesi olan bir okuyucu (reader) nesnesinin sonraki
                //satırı okumasını ve okuma konumunu bir sonraki satıra taşımasını sağlar. Bu yöntem, SqlDataReader
                //nesnesinin sorgudan dönen her bir satırı sırayla okumasını sağlar
                {
                    string klinikad = reader["KlinikAdi"].ToString();
                    combobox.Items.Add(klinikad);
                }
            }

            connection.Close();




        }


    }
}
