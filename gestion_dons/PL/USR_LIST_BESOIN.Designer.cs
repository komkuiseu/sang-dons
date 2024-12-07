namespace gestion_dons.PL
{
    partial class USR_LIST_BESOIN
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USR_LIST_BESOIN));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnexcel = new Button();
            btnimptt = new Button();
            btnimpcocher = new Button();
            btnsupp = new Button();
            dgbuser = new DataGridView();
            Column1 = new DataGridViewCheckBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            cmbrecherche = new ComboBox();
            txtrecherche = new TextBox();
            panel2 = new Panel();
            panel1 = new Panel();
            btnmodif = new Button();
            btnajouterbesoin = new Button();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgbuser).BeginInit();
            SuspendLayout();
            // 
            // btnexcel
            // 
            btnexcel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnexcel.BackColor = Color.FromArgb(33, 28, 48);
            btnexcel.FlatAppearance.BorderSize = 0;
            btnexcel.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            btnexcel.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btnexcel.FlatStyle = FlatStyle.Flat;
            btnexcel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnexcel.ForeColor = SystemColors.ControlLight;
            btnexcel.Image = (Image)resources.GetObject("btnexcel.Image");
            btnexcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnexcel.Location = new Point(800, 648);
            btnexcel.Name = "btnexcel";
            btnexcel.Size = new Size(312, 57);
            btnexcel.TabIndex = 33;
            btnexcel.Text = "sauvegarder dans excel";
            btnexcel.UseVisualStyleBackColor = false;
            // 
            // btnimptt
            // 
            btnimptt.Anchor = AnchorStyles.Bottom;
            btnimptt.BackColor = Color.FromArgb(33, 28, 48);
            btnimptt.FlatAppearance.BorderSize = 0;
            btnimptt.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            btnimptt.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btnimptt.FlatStyle = FlatStyle.Flat;
            btnimptt.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnimptt.ForeColor = SystemColors.ControlLight;
            btnimptt.Image = (Image)resources.GetObject("btnimptt.Image");
            btnimptt.ImageAlign = ContentAlignment.MiddleLeft;
            btnimptt.Location = new Point(443, 648);
            btnimptt.Name = "btnimptt";
            btnimptt.Size = new Size(268, 57);
            btnimptt.TabIndex = 32;
            btnimptt.Text = "imprimer toutes";
            btnimptt.UseVisualStyleBackColor = false;
            // 
            // btnimpcocher
            // 
            btnimpcocher.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnimpcocher.BackColor = Color.FromArgb(33, 28, 48);
            btnimpcocher.FlatAppearance.BorderSize = 0;
            btnimpcocher.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            btnimpcocher.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btnimpcocher.FlatStyle = FlatStyle.Flat;
            btnimpcocher.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnimpcocher.ForeColor = SystemColors.ControlLight;
            btnimpcocher.Image = (Image)resources.GetObject("btnimpcocher.Image");
            btnimpcocher.ImageAlign = ContentAlignment.MiddleLeft;
            btnimpcocher.Location = new Point(24, 648);
            btnimpcocher.Name = "btnimpcocher";
            btnimpcocher.Size = new Size(268, 57);
            btnimpcocher.TabIndex = 31;
            btnimpcocher.Text = "imprimer Pr  cocher";
            btnimpcocher.UseVisualStyleBackColor = false;
            // 
            // btnsupp
            // 
            btnsupp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnsupp.BackColor = Color.FromArgb(33, 28, 48);
            btnsupp.FlatAppearance.BorderSize = 0;
            btnsupp.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            btnsupp.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btnsupp.FlatStyle = FlatStyle.Flat;
            btnsupp.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnsupp.ForeColor = SystemColors.ControlLight;
            btnsupp.Image = (Image)resources.GetObject("btnsupp.Image");
            btnsupp.ImageAlign = ContentAlignment.MiddleLeft;
            btnsupp.Location = new Point(810, 16);
            btnsupp.Name = "btnsupp";
            btnsupp.Size = new Size(312, 57);
            btnsupp.TabIndex = 30;
            btnsupp.Text = "Annulé le besoin";
            btnsupp.UseVisualStyleBackColor = false;
            // 
            // dgbuser
            // 
            dgbuser.AllowUserToAddRows = false;
            dgbuser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgbuser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgbuser.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 28, 38);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgbuser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgbuser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgbuser.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgbuser.EnableHeadersVisualStyles = false;
            dgbuser.Location = new Point(0, 188);
            dgbuser.Name = "dgbuser";
            dgbuser.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgbuser.RowHeadersVisible = false;
            dgbuser.RowHeadersWidth = 51;
            dgbuser.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgbuser.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgbuser.Size = new Size(1137, 454);
            dgbuser.TabIndex = 29;
            // 
            // Column1
            // 
            Column1.HeaderText = "select";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Lieu";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Goupe sanguin";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "date besoin";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "quantité besoin";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "urgence";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // cmbrecherche
            // 
            cmbrecherche.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbrecherche.Font = new Font("Segoe UI", 15F);
            cmbrecherche.FormattingEnabled = true;
            cmbrecherche.Items.AddRange(new object[] { "urgence", "Lieu", "date", "quantité", "Grp sanguin" });
            cmbrecherche.Location = new Point(312, 121);
            cmbrecherche.Name = "cmbrecherche";
            cmbrecherche.Size = new Size(289, 43);
            cmbrecherche.TabIndex = 28;
            // 
            // txtrecherche
            // 
            txtrecherche.BackColor = SystemColors.Control;
            txtrecherche.BorderStyle = BorderStyle.None;
            txtrecherche.Font = new Font("Perpetua Titling MT", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtrecherche.ForeColor = Color.Silver;
            txtrecherche.Location = new Point(619, 117);
            txtrecherche.Multiline = true;
            txtrecherche.Name = "txtrecherche";
            txtrecherche.Size = new Size(318, 41);
            txtrecherche.TabIndex = 26;
            txtrecherche.Text = "Recherche";
            txtrecherche.TextAlign = HorizontalAlignment.Center;
            txtrecherche.Enter += txtrecherche_Enter;
            txtrecherche.Leave += txtrecherche_Leave;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(33, 28, 38);
            panel2.Location = new Point(88, 179);
            panel2.Name = "panel2";
            panel2.Size = new Size(1034, 3);
            panel2.TabIndex = 25;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(33, 28, 38);
            panel1.Location = new Point(88, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(1034, 3);
            panel1.TabIndex = 24;
            // 
            // btnmodif
            // 
            btnmodif.Anchor = AnchorStyles.Top;
            btnmodif.BackColor = Color.FromArgb(33, 28, 48);
            btnmodif.FlatAppearance.BorderSize = 0;
            btnmodif.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            btnmodif.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btnmodif.FlatStyle = FlatStyle.Flat;
            btnmodif.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnmodif.ForeColor = SystemColors.ControlLight;
            btnmodif.Image = (Image)resources.GetObject("btnmodif.Image");
            btnmodif.ImageAlign = ContentAlignment.MiddleLeft;
            btnmodif.Location = new Point(464, 16);
            btnmodif.Name = "btnmodif";
            btnmodif.Size = new Size(307, 57);
            btnmodif.TabIndex = 23;
            btnmodif.Text = "Modifier";
            btnmodif.UseVisualStyleBackColor = false;
            btnmodif.Click += btnmodif_Click;
            // 
            // btnajouterbesoin
            // 
            btnajouterbesoin.BackColor = Color.FromArgb(33, 28, 48);
            btnajouterbesoin.FlatAppearance.BorderSize = 0;
            btnajouterbesoin.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            btnajouterbesoin.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btnajouterbesoin.FlatStyle = FlatStyle.Flat;
            btnajouterbesoin.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnajouterbesoin.ForeColor = SystemColors.ControlLight;
            btnajouterbesoin.Image = (Image)resources.GetObject("btnajouterbesoin.Image");
            btnajouterbesoin.ImageAlign = ContentAlignment.MiddleLeft;
            btnajouterbesoin.Location = new Point(88, 16);
            btnajouterbesoin.Name = "btnajouterbesoin";
            btnajouterbesoin.Size = new Size(314, 57);
            btnajouterbesoin.TabIndex = 22;
            btnajouterbesoin.Text = "Ajouter";
            btnajouterbesoin.UseVisualStyleBackColor = false;
            btnajouterbesoin.Click += btnajouterbesoin_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(33, 28, 38);
            panel3.Location = new Point(619, 161);
            panel3.Name = "panel3";
            panel3.Size = new Size(318, 3);
            panel3.TabIndex = 27;
            // 
            // USR_LIST_BESOIN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnexcel);
            Controls.Add(btnimptt);
            Controls.Add(btnimpcocher);
            Controls.Add(btnsupp);
            Controls.Add(dgbuser);
            Controls.Add(cmbrecherche);
            Controls.Add(txtrecherche);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnmodif);
            Controls.Add(btnajouterbesoin);
            Controls.Add(panel3);
            Name = "USR_LIST_BESOIN";
            Size = new Size(1137, 720);
            Load += USR_LIST_BESOIN_Load;
            ((System.ComponentModel.ISupportInitialize)dgbuser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnexcel;
        private Button btnimptt;
        private Button btnimpcocher;
        private Button btnsupp;
        private DataGridView dgbuser;
        private ComboBox cmbrecherche;
        private TextBox txtrecherche;
        private Panel panel2;
        private Panel panel1;
        private Button btnmodif;
        private Button btnajouterbesoin;
        private Panel panel3;
        private DataGridViewCheckBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}
