using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyonu.Metotlar
{
    public class Doktor_Islemleri
    {
        string connectionString = "Server = LAPTOP-CI2TQ0HV\\HALIL; Database = HastahaneDB; Uid = sa; Password =sanane123; TrustServerCertificate = True;";

        public void DoktorListele(ComboBox combobox)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "Select * from Doktorlar";

            SqlCommand command = new SqlCommand(query, connection);
            

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    
                    
                    string doktorad = reader["DoktorAdi"].ToString();
                    string doktorunvan = reader["DoktorUnvanID"].ToString();
                    string doktorsoyad = reader["DoktorSoyadi"].ToString();
                    combobox.Items.Add($"{doktorunvan}.{doktorad} {doktorsoyad} ");

                }
            }

            connection.Close();




        }




    }
}
