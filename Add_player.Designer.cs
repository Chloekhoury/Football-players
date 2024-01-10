namespace CS
{
    partial class Add_player
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            Firstname_text = new TextBox();
            Lastname_text = new TextBox();
            Teamname_text = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._3d_render_illustration_football_on_the_football_field_in_night_stadium_and_sport_light_background_free_photo2;
            pictureBox1.Location = new Point(-2, -10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(807, 463);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(253, 43);
            label1.Name = "label1";
            label1.Size = new Size(298, 31);
            label1.TabIndex = 1;
            label1.Text = "Enter your player :p";
            label1.Click += label1_Click;
            // 
            // Firstname_text
            // 
            Firstname_text.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            Firstname_text.Location = new Point(22, 176);
            Firstname_text.Name = "Firstname_text";
            Firstname_text.Size = new Size(125, 27);
            Firstname_text.TabIndex = 2;
            Firstname_text.Text = "Firstname";
            Firstname_text.TextChanged += textBox1_TextChanged;
            // 
            // Lastname_text
            // 
            Lastname_text.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            Lastname_text.Location = new Point(22, 218);
            Lastname_text.Name = "Lastname_text";
            Lastname_text.Size = new Size(125, 27);
            Lastname_text.TabIndex = 3;
            Lastname_text.Text = "Lastname";
            Lastname_text.TextChanged += textBox2_TextChanged;
            // 
            // Teamname_text
            // 
            Teamname_text.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            Teamname_text.Location = new Point(22, 264);
            Teamname_text.Name = "Teamname_text";
            Teamname_text.Size = new Size(125, 27);
            Teamname_text.TabIndex = 4;
            Teamname_text.Text = "Team";
            Teamname_text.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(243, 216);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Add_player
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(Teamname_text);
            Controls.Add(Lastname_text);
            Controls.Add(Firstname_text);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Add_player";
            Text = "Add_player";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private TextBox Firstname_text;
        private TextBox Lastname_text;
        private TextBox Teamname_text;
    }
}