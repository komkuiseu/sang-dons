namespace gestion_dons.PL
{
    partial class USR_STOCK_SANG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USR_STOCK_SANG));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnexcel = new Button();
            btnimptt = new Button();
            btnimpcocher = new Button();
            dgbuser = new DataGridView();
            cmbrecherche = new ComboBox();
            txtrecherche = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            Column1 = new DataGridViewCheckBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
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
            dgbuser.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column5, Column6 });
            dgbuser.EnableHeadersVisualStyles = false;
            dgbuser.Location = new Point(0, 100);
            dgbuser.Name = "dgbuser";
            dgbuser.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgbuser.RowHeadersVisible = false;
            dgbuser.RowHeadersWidth = 51;
            dgbuser.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgbuser.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgbuser.Size = new Size(1137, 527);
            dgbuser.TabIndex = 29;
            // 
            // cmbrecherche
            // 
            cmbrecherche.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbrecherche.Font = new Font("Segoe UI", 15F);
            cmbrecherche.FormattingEnabled = true;
            cmbrecherche.Items.AddRange(new object[] { "nom", "Lieu", "date", "quantité", "Grp sanguin" });
            cmbrecherche.Location = new Point(312, 33);
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
            txtrecherche.Location = new Point(619, 29);
            txtrecherche.Multiline = true;
            txtrecherche.Name = "txtrecherche";
            txtrecherche.Size = new Size(318, 41);
            txtrecherche.TabIndex = 26;
            txtrecherche.Text = "Recherche";
            txtrecherche.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(33, 28, 38);
            panel2.Location = new Point(88, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(1034, 3);
            panel2.TabIndex = 25;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(33, 28, 38);
            panel3.Location = new Point(619, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(318, 3);
            panel3.TabIndex = 27;
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
            // USR_STOCK_SANG
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnexcel);
            Controls.Add(btnimptt);
            Controls.Add(btnimpcocher);
            Controls.Add(dgbuser);
            Controls.Add(cmbrecherche);
            Controls.Add(txtrecherche);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "USR_STOCK_SANG";
            Size = new Size(1137, 720);
            Load += USR_STOCK_SANG_Load;
            ((System.ComponentModel.ISupportInitialize)dgbuser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnexcel;
        private Button btnimptt;
        private Button btnimpcocher;
        private DataGridView dgbuser;
        private DataGridViewCheckBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private ComboBox cmbrecherche;
        private TextBox txtrecherche;
        private Panel panel2;
        private Panel panel3;
    }
}
