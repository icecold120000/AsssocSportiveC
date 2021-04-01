using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BO;
using BLL;


namespace AssocSportiveGUI
{
    public partial class btnAjout : Form
    {
        private int idColonne;

        public btnAjout()
        {
            InitializeComponent();
            GestionAdherant.SetchaineConnexion(ConfigurationManager.
                ConnectionStrings["AssocAdherant"]);

            // Création d'un objet List d'Utilisateur à afficher dans le datagridview
            List<AdherantBO> liste = new List<AdherantBO>();
            liste = GestionAdherant.GetAdherants();

            // Rattachement de la List à la source de données du datagridview

            dtgEleve.DataSource = liste;
        }

        private void btn_deconnexion_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
            FrmConnexion FrmConnect;
            FrmConnect = new FrmConnexion();
            FrmConnect.ShowDialog(); // ouverture du formulaire
            FrmConnect.Close(); // fermeture du formulaire 
        }

        private void dtgEleve_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Blocage de la génération automatique des colonnes

            dtgEleve.AutoGenerateColumns = false;
            

            // Création d'une en-tête de colonne pour la colonne 1

            DataGridViewTextBoxColumn IdColumn = new DataGridViewTextBoxColumn();

            IdColumn.DataPropertyName = "id_adherant";
            IdColumn.HeaderText = "Identifiant";

            // Création d'une en-tête de colonne pour la colonne 2

            DataGridViewTextBoxColumn NomColumn = new DataGridViewTextBoxColumn();

            NomColumn.DataPropertyName = "nom_adherant";
            NomColumn.HeaderText = "Nom de l'eleve";

            // Création d'une en-tête de colonne pour la colonne 3

            DataGridViewTextBoxColumn PrenomColumn = new DataGridViewTextBoxColumn();

            PrenomColumn.DataPropertyName = "prenom_adherant";
            PrenomColumn.HeaderText = "prenom de l'eleve";

            // Création d'une en-tête de colonne pour la colonne 4

            DataGridViewTextBoxColumn NaissanceColumn = new DataGridViewTextBoxColumn();

            NaissanceColumn.DataPropertyName = "ddn_adherant";
            NaissanceColumn.HeaderText = "Date de Naissance de l'eleve";

            // Création d'une en-tête de colonne pour la colonne 5

            DataGridViewTextBoxColumn SexeColumn = new DataGridViewTextBoxColumn();

            SexeColumn.DataPropertyName = "sexe_adherant";
            SexeColumn.HeaderText = "Sexe de l'eleve";

            // Création d'une en-tête de colonne pour la colonne 6

            DataGridViewTextBoxColumn EmailColumn = new DataGridViewTextBoxColumn();

            EmailColumn.DataPropertyName = "email_adherant";
            EmailColumn.HeaderText = "Email de l'eleve";

            // Création d'une en-tête de colonne pour la colonne 7

            DataGridViewTextBoxColumn NumTelColumn = new DataGridViewTextBoxColumn();

            NumTelColumn.DataPropertyName = "numtel_adherant";
            NumTelColumn.HeaderText = "Numero de téléphone de l'eleve";

            // Création d'une en-tête de colonne pour la colonne 8

            DataGridViewTextBoxColumn NumParentColumn = new DataGridViewTextBoxColumn();

            NumParentColumn.DataPropertyName = "numparent_adherant";
            NumParentColumn.HeaderText = "Numero téléphone du parent de l'eleve";

            // Création d'une en-tête de colonne pour la colonne 9

            DataGridViewTextBoxColumn PrelevColumn = new DataGridViewTextBoxColumn();

            PrelevColumn.DataPropertyName = "autoprelev_adherant";
            PrelevColumn.HeaderText = "Autorisation de l'auto prelevement";


            // Création d'une en-tête de colonne pour la colonne 10

            DataGridViewTextBoxColumn LoginColumn = new DataGridViewTextBoxColumn();

            LoginColumn.DataPropertyName = "login_adherant";
            LoginColumn.HeaderText = "Login de l'eleve";


            // Création d'une en-tête de colonne pour la colonne 11

            DataGridViewTextBoxColumn MdpColumn = new DataGridViewTextBoxColumn();

