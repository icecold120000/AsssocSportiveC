using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BO;
using BLL;
using System.Configuration;

namespace AssocSportiveGUI
{
    public partial class FrmGestionBudget : Form
    {
        private int libelleColumnId;
        private int idColonneEPS;
        private int idColonneAS;


        public FrmGestionBudget()
        {
            InitializeComponent();
            GestionBudget.SetchaineConnexion(ConfigurationManager.
                ConnectionStrings["AssocBudget"]);
            GestionFlux.SetchaineConnexion(ConfigurationManager.
                ConnectionStrings["AssocFlux"]);

            List<BudgetBO> budgetInitialAS = new List<BudgetBO>();
            budgetInitialAS = GestionBudget.GetBudget("AS");
            List<BudgetBO> budgetInitialEPS = new List<BudgetBO>();
            budgetInitialEPS = GestionBudget.GetBudget("EPS");
            List<Flux> listeCredit = new List<Flux>();
            listeCredit = GestionFlux.GetFlux(1);
            List<Flux> listeDebit = new List<Flux>();
            listeDebit = GestionFlux.GetFlux(2);


            // Rattachement de la List à la source de données du datagridview

            dtgBudgetAS.ColumnHeadersVisible = false;
            dtgBudgetEPS.ColumnHeadersVisible = false;

            dtgBudgetAS.DataSource = budgetInitialAS;
            dtgBudgetEPS.DataSource = budgetInitialEPS;
            dtgDebits.DataSource = listeDebit;
            dtgCredits.DataSource = listeCredit;
        }

        private void btn_deconnexion_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
            FrmConnexion FrmConnect;
            FrmConnect = new FrmConnexion();
            FrmConnect.ShowDialog(); // ouverture du formulaire
            FrmConnect.Close(); // fermeture du formulaire 
        }

        private void dtgBudgetEPS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgBudgetEPS.AutoGenerateColumns = false;

            // Création d'une en-tête de colonne pour la colonne 1

            DataGridViewTextBoxColumn BudgetEPSMontant = new DataGridViewTextBoxColumn();

            BudgetEPSMontant.DataPropertyName = "montantInitial_budget";

            dtgBudgetEPS.Columns.Add(BudgetEPSMontant);

            // Définition du style apporté au datagridview

            dtgBudgetEPS.ColumnHeadersVisible = false;

            dtgBudgetEPS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Création d'un objet List d'Utilisateur à afficher dans le datagridview
            List<BudgetBO> budgetInitial = new List<BudgetBO>();
            budgetInitial = GestionBudget.GetBudget("EPS");

            // Rattachement de la List à la source de données du datagridview

