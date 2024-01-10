namespace CS
{
    partial class Login
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
            Login_Background = new PictureBox();
            button1 = new Button();
            Username_Label = new Label();
            label2 = new Label();
            Login_Title = new Label();
            Username_Textbox = new TextBox();
            Password_Textbox = new TextBox();
            Show_Password_Button = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)Login_Background).BeginInit();
            SuspendLayout();
            // 
            // Login_Background
            // 
            Login_Background.BackColor = Color.Transparent;
            Login_Background.Image = Properties.Resources._3d_render_illustration_football_on_the_football_field_in_night_stadium_and_sport_light_background_free_photo2;
            Login_Background.Location = new Point(-94, -59);
            Login_Background.Name = "Login_Background";
            Login_Background.Size = new Size(1103, 565);
            Login_Background.TabIndex = 0;
            Login_Background.TabStop = false;
            Login_Background.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Honeydew;
            button1.Font = new Font("Viner Hand ITC", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(124, 285);
            button1.Name = "button1";
            button1.Size = new Size(102, 39);
            button1.TabIndex = 2;
            button1.Text = "login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Username_Label
            // 
            Username_Label.AutoSize = true;
            Username_Label.BackColor = SystemColors.ActiveCaptionText;
            Username_Label.FlatStyle = FlatStyle.Flat;
            Username_Label.Font = new Font("Viner Hand ITC", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Username_Label.ForeColor = SystemColors.ActiveBorder;
            Username_Label.Location = new Point(23, 132);
            Username_Label.Name = "Username_Label";
            Username_Label.Size = new Size(111, 32);
            Username_Label.TabIndex = 3;
            Username_Label.Text = "Username:";
            Username_Label.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Viner Hand ITC", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveBorder;
            label2.Location = new Point(23, 179);
            label2.Name = "label2";
            label2.Size = new Size(104, 32);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            label2.Click += label2_Click;
            // 
            // Login_Title
            // 
            Login_Title.AutoSize = true;
            Login_Title.BackColor = Color.Black;
            Login_Title.BorderStyle = BorderStyle.Fixed3D;
            Login_Title.FlatStyle = FlatStyle.Flat;
            Login_Title.Font = new Font("Viner Hand ITC", 17F, FontStyle.Regular, GraphicsUnit.Point);
            Login_Title.ForeColor = SystemColors.ButtonFace;
            Login_Title.ImageAlign = ContentAlignment.TopLeft;
            Login_Title.Location = new Point(333, 32);
            Login_Title.Name = "Login_Title";
            Login_Title.Size = new Size(140, 49);
            Login_Title.TabIndex = 5;
            Login_Title.Text = "Welcome";
            Login_Title.Click += label3_Click;
            // 
            // Username_Textbox
            // 
            Username_Textbox.Location = new Point(162, 133);
            Username_Textbox.Name = "Username_Textbox";
            Username_Textbox.Size = new Size(125, 27);
            Username_Textbox.TabIndex = 6;
            Username_Textbox.TextChanged += textBox1_TextChanged;
            // 
            // Password_Textbox
            // 
            Password_Textbox.Location = new Point(162, 180);
            Password_Textbox.Name = "Password_Textbox";
            Password_Textbox.Size = new Size(125, 27);
            Password_Textbox.TabIndex = 7;
            Password_Textbox.TextChanged += textBox2_TextChanged;
            // 
            // Show_Password_Button
            // 
            Show_Password_Button.AutoSize = true;
            Show_Password_Button.BackColor = SystemColors.ActiveCaptionText;
            Show_Password_Button.ForeColor = SystemColors.ActiveBorder;
            Show_Password_Button.Location = new Point(255, 231);
            Show_Password_Button.Name = "Show_Password_Button";
            Show_Password_Button.Size = new Size(134, 24);
            Show_Password_Button.TabIndex = 8;
            Show_Password_Button.Text = "Show password";
            Show_Password_Button.UseVisualStyleBackColor = false;
            Show_Password_Button.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Show_Password_Button);
            Controls.Add(Password_Textbox);
            Controls.Add(Username_Textbox);
            Controls.Add(Login_Title);
            Controls.Add(label2);
            Controls.Add(Username_Label);
            Controls.Add(button1);
            Controls.Add(Login_Background);
            Name = "Login";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Login_Background).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Login_Background;
        private Button button1;
        private Label Username_Label;
        private Label label2;
        private Label Login_Title;
        private TextBox Username_Textbox;
        private TextBox Password_Textbox;
        private CheckBox Show_Password_Button;
    }
}