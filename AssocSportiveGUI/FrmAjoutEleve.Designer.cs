
namespace AssocSportiveGUI
{
    partial class FrmAjoutEleve
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
            this.lstClasse = new System.Windows.Forms.ListBox();
            this.optPrelev2 = new System.Windows.Forms.RadioButton();
            this.optPrelev1 = new System.Windows.Forms.RadioButton();
            this.optSexe2 = new System.Windows.Forms.RadioButton();
            this.optSexe1 = new System.Windows.Forms.RadioButton();
            this.lblPrelev = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumParents = new System.Windows.Forms.TextBox();
            this.txtMDP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDateNaissance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSexe = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.sexeBox = new System.Windows.Forms.GroupBox();
            this.autoBox = new System.Windows.Forms.GroupBox();
            this.sexeBox.SuspendLayout();
            this.autoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstClasse
            // 
            this.lstClasse.FormattingEnabled = true;
            this.lstClasse.ItemHeight = 20;
            this.lstClasse.Location = new System.Drawing.Point(916, 152);
            this.lstClasse.Name = "lstClasse";
            this.lstClasse.Size = new System.Drawing.Size(109, 144);
            this.lstClasse.TabIndex = 126;
            this.lstClasse.ValueMember = "id_classe";
            // 
            // optPrelev2
            // 
            this.optPrelev2.AutoSize = true;
            this.optPrelev2.Location = new System.Drawing.Point(197, 21);
            this.optPrelev2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.optPrelev2.Name = "optPrelev2";
            this.optPrelev2.Size = new System.Drawing.Size(45, 24);
            this.optPrelev2.TabIndex = 125;
            this.optPrelev2.TabStop = true;
            this.optPrelev2.Text = "N";
            this.optPrelev2.UseVisualStyleBackColor = true;
            // 
            // optPrelev1
            // 
            this.optPrelev1.AutoSize = true;
            this.optPrelev1.Location = new System.Drawing.Point(145, 21);
            this.optPrelev1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.optPrelev1.Name = "optPrelev1";
            this.optPrelev1.Size = new System.Drawing.Size(46, 24);
            this.optPrelev1.TabIndex = 124;
            this.optPrelev1.TabStop = true;
            this.optPrelev1.Text = "O";
            this.optPrelev1.UseVisualStyleBackColor = true;
            // 
            // optSexe2
            // 
            this.optSexe2.AutoSize = true;
            this.optSexe2.Location = new System.Drawing.Point(164, 18);
            this.optSexe2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.optSexe2.Name = "optSexe2";
            this.optSexe2.Size = new System.Drawing.Size(44, 24);
            this.optSexe2.TabIndex = 121;
            this.optSexe2.TabStop = true;
            this.optSexe2.Text = "F";
            this.optSexe2.UseVisualStyleBackColor = true;
            // 
            // optSexe1
            // 
            this.optSexe1.AutoSize = true;
            this.optSexe1.Location = new System.Drawing.Point(93, 18);
            this.optSexe1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.optSexe1.Name = "optSexe1";
            this.optSexe1.Size = new System.Drawing.Size(47, 24);
            this.optSexe1.TabIndex = 120;
            this.optSexe1.TabStop = true;
            this.optSexe1.Text = "G";
            this.optSexe1.UseVisualStyleBackColor = true;
            // 
            // lblPrelev
            // 
            this.lblPrelev.AutoSize = true;
            this.lblPrelev.Location = new System.Drawing.Point(6, 23);
            this.lblPrelev.Name = "lblPrelev";
            this.lblPrelev.Size = new System.Drawing.Size(136, 20);
            this.lblPrelev.TabIndex = 118;
            this.lblPrelev.Text = "Auto-Prélèvement";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(853, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 117;
            this.label8.Text = "Classe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(770, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 20);
            this.label7.TabIndex = 116;
            this.label7.Text = "Numéro des parents";
            // 
            // txtNumParents
            // 
            this.txtNumParents.Location = new System.Drawing.Point(930, 102);
            this.txtNumParents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumParents.Name = "txtNumParents";
            this.txtNumParents.Size = new System.Drawing.Size(281, 26);
            this.txtNumParents.TabIndex = 115;
            // 
            // txtMDP
            // 
            this.txtMDP.Location = new System.Drawing.Point(773, 333);
            this.txtMDP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMDP.Name = "txtMDP";
            this.txtMDP.Size = new System.Drawing.Size(216, 26);
            this.txtMDP.TabIndex = 114;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(626, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 113;
            this.label6.Text = "Mot de Passe : ";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(358, 333);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(214, 26);
            this.txtLogin.TabIndex = 112;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 111;
            this.label3.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 110;
            this.label1.Text = "AJOUTER UN ELEVE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(116, 98);
            this.txtNom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(151, 26);
            this.txtNom.TabIndex = 109;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(496, 223);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(267, 26);
            this.txtTelephone.TabIndex = 108;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(116, 198);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(165, 26);
            this.txtEmail.TabIndex = 107;
            // 
            // txtDateNaissance
            // 
            this.txtDateNaissance.Location = new System.Drawing.Point(494, 99);
            this.txtDateNaissance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDateNaissance.Name = "txtDateNaissance";
            this.txtDateNaissance.Size = new System.Drawing.Size(250, 26);
            this.txtDateNaissance.TabIndex = 106;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 20);
            this.label5.TabIndex = 105;
            this.label5.Text = "Numéro de téléphone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 104;
            this.label4.Text = "Email :";
            // 
            // lblSexe
            // 
            this.lblSexe.AutoSize = true;
            this.lblSexe.Location = new System.Drawing.Point(22, 20);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(53, 20);
            this.lblSexe.TabIndex = 103;
            this.lblSexe.Text = "Sexe :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 102;
            this.label2.Text = "Date de naissance :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(32, 106);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(50, 20);
            this.lblNom.TabIndex = 101;
            this.lblNom.Text = "Nom :";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(116, 148);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(176, 26);
            this.txtPrenom.TabIndex = 100;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(32, 148);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(76, 20);
            this.lblPrenom.TabIndex = 99;
            this.lblPrenom.Text = "Prénom : ";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(475, 424);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(200, 90);
            this.btnEnregistrer.TabIndex = 98;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // sexeBox
            // 
            this.sexeBox.BackColor = System.Drawing.Color.Transparent;
            this.sexeBox.Controls.Add(this.lblSexe);
            this.sexeBox.Controls.Add(this.optSexe1);
            this.sexeBox.Controls.Add(this.optSexe2);
            this.sexeBox.Location = new System.Drawing.Point(319, 135);
            this.sexeBox.Name = "sexeBox";
            this.sexeBox.Size = new System.Drawing.Size(225, 57);
            this.sexeBox.TabIndex = 128;
            this.sexeBox.TabStop = false;
            // 
            // autoBox
            // 
            this.autoBox.Controls.Add(this.optPrelev1);
            this.autoBox.Controls.Add(this.lblPrelev);
            this.autoBox.Controls.Add(this.optPrelev2);
            this.autoBox.Location = new System.Drawing.Point(569, 135);
            this.autoBox.Name = "autoBox";
            this.autoBox.Size = new System.Drawing.Size(256, 57);
            this.autoBox.TabIndex = 129;
            this.autoBox.TabStop = false;
            // 
            // FrmAjoutEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 543);
            this.Controls.Add(this.autoBox);
            this.Controls.Add(this.sexeBox);
            this.Controls.Add(this.lstClasse);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNumParents);
            this.Controls.Add(this.txtMDP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDateNaissance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.btnEnregistrer);
            this.Name = "FrmAjoutEleve";
            this.Text = "FrmAjoutEleve";
            this.sexeBox.ResumeLayout(false);
            this.sexeBox.PerformLayout();
            this.autoBox.ResumeLayout(false);
            this.autoBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstClasse;
        private System.Windows.Forms.RadioButton optPrelev2;
        private System.Windows.Forms.RadioButton optPrelev1;
        private System.Windows.Forms.RadioButton optSexe2;
        private System.Windows.Forms.RadioButton optSexe1;
        private System.Windows.Forms.Label lblPrelev;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumParents;
        private System.Windows.Forms.TextBox txtMDP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDateNaissance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSexe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.GroupBox sexeBox;
        private System.Windows.Forms.GroupBox autoBox;
    }
}