            dtgBudgetEPS.DataSource = budgetInitial;

        }

        private void dtgBudgetAS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgBudgetAS.AutoGenerateColumns = false;

            // Création d'une en-tête de colonne pour la colonne 2

            DataGridViewTextBoxColumn BudgetASMontant = new DataGridViewTextBoxColumn();

            BudgetASMontant.DataPropertyName = "montantInitial_budget";

            dtgBudgetAS.Columns.Add(BudgetASMontant);


            // Définition du style apporté au datagridview

            dtgBudgetAS.ColumnHeadersVisible = false;

            dtgBudgetAS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Création d'un objet List d'Utilisateur à afficher dans le datagridview
            List<BudgetBO> budgetInitial = new List<BudgetBO>();
            budgetInitial = GestionBudget.GetBudget("AS");

            // Rattachement de la List à la source de données du datagridview

            dtgBudgetAS.DataSource = budgetInitial;
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {

            dtgBudgetAS.ColumnHeadersVisible = false;
            dtgBudgetEPS.ColumnHeadersVisible = false;

            dtgBudgetAS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgBudgetEPS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            // Création d'un objet List d'Utilisateur à afficher dans le datagridview

            List<BudgetBO> budgetInitialAS = new List<BudgetBO>();
            budgetInitialAS = GestionBudget.GetBudget("AS");
            List<BudgetBO> budgetInitialEPS = new List<BudgetBO>();
            budgetInitialEPS = GestionBudget.GetBudget("EPS"); 

            // Rattachement de la List à la source de données du datagridview

            dtgBudgetAS.DataSource = budgetInitialAS;
            dtgBudgetEPS.DataSource = budgetInitialEPS;

        }

        private void dtgCredits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgCredits.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn libelleColumn = new DataGridViewTextBoxColumn();
            libelleColumn.DataPropertyName = "libelle_flux";
            libelleColumn.HeaderText = "Libelle";

            DataGridViewTextBoxColumn montantColumn = new DataGridViewTextBoxColumn();
            montantColumn.DataPropertyName = "montant_flux";
            montantColumn.HeaderText = "Montant";

            DataGridViewTextBoxColumn dateColumn = new DataGridViewTextBoxColumn();
            dateColumn.DataPropertyName = "date_flux";
            dateColumn.HeaderText = "Date";

            DataGridViewTextBoxColumn AdherentColumn = new DataGridViewTextBoxColumn();
            AdherentColumn.DataPropertyName = "adherent_flux";
            AdherentColumn.HeaderText = "Adherent";

            DataGridViewTextBoxColumn TypeFluxColumn = new DataGridViewTextBoxColumn();
            TypeFluxColumn.DataPropertyName = "id_type_flux";
            TypeFluxColumn.HeaderText = "TypeFlux";

            DataGridViewTextBoxColumn EventColumn = new DataGridViewTextBoxColumn();
            EventColumn.DataPropertyName = "event_flux";
            EventColumn.HeaderText = "Event";

            dtgCredits.Columns.Add(libelleColumn);
            dtgCredits.Columns.Add(montantColumn);
            dtgCredits.Columns.Add(dateColumn);
            dtgCredits.Columns.Add(AdherentColumn);
            dtgCredits.Columns.Add(TypeFluxColumn);
            dtgCredits.Columns.Add(EventColumn);

            dtgCredits.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 12, FontStyle.Bold);

            dtgCredits.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dtgCredits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Création d'un objet Liste à afficher dans le datagridview
            List<Flux> liste = new List<Flux>();
            liste = GestionFlux.GetFlux(1);

            // Rattachement de la List à la source de données du datagridview

            dtgCredits.DataSource = liste;
        }

        private void btnActualiserCredits_Click(object sender, EventArgs e)
        {

            List<Flux> listeCredit = new List<Flux>();
            listeCredit = GestionFlux.GetFlux(1);
            dtgCredits.DataSource = listeCredit;
        }

        private void btnSupprimerCredits_Click(object sender, EventArgs e)
        {
            List<Flux> liste = new List<Flux>();
            liste = GestionFlux.GetFlux(1);

            var result1 = MessageBox.Show("Voulez-vous vraiment supprimer ce crédit ?", "Message d'information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result1 == DialogResult.Yes)
            {
                dtgCredits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                int rowIndex = dtgCredits.CurrentCell.RowIndex;
                int columnIndex = dtgCredits.CurrentCell.ColumnIndex;

                // Il choisit la colonne infectée par le choix
                libelleColumnId = Int32.Parse(dtgCredits.Rows[rowIndex].Cells[columnIndex].Value.ToString());

                // Supprime le crédit avec l'id concerné
                GestionFlux.DeleteFlux(libelleColumnId);

                var result2 = MessageBox.Show("Votre crédit a bien été supprimé" + "\nVoulez vous supprimé un autre crédit ?", "Message d'information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result2 == DialogResult.No)
                {
                    Form.ActiveForm.Close();
                }
            }
        }

        private void dtgDebits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgDebits.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn libelleColumn = new DataGridViewTextBoxColumn();
            libelleColumn.DataPropertyName = "libelle_flux";
            libelleColumn.HeaderText = "Libelle";

            DataGridViewTextBoxColumn montantColumn = new DataGridViewTextBoxColumn();
            montantColumn.DataPropertyName = "montant_flux";
            montantColumn.HeaderText = "Montant";

            DataGridViewTextBoxColumn dateColumn = new DataGridViewTextBoxColumn();
            dateColumn.DataPropertyName = "date_flux";
            dateColumn.HeaderText = "Date";

            DataGridViewTextBoxColumn AdherentColumn = new DataGridViewTextBoxColumn();
            AdherentColumn.DataPropertyName = "id_adherent";
            AdherentColumn.HeaderText = "Adherent";

            DataGridViewTextBoxColumn TypeFluxColumn = new DataGridViewTextBoxColumn();
            TypeFluxColumn.DataPropertyName = "id_type_flux";
            TypeFluxColumn.HeaderText = "Type de Flux";

            DataGridViewTextBoxColumn EventColumn = new DataGridViewTextBoxColumn();
            EventColumn.DataPropertyName = "id_budget";
            EventColumn.HeaderText = "Budget Impacté";

            dtgDebits.Columns.Add(libelleColumn);
            dtgDebits.Columns.Add(montantColumn);
            dtgDebits.Columns.Add(dateColumn);
            dtgDebits.Columns.Add(AdherentColumn);
            dtgDebits.Columns.Add(TypeFluxColumn);
            dtgDebits.Columns.Add(EventColumn);

            dtgDebits.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 12, FontStyle.Bold);

            dtgDebits.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dtgDebits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Création d'un objet Liste à afficher dans le datagridview
            List<Flux> liste = new List<Flux>();
            liste = GestionFlux.GetFlux(2);

            // Rattachement de la List à la source de données du datagridview

            dtgDebits.DataSource = liste;
        }

        private void btnActualiserDebits_Click(object sender, EventArgs e)
        {
            List<Flux> liste = new List<Flux>();
            liste = GestionFlux.GetFlux(2);
            dtgDebits.DataSource = liste;
        }

        private void btnSupprimerDebits_Click(object sender, EventArgs e)
        {
            List<Flux> liste = new List<Flux>();
            liste = GestionFlux.GetFlux(2);

            var result1 = MessageBox.Show("Voulez-vous vraiment supprimer ce débit ?", "Message d'information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result1 == DialogResult.Yes)
            {
                dtgDebits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                int rowIndex = dtgDebits.CurrentCell.RowIndex;
                int columnIndex = dtgDebits.CurrentCell.ColumnIndex;

                // Il choisit la colonne infectée par le choix
                libelleColumnId = Int32.Parse(dtgDebits.Rows[rowIndex].Cells[columnIndex].Value.ToString());

                // Supprime le crédit avec l'id concerné
                GestionFlux.DeleteFlux(libelleColumnId);

                var result2 = MessageBox.Show("Votre débit a bien été supprimé" + "\nVoulez vous supprimé un autre débit ?", "Message d'information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result2 == DialogResult.No)
                {
                    Form.ActiveForm.Close();
                }
            }
        }

        private void btnAjoutCredit_Click(object sender, EventArgs e)
        {
            FrmAjoutFlux FrmAjouterCredit;
            FrmAjouterCredit = new FrmAjoutFlux(1);
            FrmAjouterCredit.ShowDialog(); // ouverture du formulaire
            FrmAjouterCredit.Close(); // fermeture du formulaire 
        }

        private void btnAjoutDébit_Click(object sender, EventArgs e)
        {
            FrmAjoutFlux FrmAjouterDebit;
            FrmAjouterDebit = new FrmAjoutFlux(2);
            FrmAjouterDebit.ShowDialog(); // ouverture du formulaire
            FrmAjouterDebit.Close(); // fermeture du formulaire 
        }

        private void btnAjouterBudget_Click(object sender, EventArgs e)
        {
            FrmAjoutBudget FrmAjouterBudget;
            FrmAjouterBudget = new FrmAjoutBudget();
            FrmAjouterBudget.ShowDialog(); // ouverture du formulaire
            FrmAjouterBudget.Close(); // fermeture du formulaire 
        }

        private void btnModifie_Click(object sender, EventArgs e)
        {

            dtgBudgetEPS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            int rowIndexEPS = dtgBudgetEPS.CurrentCell.RowIndex;
            int columnIndexEPS = dtgBudgetEPS.CurrentCell.ColumnIndex;

            dtgBudgetAS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            int rowIndexAS = dtgBudgetAS.CurrentCell.RowIndex;
            int columnIndexAS = dtgBudgetAS.CurrentCell.ColumnIndex;

            idColonneEPS = Int32.Parse(dtgBudgetEPS.Rows[rowIndexEPS].Cells[columnIndexEPS].Value.ToString());
            idColonneAS = Int32.Parse(dtgBudgetAS.Rows[rowIndexAS].Cells[columnIndexAS].Value.ToString());

            if(idColonneEPS != ' ')
            {
                FrmModifieBudget FrmModifierBudget;
                FrmModifierBudget = new FrmModifieBudget(idColonneEPS);
                FrmModifierBudget.ShowDialog(); // ouverture du formulaire
                FrmModifierBudget.Close(); // fermeture du formulaire 
            }
            else
            {
                if(idColonneAS != ' ')
                {
                    FrmModifieBudget FrmModifierBudget;
                    FrmModifierBudget = new FrmModifieBudget(idColonneAS);
                    FrmModifierBudget.ShowDialog(); // ouverture du formulaire
                    FrmModifierBudget.Close(); // fermeture du formulaire 
                }
            }

        }
    }
}
