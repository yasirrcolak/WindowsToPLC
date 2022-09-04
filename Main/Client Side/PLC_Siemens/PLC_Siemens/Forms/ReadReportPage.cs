using PLC_Siemens.Classes.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLC_Siemens.Forms
{
    public partial class ReadReportPage : Form
    {
        public ReadReportPage()
        {
            InitializeComponent();
        }

        private void ReadReportPage_Load(object sender, EventArgs e)
        {
            DatabaseOperations db = new DatabaseOperations();
            string records = db.ReadFromDatabaseReadTable();

            records_ListView.View = View.Details;

            records_ListView.Columns.Add("PLC", 100);
            records_ListView.Columns.Add("Okuma Adresi", 150);
            records_ListView.Columns.Add("Okunan Değer", 150);
            records_ListView.Columns.Add("Tarih/Saat", 150);

            string[] record = records.Split('#');

            for (int i = 0; i < record.Length; i++)
            {
                if (record[i] != "")
                {
                    string[] rec = record[i].Split('&');

                    records_ListView.Items.Add(rec[0].ToString());

                    records_ListView.Items[i].SubItems.Add(rec[1]);
                    records_ListView.Items[i].SubItems.Add(rec[2]);
                    records_ListView.Items[i].SubItems.Add(rec[3]);

                }
            }

            totalRegistryCount_TextBox.Text = records_ListView.Items.Count.ToString();

        }
    }
}
