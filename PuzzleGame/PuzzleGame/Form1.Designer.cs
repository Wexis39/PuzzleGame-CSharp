namespace PuzzleGame
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
            components = new System.ComponentModel.Container();
            btn00 = new Button();
            btn01 = new Button();
            btn02 = new Button();
            btn12 = new Button();
            btn11 = new Button();
            btn10 = new Button();
            btnBlack = new Button();
            btn21 = new Button();
            btn20 = new Button();
            pictureBox1 = new PictureBox();
            btnStart = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            lblTime = new Label();
            btnRestart = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn00
            // 
            btn00.BackgroundImage = Properties.Resources.row_0_column_0;
            btn00.BackgroundImageLayout = ImageLayout.Zoom;
            btn00.Location = new Point(0, 0);
            btn00.Name = "btn00";
            btn00.Size = new Size(150, 150);
            btn00.TabIndex = 0;
            btn00.UseVisualStyleBackColor = true;
            // 
            // btn01
            // 
            btn01.BackgroundImage = Properties.Resources.row_0_column_1;
            btn01.BackgroundImageLayout = ImageLayout.Zoom;
            btn01.Location = new Point(150, 0);
            btn01.Name = "btn01";
            btn01.Size = new Size(150, 150);
            btn01.TabIndex = 1;
            btn01.UseVisualStyleBackColor = true;
            // 
            // btn02
            // 
            btn02.BackgroundImage = Properties.Resources.row_0_column_2;
            btn02.BackgroundImageLayout = ImageLayout.Zoom;
            btn02.Location = new Point(300, 0);
            btn02.Name = "btn02";
            btn02.Size = new Size(150, 150);
            btn02.TabIndex = 2;
            btn02.UseVisualStyleBackColor = true;
            // 
            // btn12
            // 
            btn12.BackgroundImage = Properties.Resources.row_1_column_2;
            btn12.BackgroundImageLayout = ImageLayout.Zoom;
            btn12.Location = new Point(300, 150);
            btn12.Name = "btn12";
            btn12.Size = new Size(150, 150);
            btn12.TabIndex = 5;
            btn12.UseVisualStyleBackColor = true;
            // 
            // btn11
            // 
            btn11.BackgroundImage = Properties.Resources.row_1_column_1;
            btn11.BackgroundImageLayout = ImageLayout.Zoom;
            btn11.Location = new Point(150, 150);
            btn11.Name = "btn11";
            btn11.Size = new Size(150, 150);
            btn11.TabIndex = 4;
            btn11.UseVisualStyleBackColor = true;
            // 
            // btn10
            // 
            btn10.BackgroundImage = Properties.Resources.row_1_column_0;
            btn10.BackgroundImageLayout = ImageLayout.Zoom;
            btn10.Location = new Point(0, 150);
            btn10.Name = "btn10";
            btn10.Size = new Size(150, 150);
            btn10.TabIndex = 3;
            btn10.UseVisualStyleBackColor = true;
            // 
            // btnBlack
            // 
            btnBlack.BackColor = Color.Black;
            btnBlack.Location = new Point(300, 300);
            btnBlack.Name = "btnBlack";
            btnBlack.Size = new Size(150, 150);
            btnBlack.TabIndex = 8;
            btnBlack.UseVisualStyleBackColor = false;
            // 
            // btn21
            // 
            btn21.BackgroundImage = Properties.Resources.row_2_column_1;
            btn21.BackgroundImageLayout = ImageLayout.Zoom;
            btn21.Location = new Point(150, 300);
            btn21.Name = "btn21";
            btn21.Size = new Size(150, 150);
            btn21.TabIndex = 7;
            btn21.UseVisualStyleBackColor = true;
            // 
            // btn20
            // 
            btn20.BackgroundImage = Properties.Resources.row_2_column_0;
            btn20.BackgroundImageLayout = ImageLayout.Zoom;
            btn20.Location = new Point(0, 300);
            btn20.Name = "btn20";
            btn20.Size = new Size(150, 150);
            btn20.TabIndex = 6;
            btn20.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Full;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(475, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(385, 385);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Transparent;
            btnStart.BackgroundImageLayout = ImageLayout.Zoom;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.ForeColor = Color.Gray;
            btnStart.Image = Properties.Resources.start;
            btnStart.Location = new Point(475, 0);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(134, 65);
            btnStart.TabIndex = 10;
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(627, 2);
            label1.Name = "label1";
            label1.Size = new Size(132, 60);
            label1.TabIndex = 11;
            label1.Text = "Time:";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.Khaki;
            lblTime.Location = new Point(747, 2);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(113, 60);
            lblTime.TabIndex = 11;
            lblTime.Text = "0:00";
            // 
            // btnRestart
            // 
            btnRestart.BackColor = Color.FromArgb(64, 64, 64);
            btnRestart.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRestart.ForeColor = Color.White;
            btnRestart.Location = new Point(475, 393);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(156, 57);
            btnRestart.TabIndex = 12;
            btnRestart.Text = "RESTART";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += btnRestart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(872, 453);
            Controls.Add(btnRestart);
            Controls.Add(lblTime);
            Controls.Add(label1);
            Controls.Add(btnStart);
            Controls.Add(pictureBox1);
            Controls.Add(btnBlack);
            Controls.Add(btn21);
            Controls.Add(btn20);
            Controls.Add(btn12);
            Controls.Add(btn11);
            Controls.Add(btn10);
            Controls.Add(btn02);
            Controls.Add(btn01);
            Controls.Add(btn00);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "PuzzleGame";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn00;
        private Button btn01;
        private Button btn02;
        private Button btn12;
        private Button btn11;
        private Button btn10;
        private Button btnBlack;
        private Button btn21;
        private Button btn20;
        private PictureBox pictureBox1;
        private Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label lblTime;
        private Button btnRestart;
    }
}
