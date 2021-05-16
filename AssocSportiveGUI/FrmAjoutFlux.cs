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
    public partial class FrmAjoutFlux : Form
    {
        int idTypeFlux;

        public FrmAjoutFlux(int idType)
        {
            InitializeComponent();
            idTypeFlux = idType;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            int montantFlux = 0;
            int idAdherent = ' ';
            int idBudget = ' ';

            if (txtLibelle.Text == " ")
            {
                MessageBox.Show("Erreur votre champ est vide." +
                    " Veuillez saisir un nom", "Erreur"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (txtMontant.Text == " ")
            {
                MessageBox.Show("Erreur votre champ est vide. " +
                    "Veuillez saisir un montant", "Erreur"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                montantFlux = (int)Int32.Parse(txtMontant.Text);
            }

            if(lstAdherent.SelectedIndex == ' ')
            {
                MessageBox.Show("Erreur votre champ est vide. " +
                    "Veuillez selectionner un adherent", "Erreur"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                idAdherent = lstAdherent.SelectedIndex;
            }

            if (lstBudget.SelectedIndex == ' ')
            {
                MessageBox.Show("Erreur votre champ est vide. " +
                    "Veuillez selectionner un budget", "Erreur"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                idBudget = lstBudget.SelectedIndex;
            }

            Flux unFlux = new Flux(txtLibelle.Text,montantFlux,idAdherent,idTypeFlux,idBudget);
            GestionFlux.AjoutFlux(unFlux);

            Form.ActiveForm.Close();

        }

        private void FrmAjoutFlux_Load(object sender, EventArgs e)
        {

            // TODO: cette ligne de code charge les données dans la table 'budget.BUDGET'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.bUDGETTableAdapter.Fill(this.budget.BUDGET);
            // TODO: cette ligne de code charge les données dans la table 'adherent.ADHERANT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.aDHERANTTableAdapter.Fill(this.adherent.ADHERANT);

        }
    }
}
