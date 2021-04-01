
namespace AssocSportiveGUI
{
    partial class FrmGestionBudget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionBudget));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_deconnexion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.présentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesÉlèvesAdhérantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesBudgetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeLaComptabilitéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ecranStatistiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgBudgetEPS = new System.Windows.Forms.DataGridView();
            this.dtgBudgetAS = new System.Windows.Forms.DataGridView();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.btnModifie = new System.Windows.Forms.Button();
            this.btnSupprimerDebits = new System.Windows.Forms.Button();
            this.btnSupprimerCredits = new System.Windows.Forms.Button();
            this.dtgDebits = new System.Windows.Forms.DataGridView();
            this.dtgCredits = new System.Windows.Forms.DataGridView();
            this.FLUX = new System.Windows.Forms.Label();
            this.btnAjoutCredit = new System.Windows.Forms.Button();
            this.btnAjoutDébit = new System.Windows.Forms.Button();
            this.btnAjouterBudget = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBudgetEPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBudgetAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDebits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCredits)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Page de gestion des budgets";
            // 
            // btn_deconnexion
            // 
            this.btn_deconnexion.Location = new System.Drawing.Point(512, 315);
            this.btn_deconnexion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_deconnexion.Name = "btn_deconnexion";
            this.btn_deconnexion.Size = new System.Drawing.Size(151, 34);
            this.btn_deconnexion.TabIndex = 11;
            this.btn_deconnexion.Text = "Se déconnecter";
            this.btn_deconnexion.UseVisualStyleBackColor = true;
            this.btn_deconnexion.Click += new System.EventHandler(this.btn_deconnexion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(196, 71);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(814, 202);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
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
            this.menuStrip1.Size = new System.Drawing.Size(1219, 33);
            this.menuStrip1.TabIndex = 9;
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
            this.gestionDesÉlèvesAdhérantsToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.gestionDesÉlèvesAdhérantsToolStripMenuItem.Name = "gestionDesÉlèvesAdhérantsToolStripMenuItem";
            this.gestionDesÉlèvesAdhérantsToolStripMenuItem.Size = new System.Drawing.Size(257, 29);
            this.gestionDesÉlèvesAdhérantsToolStripMenuItem.Text = "Gestion des élèves adhérants";
            // 
            // gestionDesBudgetsToolStripMenuItem
            // 
            this.gestionDesBudgetsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gestionDesBudgetsToolStripMenuItem.Name = "gestionDesBudgetsToolStripMenuItem";
            this.gestionDesBudgetsToolStripMenuItem.Size = new System.Drawing.Size(192, 29);
            this.gestionDesBudgetsToolStripMenuItem.Text = "Gestion des budgets";
            // 
            // gestionDeLaComptabilitéToolStripMenuItem
            // 
            this.gestionDeLaComptabilitéToolStripMenuItem.Name = "gestionDeLaComptabilitéToolStripMenuItem";
            this.gestionDeLaComptabilitéToolStripMenuItem.Size = new System.Drawing.Size(235, 29);
            this.gestionDeLaComptabilitéToolStripMenuItem.Text = "Gestion de la comptabilité";
            // 
            // ecranStatistiqueToolStripMenuItem
            // 
            this.ecranStatistiqueToolStripMenuItem.Name = "ecranStatistiqueToolStripMenuItem";
            this.ecranStatistiqueToolStripMenuItem.Size = new System.Drawing.Size(156, 29);
            this.ecranStatistiqueToolStripMenuItem.Text = "Ecran statistique";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Budget EPS :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(691, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Budget AS :";
            // 
            // dtgBudgetEPS
            // 
            this.dtgBudgetEPS.AllowUserToAddRows = false;
            this.dtgBudgetEPS.AllowUserToDeleteRows = false;
            this.dtgBudgetEPS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBudgetEPS.ColumnHeadersVisible = false;
            this.dtgBudgetEPS.Location = new System.Drawing.Point(258, 365);
            this.dtgBudgetEPS.Name = "dtgBudgetEPS";
            this.dtgBudgetEPS.ReadOnly = true;
            this.dtgBudgetEPS.RowHeadersVisible = false;
            this.dtgBudgetEPS.RowHeadersWidth = 62;
            this.dtgBudgetEPS.RowTemplate.Height = 28;
            this.dtgBudgetEPS.Size = new System.Drawing.Size(200, 93);
            this.dtgBudgetEPS.TabIndex = 15;
            this.dtgBudgetEPS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgBudgetEPS_CellContentClick);
            // 
            // dtgBudgetAS
            // 
            this.dtgBudgetAS.AllowUserToAddRows = false;
            this.dtgBudgetAS.AllowUserToDeleteRows = false;
            this.dtgBudgetAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBudgetAS.Location = new System.Drawing.Point(792, 356);
            this.dtgBudgetAS.Name = "dtgBudgetAS";
            this.dtgBudgetAS.ReadOnly = true;
            this.dtgBudgetAS.RowHeadersVisible = false;
            this.dtgBudgetAS.RowHeadersWidth = 62;
            this.dtgBudgetAS.RowTemplate.Height = 28;
            this.dtgBudgetAS.Size = new System.Drawing.Size(173, 93);
            this.dtgBudgetAS.TabIndex = 16;
            this.dtgBudgetAS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgBudgetAS_CellContentClick);
            // 
            // btnActualiser
            // 
            this.btnActualiser.Location = new System.Drawing.Point(522, 718);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(113, 62);
            this.btnActualiser.TabIndex = 17;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = true;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // btnModifie
            // 
            this.btnModifie.Location = new System.Drawing.Point(779, 301);
            this.btnModifie.Name = "btnModifie";
            this.btnModifie.Size = new System.Drawing.Size(173, 34);
            this.btnModifie.TabIndex = 19;
            this.btnModifie.Text = "Modifier Budget";
            this.btnModifie.UseVisualStyleBackColor = true;
            this.btnModifie.Click += new System.EventHandler(this.btnModifie_Click);
            // 
            // btnSupprimerDebits
            // 
            this.btnSupprimerDebits.Location = new System.Drawing.Point(806, 726);
            this.btnSupprimerDebits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSupprimerDebits.Name = "btnSupprimerDebits";
            this.btnSupprimerDebits.Size = new System.Drawing.Size(159, 46);
            this.btnSupprimerDebits.TabIndex = 26;
            this.btnSupprimerDebits.Text = "btnSupprimerDebits";
            this.btnSupprimerDebits.UseVisualStyleBackColor = true;
            this.btnSupprimerDebits.Click += new System.EventHandler(this.btnSupprimerDebits_Click);
            // 
            // btnSupprimerCredits
            // 
            this.btnSupprimerCredits.Location = new System.Drawing.Point(237, 726);
            this.btnSupprimerCredits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSupprimerCredits.Name = "btnSupprimerCredits";
            this.btnSupprimerCredits.Size = new System.Drawing.Size(180, 46);
            this.btnSupprimerCredits.TabIndex = 25;
            this.btnSupprimerCredits.Text = "btnSupprimerCredits";
            this.btnSupprimerCredits.UseVisualStyleBackColor = true;
            this.btnSupprimerCredits.Click += new System.EventHandler(this.btnSupprimerCredits_Click);
            // 
            // dtgDebits
            // 
            this.dtgDebits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDebits.Location = new System.Drawing.Point(607, 514);
            this.dtgDebits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgDebits.Name = "dtgDebits";
            this.dtgDebits.RowHeadersWidth = 51;
            this.dtgDebits.RowTemplate.Height = 24;
            this.dtgDebits.Size = new System.Drawing.Size(522, 188);
            this.dtgDebits.TabIndex = 24;
            this.dtgDebits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDebits_CellContentClick);
            // 
            // dtgCredits
            // 
            this.dtgCredits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCredits.Location = new System.Drawing.Point(80, 514);
            this.dtgCredits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgCredits.Name = "dtgCredits";
            this.dtgCredits.RowHeadersWidth = 51;
            this.dtgCredits.RowTemplate.Height = 24;
            this.dtgCredits.Size = new System.Drawing.Size(468, 188);
            this.dtgCredits.TabIndex = 23;
            this.dtgCredits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCredits_CellContentClick);
            // 
            // FLUX
            // 
            this.FLUX.AutoSize = true;
            this.FLUX.Location = new System.Drawing.Point(557, 474);
            this.FLUX.Name = "FLUX";
            this.FLUX.Size = new System.Drawing.Size(51, 20);
            this.FLUX.TabIndex = 22;
            this.FLUX.Text = "FLUX";
            // 
            // btnAjoutCredit
            // 
            this.btnAjoutCredit.Location = new System.Drawing.Point(249, 464);
            this.btnAjoutCredit.Name = "btnAjoutCredit";
            this.btnAjoutCredit.Size = new System.Drawing.Size(220, 41);
            this.btnAjoutCredit.TabIndex = 29;
            this.btnAjoutCredit.Text = "Ajouter un Crédit";
            this.btnAjoutCredit.UseVisualStyleBackColor = true;
            this.btnAjoutCredit.Click += new System.EventHandler(this.btnAjoutCredit_Click);
            // 
            // btnAjoutDébit
            // 
            this.btnAjoutDébit.Location = new System.Drawing.Point(756, 464);
            this.btnAjoutDébit.Name = "btnAjoutDébit";
            this.btnAjoutDébit.Size = new System.Drawing.Size(223, 41);
            this.btnAjoutDébit.TabIndex = 30;
            this.btnAjoutDébit.Text = "Ajouter un débit";
            this.btnAjoutDébit.UseVisualStyleBackColor = true;
            this.btnAjoutDébit.Click += new System.EventHandler(this.btnAjoutDébit_Click);
            // 
            // btnAjouterBudget
            // 
            this.btnAjouterBudget.Location = new System.Drawing.Point(279, 301);
            this.btnAjouterBudget.Name = "btnAjouterBudget";
            this.btnAjouterBudget.Size = new System.Drawing.Size(138, 34);
            this.btnAjouterBudget.TabIndex = 31;
            this.btnAjouterBudget.Text = "Ajouter Budget";
            this.btnAjouterBudget.UseVisualStyleBackColor = true;
            this.btnAjouterBudget.Click += new System.EventHandler(this.btnAjouterBudget_Click);
            // 
            // FrmGestionBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 828);
            this.Controls.Add(this.btnAjouterBudget);
            this.Controls.Add(this.btnAjoutDébit);
            this.Controls.Add(this.btnAjoutCredit);
            this.Controls.Add(this.btnSupprimerDebits);
            this.Controls.Add(this.btnSupprimerCredits);
            this.Controls.Add(this.dtgDebits);
            this.Controls.Add(this.dtgCredits);
            this.Controls.Add(this.FLUX);
            this.Controls.Add(this.btnModifie);
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.dtgBudgetAS);
            this.Controls.Add(this.dtgBudgetEPS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_deconnexion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmGestionBudget";
            this.Text = "FrmGestionBudget";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBudgetEPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBudgetAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDebits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCredits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_deconnexion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem présentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesÉlèvesAdhérantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesBudgetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeLaComptabilitéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ecranStatistiqueToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgBudgetEPS;
        private System.Windows.Forms.DataGridView dtgBudgetAS;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.Button btnModifie;
        private System.Windows.Forms.Button btnSupprimerDebits;
        private System.Windows.Forms.Button btnSupprimerCredits;
        private System.Windows.Forms.DataGridView dtgDebits;
        private System.Windows.Forms.DataGridView dtgCredits;
        private System.Windows.Forms.Label FLUX;
        private System.Windows.Forms.Button btnAjoutCredit;
        private System.Windows.Forms.Button btnAjoutDébit;
        private System.Windows.Forms.Button btnAjouterBudget;
    }
}