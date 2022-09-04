using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLC_Siemens.Classes.Concrete
{
    class DatabaseOperations
    {
        /// <summary>
        /// Veritabanından okunan değerleri tutar.
        /// </summary>
        private string _result;

        /// <summary>
        /// Veritabbanından okunan değerin hangi tablodan okunduğu bilgisini tutar.
        /// </summary>
        private string _resultType;

        /// <summary>
        /// PLC'den okuma işlemi yapıldığında bunu SQL veritabanına kaydeder.
        /// </summary>
        /// <param name="islemYapilanPlc">işlem yapılan plc ismi</param>
        /// <param name="okumaAdresi">okuma yapılan adres</param>
        /// <param name="okunanDeger">okunan değer</param>
        /// <param name="tarihSaat">tarih saat bilgisi</param>
        public void WriteToDatabaseReadTable(string islemYapilanPlc, string okumaAdresi, string okunanDeger, string tarihSaat)
        {
            string insertRead = "INSERT INTO `okuma`(`islemYapilanPlc`, `okumaAdresi`, `okunanDeger`, `tarihSaat`)" +
                "VALUES ('" +
                islemYapilanPlc + "','" +
                okumaAdresi + "','" +
                okunanDeger + "','" +
                tarihSaat + "')";

            DatabaseOperation(insertRead);
        }

        /// <summary>
        /// PLC'ye yazma işlemi yapıldığında bunu SQL veritabanına kaydeder.
        /// </summary>
        /// <param name="islemYapilanPlc">işlem yapılan plc ismi</param>
        /// <param name="yazilmaAdresi">yazma yapılan adres</param>
        /// <param name="oncekiDeger">yazılmadan önceki değer</param>
        /// <param name="yazilanDeger">yazılan değer</param>
        /// <param name="tarihSaat">tarih saat bilgisi</param>
        public void WriteToDatabaseWriteTable(string islemYapilanPlc, string yazilmaAdresi, string oncekiDeger, string yazilanDeger, string tarihSaat)
        {
            string insertWrite = "INSERT INTO `yazma`(`islemYapilanPlc`, `yazmaAdresi`, `oncekiDeger`, `yazilanDeger`, `tarihSaat`)" +
                "VALUES ('" +
                islemYapilanPlc + "','" +
                yazilmaAdresi + "','" +
                oncekiDeger + "','" +
                yazilanDeger + "','" +
                tarihSaat + "')";

            DatabaseOperation(insertWrite);
        }

        /// <summary>
        /// Veritabanından PLC'den okuma işlemlerinin bilgilerini okur.
        /// </summary>
        public string ReadFromDatabaseReadTable()
        {
            _result = "";
            _resultType = "read";

            string queryRead = "SELECT * FROM `okuma`";

            DatabaseOperation(queryRead);

            return _result;
        }

        /// <summary>
        /// Veritabanından PLC'ye yazma işlemlerinin bilgilerini okur.
        /// </summary>
        public string ReadFromDatabaseWriteTable()
        {
            _result = "";
            _resultType = "write";

            string queryWrite = "SELECT * FROM `yazma`";

            DatabaseOperation(queryWrite);

            return _result;
        }

        private void DatabaseOperation(string sql)
        {
            // MySQL veritabanına bağlanmamız için gereken string bilgileri.
            string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=plc_db_s7";

            // Veritabanına atılacak sorgu.
            string query = sql;

            // Veritabanı bağlantısı yapabilmemiz için MySqlConnection sınıfından databaseConnection isminde nesne ürettik.
            // Constuructor olarak ise MySqlConnection sınıfının birinci overloadını seçtik, parametre olarak ise kendi bağlantı stringimizi verdik.
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);

            // veritabanı sorgusu atabilmek için ise MySqlCommand sınıfından commandDatabase adında bir nesne ürettik.
            // Constructor olarak ise MySqlCommand sınıfının ikinci overloadını seçtik. parametre olarak ise sorgu(query) string değişkenini ve bağlantı yapabileceğimiz databaseConnection nesnesini gönderdik 
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();

                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {
                    MessageBox.Show("Rapor oluşturuldu. \nRapor ekranına bakın.");

                    if (_resultType == "read")
                    {
                        while (myReader.Read())
                        {
                            _result +=
                                 myReader.GetString(0) + "&" + // işlem yapılan plc
                                 myReader.GetString(1) + "&" + // okuma adresi
                                 myReader.GetString(2) + "&" + // okunan değer 
                                 myReader.GetString(3) + "#"; // tarih/saat                      
                        }
                    }
                    else if(_resultType == "write")
                    {
                        while (myReader.Read())
                        {
                            _result +=
                                 myReader.GetString(0) + "&" + // işlem yapılan plc
                                 myReader.GetString(1) + "&" + // yazma adresi 
                                 myReader.GetString(2) + "&" + // önceki değer
                                 myReader.GetString(3) + "&" + // yazılan değer
                                 myReader.GetString(4) + "#";  // tarih/saat   
                        }
                    }
                }
                else
                {
                    MessageBox.Show("İşlem veritabanına kaydedildi.");
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show("Hata : " + exp.Message.ToString());
            }

        }

    }
}
