namespace Example
{
    partial class MainForm
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
            panel1 = new Panel();
            restart = new Button();
            label2 = new Label();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            Closebutton = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(restart);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 1;
            // 
            // restart
            // 
            restart.Location = new Point(629, 224);
            restart.Name = "restart";
            restart.Size = new Size(94, 68);
            restart.TabIndex = 11;
            restart.Text = "Начать заново";
            restart.UseVisualStyleBackColor = true;
            restart.Click += restart_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(629, 159);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 10;
            label2.Text = "label2";
            // 
            // button9
            // 
            button9.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(505, 352);
            button9.Name = "button9";
            button9.Size = new Size(94, 77);
            button9.TabIndex = 9;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button1_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(353, 352);
            button8.Name = "button8";
            button8.Size = new Size(94, 77);
            button8.TabIndex = 8;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button1_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(205, 352);
            button7.Name = "button7";
            button7.Size = new Size(94, 77);
            button7.TabIndex = 7;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button1_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(505, 252);
            button6.Name = "button6";
            button6.Size = new Size(94, 77);
            button6.TabIndex = 6;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button1_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(353, 252);
            button5.Name = "button5";
            button5.Size = new Size(94, 77);
            button5.TabIndex = 5;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button1_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(205, 252);
            button4.Name = "button4";
            button4.Size = new Size(94, 77);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(505, 159);
            button3.Name = "button3";
            button3.Size = new Size(94, 77);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(353, 159);
            button2.Name = "button2";
            button2.Size = new Size(94, 77);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(205, 159);
            button1.Name = "button1";
            button1.Size = new Size(94, 77);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 0, 64);
            panel2.Controls.Add(Closebutton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 129);
            panel2.TabIndex = 0;
            // 
            // Closebutton
            // 
            Closebutton.BackColor = Color.FromArgb(255, 255, 128);
            Closebutton.Location = new Point(742, 34);
            Closebutton.Name = "Closebutton";
            Closebutton.Size = new Size(31, 29);
            Closebutton.TabIndex = 2;
            Closebutton.Text = "x";
            Closebutton.UseVisualStyleBackColor = false;
            Closebutton.Click += Closebutton_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(256, 34);
            label1.Name = "label1";
            label1.Size = new Size(244, 59);
            label1.TabIndex = 0;
            label1.Text = "main ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button Closebutton;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button9;
        private Label label2;
        private Button restart;
    }
}