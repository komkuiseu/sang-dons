namespace gestion_dons.PL
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            panel1 = new Panel();
            btnnotif = new Button();
            pnuBut = new Panel();
            btnmenu = new Button();
            btnDecon = new Button();
            btnbesoin = new Button();
            btnStock = new Button();
            btnDons = new Button();
            btnuser = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            pnlParametre = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pnlAffichage = new Panel();
            btnpara = new Button();
            btnred = new Button();
            btnFerme = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            pnlParametre.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 39, 40);
            panel1.Controls.Add(btnnotif);
            panel1.Controls.Add(pnuBut);
            panel1.Controls.Add(btnmenu);
            panel1.Controls.Add(btnDecon);
            panel1.Controls.Add(btnbesoin);
            panel1.Controls.Add(btnStock);
            panel1.Controls.Add(btnDons);
            panel1.Controls.Add(btnuser);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 745);
            panel1.TabIndex = 0;
            // 
            // btnnotif
            // 
            btnnotif.FlatAppearance.BorderSize = 0;
            btnnotif.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 8, 55);
            btnnotif.FlatAppearance.MouseOverBackColor = Color.FromArgb(178, 8, 74);
            btnnotif.FlatStyle = FlatStyle.Flat;
            btnnotif.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnnotif.ForeColor = SystemColors.ControlLight;
            btnnotif.Image = (Image)resources.GetObject("btnnotif.Image");
            btnnotif.ImageAlign = ContentAlignment.MiddleLeft;
            btnnotif.Location = new Point(13, 534);
            btnnotif.Name = "btnnotif";
            btnnotif.Size = new Size(247, 58);
            btnnotif.TabIndex = 10;
            btnnotif.Text = "  Notifications";
            btnnotif.UseVisualStyleBackColor = true;
            // 
            // pnuBut
            // 
            pnuBut.BackColor = Color.FromArgb(178, 8, 55);
            pnuBut.Location = new Point(3, 128);
            pnuBut.Name = "pnuBut";
            pnuBut.Size = new Size(10, 58);
            pnuBut.TabIndex = 6;
            // 
            // btnmenu
            // 
            btnmenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnmenu.FlatAppearance.BorderSize = 0;
            btnmenu.FlatStyle = FlatStyle.Flat;
            btnmenu.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnmenu.ForeColor = Color.Red;
            btnmenu.Image = (Image)resources.GetObject("btnmenu.Image");
            btnmenu.Location = new Point(222, 5);
            btnmenu.Name = "btnmenu";
            btnmenu.Size = new Size(53, 43);
            btnmenu.TabIndex = 9;
            btnmenu.UseVisualStyleBackColor = true;
            btnmenu.Click += btnmenu_Click;
            // 
            // btnDecon
            // 
            btnDecon.Dock = DockStyle.Bottom;
            btnDecon.FlatAppearance.BorderSize = 0;
            btnDecon.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 8, 55);
            btnDecon.FlatAppearance.MouseOverBackColor = Color.FromArgb(178, 8, 74);
            btnDecon.FlatStyle = FlatStyle.Flat;
            btnDecon.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDecon.ForeColor = SystemColors.ControlLight;
            btnDecon.Image = (Image)resources.GetObject("btnDecon.Image");
            btnDecon.ImageAlign = ContentAlignment.MiddleLeft;
            btnDecon.Location = new Point(0, 681);
            btnDecon.Name = "btnDecon";
            btnDecon.Size = new Size(282, 64);
            btnDecon.TabIndex = 8;
            btnDecon.Text = "Deconnexion";
            btnDecon.UseVisualStyleBackColor = true;
            btnDecon.Click += btnDecon_Click;
            // 
            // btnbesoin
            // 
            btnbesoin.FlatAppearance.BorderSize = 0;
            btnbesoin.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 8, 55);
            btnbesoin.FlatAppearance.MouseOverBackColor = Color.FromArgb(178, 8, 74);
            btnbesoin.FlatStyle = FlatStyle.Flat;
            btnbesoin.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnbesoin.ForeColor = SystemColors.ControlLight;
            btnbesoin.Image = (Image)resources.GetObject("btnbesoin.Image");
            btnbesoin.ImageAlign = ContentAlignment.MiddleLeft;
            btnbesoin.Location = new Point(12, 449);
            btnbesoin.Name = "btnbesoin";
            btnbesoin.Size = new Size(247, 58);
            btnbesoin.TabIndex = 7;
            btnbesoin.Text = "  Besoins";
            btnbesoin.UseVisualStyleBackColor = true;
            btnbesoin.Click += btnNotiv_Click;
            // 
            // btnStock
            // 
            btnStock.FlatAppearance.BorderSize = 0;
            btnStock.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 8, 55);
            btnStock.FlatAppearance.MouseOverBackColor = Color.FromArgb(178, 8, 74);
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStock.ForeColor = SystemColors.ControlLight;
            btnStock.Image = (Image)resources.GetObject("btnStock.Image");
            btnStock.ImageAlign = ContentAlignment.MiddleLeft;
            btnStock.Location = new Point(2, 340);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(247, 64);
            btnStock.TabIndex = 6;
            btnStock.Text = "Stocks";
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += btnStock_Click;
            // 
            // btnDons
            // 
            btnDons.FlatAppearance.BorderSize = 0;
            btnDons.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 8, 55);
            btnDons.FlatAppearance.MouseOverBackColor = Color.FromArgb(178, 8, 74);
            btnDons.FlatStyle = FlatStyle.Flat;
            btnDons.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDons.ForeColor = SystemColors.ControlLight;
            btnDons.Image = (Image)resources.GetObject("btnDons.Image");
            btnDons.ImageAlign = ContentAlignment.MiddleLeft;
            btnDons.Location = new Point(2, 232);
            btnDons.Name = "btnDons";
            btnDons.Size = new Size(247, 64);
            btnDons.TabIndex = 5;
            btnDons.Text = "Dons";
            btnDons.UseVisualStyleBackColor = true;
            btnDons.Click += btnDons_Click;
            // 
            // btnuser
            // 
            btnuser.FlatAppearance.BorderSize = 0;
            btnuser.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 8, 55);
            btnuser.FlatAppearance.MouseOverBackColor = Color.FromArgb(178, 8, 74);
            btnuser.FlatStyle = FlatStyle.Flat;
            btnuser.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnuser.ForeColor = SystemColors.ControlLight;
            btnuser.Image = (Image)resources.GetObject("btnuser.Image");
            btnuser.ImageAlign = ContentAlignment.MiddleLeft;
            btnuser.Location = new Point(13, 122);
            btnuser.Name = "btnuser";
            btnuser.Size = new Size(247, 64);
            btnuser.TabIndex = 4;
            btnuser.Text = "Utilisateur";
            btnuser.UseVisualStyleBackColor = true;
            btnuser.Click += btnuser_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(178, 8, 55);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(282, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(823, 16);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(pnlParametre);
            panel3.Controls.Add(pnlAffichage);
            panel3.Controls.Add(btnpara);
            panel3.Controls.Add(btnred);
            panel3.Controls.Add(btnFerme);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(282, 16);
            panel3.Name = "panel3";
            panel3.Size = new Size(823, 729);
            panel3.TabIndex = 2;
            // 
            // pnlParametre
            // 
            pnlParametre.BackColor = Color.FromArgb(41, 39, 40);
            pnlParametre.Controls.Add(button4);
            pnlParametre.Controls.Add(button3);
            pnlParametre.Controls.Add(button2);
            pnlParametre.Controls.Add(button1);
            pnlParametre.Location = new Point(51, 3);
            pnlParametre.Name = "pnlParametre";
            pnlParametre.Size = new Size(349, 54);
            pnlParametre.TabIndex = 13;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderColor = Color.FromArgb(178, 8, 55);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 8, 55);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(178, 8, 55);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlDarkDark;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(3, 180);
            button4.Name = "button4";
            button4.Size = new Size(320, 53);
            button4.TabIndex = 3;
            button4.Text = "Deconnecter";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderColor = Color.FromArgb(178, 8, 55);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 8, 55);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(178, 8, 55);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlDarkDark;
            button3.Location = new Point(0, 123);
            button3.Name = "button3";
            button3.Size = new Size(320, 53);
            button3.TabIndex = 2;
            button3.Text = "Restaurer une copie Enregistrée";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.FromArgb(178, 8, 55);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 8, 55);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(178, 8, 55);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlDarkDark;
            button2.Location = new Point(3, 62);
            button2.Name = "button2";
            button2.Size = new Size(320, 53);
            button2.TabIndex = 1;
            button2.Text = "creer une copie de l application";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.FromArgb(178, 8, 55);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 8, 55);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(178, 8, 55);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlDarkDark;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(320, 53);
            button1.TabIndex = 0;
            button1.Text = "connecter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // pnlAffichage
            // 
            pnlAffichage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlAffichage.BackColor = SystemColors.Control;
            pnlAffichage.Location = new Point(0, 63);
            pnlAffichage.Name = "pnlAffichage";
            pnlAffichage.Size = new Size(823, 666);
            pnlAffichage.TabIndex = 15;
            // 
            // btnpara
            // 
            btnpara.FlatAppearance.BorderSize = 0;
            btnpara.FlatStyle = FlatStyle.Flat;
            btnpara.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnpara.ForeColor = Color.Red;
            btnpara.Image = (Image)resources.GetObject("btnpara.Image");
            btnpara.Location = new Point(0, 3);
            btnpara.Name = "btnpara";
            btnpara.Size = new Size(48, 43);
            btnpara.TabIndex = 14;
            btnpara.UseVisualStyleBackColor = true;
            btnpara.Click += button1_Click;
            // 
            // btnred
            // 
            btnred.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnred.FlatAppearance.BorderSize = 0;
            btnred.FlatStyle = FlatStyle.Flat;
            btnred.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnred.ForeColor = Color.Red;
            btnred.Image = (Image)resources.GetObject("btnred.Image");
            btnred.Location = new Point(725, 6);
            btnred.Name = "btnred";
            btnred.Size = new Size(39, 40);
            btnred.TabIndex = 12;
            btnred.UseVisualStyleBackColor = true;
            btnred.Click += btnred_Click;
            // 
            // btnFerme
            // 
            btnFerme.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFerme.FlatAppearance.BorderSize = 0;
            btnFerme.FlatStyle = FlatStyle.Flat;
            btnFerme.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFerme.ForeColor = Color.Red;
            btnFerme.Image = (Image)resources.GetObject("btnFerme.Image");
            btnFerme.Location = new Point(770, 2);
            btnFerme.Name = "btnFerme";
            btnFerme.Size = new Size(53, 43);
            btnFerme.TabIndex = 11;
            btnFerme.UseVisualStyleBackColor = true;
            btnFerme.Click += btnFerme_Click_1;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 745);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(0, 64, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            pnlParametre.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnuser;
        private Button btnbesoin;
        private Button btnStock;
        private Button btnDons;
        private Button btnDecon;
        private Button btnmenu;
        private Panel pnuBut;
        private Panel panel3;
        private Button btnpara;
        private Panel pnlParametre;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button btnred;
        private Button btnFerme;
        private Panel pnlAffichage;
        private Button btnnotif;
    }
}