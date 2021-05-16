
namespace AssocSportiveGUI
{
    partial class FrmEcranStatistique
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEcranStatistique));
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
            this.label4 = new System.Windows.Forms.Label();
            this.nbTotal = new System.Windows.Forms.Label();
            this.nbFille = new System.Windows.Forms.Label();
            this.nbGarçon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Page de statistique";
            // 
            // btn_deconnexion
            // 
            this.btn_deconnexion.Location = new System.Drawing.Point(461, 296);
            this.btn_deconnexion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_deconnexion.Name = "btn_deconnexion";
            this.btn_deconnexion.Size = new System.Drawing.Size(179, 52);
            this.btn_deconnexion.TabIndex = 9;
            this.btn_deconnexion.Text = "Se déconnecter";
            this.btn_deconnexion.UseVisualStyleBackColor = true;
            this.btn_deconnexion.Click += new System.EventHandler(this.btn_deconnexion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(179, 54);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(730, 202);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
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
            this.menuStrip1.Size = new System.Drawing.Size(1075, 33);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // présentationToolStripMenuItem
            // 
            this.présentationToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.présentationToolStripMenuItem.Name = "présentationToolStripMenuItem";
            this.présentationToolStripMenuItem.Size = new System.Drawing.Size(126, 29);
            this.présentationToolStripMenuItem.Text = "Présentation";
            this.présentationToolStripMenuItem.Click += new System.EventHandler(this.présentationToolStripMenuItem_Click);
            // 
            // gestionDesÉlèvesAdhérantsToolStripMenuItem
            // 
            this.gestionDesÉlèvesAdhérantsToolStripMenuItem.Name = "gestionDesÉlèvesAdhérantsToolStripMenuItem";
            this.gestionDesÉlèvesAdhérantsToolStripMenuItem.Size = new System.Drawing.Size(257, 29);
            this.gestionDesÉlèvesAdhérantsToolStripMenuItem.Text = "Gestion des élèves adhérants";
            this.gestionDesÉlèvesAdhérantsToolStripMenuItem.Click += new System.EventHandler(this.gestionDesÉlèvesAdhérantsToolStripMenuItem_Click);
            // 
            // gestionDesBudgetsToolStripMenuItem
            // 
            this.gestionDesBudgetsToolStripMenuItem.Name = "gestionDesBudgetsToolStripMenuItem";
            this.gestionDesBudgetsToolStripMenuItem.Size = new System.Drawing.Size(192, 29);
            this.gestionDesBudgetsToolStripMenuItem.Text = "Gestion des budgets";
            this.gestionDesBudgetsToolStripMenuItem.Click += new System.EventHandler(this.gestionDesBudgetsToolStripMenuItem_Click);
            // 
            // gestionDeLaComptabilitéToolStripMenuItem
            // 
            this.gestionDeLaComptabilitéToolStripMenuItem.Name = "gestionDeLaComptabilitéToolStripMenuItem";
            this.gestionDeLaComptabilitéToolStripMenuItem.Size = new System.Drawing.Size(235, 29);
            this.gestionDeLaComptabilitéToolStripMenuItem.Text = "Gestion de la comptabilité";
            this.gestionDeLaComptabilitéToolStripMenuItem.Click += new System.EventHandler(this.gestionDeLaComptabilitéToolStripMenuItem_Click);
            // 
            // ecranStatistiqueToolStripMenuItem
            // 
            this.ecranStatistiqueToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ecranStatistiqueToolStripMenuItem.Name = "ecranStatistiqueToolStripMenuItem";
            this.ecranStatistiqueToolStripMenuItem.Size = new System.Drawing.Size(156, 29);
            this.ecranStatistiqueToolStripMenuItem.Text = "Ecran statistique";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(708, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre de garçon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nombre de Fille";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nombre d\'élève total";
            // 
            // nbTotal
            // 
            this.nbTotal.AutoSize = true;
            this.nbTotal.Location = new System.Drawing.Point(301, 381);
            this.nbTotal.Name = "nbTotal";
            this.nbTotal.Size = new System.Drawing.Size(18, 20);
            this.nbTotal.TabIndex = 15;
            this.nbTotal.Text = "0";
            // 
            // nbFille
            // 
            this.nbFille.AutoSize = true;
            this.nbFille.Location = new System.Drawing.Point(564, 381);
            this.nbFille.Name = "nbFille";
            this.nbFille.Size = new System.Drawing.Size(51, 20);
            this.nbFille.TabIndex = 16;
            this.nbFille.Text = "label5";
            // 
            // nbGarçon
            // 
            this.nbGarçon.AutoSize = true;
            this.nbGarçon.Location = new System.Drawing.Point(898, 381);
            this.nbGarçon.Name = "nbGarçon";
            this.nbGarçon.Size = new System.Drawing.Size(51, 20);
            this.nbGarçon.TabIndex = 17;
            this.nbGarçon.Text = "label5";
            // 
            // FrmEcranStatistique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 636);
            this.Controls.Add(this.nbGarçon);
            this.Controls.Add(this.nbFille);
            this.Controls.Add(this.nbTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_deconnexion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmEcranStatistique";
            this.Text = "FrmEcranStatistique";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nbTotal;
        private System.Windows.Forms.Label nbFille;
        private System.Windows.Forms.Label nbGarçon;
    }
}