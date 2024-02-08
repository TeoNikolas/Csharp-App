namespace Airlines_Company
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
            panel1 = new Panel();
            button1 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            button7 = new Button();
            label4 = new Label();
            button6 = new Button();
            monthCalendar1 = new MonthCalendar();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1249, 180);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Font = new Font("Yu Gothic UI Light", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(10, 11);
            button1.Name = "button1";
            button1.Size = new Size(225, 56);
            button1.TabIndex = 6;
            button1.Text = "CheapFlights";
            button1.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.Location = new Point(757, 11);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 5;
            button5.Text = "Dashboard";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(875, 11);
            button4.Name = "button4";
            button4.Size = new Size(124, 34);
            button4.TabIndex = 3;
            button4.Text = "My Bookings";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1005, 11);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 2;
            button3.Text = "Log In";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(1123, 11);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(monthCalendar1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(24, 187);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(532, 489);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Flight Info";
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(185, 78);
            button7.Name = "button7";
            button7.Size = new Size(57, 41);
            button7.TabIndex = 8;
            button7.Text = "⇄";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(183, 50);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 7;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(128, 255, 128);
            button6.Location = new Point(136, 424);
            button6.Name = "button6";
            button6.Size = new Size(191, 42);
            button6.TabIndex = 6;
            button6.Text = "SAVE";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(93, 147);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Helsinki", "Paris", "London", "Vienne", "Lisbon" });
            comboBox2.Location = new Point(277, 80);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(128, 33);
            comboBox2.TabIndex = 4;
            comboBox2.Text = "Destination";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Helsinki", "Paris", "London", "Vienne", "Lisbon" });
            comboBox1.Location = new Point(23, 80);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(130, 33);
            comboBox1.TabIndex = 3;
            comboBox1.Text = "Departure";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 147);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 2;
            label3.Text = "Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 46);
            label2.Name = "label2";
            label2.Size = new Size(30, 25);
            label2.TabIndex = 1;
            label2.Text = "To";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 46);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 0;
            label1.Text = "From";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(656, 187);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(532, 489);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Passanger Info";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 63);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 0;
            label5.Text = "Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 126);
            label6.Name = "label6";
            label6.Size = new Size(114, 25);
            label6.TabIndex = 1;
            label6.Text = "Family Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 196);
            label7.Name = "label7";
            label7.Size = new Size(112, 25);
            label7.TabIndex = 2;
            label7.Text = "Date of Birth";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 259);
            label8.Name = "label8";
            label8.Size = new Size(138, 25);
            label8.TabIndex = 3;
            label8.Text = "Passport Details";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 317);
            label9.Name = "label9";
            label9.Size = new Size(129, 25);
            label9.TabIndex = 4;
            label9.Text = "Phone number";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(243, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(243, 126);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 688);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private MonthCalendar monthCalendar1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button5;
        private Button button1;
        private Button button6;
        private Button button7;
        private Label label4;
        private GroupBox groupBox2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}
