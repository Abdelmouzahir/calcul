namespace WinFormsApp1
{
    partial class calculator
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
            fontDialog1 = new FontDialog();
            tbDisplayResult = new TextBox();
            bttn7 = new Button();
            bttn1 = new Button();
            bttn2 = new Button();
            bttn3 = new Button();
            bttn4 = new Button();
            bttn5 = new Button();
            bttn9 = new Button();
            bttn8 = new Button();
            bttn0 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            lbCurrentop = new Label();
            SuspendLayout();
            // 
            // tbDisplayResult
            // 
            tbDisplayResult.BackColor = Color.WhiteSmoke;
            tbDisplayResult.Font = new Font("Comic Sans MS", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            tbDisplayResult.Location = new Point(11, 12);
            tbDisplayResult.Multiline = true;
            tbDisplayResult.Name = "tbDisplayResult";
            tbDisplayResult.Size = new Size(321, 72);
            tbDisplayResult.TabIndex = 0;
            tbDisplayResult.Text = "0";
            tbDisplayResult.TextAlign = HorizontalAlignment.Right;
            // 
            // bttn7
            // 
            bttn7.BackColor = Color.LightCyan;
            bttn7.Font = new Font("Microsoft Tai Le", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            bttn7.ForeColor = SystemColors.ActiveCaptionText;
            bttn7.Location = new Point(12, 103);
            bttn7.Name = "bttn7";
            bttn7.Size = new Size(57, 57);
            bttn7.TabIndex = 1;
            bttn7.Text = "7";
            bttn7.UseVisualStyleBackColor = false;
            bttn7.Click += button_click;
            // 
            // bttn1
            // 
            bttn1.BackColor = Color.LightCyan;
            bttn1.Font = new Font("Microsoft New Tai Lue", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            bttn1.ForeColor = SystemColors.ActiveCaptionText;
            bttn1.Location = new Point(12, 229);
            bttn1.Name = "bttn1";
            bttn1.Size = new Size(57, 57);
            bttn1.TabIndex = 2;
            bttn1.Text = "1";
            bttn1.UseVisualStyleBackColor = false;
            bttn1.Click += button_click;
            // 
            // bttn2
            // 
            bttn2.BackColor = Color.LightCyan;
            bttn2.Font = new Font("Microsoft New Tai Lue", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            bttn2.ForeColor = SystemColors.ActiveCaptionText;
            bttn2.Location = new Point(75, 229);
            bttn2.Name = "bttn2";
            bttn2.Size = new Size(57, 57);
            bttn2.TabIndex = 3;
            bttn2.Text = "2";
            bttn2.UseVisualStyleBackColor = false;
            bttn2.Click += button_click;
            // 
            // bttn3
            // 
            bttn3.BackColor = Color.LightCyan;
            bttn3.Font = new Font("Microsoft New Tai Lue", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            bttn3.ForeColor = SystemColors.ActiveCaptionText;
            bttn3.Location = new Point(138, 229);
            bttn3.Name = "bttn3";
            bttn3.Size = new Size(57, 57);
            bttn3.TabIndex = 4;
            bttn3.Text = "3";
            bttn3.UseVisualStyleBackColor = false;
            bttn3.Click += button_click;
            // 
            // bttn4
            // 
            bttn4.BackColor = Color.LightCyan;
            bttn4.Font = new Font("Microsoft New Tai Lue", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            bttn4.ForeColor = SystemColors.ActiveCaptionText;
            bttn4.Location = new Point(12, 166);
            bttn4.Name = "bttn4";
            bttn4.Size = new Size(57, 57);
            bttn4.TabIndex = 5;
            bttn4.Text = "4";
            bttn4.UseVisualStyleBackColor = false;
            bttn4.Click += button_click;
            // 
            // bttn5
            // 
            bttn5.BackColor = Color.LightCyan;
            bttn5.Font = new Font("Microsoft New Tai Lue", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            bttn5.ForeColor = SystemColors.ActiveCaptionText;
            bttn5.Location = new Point(75, 166);
            bttn5.Name = "bttn5";
            bttn5.Size = new Size(57, 57);
            bttn5.TabIndex = 6;
            bttn5.Text = "5";
            bttn5.UseVisualStyleBackColor = false;
            bttn5.Click += button_click;
            // 
            // bttn9
            // 
            bttn9.BackColor = Color.LightCyan;
            bttn9.Font = new Font("Microsoft New Tai Lue", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            bttn9.ForeColor = SystemColors.ActiveCaptionText;
            bttn9.Location = new Point(138, 103);
            bttn9.Name = "bttn9";
            bttn9.Size = new Size(57, 57);
            bttn9.TabIndex = 7;
            bttn9.Text = "9";
            bttn9.UseVisualStyleBackColor = false;
            bttn9.Click += button_click;
            // 
            // bttn8
            // 
            bttn8.BackColor = Color.LightCyan;
            bttn8.Font = new Font("Microsoft New Tai Lue", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            bttn8.ForeColor = SystemColors.ActiveCaptionText;
            bttn8.Location = new Point(75, 103);
            bttn8.Name = "bttn8";
            bttn8.Size = new Size(57, 57);
            bttn8.TabIndex = 8;
            bttn8.Text = "8";
            bttn8.UseVisualStyleBackColor = false;
            bttn8.Click += button_click;
            // 
            // bttn0
            // 
            bttn0.BackColor = Color.LightCyan;
            bttn0.Font = new Font("Microsoft New Tai Lue", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            bttn0.ForeColor = SystemColors.ActiveCaptionText;
            bttn0.Location = new Point(12, 292);
            bttn0.Name = "bttn0";
            bttn0.Size = new Size(120, 57);
            bttn0.TabIndex = 9;
            bttn0.Text = "0";
            bttn0.UseVisualStyleBackColor = false;
            bttn0.Click += button_click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCyan;
            button1.Font = new Font("Microsoft New Tai Lue", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(138, 166);
            button1.Name = "button1";
            button1.Size = new Size(57, 57);
            button1.TabIndex = 10;
            button1.Text = "6";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button_click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCyan;
            button2.Font = new Font("Microsoft New Tai Lue", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(138, 292);
            button2.Name = "button2";
            button2.Size = new Size(57, 57);
            button2.TabIndex = 11;
            button2.Text = ".";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button_click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightCyan;
            button3.Font = new Font("Microsoft New Tai Lue", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(212, 103);
            button3.Name = "button3";
            button3.Size = new Size(57, 57);
            button3.TabIndex = 12;
            button3.Text = "/";
            button3.UseVisualStyleBackColor = false;
            button3.Click += operator_click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightCyan;
            button4.Font = new Font("Microsoft New Tai Lue", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(212, 166);
            button4.Name = "button4";
            button4.Size = new Size(57, 57);
            button4.TabIndex = 13;
            button4.Text = "X";
            button4.UseVisualStyleBackColor = false;
            button4.Click += operator_click;
            // 
            // button5
            // 
            button5.BackColor = Color.LightCyan;
            button5.Font = new Font("Microsoft New Tai Lue", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(212, 229);
            button5.Name = "button5";
            button5.Size = new Size(57, 57);
            button5.TabIndex = 14;
            button5.Text = "-";
            button5.UseVisualStyleBackColor = false;
            button5.Click += operator_click;
            // 
            // button6
            // 
            button6.BackColor = Color.LightCyan;
            button6.Font = new Font("Microsoft New Tai Lue", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ActiveCaptionText;
            button6.Location = new Point(212, 292);
            button6.Name = "button6";
            button6.Size = new Size(57, 57);
            button6.TabIndex = 15;
            button6.Text = "+";
            button6.UseVisualStyleBackColor = false;
            button6.Click += operator_click;
            // 
            // button7
            // 
            button7.BackColor = Color.LightCyan;
            button7.Font = new Font("Microsoft New Tai Lue", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ActiveCaptionText;
            button7.Location = new Point(275, 103);
            button7.Name = "button7";
            button7.Size = new Size(57, 57);
            button7.TabIndex = 16;
            button7.Text = "Dell";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.LightCyan;
            button8.Font = new Font("Microsoft New Tai Lue", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = SystemColors.ActiveCaptionText;
            button8.Location = new Point(276, 166);
            button8.Name = "button8";
            button8.Size = new Size(57, 57);
            button8.TabIndex = 17;
            button8.Text = "CE";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.LightCyan;
            button9.Font = new Font("Microsoft New Tai Lue", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = SystemColors.ActiveCaptionText;
            button9.Location = new Point(276, 229);
            button9.Name = "button9";
            button9.Size = new Size(57, 57);
            button9.TabIndex = 18;
            button9.Text = "C";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.LightCyan;
            button10.Font = new Font("Microsoft New Tai Lue", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button10.ForeColor = SystemColors.ActiveCaptionText;
            button10.Location = new Point(275, 292);
            button10.Name = "button10";
            button10.Size = new Size(57, 57);
            button10.TabIndex = 19;
            button10.Text = "=";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // lbCurrentop
            // 
            lbCurrentop.AutoSize = true;
            lbCurrentop.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbCurrentop.ForeColor = SystemColors.ActiveCaptionText;
            lbCurrentop.Location = new Point(11, 9);
            lbCurrentop.Name = "lbCurrentop";
            lbCurrentop.Size = new Size(0, 20);
            lbCurrentop.TabIndex = 20;
            // 
            // calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(345, 357);
            Controls.Add(lbCurrentop);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(bttn0);
            Controls.Add(bttn8);
            Controls.Add(bttn9);
            Controls.Add(bttn5);
            Controls.Add(bttn4);
            Controls.Add(bttn3);
            Controls.Add(bttn2);
            Controls.Add(bttn1);
            Controls.Add(bttn7);
            Controls.Add(tbDisplayResult);
            ForeColor = SystemColors.ActiveCaption;
            Name = "calculator";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontDialog fontDialog1;
        private TextBox tbDisplayResult;
        private Button bttn7;
        private Button bttn1;
        private Button bttn2;
        private Button bttn3;
        private Button bttn4;
        private Button bttn5;
        private Button bttn9;
        private Button bttn8;
        private Button bttn0;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Label lbCurrentop;
    }
}