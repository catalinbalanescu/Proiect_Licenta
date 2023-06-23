using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proiect_Licenta
{
    public partial class Form4 : Form
    {
        public string query;

        public Form4()
        {
            InitializeComponent();

        }

        private void Form4_Load_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            const int passwordLength = 4;

            Random random = new Random();
            StringBuilder password = new StringBuilder();

            for (int i = 0; i < passwordLength; i++)
            {
                int randomIndex = random.Next(0, characters.Length);
                char randomCharacter = characters[randomIndex];
                password.Append(randomCharacter);
            }

            textBox2.Text = password.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=licenta;uid=root;pwd=Maineemarti23@";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string tableName = "";
                    switch (comboBox1.SelectedItem.ToString())
                    {
                        case "Student":
                            tableName = "STUDENTI";
                            break;
                        case "Profesor":
                            tableName = "PROFESORI";
                            break;
                        case "Administrator":
                            tableName = "ADMINISTRATOR";
                            break;
                        default:
                            // Nu s-a selectat nicio opțiune validă
                            return;
                    }

                    string query = $"INSERT INTO {tableName} (USERNAME, PAROLA) VALUES (@Username, @Parola)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", textBox1.Text);
                    command.Parameters.AddWithValue("@Parola", textBox2.Text);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Înregistrare adăugată în baza de date!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la inserarea în baza de date: " + ex.Message);
                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            const string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            const int passwordLength = 4;

            Random random = new Random();
            StringBuilder password = new StringBuilder();

            for (int i = 0; i < passwordLength; i++)
            {
                int randomIndex = random.Next(0, characters.Length);
                char randomCharacter = characters[randomIndex];
                password.Append(randomCharacter);
            }

            textBox4.Text = password.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=licenta;uid=root;pwd=Maineemarti23@";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string tableName = "";
                    string emailSuffix = "";

                    if (textBox3.Text.EndsWith("@student.university.ro"))
                    {
                        tableName = "STUDENTI";
                        emailSuffix = "@student.university.ro";
                    }
                    else if (textBox3.Text.EndsWith("@profesor.university.ro"))
                    {
                        tableName = "PROFESORI";
                        emailSuffix = "@profesor.university.ro";
                    }
                    else if (textBox3.Text.EndsWith("@administrator.university.ro"))
                    {
                        tableName = "ADMINISTRATOR";
                        emailSuffix = "@administrator.university.ro";
                    }
                    else
                    {
                        MessageBox.Show("Adresa de e-mail nu este validă.");
                        return;
                    }

                    string query = $"UPDATE {tableName} SET PAROLA = @NouaParola WHERE USERNAME = @Username";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@NouaParola", textBox4.Text);
                    command.Parameters.AddWithValue("@Username", textBox3.Text);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Parola actualizată în baza de date!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la actualizarea parolei în baza de date: " + ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=licenta;uid=root;pwd=Maineemarti23@";
            string query = "SELECT username FROM studenti";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    MySqlCommand command = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        checkedListBox1.Items.Clear();
                        while (reader.Read())
                        {
                            string username = reader.GetString("username");
                            checkedListBox1.Items.Add(username);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la interogarea bazei de date: " + ex.Message);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=licenta;uid=root;pwd=Maineemarti23@";
            string selectedMaterie = comboBox2.SelectedItem?.ToString();

            if (selectedMaterie == "Materie1")
            {
                
                string tableName = "situatie_materie1";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Iterează prin fiecare element selectat din CheckedListBox
                        foreach (object item in checkedListBox1.CheckedItems)
                        {
                            string student = item.ToString();

                            // Inserează înregistrarea în baza de date
                            string query = $"INSERT INTO {tableName} (student) VALUES (@Student)";
                            MySqlCommand command = new MySqlCommand(query, connection);
                            command.Parameters.AddWithValue("@Student", student);
                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Înregistrări adăugate în baza de date!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Eroare la inserarea în baza de date: " + ex.Message);
                    }
                }
            }
            else if (selectedMaterie == "Materie2")
            {
                string tableName = "situatie_materie2";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Iterează prin fiecare element selectat din CheckedListBox
                        foreach (object item in checkedListBox1.CheckedItems)
                        {
                            string student = item.ToString();

                            // Inserează înregistrarea în baza de date
                            string query = $"INSERT INTO {tableName} (student) VALUES (@Student)";
                            MySqlCommand command = new MySqlCommand(query, connection);
                            command.Parameters.AddWithValue("@Student", student);
                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Înregistrări adăugate în baza de date!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Eroare la inserarea în baza de date: " + ex.Message);
                    }
                }
            }
        }
    }
}
