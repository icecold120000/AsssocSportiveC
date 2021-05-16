using BLL;
using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssocSportiveGUI
{
    public partial class FrmGestionComptabilite : Form
    {
        public FrmGestionComptabilite()
        {
            InitializeComponent();
        }

        private void btn_deconnexion_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
            FrmConnexion FrmConnect;
            FrmConnect = new FrmConnexion();
            FrmConnect.ShowDialog(); // ouverture du formulaire
            FrmConnect.Close(); // fermeture du formulaire 
        }

        DataTable dt = new DataTable("adherents");
        private void FrmGestionComptabilite_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connexion = new SqlConnection(ConfigurationManager.ConnectionStrings["connexion"].ConnectionString))
                {
                    if (connexion.State == ConnectionState.Closed)
                        connexion.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ADHERANT", connexion))
                    {
                        da.Fill(dt);
                        lstEleve.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void lstEleve_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Blocage de la génération automatique des colonnes

            lstEleve.AutoGenerateColumns = false;

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

            lstEleve.Columns.Add(IdColumn);
            lstEleve.Columns.Add(NomColumn);
            lstEleve.Columns.Add(PrenomColumn);
            lstEleve.Columns.Add(NaissanceColumn);
            lstEleve.Columns.Add(SexeColumn);
            lstEleve.Columns.Add(EmailColumn);
            lstEleve.Columns.Add(NumTelColumn);
            lstEleve.Columns.Add(NumParentColumn);
            lstEleve.Columns.Add(PrelevColumn);
            lstEleve.Columns.Add(LoginColumn);
            lstEleve.Columns.Add(MdpColumn);
            lstEleve.Columns.Add(ClasseColumn);
            lstEleve.Columns.Add(ArchiveColumn);
            lstEleve.Columns.Add(DateMajColumn);

            // Définition du style apporté au datagridview

            lstEleve.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 12, FontStyle.Bold);

            lstEleve.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            lstEleve.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Création d'un objet List d'Utilisateur à afficher dans le datagridview
            List<AdherantBO> liste = new List<AdherantBO>();
            liste = GestionAdherant.GetAdherants();

            // Rattachement de la List à la source de données du datagridview

            lstEleve.DataSource = liste;
        }

        private void ecranStatistiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEcranStatistique EcranStatistique;
            EcranStatistique = new FrmEcranStatistique();
            EcranStatistique.ShowDialog();
            EcranStatistique.Close();
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {

            GestionAdherant.FiltreAdherant(txtSearch.Text);
        }
    }
}
