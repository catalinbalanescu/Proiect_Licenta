namespace Proiect_Licenta
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            comboBox1 = new ComboBox();
            label3 = new Label();
            button2 = new Button();
            checkBox1 = new CheckBox();
            label2 = new Label();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            label5 = new Label();
            listBox1 = new ListBox();
            comboBox2 = new ComboBox();
            label4 = new Label();
            tabPage3 = new TabPage();
            button3 = new Button();
            label7 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            comboBox3 = new ComboBox();
            listBox2 = new ListBox();
            tabPage4 = new TabPage();
            button4 = new Button();
            comboBox4 = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            monthCalendar1 = new MonthCalendar();
            label1 = new Label();
            label8 = new Label();
            label11 = new Label();
            comboBox5 = new ComboBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarTitleBackColor = SystemColors.ActiveBorder;
            dateTimePicker1.CalendarTrailingForeColor = SystemColors.Highlight;
            dateTimePicker1.Location = new Point(561, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(237, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(628, 465);
            button1.Name = "button1";
            button1.Size = new Size(198, 41);
            button1.TabIndex = 1;
            button1.Text = "Deconectare";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(3, 45);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(572, 461);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.BorderStyle = BorderStyle.Fixed3D;
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(checkBox1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(564, 360);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Adaugare anunt";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Materie1" });
            comboBox1.Location = new Point(373, 203);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(109, 28);
            comboBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 200);
            label3.Name = "label3";
            label3.Size = new Size(364, 20);
            label3.TabIndex = 4;
            label3.Text = "Selectati materia pentru care doriti sa postati anuntul:";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(1, 291);
            button2.Name = "button2";
            button2.Size = new Size(162, 33);
            button2.TabIndex = 3;
            button2.Text = "Adaugare anunt";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.Location = new Point(6, 263);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(313, 22);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Anuntul este vizibil pentru toti studentii.";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 24);
            label2.Name = "label2";
            label2.Size = new Size(328, 18);
            label2.TabIndex = 1;
            label2.Text = "Introduceti anuntul pe care doriti sa il postati:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 45);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(555, 152);
            textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(listBox1);
            tabPage2.Controls.Add(comboBox2);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(564, 360);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Stergere anunt";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 75);
            label5.Name = "label5";
            label5.Size = new Size(487, 20);
            label5.TabIndex = 3;
            label5.Text = "Selectati anuntul pe care doriti sa il stergeti din lista curenta de anunturi:";
            label5.Click += label5_Click;
            // 
            // listBox1
            // 
            listBox1.AllowDrop = true;
            listBox1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(6, 98);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(487, 157);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Materie1" });
            comboBox2.Location = new Point(382, 17);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(84, 28);
            comboBox2.TabIndex = 1;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 17);
            label4.Name = "label4";
            label4.Size = new Size(363, 20);
            label4.TabIndex = 0;
            label4.Text = "Selectati cursul pentru care doriti sa stergeti un anunt:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(textBox2);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(comboBox3);
            tabPage3.Controls.Add(listBox2);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(564, 360);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Modificare anunt existent";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientActiveCaption;
            button3.Location = new Point(5, 307);
            button3.Name = "button3";
            button3.Size = new Size(245, 30);
            button3.TabIndex = 6;
            button3.Text = "Salvati modificarea efectuata";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 189);
            label7.Name = "label7";
            label7.Size = new Size(185, 20);
            label7.TabIndex = 5;
            label7.Text = "Modificati anuntul selectat";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(5, 221);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(286, 80);
            textBox2.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 24);
            label6.Name = "label6";
            label6.Size = new Size(394, 20);
            label6.TabIndex = 3;
            label6.Text = "Selectati materia pentru care doriti sa modificati un anunt:";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Materie1" });
            comboBox3.Location = new Point(415, 24);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(89, 28);
            comboBox3.TabIndex = 2;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(5, 69);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(302, 104);
            listBox2.TabIndex = 1;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(comboBox5);
            tabPage4.Controls.Add(label11);
            tabPage4.Controls.Add(button4);
            tabPage4.Controls.Add(comboBox4);
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(label9);
            tabPage4.Controls.Add(monthCalendar1);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(564, 428);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Planificare examen";
            tabPage4.UseVisualStyleBackColor = true;
            tabPage4.Click += tabPage4_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.GradientActiveCaption;
            button4.Location = new Point(11, 391);
            button4.Name = "button4";
            button4.Size = new Size(103, 33);
            button4.TabIndex = 4;
            button4.Text = "Planificare";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // comboBox4
            // 
            comboBox4.BackColor = SystemColors.GradientActiveCaption;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Sala1", "Sala2", "Sala3", "Sala4" });
            comboBox4.Location = new Point(333, 266);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(70, 28);
            comboBox4.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 266);
            label10.Name = "label10";
            label10.Size = new Size(316, 20);
            label10.TabIndex = 2;
            label10.Text = "Selectati sala in care se va desfasura examenul";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 21);
            label9.Name = "label9";
            label9.Size = new Size(242, 20);
            label9.TabIndex = 1;
            label9.Text = "Selectati ziua sustinerii examenului:";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(11, 50);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(133, 4);
            label1.Name = "label1";
            label1.Size = new Size(52, 22);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 4);
            label8.Name = "label8";
            label8.Size = new Size(115, 20);
            label8.TabIndex = 4;
            label8.Text = "Esti conectat ca:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(11, 331);
            label11.Name = "label11";
            label11.Size = new Size(183, 20);
            label11.TabIndex = 5;
            label11.Text = "Selectati tipul examenului:";
            // 
            // comboBox5
            // 
            comboBox5.BackColor = SystemColors.GradientActiveCaption;
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Prezentarea1", "Prezentarea2", "Prezentarea3", "Prezentare Speciala" });
            comboBox5.Location = new Point(200, 331);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(72, 28);
            comboBox5.TabIndex = 6;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 518);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Name = "Form3";
            Text = "Form3";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button button1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBox1;
        public Label label1;
        private Button button2;
        private CheckBox checkBox1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private ComboBox comboBox2;
        private Label label4;
        public ListBox listBox1;
        private Label label5;
        private TabPage tabPage3;
        private Label label6;
        private ComboBox comboBox3;
        private Label label7;
        public ListBox listBox2;
        public TextBox textBox2;
        private Button button3;
        private Label label8;
        private TabPage tabPage4;
        private Label label9;
        private MonthCalendar monthCalendar1;
        private Label label10;
        private Button button4;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private Label label11;
    }
}