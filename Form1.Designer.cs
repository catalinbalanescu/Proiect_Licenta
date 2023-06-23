namespace Proiect_Licenta
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            sign_in_button = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // sign_in_button
            // 
            sign_in_button.BackColor = SystemColors.GradientActiveCaption;
            sign_in_button.ForeColor = SystemColors.ActiveCaptionText;
            sign_in_button.Location = new Point(67, 389);
            sign_in_button.Name = "sign_in_button";
            sign_in_button.Size = new Size(179, 35);
            sign_in_button.TabIndex = 0;
            sign_in_button.Text = "Conectare";
            sign_in_button.UseVisualStyleBackColor = false;
            sign_in_button.Click += sign_in_button_Click;
            // 
            // button1
            // 
            button1.Location = new Point(267, 389);
            button1.Name = "button1";
            button1.Size = new Size(179, 35);
            button1.TabIndex = 1;
            button1.Text = "Forget";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.AcceptsTab = true;
            textBox1.BackColor = SystemColors.Window;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(67, 183);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nume de utilizator";
            textBox1.Size = new Size(219, 27);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(67, 259);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Parola";
            textBox2.Size = new Size(219, 27);
            textBox2.TabIndex = 5;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSkyBlue;
            label1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label1.Location = new Point(433, 460);
            label1.Name = "label1";
            label1.Size = new Size(237, 23);
            label1.TabIndex = 6;
            label1.Text = "University Virtual Campus ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.LightSkyBlue;
            label2.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label2.Location = new Point(29, 51);
            label2.Name = "label2";
            label2.Size = new Size(362, 37);
            label2.TabIndex = 7;
            label2.Text = "University Virtual Campus ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(701, 539);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(sign_in_button);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sign_in_button;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
    }
}