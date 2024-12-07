namespace gestion_dons.PL
{
    partial class USR_List_Utilisateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USR_List_Utilisateur));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnajouteruser = new Button();
            btnsupp = new Button();
            btnmodif = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            txtrecherche = new TextBox();
            panel3 = new Panel();
            cmbrecherche = new ComboBox();
            dgbuser = new DataGridView();
            Column1 = new DataGridViewCheckBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            btncocher = new Button();
            btnimptt = new Button();
            btnexcel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgbuser).BeginInit();
            SuspendLayout();
            // 
            // btnajouteruser
            // 
            btnajouteruser.BackColor = Color.FromArgb(33, 28, 48);
            btnajouteruser.FlatAppearance.BorderSize = 0;
            btnajouteruser.FlatStyle = FlatStyle.Flat;
            btnajouteruser.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnajouteruser.ForeColor = SystemColors.ControlLight;
            btnajouteruser.Image = (Image)resources.GetObject("btnajouteruser.Image");
            btnajouteruser.ImageAlign = ContentAlignment.MiddleLeft;
            btnajouteruser.Location = new Point(88, 16);
            btnajouteruser.Name = "btnajouteruser";
            btnajouteruser.Size = new Size(314, 57);
            btnajouteruser.TabIndex = 0;
            btnajouteruser.Text = "Ajouter";
            btnajouteruser.UseVisualStyleBackColor = false;
            btnajouteruser.Click += btnajouteruser_Click;
            // 
            // btnsupp
            // 
            btnsupp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnsupp.BackColor = Color.FromArgb(33, 28, 48);
            btnsupp.FlatAppearance.BorderSize = 0;
            btnsupp.FlatStyle = FlatStyle.Flat;
            btnsupp.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnsupp.ForeColor = SystemColors.ControlLight;
            btnsupp.Image = (Image)resources.GetObject("btnsupp.Image");
            btnsupp.ImageAlign = ContentAlignment.MiddleLeft;
            btnsupp.Location = new Point(810, 16);
            btnsupp.Name = "btnsupp";
            btnsupp.Size = new Size(312, 57);
            btnsupp.TabIndex = 1;
            btnsupp.Text = "Supprimer";
            btnsupp.UseVisualStyleBackColor = false;
            // 
            // btnmodif
            // 
            btnmodif.Anchor = AnchorStyles.Top;
            btnmodif.BackColor = Color.FromArgb(33, 28, 48);
            btnmodif.FlatAppearance.BorderSize = 0;
            btnmodif.FlatStyle = FlatStyle.Flat;
            btnmodif.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnmodif.ForeColor = SystemColors.ControlLight;
            btnmodif.Image = (Image)resources.GetObject("btnmodif.Image");
            btnmodif.ImageAlign = ContentAlignment.MiddleLeft;
            btnmodif.Location = new Point(464, 16);
            btnmodif.Name = "btnmodif";
            btnmodif.Size = new Size(307, 57);
            btnmodif.TabIndex = 2;
            btnmodif.Text = "Modifier";
            btnmodif.UseVisualStyleBackColor = false;
            btnmodif.Click += btnmodif_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(33, 28, 38);
            panel1.Location = new Point(88, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(1034, 3);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(33, 28, 38);
            panel2.Location = new Point(88, 174);
            panel2.Name = "panel2";
            panel2.Size = new Size(1034, 3);
            panel2.TabIndex = 4;
            // 
            // txtrecherche
            // 
            txtrecherche.BackColor = SystemColors.Control;
            txtrecherche.BorderStyle = BorderStyle.None;
            txtrecherche.Font = new Font("Perpetua Titling MT", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtrecherche.ForeColor = Color.Silver;
            txtrecherche.Location = new Point(619, 110);
            txtrecherche.Multiline = true;
            txtrecherche.Name = "txtrecherche";
            txtrecherche.Size = new Size(318, 41);
            txtrecherche.TabIndex = 5;
            txtrecherche.Text = "Recherche";
            txtrecherche.TextAlign = HorizontalAlignment.Center;
            txtrecherche.Enter += txtrecherche_Enter;
            txtrecherche.Leave += txtrecherche_Leave;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(33, 28, 38);
            panel3.Location = new Point(619, 161);
            panel3.Name = "panel3";
            panel3.Size = new Size(318, 3);
            panel3.TabIndex = 6;
            // 
            // cmbrecherche
            // 
            cmbrecherche.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbrecherche.Font = new Font("Segoe UI", 15F);
            cmbrecherche.FormattingEnabled = true;
            cmbrecherche.Items.AddRange(new object[] { "nom", "prenom", "Email", "ville", "date_inscrit" });
            cmbrecherche.Location = new Point(312, 114);
            cmbrecherche.Name = "cmbrecherche";
            cmbrecherche.Size = new Size(289, 43);
            cmbrecherche.TabIndex = 7;
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
            dgbuser.Location = new Point(0, 177);
            dgbuser.Name = "dgbuser";
            dgbuser.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgbuser.RowHeadersVisible = false;
            dgbuser.RowHeadersWidth = 51;
            dgbuser.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgbuser.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgbuser.Size = new Size(1137, 461);
            dgbuser.TabIndex = 8;
            // 
            // Column1
            // 
            Column1.HeaderText = "select";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "nom";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "prenom";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Email";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "ville";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "date Inscription";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // btncocher
            // 
            btncocher.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btncocher.BackColor = Color.FromArgb(33, 28, 48);
            btncocher.FlatAppearance.BorderSize = 0;
            btncocher.FlatStyle = FlatStyle.Flat;
            btncocher.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btncocher.ForeColor = SystemColors.ControlLight;
            btncocher.Image = (Image)resources.GetObject("btncocher.Image");
            btncocher.ImageAlign = ContentAlignment.MiddleLeft;
            btncocher.Location = new Point(34, 644);
            btncocher.Name = "btncocher";
            btncocher.Size = new Size(268, 57);
            btncocher.TabIndex = 9;
            btncocher.Text = "imprimer Pr  cocher";
            btncocher.UseVisualStyleBackColor = false;
            btncocher.Click += button1_Click;
            // 
            // btnimptt
            // 
            btnimptt.Anchor = AnchorStyles.Bottom;
            btnimptt.BackColor = Color.FromArgb(33, 28, 48);
            btnimptt.FlatAppearance.BorderSize = 0;
            btnimptt.FlatStyle = FlatStyle.Flat;
            btnimptt.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnimptt.ForeColor = SystemColors.ControlLight;
            btnimptt.Image = (Image)resources.GetObject("btnimptt.Image");
            btnimptt.ImageAlign = ContentAlignment.MiddleLeft;
            btnimptt.Location = new Point(453, 644);
            btnimptt.Name = "btnimptt";
            btnimptt.Size = new Size(268, 57);
            btnimptt.TabIndex = 10;
            btnimptt.Text = "imprimer toutes";
            btnimptt.UseVisualStyleBackColor = false;
            // 
            // btnexcel
            // 
            btnexcel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnexcel.BackColor = Color.FromArgb(33, 28, 48);
            btnexcel.FlatAppearance.BorderSize = 0;
            btnexcel.FlatStyle = FlatStyle.Flat;
            btnexcel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnexcel.ForeColor = SystemColors.ControlLight;
            btnexcel.Image = (Image)resources.GetObject("btnexcel.Image");
            btnexcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnexcel.Location = new Point(810, 644);
            btnexcel.Name = "btnexcel";
            btnexcel.Size = new Size(312, 57);
            btnexcel.TabIndex = 11;
            btnexcel.Text = "sauvegarder dans excel";
            btnexcel.UseVisualStyleBackColor = false;
            // 
            // USR_List_Utilisateur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            Controls.Add(btnexcel);
            Controls.Add(btnimptt);
            Controls.Add(btncocher);
            Controls.Add(dgbuser);
            Controls.Add(cmbrecherche);
            Controls.Add(panel3);
            Controls.Add(txtrecherche);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnmodif);
            Controls.Add(btnsupp);
            Controls.Add(btnajouteruser);
            Name = "USR_List_Utilisateur";
            Size = new Size(1137, 721);
            Load += USR_List_Utilisateur_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgbuser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnajouteruser;
        private Button btnsupp;
        private Button btnmodif;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtrecherche;
        private Panel panel3;
        private ComboBox cmbrecherche;
        private DataGridView dgbuser;
        private DataGridViewCheckBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button btncocher;
        private Button btnimptt;
        private Button btnexcel;
    }
}
