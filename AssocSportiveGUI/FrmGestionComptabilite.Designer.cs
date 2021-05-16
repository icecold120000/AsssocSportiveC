
namespace AssocSportiveGUI
{
    partial class FrmGestionComptabilite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionComptabilite));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.présentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesÉlèvesAdhérantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesBudgetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeLaComptabilitéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ecranStatistiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstEleve = new System.Windows.Forms.DataGridView();
            this.lblRechercheEleve = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.btnAcces = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstEleve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.présentationToolStripMenuItem,
            this.gestionDesÉlèvesAdhérantsToolStripMenuItem,
            this.gestionDesBudgetsToolStripMenuItem,
            this.gestionDeLaComptabilitéToolStripMenuItem,
            this.ecranStatistiqueToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1080, 33);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // présentationToolStripMenuItem
            // 
            this.présentationToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.présentationToolStripMenuItem.Name = "présentationToolStripMenuItem";
            this.présentationToolStripMenuItem.Size = new System.Drawing.Size(126, 29);
            this.présentationToolStripMenuItem.Text = "Présentation";
            // 
            // gestionDesÉlèvesAdhérantsToolStripMenuItem
            // 
            this.gestionDesÉlèvesAdhérantsToolStripMenuItem.Name = "gestionDesÉlèvesAdhérantsToolStripMenuItem";
            this.gestionDesÉlèvesAdhérantsToolStripMenuItem.Size = new System.Drawing.Size(257, 29);
            this.gestionDesÉlèvesAdhérantsToolStripMenuItem.Text = "Gestion des élèves adhérants";
            // 
            // gestionDesBudgetsToolStripMenuItem
            // 
            this.gestionDesBudgetsToolStripMenuItem.Name = "gestionDesBudgetsToolStripMenuItem";
            this.gestionDesBudgetsToolStripMenuItem.Size = new System.Drawing.Size(192, 29);
            this.gestionDesBudgetsToolStripMenuItem.Text = "Gestion des budgets";
            // 
            // gestionDeLaComptabilitéToolStripMenuItem
            // 
            this.gestionDeLaComptabilitéToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gestionDeLaComptabilitéToolStripMenuItem.Name = "gestionDeLaComptabilitéToolStripMenuItem";
            this.gestionDeLaComptabilitéToolStripMenuItem.Size = new System.Drawing.Size(235, 29);
            this.gestionDeLaComptabilitéToolStripMenuItem.Text = "Gestion de la comptabilité";
            // 
            // ecranStatistiqueToolStripMenuItem
            // 
            this.ecranStatistiqueToolStripMenuItem.Name = "ecranStatistiqueToolStripMenuItem";
            this.ecranStatistiqueToolStripMenuItem.Size = new System.Drawing.Size(156, 29);
            this.ecranStatistiqueToolStripMenuItem.Text = "Ecran statistique";
            this.ecranStatistiqueToolStripMenuItem.Click += new System.EventHandler(this.ecranStatistiqueToolStripMenuItem_Click);
            // 
            // lstEleve
            // 
            this.lstEleve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstEleve.Location = new System.Drawing.Point(77, 338);
            this.lstEleve.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstEleve.Name = "lstEleve";
            this.lstEleve.RowHeadersWidth = 51;
            this.lstEleve.RowTemplate.Height = 24;
            this.lstEleve.Size = new System.Drawing.Size(929, 294);
            this.lstEleve.TabIndex = 18;
            this.lstEleve.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lstEleve_CellContentClick);
            // 
            // lblRechercheEleve
            // 
            this.lblRechercheEleve.AutoSize = true;
            this.lblRechercheEleve.Location = new System.Drawing.Point(160, 294);
            this.lblRechercheEleve.Name = "lblRechercheEleve";
            this.lblRechercheEleve.Size = new System.Drawing.Size(155, 20);
            this.lblRechercheEleve.TabIndex = 17;
            this.lblRechercheEleve.Text = "Rechercher un élève";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(335, 288);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(369, 26);
            this.txtSearch.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Page de gestion de la comptabilité";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(215, 51);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(618, 202);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(749, 279);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(171, 35);
            this.btnRecherche.TabIndex = 19;
            this.btnRecherche.Text = "Rechercher";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // btnAcces
            // 
            this.btnAcces.Location = new System.Drawing.Point(359, 639);
            this.btnAcces.Name = "btnAcces";
            this.btnAcces.Size = new System.Drawing.Size(243, 58);
            this.btnAcces.TabIndex = 20;
            this.btnAcces.Text = "Accéder à la page de détail";
            this.btnAcces.UseVisualStyleBackColor = true;
            // 
            // FrmGestionComptabilite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 709);
            this.Controls.Add(this.btnAcces);
            this.Controls.Add(this.btnRecherche);
            this.Controls.Add(this.lstEleve);
            this.Controls.Add(this.lblRechercheEleve);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmGestionComptabilite";
            this.Text = "FrmGestionComptabilite";
            this.Load += new System.EventHandler(this.FrmGestionComptabilite_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstEleve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem présentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesÉlèvesAdhérantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesBudgetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeLaComptabilitéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ecranStatistiqueToolStripMenuItem;
        private System.Windows.Forms.DataGridView lstEleve;
        private System.Windows.Forms.Label lblRechercheEleve;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.Button btnAcces;
    }
}