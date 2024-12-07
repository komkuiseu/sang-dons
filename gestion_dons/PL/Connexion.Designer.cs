namespace gestion_dons.PL
{
    partial class Connexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            btnFerme = new Button();
            label1 = new Label();
            txtnom = new TextBox();
            panel5 = new Panel();
            panel6 = new Panel();
            txtpass = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btncon = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(178, 8, 55);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(450, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(2, 518);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(178, 8, 55);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 2);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(178, 8, 55);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(2, 516);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(178, 8, 55);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(2, 516);
            panel4.Name = "panel4";
            panel4.Size = new Size(448, 2);
            panel4.TabIndex = 3;
            // 
            // btnFerme
            // 
            btnFerme.FlatAppearance.BorderSize = 0;
            btnFerme.FlatStyle = FlatStyle.Flat;
            btnFerme.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFerme.ForeColor = Color.FromArgb(192, 0, 0);
            btnFerme.Location = new Point(400, 3);
            btnFerme.Name = "btnFerme";
            btnFerme.Size = new Size(44, 60);
            btnFerme.TabIndex = 4;
            btnFerme.Text = "X";
            btnFerme.TextAlign = ContentAlignment.TopCenter;
            btnFerme.UseVisualStyleBackColor = true;
            btnFerme.Click += btnFerme_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(98, 61);
            label1.Name = "label1";
            label1.Size = new Size(254, 56);
            label1.TabIndex = 5;
            label1.Text = "Connexion";
            // 
            // txtnom
            // 
            txtnom.BackColor = Color.FromArgb(30, 28, 38);
            txtnom.BorderStyle = BorderStyle.None;
            txtnom.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtnom.ForeColor = Color.FromArgb(224, 224, 224);
            txtnom.Location = new Point(90, 195);
            txtnom.Multiline = true;
            txtnom.Name = "txtnom";
            txtnom.Size = new Size(337, 45);
            txtnom.TabIndex = 6;
            txtnom.Text = "Nom d' utilisateur";
            txtnom.Enter += txtnom_Enter;
            txtnom.Leave += txtnom_Leave;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(90, 237);
            panel5.Name = "panel5";
            panel5.Size = new Size(340, 1);
            panel5.TabIndex = 7;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(87, 338);
            panel6.Name = "panel6";
            panel6.Size = new Size(340, 1);
            panel6.TabIndex = 9;
            // 
            // txtpass
            // 
            txtpass.BackColor = Color.FromArgb(30, 28, 38);
            txtpass.BorderStyle = BorderStyle.None;
            txtpass.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtpass.ForeColor = Color.FromArgb(224, 224, 224);
            txtpass.Location = new Point(87, 296);
            txtpass.Multiline = true;
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(337, 45);
            txtpass.TabIndex = 8;
            txtpass.Text = "Password";
            txtpass.Enter += txtpass_Enter;
            txtpass.Leave += txtpass_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(35, 195);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(32, 294);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // btncon
            // 
            btncon.BackColor = Color.FromArgb(178, 8, 55);
            btncon.FlatAppearance.BorderSize = 0;
            btncon.FlatStyle = FlatStyle.Flat;
            btncon.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncon.ForeColor = SystemColors.MenuBar;
            btncon.Location = new Point(35, 413);
            btncon.Name = "btncon";
            btncon.Size = new Size(395, 61);
            btncon.TabIndex = 12;
            btncon.Text = "Se Connecter";
            btncon.UseVisualStyleBackColor = false;
            btncon.Click += button1_Click;
            // 
            // Connexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 28, 38);
            ClientSize = new Size(452, 518);
            Controls.Add(btncon);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel6);
            Controls.Add(txtpass);
            Controls.Add(panel5);
            Controls.Add(txtnom);
            Controls.Add(label1);
            Controls.Add(btnFerme);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Connexion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Connexion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button btnFerme;
        private Label label1;
        private TextBox txtnom;
        private Panel panel5;
        private Panel panel6;
        private TextBox txtpass;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btncon;
    }
}