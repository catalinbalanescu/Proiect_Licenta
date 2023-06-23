namespace Proiect_Licenta
{
    partial class Form4
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
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button2 = new Button();
            textBox2 = new TextBox();
            button1 = new Button();
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            tabPage2 = new TabPage();
            button4 = new Button();
            textBox4 = new TextBox();
            button3 = new Button();
            label6 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            tabPage3 = new TabPage();
            comboBox2 = new ComboBox();
            label9 = new Label();
            button6 = new Button();
            button5 = new Button();
            checkedListBox1 = new CheckedListBox();
            deconecatare_formadm = new Button();
            label7 = new Label();
            label8 = new Label();
            button7 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 334);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(874, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, 61);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(877, 334);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Window;
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label2);
            tabPage1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(869, 301);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Create account ";
            tabPage1.Click += tabPage1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(3, 172);
            button2.Name = "button2";
            button2.Size = new Size(179, 31);
            button2.TabIndex = 7;
            button2.Text = "Adaugare cont utilizator";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(192, 105);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(173, 25);
            textBox2.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(0, 100);
            button1.Name = "button1";
            button1.Size = new Size(185, 32);
            button1.TabIndex = 5;
            button1.Text = "Generare parola ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 101);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(192, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(335, 25);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(0, 56);
            label3.Name = "label3";
            label3.Size = new Size(191, 17);
            label3.TabIndex = 2;
            label3.Text = "Nume utilizator\\adresa mail:";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Student", "Profesor", "Administrator" });
            comboBox1.Location = new Point(472, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(139, 27);
            comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(-4, 3);
            label2.Name = "label2";
            label2.Size = new Size(470, 19);
            label2.TabIndex = 0;
            label2.Text = "Selectati tipul de utilizator pentru care doriti sa creati contul:";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Window;
            tabPage2.BorderStyle = BorderStyle.Fixed3D;
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(label5);
            tabPage2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(869, 301);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Resetare parola";
            tabPage2.Click += tabPage2_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(6, 140);
            button4.Name = "button4";
            button4.Size = new Size(171, 28);
            button4.TabIndex = 5;
            button4.Text = "Efectuati modificarea parolei";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(203, 82);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(192, 25);
            textBox4.TabIndex = 4;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(11, 82);
            button3.Name = "button3";
            button3.Size = new Size(171, 28);
            button3.TabIndex = 3;
            button3.Text = "Generare parola noua";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 72);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox3.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox3.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(506, 18);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(234, 25);
            textBox3.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(11, 18);
            label5.Name = "label5";
            label5.Size = new Size(473, 17);
            label5.TabIndex = 0;
            label5.Text = "Introduceti contul de utilizator pentru care se doreste resetarea parolei";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button7);
            tabPage3.Controls.Add(comboBox2);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(button6);
            tabPage3.Controls.Add(button5);
            tabPage3.Controls.Add(checkedListBox1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(869, 301);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Repartizare curs";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Materie1", "Materie2", "Materie3", "Materie4" });
            comboBox2.Location = new Point(292, 112);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(122, 28);
            comboBox2.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(8, 112);
            label9.Name = "label9";
            label9.Size = new Size(281, 20);
            label9.TabIndex = 4;
            label9.Text = "Selectati Cursul la care adaugati studenti:";
            // 
            // button6
            // 
            button6.Location = new Point(261, 48);
            button6.Name = "button6";
            button6.Size = new Size(153, 26);
            button6.TabIndex = 3;
            button6.Text = "Selectatati tot";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(8, 10);
            button5.Name = "button5";
            button5.Size = new Size(420, 32);
            button5.TabIndex = 2;
            button5.Text = "Selectati studentul\\studentii pentru care doriti repartizarea:";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.HorizontalScrollbar = true;
            checkedListBox1.Location = new Point(434, 10);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.ScrollAlwaysVisible = true;
            checkedListBox1.Size = new Size(306, 92);
            checkedListBox1.TabIndex = 1;
            checkedListBox1.Click += checkedListBox1_Click;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // deconecatare_formadm
            // 
            deconecatare_formadm.BackColor = SystemColors.GradientActiveCaption;
            deconecatare_formadm.Location = new Point(893, 409);
            deconecatare_formadm.Name = "deconecatare_formadm";
            deconecatare_formadm.Size = new Size(221, 29);
            deconecatare_formadm.TabIndex = 4;
            deconecatare_formadm.Text = "Deconectare";
            deconecatare_formadm.UseVisualStyleBackColor = false;
            deconecatare_formadm.Click += button5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.GradientActiveCaption;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Location = new Point(137, 9);
            label7.Name = "label7";
            label7.Size = new Size(52, 22);
            label7.TabIndex = 5;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 7);
            label8.Name = "label8";
            label8.Size = new Size(133, 20);
            label8.TabIndex = 6;
            label8.Text = "Esti autentificat ca:";
            // 
            // button7
            // 
            button7.Location = new Point(8, 159);
            button7.Name = "button7";
            button7.Size = new Size(128, 29);
            button7.TabIndex = 6;
            button7.Text = "Repartizare";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(deconecatare_formadm);
            Controls.Add(tabControl1);
            Controls.Add(dateTimePicker2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load_1;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private Button button2;
        private Label label5;
        private Button button4;
        private TextBox textBox4;
        private Button button3;
        private Label label6;
        private TextBox textBox3;
        private Button deconecatare_formadm;
        public Label label7;
        private Label label8;
        private TabPage tabPage3;
        private CheckedListBox checkedListBox1;
        private Button button5;
        private Button button6;
        private Label label9;
        private ComboBox comboBox2;
        private Button button7;
    }
}