using System.Data;
using MySql.Data.MySqlClient;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Proiect_Licenta
{
    public partial class Form1 : Form
    {
        public string query;
        public string variabila { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void sign_in_button_Click(object sender, EventArgs e)
        {
            string connetionString = "server=localhost;database=licenta;uid=root;pwd=Maineemarti23@";
            MySqlConnection cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                string string1 = "@student.university.ro";
                string string2 = "@profesor.university.ro";
                string string3 = "@administrator.university.ro";
                string string_textbox = textBox1.Text;
                if (string_textbox.EndsWith(string1))
                {
                    query = "SELECT * FROM STUDENTI WHERE username='" + textBox1.Text + "'AND parola ='" + textBox2.Text + "'";
                }
                else if (string_textbox.EndsWith(string2))
                {
                    query = "SELECT * FROM PROFESORI WHERE username='" + textBox1.Text + "'AND parola ='" + textBox2.Text + "'";
                }
                else if (string_textbox.EndsWith(string3))
                {
                    query = "SELECT * FROM ADMINISTRATOR  WHERE username='" + textBox1.Text + "'AND parola ='" + textBox2.Text + "'";
                }
                MySqlDataAdapter sda = new MySqlDataAdapter(query, cnn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    if (!IsInternetConnected())
                    {
                        MessageBox.Show("Nu există o conexiune la internet.");
                        return;
                    }
                    if (string_textbox.EndsWith(string1))
                    {
                        Form2 hh = new Form2();
                        hh.label5.Text = this.textBox1.Text;
                        hh.ShowDialog();
                        textBox1.Clear();
                        textBox2.Clear();
                    }
                    else if (string_textbox.EndsWith(string2))
                    {
                        Form3 form3 = new Form3();
                        form3.label1.Text = this.textBox1.Text;
                        form3.ShowDialog();
                        textBox1.Clear();
                        textBox2.Clear();
                    }
                    else if (string_textbox.EndsWith(string3))
                    {
                        Form4 form4 = new Form4();
                        form4.label7.Text = this.textBox1.Text;
                        form4.ShowDialog();
                        textBox1.Clear();
                        textBox2.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Credentials");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
            }
            catch (Exception ex)
            {
                if (!textBox1.Text.Contains("@student.university.ro"))
                    MessageBox.Show("trebuie sa te conectezi folosind numeutilizator@student.university.ro");
            }
        }

        private bool IsInternetConnected()
        {
            return NetworkInterface.GetIsNetworkAvailable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
