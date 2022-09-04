using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;
using MySql.Data.MySqlClient;
using PLC_Siemens.Classes.Concrete;
using PLC_Siemens.Forms;

namespace PLC_Siemens
{
    public partial class Form1 : Form
    {
        #region Properties and Fields

        /// <summary>
        /// Bağlanmak istenilen PLC'nin Ip değerini tutacak olan değişken.
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        /// Bağlanmak istenilen PLC'nin Rack değerini tutacak olan değişken.
        /// </summary>
        public int Rack { get; set; }

        /// <summary>
        /// Bağlanmak istenilen PLC'nin Slot değerini tutacak olan değişken.
        /// </summary>
        public int Slot { get; set; }

        /// <summary>
        /// Üzerinde işlem yapacağımız plc nesnesi. 
        /// </summary>
        Plc plc;

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        #region Events

        /// <summary>
        /// Form1 load Event'i
        /// Combobox içine enumdaki verileri yazıyor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // CpuType enumeratorundeki değerler cpu combobox'una çekildi.
            cpuType_ComboBox.DataSource = Enum.GetNames(typeof(CpuType));

            // Bağlantı yoksa disconnect butonuna tıklamayı engelle.
            disconnect_Button.Enabled = false;

            // Bağlantı yoksa read butonuna tıklamayı engelle.
            read_Button.Enabled = false;

            // Bağlantı yoksa write butonuna tıklamayı engelle.
            write_Button.Enabled = false;
        }

        /// <summary>
        /// Connect Buton Event'i
        /// Bağlanmak istediğimizde kullanıcı tarafından girilen değerlere göre olan plc ye bağlanır.
        /// Eğer işler yolunda gitmezse program patlamaz fakat hata fırlatır.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void connect_Button_Click(object sender, EventArgs e)
        {
            // Dene, olmazsa hata fırlat.
            try
            {
                // Kullanıcıdan alınan bilgilerin değişkenlere atama.
                Ip = ipAdress_TextBox.Text;
                Rack = Convert.ToInt16(rack_TextBox.Text);
                Slot = Convert.ToInt16(slot_TextBox.Text);

                // Combobox ile seçilen cpu tipi cpu değişkenine atandı.
                CpuType cpu = (CpuType)Enum.Parse(typeof(CpuType), cpuType_ComboBox.SelectedValue.ToString());

                // Plc sınıfındaki yeni plc oluşturmak için constructorun 3. override'ı seçildi.
                // Plc(CpuType cpu, string ip, Int16 rack, Int16 slot)
                plc = new Plc(
                    cpu,
                    this.Ip,
                    Convert.ToInt16(this.Rack),
                    Convert.ToInt16(this.Slot)
                    );  

                // Plc ile verilen bağlantı kur.
                plc.Open();

                // Bağlantı kontrolü
                if (plc.IsConnected)
                {
                    cpuStatus_Label.Text = "Connected";
                    disconnect_Button.Enabled = true;
                    read_Button.Enabled = true;
                    write_Button.Enabled = true;
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show("Hata!!" + exp.Message.ToString());
            }
        }

        /// <summary>
        /// Disconnect Buton Event'i
        /// Eğer bağlı bir plc varsa bağlantısını sonlandırır. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void disconnect_Button_Click(object sender, EventArgs e)
        {
            // Dene, olmazsa hata fırlat.
            try
            {
                // Plc ile bağlantıyı kapat.1
                plc.Close();

                // Bağlantı kontrolü
                if (!plc.IsConnected)
                {
                    cpuStatus_Label.Text = "Disconnected";
                }
            }
            catch 
            {
                MessageBox.Show("Bağlı cihaz yok!");
            }

        }

        /// <summary>
        /// Read Buton Event'i 
        /// Adres olarak verilen kutucuğun içeriğini okuyup Present text box a yazar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void read_Button_Click(object sender, EventArgs e)
        {
            try
            {
                // plc'de bulunan tablonun içerisindeki kutucuğun adresi. 
                string adres = address_TextBox.Text;

                // o kutucukta daha önceden var olan değer sonuç objesine yazılıyor.
                object sonuc = plc.Read(adres);

                // aynı kutucuktaki veriyi okuyarak Present value text box'una yazıyor.
                PresentValue_TextBox.Text = string.Format("{0}", sonuc.ToString());

                DatabaseOperations db = new DatabaseOperations();
                db.WriteToDatabaseReadTable(cpuType_ComboBox.Text, address_TextBox.Text, PresentValue_TextBox.Text, "tarih-saat bilgisi");
            }
            catch (Exception exp)
            {
                MessageBox.Show("Hata: " + exp.Message.ToString());
            }
        }

        /// <summary>
        /// Write Buton Event'i 
        /// Set edilmek istenen değer o anki adres değerindeki kutucuğa yazılır.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void write_Button_Click(object sender, EventArgs e)
        {
            try
            {
                // plc'de bulunan tablonun içerisindeki kutucuğun adresi. 
                string adres = address_TextBox.Text;

                object setpoint = setPoint_TextBox.Text;

                // aynı adrese set etmek istediğimiz değişkeni gönderiyor.
                plc.Write(adres, setpoint);

                DatabaseOperations db = new DatabaseOperations();
                db.WriteToDatabaseWriteTable(cpuType_ComboBox.Text, address_TextBox.Text, PresentValue_TextBox.Text, setPoint_TextBox.Text, "tarih-saat bilgisi");
            }
            catch (Exception exp)
            {
                MessageBox.Show("Hata: " + exp.Message.ToString());
            }
        }

        /// <summary>
        /// Read Report Buton Event'i.
        /// Okuma işlemlerini listelemek işin Rapor sayfasını açar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void readReport_Button_Click(object sender, EventArgs e)
        {
            ReadReportPage readReportPage = new ReadReportPage();
            readReportPage.Show();
        }

        /// <summary>
        /// Write Report Buton Event'i.
        /// Yazma işlemlerini listelemek işin Rapor sayfasını açar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void writeReport_Button_Click(object sender, EventArgs e)
        {
            WriteReportPage writeReportPage = new WriteReportPage();
            writeReportPage.Show();
        }

        #endregion
    }
}
