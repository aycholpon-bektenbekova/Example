namespace Example
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            panel1 = new Panel();
            userAge = new TextBox();
            userNameField = new TextBox();
            buttonRegister = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            password = new TextBox();
            login = new TextBox();
            panel3 = new Panel();
            Closebutton = new Button();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(userAge);
            panel1.Controls.Add(userNameField);
            panel1.Controls.Add(buttonRegister);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(password);
            panel1.Controls.Add(login);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 2;
            // 
            // userAge
            // 
            userAge.Font = new Font("Simple Indust Outline", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            userAge.Location = new Point(522, 167);
            userAge.Multiline = true;
            userAge.Name = "userAge";
            userAge.Size = new Size(254, 64);
            userAge.TabIndex = 7;
            userAge.UseSystemPasswordChar = true;
            // 
            // userNameField
            // 
            userNameField.Font = new Font("Simple Indust Outline", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            userNameField.Location = new Point(114, 170);
            userNameField.Multiline = true;
            userNameField.Name = "userNameField";
            userNameField.Size = new Size(254, 61);
            userNameField.TabIndex = 6;
            userNameField.Enter += userNameField_Enter;
            userNameField.Leave += userNameField_Leave;
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.DarkKhaki;
            buttonRegister.Location = new Point(316, 348);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(209, 56);
            buttonRegister.TabIndex = 5;
            buttonRegister.Text = "send";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(442, 268);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(74, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 268);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // password
            // 
            password.Font = new Font("Simple Indust Outline", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(522, 265);
            password.Multiline = true;
            password.Name = "password";
            password.Size = new Size(254, 64);
            password.TabIndex = 2;
            password.UseSystemPasswordChar = true;
            // 
            // login
            // 
            login.Font = new Font("Simple Indust Outline", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            login.Location = new Point(114, 268);
            login.Multiline = true;
            login.Name = "login";
            login.Size = new Size(254, 61);
            login.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 0, 64);
            panel3.Controls.Add(Closebutton);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 129);
            panel3.TabIndex = 0;
            // 
            // Closebutton
            // 
            Closebutton.BackColor = Color.FromArgb(255, 255, 128);
            Closebutton.Location = new Point(757, 12);
            Closebutton.Name = "Closebutton";
            Closebutton.Size = new Size(31, 29);
            Closebutton.TabIndex = 1;
            Closebutton.Text = "x";
            Closebutton.UseVisualStyleBackColor = false;
            Closebutton.Click += Closebutton_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(184, 28);
            label2.Name = "label2";
            label2.Size = new Size(387, 60);
            label2.TabIndex = 0;
            label2.Text = "registration";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Location = new Point(348, 421);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 8;
            label1.Text = "авторизоваться";
            label1.Click += label1_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonRegister;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox password;
        private TextBox login;
        private Panel panel3;
        private Label label2;
        private TextBox userAge;
        private TextBox userNameField;
        private Button Closebutton;
        private Label label1;
    }
}