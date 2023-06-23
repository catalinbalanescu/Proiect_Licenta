using System;
using System.Windows.Forms;

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
    }
}