            MdpColumn.DataPropertyName = "mdp_adherant";
            MdpColumn.HeaderText = "Mot de passe de l'eleve";


            // Création d'une en-tête de colonne pour la colonne 12

            DataGridViewTextBoxColumn ClasseColumn = new DataGridViewTextBoxColumn();

            ClasseColumn.DataPropertyName = "id_classe";
            ClasseColumn.HeaderText = "Classe de l'élève";

            // Création d'une en-tête de colonne pour la colonne 13

            DataGridViewTextBoxColumn DateMajColumn = new DataGridViewTextBoxColumn();

            DateMajColumn.DataPropertyName = "date_maj_adherant";
            DateMajColumn.HeaderText = "Date de mise à jour de l'eleve";

            // Création d'une en-tête de colonne pour la colonne 14

            DataGridViewTextBoxColumn ArchiveColumn = new DataGridViewTextBoxColumn();

            ArchiveColumn.DataPropertyName = "archive_adherant";
            ArchiveColumn.HeaderText = "Si l'élève est archivé ou non";

            // Ajout des 12 en-têtes de colonne au datagridview

            dtgEleve.Columns.Add(IdColumn);
            dtgEleve.Columns.Add(NomColumn);
            dtgEleve.Columns.Add(PrenomColumn);
            dtgEleve.Columns.Add(NaissanceColumn);
            dtgEleve.Columns.Add(SexeColumn);
            dtgEleve.Columns.Add(EmailColumn);
            dtgEleve.Columns.Add(NumTelColumn);
            dtgEleve.Columns.Add(NumParentColumn);
            dtgEleve.Columns.Add(PrelevColumn);
            dtgEleve.Columns.Add(LoginColumn);
            dtgEleve.Columns.Add(MdpColumn);
            dtgEleve.Columns.Add(ClasseColumn);
            dtgEleve.Columns.Add(ArchiveColumn);
            dtgEleve.Columns.Add(DateMajColumn);

            // Définition du style apporté au datagridview

            dtgEleve.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 12, FontStyle.Bold);

            dtgEleve.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dtgEleve.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Création d'un objet List d'Utilisateur à afficher dans le datagridview
            List<AdherantBO> liste = new List<AdherantBO>();
            liste = GestionAdherant.GetAdherants();

            // Rattachement de la List à la source de données du datagridview

            dtgEleve.DataSource = liste;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            List<AdherantBO> liste = new List<AdherantBO>();
            liste = GestionAdherant.GetAdherants();

            var result1 = MessageBox.Show("Voulez vous vraiment supprimer cette élève ?",
                          "Message d'information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                dtgEleve.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                int rowIndex = dtgEleve.CurrentCell.RowIndex;
                int columnIndex = dtgEleve.CurrentCell.ColumnIndex;

                idColonne = Int32.Parse(dtgEleve.Rows[rowIndex].Cells[columnIndex].Value.ToString());

                GestionAdherant.DeleteAdherant(idColonne);
                
            }

        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            // Création d'un objet List d'Utilisateur à afficher dans le datagridview

            List<AdherantBO> liste = new List<AdherantBO>();
            liste = GestionAdherant.GetAdherants();
            // Rattachement de la List à la source de données du datagridview

            dtgEleve.DataSource = liste;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

            dtgEleve.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            int rowIndex = dtgEleve.CurrentCell.RowIndex;
            int columnIndex = dtgEleve.CurrentCell.ColumnIndex;

            idColonne = Int32.Parse(dtgEleve.Rows[rowIndex].Cells[columnIndex].Value.ToString());

            FrmModifieEleve FrmModifierEleve;
            FrmModifierEleve = new FrmModifieEleve(idColonne);
            FrmModifierEleve.ShowDialog(); // ouverture du formulaire
            FrmModifierEleve.Close(); // fermeture du formulaire 
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FrmAjoutEleve FrmAjoutEleve;
            FrmAjoutEleve = new FrmAjoutEleve();
            FrmAjoutEleve.ShowDialog(); // ouverture du formulaire
            FrmAjoutEleve.Close(); // fermeture du formulaire 
        }
    }
}
