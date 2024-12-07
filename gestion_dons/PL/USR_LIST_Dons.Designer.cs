namespace gestion_dons.PL
{
    partial class USR_LIST_Dons
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USR_LIST_Dons));
            dgbuser = new DataGridView();
            Column1 = new DataGridViewCheckBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            cmbrecherche = new ComboBox();
            panel3 = new Panel();
            txtrecherche = new TextBox();
            panel2 = new Panel();
            panel1 = new Panel();
            btnmodif = new Button();
            btnajouterdons = new Button();
            button1 = new Button();
            btnexcel = new Button();
            btnimptt = new Button();
            btnimpcocher = new Button();
            ((System.ComponentModel.ISupportInitialize)dgbuser).BeginInit();
            SuspendLayout();
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
            dgbuser.Location = new Point(3, 185);
            dgbuser.Name = "dgbuser";
            dgbuser.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgbuser.RowHeadersVisible = false;
            dgbuser.RowHeadersWidth = 51;
            dgbuser.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgbuser.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgbuser.Size = new Size(1137, 454);
            dgbuser.TabIndex = 17;
            // 
            // Column1
            // 
            Column1.HeaderText = "select";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "utilisateur ";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "lieu";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "date";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Quantité";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "groupe sanguin";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // cmbrecherche
            // 
            cmbrecherche.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbrecherche.Font = new Font("Segoe UI", 15F);
            cmbrecherche.FormattingEnabled = true;
            cmbrecherche.Items.AddRange(new object[] { "nom", "Lieu", "date", "quantité", "Grp sanguin" });
            cmbrecherche.Location = new Point(315, 118);
            cmbrecherche.Name = "cmbrecherche";
            cmbrecherche.Size = new Size(289, 43);
            cmbrecherche.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(33, 28, 38);
            panel3.Location = new Point(622, 158);
            panel3.Name = "panel3";
            panel3.Size = new Size(318, 3);
            panel3.TabIndex = 15;
            // 
            // txtrecherche
            // 
            txtrecherche.BackColor = SystemColors.Control;
            txtrecherche.BorderStyle = BorderStyle.None;
            txtrecherche.Font = new Font("Perpetua Titling MT", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtrecherche.ForeColor = Color.Silver;
            txtrecherche.Location = new Point(622, 114);
            txtrecherche.Multiline = true;
            txtrecherche.Name = "txtrecherche";
            txtrecherche.Size = new Size(318, 41);
            txtrecherche.TabIndex = 14;
            txtrecherche.Text = "Recherche";
            txtrecherche.TextAlign = HorizontalAlignment.Center;
            txtrecherche.Enter += txtrecherche_Enter;
            txtrecherche.Leave += txtrecherche_Leave;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(33, 28, 38);
            panel2.Location = new Point(91, 176);
            panel2.Name = "panel2";
            panel2.Size = new Size(1034, 3);
            panel2.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(33, 28, 38);
            panel1.Location = new Point(91, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(1034, 3);
            panel1.TabIndex = 12;
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
            btnmodif.Location = new Point(467, 13);
            btnmodif.Name = "btnmodif";
            btnmodif.Size = new Size(307, 57);
            btnmodif.TabIndex = 11;
            btnmodif.Text = "Modifier";
            btnmodif.UseVisualStyleBackColor = false;
            btnmodif.Click += btnmodif_Click;
            // 
            // btnajouterdons
            // 
            btnajouterdons.BackColor = Color.FromArgb(33, 28, 48);
            btnajouterdons.FlatAppearance.BorderSize = 0;
            btnajouterdons.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            btnajouterdons.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btnajouterdons.FlatStyle = FlatStyle.Flat;
            btnajouterdons.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnajouterdons.ForeColor = SystemColors.ControlLight;
            btnajouterdons.Image = (Image)resources.GetObject("btnajouterdons.Image");
            btnajouterdons.ImageAlign = ContentAlignment.MiddleLeft;
            btnajouterdons.Location = new Point(91, 13);
            btnajouterdons.Name = "btnajouterdons";
            btnajouterdons.Size = new Size(314, 57);
            btnajouterdons.TabIndex = 9;
            btnajouterdons.Text = "Ajouter";
            btnajouterdons.UseVisualStyleBackColor = false;
            btnajouterdons.Click += btnajouterdons_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(33, 28, 48);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(813, 13);
            button1.Name = "button1";
            button1.Size = new Size(312, 57);
            button1.TabIndex = 18;
            button1.Text = "Supprimer";
            button1.UseVisualStyleBackColor = false;
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
            btnexcel.Location = new Point(803, 645);
            btnexcel.Name = "btnexcel";
            btnexcel.Size = new Size(312, 57);
            btnexcel.TabIndex = 21;
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
            btnimptt.Location = new Point(446, 645);
            btnimptt.Name = "btnimptt";
            btnimptt.Size = new Size(268, 57);
            btnimptt.TabIndex = 20;
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
            btnimpcocher.Location = new Point(27, 645);
            btnimpcocher.Name = "btnimpcocher";
            btnimpcocher.Size = new Size(268, 57);
            btnimpcocher.TabIndex = 19;
            btnimpcocher.Text = "imprimer Pr  cocher";
            btnimpcocher.UseVisualStyleBackColor = false;
            // 
            // USR_LIST_Dons
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnexcel);
            Controls.Add(btnimptt);
            Controls.Add(btnimpcocher);
            Controls.Add(button1);
            Controls.Add(dgbuser);
            Controls.Add(cmbrecherche);
            Controls.Add(panel3);
            Controls.Add(txtrecherche);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnmodif);
            Controls.Add(btnajouterdons);
            Name = "USR_LIST_Dons";
            Size = new Size(1137, 720);
            ((System.ComponentModel.ISupportInitialize)dgbuser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgbuser;
        private ComboBox cmbrecherche;
        private Panel panel3;
        private TextBox txtrecherche;
        private Panel panel2;
        private Panel panel1;
        private Button btnmodif;
        private Button btnajouterdons;
        private Button button1;
        private DataGridViewCheckBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button btnexcel;
        private Button btnimptt;
        private Button btnimpcocher;
    }
}
