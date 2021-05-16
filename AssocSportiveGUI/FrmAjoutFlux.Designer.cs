
namespace AssocSportiveGUI
{
    partial class FrmAjoutFlux
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
            this.components = new System.ComponentModel.Container();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstAdherent = new System.Windows.Forms.ListBox();
            this.aDHERANTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adherent = new AssocSportiveGUI.Adherent();
            this.lstBudget = new System.Windows.Forms.ListBox();
            this.bUDGETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budget = new AssocSportiveGUI.Budget();
            this.aDHERANTTableAdapter = new AssocSportiveGUI.AdherentTableAdapters.ADHERANTTableAdapter();
            this.bUDGETTableAdapter = new AssocSportiveGUI.BudgetTableAdapters.BUDGETTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.aDHERANTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adherent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUDGETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budget)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(442, 366);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(214, 111);
            this.btnEnregistrer.TabIndex = 0;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Libelle de flux";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Montant du flux";
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(247, 125);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(201, 26);
            this.txtLibelle.TabIndex = 3;
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(715, 125);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(187, 26);
            this.txtMontant.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "L\'adherent concerné";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(578, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Budget impacté";
            // 
            // lstAdherent
            // 
            this.lstAdherent.DataSource = this.aDHERANTBindingSource;
            this.lstAdherent.DisplayMember = "login_adherant";
            this.lstAdherent.FormattingEnabled = true;
            this.lstAdherent.ItemHeight = 20;
            this.lstAdherent.Location = new System.Drawing.Point(247, 186);
            this.lstAdherent.Name = "lstAdherent";
            this.lstAdherent.Size = new System.Drawing.Size(120, 124);
            this.lstAdherent.TabIndex = 8;
            this.lstAdherent.ValueMember = "id_adherant";
            // 
            // aDHERANTBindingSource
            // 
            this.aDHERANTBindingSource.DataMember = "ADHERANT";
            this.aDHERANTBindingSource.DataSource = this.adherent;
            // 
            // adherent
            // 
            this.adherent.DataSetName = "Adherent";
            this.adherent.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lstBudget
            // 
            this.lstBudget.DataSource = this.bUDGETBindingSource;
            this.lstBudget.DisplayMember = "lbl_budget";
            this.lstBudget.FormattingEnabled = true;
            this.lstBudget.ItemHeight = 20;
            this.lstBudget.Location = new System.Drawing.Point(715, 186);
            this.lstBudget.Name = "lstBudget";
            this.lstBudget.Size = new System.Drawing.Size(120, 84);
            this.lstBudget.TabIndex = 9;
            this.lstBudget.ValueMember = "id_budget";
            // 
            // bUDGETBindingSource
            // 
            this.bUDGETBindingSource.DataMember = "BUDGET";
            this.bUDGETBindingSource.DataSource = this.budget;
            // 
            // budget
            // 
            this.budget.DataSetName = "Budget";
            this.budget.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aDHERANTTableAdapter
            // 
            this.aDHERANTTableAdapter.ClearBeforeFill = true;
            // 
            // bUDGETTableAdapter
            // 
            this.bUDGETTableAdapter.ClearBeforeFill = true;
            // 
            // FrmAjoutFlux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 536);
            this.Controls.Add(this.lstBudget);
            this.Controls.Add(this.lstAdherent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnregistrer);
            this.Name = "FrmAjoutFlux";
            this.Text = "FrmAjoutFlux";
            this.Load += new System.EventHandler(this.FrmAjoutFlux_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aDHERANTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adherent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUDGETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstAdherent;
        private System.Windows.Forms.ListBox lstBudget;
        private Adherent adherent;
        private System.Windows.Forms.BindingSource aDHERANTBindingSource;
        private AdherentTableAdapters.ADHERANTTableAdapter aDHERANTTableAdapter;
        private Budget budget;
        private System.Windows.Forms.BindingSource bUDGETBindingSource;
        private BudgetTableAdapters.BUDGETTableAdapter bUDGETTableAdapter;
    }
}