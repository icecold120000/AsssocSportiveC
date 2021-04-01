using BLL;
using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssocSportiveGUI
{
    public partial class FrmAjoutBudget : Form
    {
        public FrmAjoutBudget()
        {
            InitializeComponent();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            int montantInitial = ' ';

            if(txtLibelle.Text == " ")
            {
                MessageBox.Show("Erreur votre champ est vide. " +
                    "Veuillez saisir un libellé", "Erreur"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(txtMontant.Text ==" ")
            {
                MessageBox.Show("Erreur votre champ est vide. " +
                    "Veuillez saisir un montant", "Erreur"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                montantInitial = (int)Int64.Parse(txtMontant.Text);
            }

            BudgetBO unBudget = new BudgetBO(txtLibelle.Text, montantInitial);

            GestionBudget.AjoutBudget(unBudget);

            ActiveForm.Close();

        }
    }
}
