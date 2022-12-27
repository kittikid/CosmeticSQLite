using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CosmeticWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _fullPath = Application.StartupPath.ToString(); 
        }

        private readonly string _fullPath;

        public void outputStrings( string query ) 
        {
            
            //MessageBox.Show(fullPath);
            SQLiteConnection conn = new SQLiteConnection($"URI=file: {_fullPath}\\db\\cosmetic.db");
            conn.Open();
            SQLiteCommand command = new SQLiteCommand(query, conn); 
            //вытягиваем данные из таблицы
            SQLiteDataReader reader = command.ExecuteReader();

            listBox1.Items.Clear();
            while (reader.Read())
            {
              listBox1.Items.Add( reader["name"] + " " + reader["brand"]
                 //+ " " + reader["name_study"]  + " адрес " + reader["address"] + " " + reader["dateBirth"] 
                 + " " + reader["price"]
                 + " " + reader["amount"]
                );
            }

            conn.Close();

        }

        public void ExecuteQuery(string query)
        {
            SQLiteConnection conn =
                new SQLiteConnection($"URI=file: {_fullPath}\\db\\cosmetic.db");
            conn.Open();
            SQLiteCommand command = new SQLiteCommand(query, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        private void SelectAllButton_Click(object sender, EventArgs e)
        {
            outputStrings(" SELECT * FROM cosmetic ");
        }

        private void SelectItem_Click(object sender, EventArgs e)
        {
          outputStrings(" SELECT * FROM cosmetic where Name='Помада' ");
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            string sssr =
               "INSERT INTO cosmetic ( name, brand, price, amount )" +
           "VALUES ('" +
                 TextName.Text + "', '" +
                 TextBrand.Text + "', '" +
                 TextPrice.Text + "', '" +
                 TextAmount.Text + "') ";
            MessageBox.Show(sssr);
            ExecuteQuery(sssr);
            outputStrings(" SELECT * FROM cosmetic ");
        }
    }
}
