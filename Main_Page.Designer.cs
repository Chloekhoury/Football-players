namespace CS
{
    partial class Main_Page
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
            label2 = new Label();
            Search_TextBox = new TextBox();
            Search_Button = new Button();
            label3 = new Label();
            button2 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label1 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1000_F_132029225_bBVawDejPqhcKR8IvlTzLalJSSlFRVas1;
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 102);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveBorder;
            label2.Font = new Font("Britannic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(91, 134);
            label2.Name = "label2";
            label2.Size = new Size(620, 26);
            label2.TabIndex = 3;
            label2.Text = "Search for your favorite player, team or whatever you want!!";
            label2.Click += label2_Click;
            // 
            // Search_TextBox
            // 
            Search_TextBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Search_TextBox.ForeColor = SystemColors.WindowFrame;
            Search_TextBox.Location = new Point(316, 195);
            Search_TextBox.Name = "Search_TextBox";
            Search_TextBox.Size = new Size(125, 28);
            Search_TextBox.TabIndex = 4;
            Search_TextBox.Text = "search";
            Search_TextBox.TextChanged += textBox1_TextChanged;
            // 
            // Search_Button
            // 
            Search_Button.BackColor = SystemColors.ActiveCaptionText;
            Search_Button.ForeColor = SystemColors.ActiveBorder;
            Search_Button.Location = new Point(331, 238);
            Search_Button.Name = "Search_Button";
            Search_Button.Size = new Size(94, 29);
            Search_Button.TabIndex = 5;
            Search_Button.Text = "Search";
            Search_Button.UseVisualStyleBackColor = false;
            Search_Button.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DimGray;
            label3.Font = new Font("Britannic Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(12, 361);
            label3.Name = "label3";
            label3.Size = new Size(341, 21);
            label3.TabIndex = 6;
            label3.Text = "You can also add a player or  a team :P";
            label3.Click += label3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveBorder;
            button2.Location = new Point(424, 351);
            button2.Name = "button2";
            button2.Size = new Size(122, 37);
            button2.TabIndex = 7;
            button2.Text = "New player";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.FromArgb(64, 64, 64);
            checkBox1.ForeColor = SystemColors.ButtonFace;
            checkBox1.Location = new Point(91, 184);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(71, 24);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Player";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.FromArgb(64, 64, 64);
            checkBox2.ForeColor = SystemColors.ButtonFace;
            checkBox2.Location = new Point(91, 214);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(67, 24);
            checkBox2.TabIndex = 10;
            checkBox2.Text = "Team";
            checkBox2.UseVisualStyleBackColor = false;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(217, 50);
            label1.Name = "label1";
            label1.Size = new Size(349, 33);
            label1.TabIndex = 2;
            label1.Text = "Your Own FIBA World";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources._3d_render_illustration_football_on_the_football_field_in_night_stadium_and_sport_light_background_free_photo2;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(806, 478);
            panel1.TabIndex = 11;
            panel1.TabStop = true;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(302, 281);
            button1.Name = "button1";
            button1.Size = new Size(158, 29);
            button1.TabIndex = 4;
            button1.Text = "View all players";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(447, 171);
            panel2.Name = "panel2";
            panel2.Size = new Size(341, 166);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.DimGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(300, 234);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(19, 99);
            label7.Name = "label7";
            label7.Size = new Size(0, 28);
            label7.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(19, 60);
            label5.Name = "label5";
            label5.Size = new Size(0, 28);
            label5.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(19, 21);
            label4.Name = "label4";
            label4.Size = new Size(0, 28);
            label4.TabIndex = 0;
            // 
            // Main_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(Search_Button);
            Controls.Add(Search_TextBox);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Main_Page";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private TextBox Search_TextBox;
        private Button Search_Button;
        private Label label3;
        private Button button2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label7;
        private Label label5;
        private Label label4;
        private DataGridView dataGridView1;
        private Button button1;
    }
}