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
using BLL;
using BO;

namespace AssocSportiveGUI
{
    public partial class FrmModifieBudget : Form
    {
        
        private System.Windows.Forms.TextBox textbox1;

        private System.Windows.Forms.ErrorProvider errorProvider1;

        private BudgetBO budgetModifie;

        public FrmModifieBudget(int idBudget)
        {
            InitializeComponent();
            GestionAdherant.SetchaineConnexion(ConfigurationManager
                .ConnectionStrings["AssocBudget"]);

            budgetModifie = GestionBudget.TrouverBudget(idBudget);

            this.textbox1 = new System.Windows.Forms.TextBox();

            this.errorProvider1 = new System.Windows.Forms.ErrorProvider();

            this.SuspendLayout();

            this.txtMontant.Name = "textBox1";

            this.errorProvider1 = new System.Windows.Forms.ErrorProvider();

            this.txtMontant.TabIndex = 1;
            this.txtMontant.Text = budgetModifie.Montant.ToString();
            this.txtMontant.Validating += new CancelEventHandler(this.txtNom_Validating);
        }

        private void ValidateForm()
        {
            bool bValidName = ValidateName();

        }

        // Validation du nom
        private bool ValidateName()
        {
            bool bStatus = true;
            if (txtMontant.Text == "")
            {
                errorProvider1.SetError(txtMontant, "Veuillez entrer votre montant");
                bStatus = false;
            }
            else
                errorProvider1.SetError(txtMontant, "");
            return bStatus;
        }
        private void txtNom_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateName();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            int montantBudget = 0;

            if(txtMontant.Text == " ")
            {
                MessageBox.Show("Erreur votre champ est vide." +
                    " Veuillez saisir un montant", "Erreur"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                montantBudget = (int)Int64.Parse(txtMontant.Text);
            }

            SqlConnection myConnexion = default(SqlConnection);
            myConnexion = new SqlConnection(DAL.ConnexionBD.
            GetConnexionBD().GetchaineConnexion());

            BudgetBO unBudget = new BudgetBO(montantBudget);

            GestionBudget.ModifieMontant(unBudget);
        }
    }
}
