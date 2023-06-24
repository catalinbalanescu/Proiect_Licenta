using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proiect_Licenta
{
    public partial class Form2 : Form
    {
        public string variabila { get; set; }

        public Form2()
        {
            InitializeComponent();
            SetLabelValue();
        }

        private void SetLabelValue()
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Codul pentru desenarea tablei
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Codul pentru evenimentul de intrare în grupul de controale
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormMaterie1 formmat1 = new FormMaterie1();
            formmat1.ShowDialog();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormMaterie2 formmat2 = new FormMaterie2();
            formmat2.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormMaterie3 formmat3 = new FormMaterie3();
            formmat3.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormMaterie4 formmat4 = new FormMaterie4();
            formmat4.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Codul pentru evenimentul de clic pe etichetă
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Codul pentru schimbarea valorii selecției în controlul dateTimePicker1
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string connectionString = "server=localhost;database=licenta;uid=root;pwd=Maineemarti23@";
            string student = label5.Text; // Obținem numele studentului din Label5

            // Creăm un DataTable pentru a stoca rezultatele
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Materie");
            dataTable.Columns.Add("Nota_examen");
            dataTable.Columns.Add("Nota_test_laborator");

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Iterăm prin toate cele 4 tabele
                    for (int i = 1; i <= 4; i++)
                    {
                        string tableName = $"situatie_materie{i}";

                        // Realizăm interogarea pentru a obține notele studentului în materie
                        string query = $"SELECT nota_examen, nota_test_laborator FROM {tableName} WHERE student = @Student";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Student", student);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Obținem notele din rezultatele interogării
                                string notaExamen = reader["nota_examen"].ToString();
                                string notaTestLaborator = reader["nota_test_laborator"].ToString();

                                // Adăugăm rândul în DataTable
                                dataTable.Rows.Add(tableName, notaExamen, notaTestLaborator);
                            }
                        }
                    }

                    // Setăm sursa de date a DataGridView ca fiind DataTable
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la interogarea bazei de date: " + ex.Message);
                }
            }
        }
    }
}
