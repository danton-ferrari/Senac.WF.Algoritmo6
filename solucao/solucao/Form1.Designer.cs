namespace solucao
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
            panel3 = new Panel();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(linkLabel1);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(textBox1);
            panel3.Location = new Point(475, 140);
            panel3.Name = "panel3";
            panel3.Size = new Size(350, 450);
            panel3.TabIndex = 3;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI", 6F);
            linkLabel1.ForeColor = Color.White;
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(132, 435);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(95, 15);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Recuperar Senha";
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 7F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(132, 177);
            button1.Name = "button1";
            button1.Size = new Size(100, 25);
            button1.TabIndex = 3;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.IndianRed;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(28, 109);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(300, 31);
            textBox2.TabIndex = 2;
            textBox2.Text = "SENHA";
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.IndianRed;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(28, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 31);
            textBox1.TabIndex = 1;
            textBox1.Text = "USUÁRIO";
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1231, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, -7);
            panel1.Name = "panel1";
            panel1.Size = new Size(1310, 733);
            panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1180, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources._4k_pc_8dxv1c1kpj1bsvde;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(660, 733);
            panel2.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(135, 152, 34);
            ClientSize = new Size(1308, 721);
            Controls.Add(panel1);
            ForeColor = SystemColors.Desktop;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private LinkLabel linkLabel1;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
    }
}
