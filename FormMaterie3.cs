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
    public partial class FormMaterie3 : Form
    {
        public FormMaterie3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connetionString = "server=localhost;database=licenta;uid=root;pwd=Maineemarti23@";
            MySqlConnection cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                string interogare = "SELECT * FROM ANUNTURI_MATERIE3";
                using (MySqlCommand comanda = new MySqlCommand(interogare, cnn))
                {

                    MySqlDataAdapter adapter = new MySqlDataAdapter(comanda);
                    DataTable tabelaAnunturi = new DataTable();
                    adapter.Fill(tabelaAnunturi);
                    int posY = 10;
                    foreach (DataRow rand in tabelaAnunturi.Rows)
                    {
                        string continutLinie = rand["anunturi"].ToString(); // înlocuiește "anunturi" cu numele corect al coloanei din tabelul ANUNTURI_MATERIE1

                        Label labelAnunt = new Label();
                        labelAnunt.Text = continutLinie;
                        labelAnunt.AutoSize = true;
                        labelAnunt.Height = 50;
                        labelAnunt.Width = 50;

                        labelAnunt.Location = new Point(10, posY); // poziționează label-ul la coordonatele (10, posY)
                        labelAnunt.BorderStyle = BorderStyle.Fixed3D;
                        panel1.Controls.Add(labelAnunt);

                        posY += labelAnunt.Height + 10; // actualizează poziția verticală pentru următorul label


                    }

                }
            }



            catch
            {
                MessageBox.Show("A apărut o eroare la încărcarea anunțurilor: ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=licenta;uid=root;pwd=Maineemarti23@";
            string tableName = "MATERIE3";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = $"SELECT tip_examen,data_examen, sala_examen FROM {tableName}";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    DataTable dataTable = new DataTable();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }

                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Visible = true;

                    MessageBox.Show("Lista de examene planificate a fost incarcata!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la încărcarea datelor: " + ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=licenta;uid=root;pwd=Maineemarti23@";
            string tableName = "situatie_materie3";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Selectează toate înregistrările din coloana "student" din tabelul "situatie_materie1"
                    string query = $"SELECT student FROM {tableName}";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    // Golește ListBox1 înainte de a adăuga elementele
                    listBox1.Items.Clear();

                    // Parcurge rezultatele și adaugă fiecare element în ListBox1
                    while (reader.Read())
                    {
                        string student = reader.GetString("student");
                        listBox1.Items.Add(student);
                    }

                    reader.Close();


                    listBox1.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la citirea din baza de date: " + ex.Message);
                }
            }
        }
    }
}
