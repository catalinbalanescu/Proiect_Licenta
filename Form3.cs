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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proiect_Licenta
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            label7.Visible = false;
            textBox2.Visible = false;
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
                        case "Materie1":
                            tableName = "ANUNTURI_MATERIE1";
                            break;
                        case "Materie2":
                            tableName = "PROFESORI";
                            break;
                        case "Administrator":
                            tableName = "ADMINISTRATOR";
                            break;
                        default:
                            // Nu s-a selectat nicio opțiune validă
                            return;
                    }

                    string query = $"INSERT INTO {tableName} (ANUNTURI) VALUES (@ANTUR)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ANTUR", textBox1.Text);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Înregistrare adăugată în baza de date!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la inserarea în baza de date: " + ex.Message);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=licenta;uid=root;pwd=Maineemarti23@";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectedOption = comboBox2.SelectedItem?.ToString();
                    if (selectedOption != null)
                    {
                        string tableName = "";
                        switch (selectedOption)
                        {
                            case "Materie1":
                                tableName = "ANUNTURI_MATERIE1";
                                break;
                            case "Materie2":
                                tableName = "PROFESORI";
                                break;
                            case "Administrator":
                                tableName = "ADMINISTRATOR";
                                break;
                            default:
                                // Nu s-a selectat nicio opțiune validă
                                return;
                        }

                        string query = $"SELECT ANUNTURI FROM {tableName}";
                        MySqlCommand command = new MySqlCommand(query, connection);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            listBox1.Items.Clear();

                            while (reader.Read())
                            {
                                string anunt = reader.GetString("ANUNTURI");
                                listBox1.Items.Add(anunt);
                            }
                        }

                        MessageBox.Show("Anunțurile au fost afișate în ListBox!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la interogarea bazei de date: " + ex.Message);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedOption = comboBox2.SelectedItem?.ToString();
                string tableName = "";

                switch (selectedOption)
                {
                    case "Materie1":
                        tableName = "ANUNTURI_MATERIE1";
                        break;
                    case "Materie2":
                        tableName = "PROFESORI";
                        break;
                    case "Administrator":
                        tableName = "ADMINISTRATOR";
                        break;
                    default:
                        // Nu s-a selectat nicio opțiune validă
                        return;
                }

                string connectionString = "server=localhost;database=licenta;uid=root;pwd=Maineemarti23@";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string selectedAnunt = listBox1.SelectedItem.ToString();

                        string query = $"DELETE FROM {tableName} WHERE ANUNTURI = @ANTUR";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ANTUR", selectedAnunt);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            listBox1.Items.Remove(selectedAnunt);
                            MessageBox.Show("Înregistrare ștearsă din baza de date și din ListBox!");
                        }
                        else
                        {
                            MessageBox.Show("Înregistrarea nu a fost găsită în baza de date!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Eroare la ștergerea din baza de date: " + ex.Message);
                    }
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=licenta;uid=root;pwd=Maineemarti23@";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectedOption = comboBox3.SelectedItem?.ToString();
                    if (selectedOption != null)
                    {
                        string tableName = "";
                        switch (selectedOption)
                        {
                            case "Materie1":
                                tableName = "ANUNTURI_MATERIE1";
                                break;
                            case "Materie2":
                                tableName = "PROFESORI";
                                break;
                            case "Administrator":
                                tableName = "ADMINISTRATOR";
                                break;
                            default:
                                // Nu s-a selectat nicio opțiune validă
                                return;
                        }

                        string query = $"SELECT ANUNTURI FROM {tableName}";
                        MySqlCommand command = new MySqlCommand(query, connection);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            listBox1.Items.Clear();

                            while (reader.Read())
                            {
                                string anunt = reader.GetString("ANUNTURI");
                                listBox2.Items.Add(anunt);
                            }
                        }

                        MessageBox.Show("Anunțurile au fost afișate în ListBox!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la interogarea bazei de date: " + ex.Message);
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label7.Visible = true;
            textBox2.Visible = true;
            textBox2.Text = listBox2.SelectedItem?.ToString();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                // Verifică dacă există un element selectat în ListBox
                if (textBox2.Text.Trim() != "")
                {
                    // Obține textul vechi din ListBox
                    string oldText = listBox2.SelectedItem.ToString();

                    // Obține textul nou din TextBox
                    string newText = textBox2.Text;

                    // Modifică textul vechi cu textul nou în ListBox
                    int selectedIndex = listBox2.SelectedIndex;
                    listBox2.Items[selectedIndex] = newText;

                    // Actualizează textul în baza de date, dacă este necesar

                    // Obține opțiunea selectată în ComboBox
                    string selectedOption = comboBox3.SelectedItem?.ToString();

                    // Afișează numele tabelului corespunzător opțiunii selectate
                    string tableName = "";
                    switch (selectedOption)
                    {
                        case "Materie1":
                            tableName = "ANUNTURI_MATERIE1";
                            break;
                        case "Materie2":
                            tableName = "PROFESORI";
                            break;
                        case "Administrator":
                            tableName = "ADMINISTRATOR";
                            break;
                        default:
                            // Nu s-a selectat nicio opțiune validă
                            return;
                    }

                    // Conectare la baza de date
                    string connectionString = "server=localhost;database=licenta;uid=root;pwd=Maineemarti23@";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();

                            // Actualizează înregistrarea corespunzătoare în baza de date
                            string query = $"UPDATE {tableName} SET ANUNTURI = @NewText WHERE ANUNTURI = @OldText";
                            MySqlCommand command = new MySqlCommand(query, connection);
                            command.Parameters.AddWithValue("@NewText", newText);
                            command.Parameters.AddWithValue("@OldText", oldText);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Textul a fost modificat cu succes!");
                            }
                            else
                            {
                                MessageBox.Show("Nu s-a putut modifica textul.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Eroare la actualizarea înregistrării în baza de date: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Introduceți un text valid în TextBox.");
                }
            }
            else
            {
                MessageBox.Show("Selectați un element în ListBox.");
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (monthCalendar1.SelectionRange.Start != null && comboBox4.SelectedItem != null)
            {
                string tipexamen=comboBox5.SelectedItem.ToString(); 
                // Obține data selectată din MonthCalendar
                DateTime selectedDate = monthCalendar1.SelectionRange.Start;

                // Obține sala selectată din ComboBox
                string selectedSala = comboBox4.SelectedItem.ToString();

                // Afișează data și sala în MessageBox (opțional)
                MessageBox.Show($"Tipul Examenului: {tipexamen}\nData examenului: {selectedDate.ToString("dd/MM/yyyy")}\nSala examenului: {selectedSala}");

                // Inserează valorile în baza de date

                // Obține opțiunea selectată în ComboBox
                string selectedOption = comboBox3.SelectedItem?.ToString();

                // Afișează numele tabelului corespunzător opțiunii selectate
                string tableName = "MATERIE1";


                // Conectare la baza de date
                string connectionString = "server=localhost;database=licenta;uid=root;pwd=Maineemarti23@";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Inserează înregistrarea în baza de date
                        string query = $"INSERT INTO {tableName} (TIP_EXAMEN,DATA_EXAMEN, SALA_EXAMEN) VALUES (@TipExamen,@DataExamen, @SalaExamen)";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@TipExamen", tipexamen);
                        command.Parameters.AddWithValue("@DataExamen", selectedDate);
                        command.Parameters.AddWithValue("@SalaExamen", selectedSala);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Examenul a fost planificat cu succes!");
                        }
                        else
                        {
                            MessageBox.Show("Nu s-a putut adăuga înregistrarea în baza de date.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Eroare la inserarea în baza de date: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selectați o dată și o sală pentru examen.");
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
    }
}
