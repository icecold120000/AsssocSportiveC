﻿
namespace AssocSportiveGUI
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_deconnexion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.présentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesÉlèvesAdhérantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesBudgetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeLaComptabilitéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ecranStatistiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(584, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "BIENVENUE ADMIN";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(253, 344);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(826, 202);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // btn_deconnexion
            // 
            this.btn_deconnexion.Location = new System.Drawing.Point(609, 284);
            this.btn_deconnexion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_deconnexion.Name = "btn_deconnexion";
            this.btn_deconnexion.Size = new System.Drawing.Size(179, 52);
            this.btn_deconnexion.TabIndex = 6;
            this.btn_deconnexion.Text = "Se déconnecter";
            this.btn_deconnexion.UseVisualStyleBackColor = true;
            this.btn_deconnexion.Click += new System.EventHandler(this.btn_deconnexion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(273, 45);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(730, 202);
            this.pictureBox1.TabIndex = 5;
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
            this.menuStrip1.Size = new System.Drawing.Size(1145, 33);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // présentationToolStripMenuItem
            // 
            this.présentationToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.présentationToolStripMenuItem.Name = "présentationToolStripMenuItem";
            this.présentationToolStripMenuItem.Size = new System.Drawing.Size(126, 29);
            this.présentationToolStripMenuItem.Text = "Présentation";
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
            this.ecranStatistiqueToolStripMenuItem.Name = "ecranStatistiqueToolStripMenuItem";
            this.ecranStatistiqueToolStripMenuItem.Size = new System.Drawing.Size(156, 29);
            this.ecranStatistiqueToolStripMenuItem.Text = "Ecran statistique";
            this.ecranStatistiqueToolStripMenuItem.Click += new System.EventHandler(this.ecranStatistiqueToolStripMenuItem_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 609);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_deconnexion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmAdmin";
            this.Text = "FrmAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_deconnexion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem présentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesÉlèvesAdhérantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesBudgetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeLaComptabilitéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ecranStatistiqueToolStripMenuItem;
    }
}