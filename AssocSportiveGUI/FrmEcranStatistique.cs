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
    public partial class FrmEcranStatistique : Form
    {
        public FrmEcranStatistique()
        {
            InitializeComponent();
        }

        private void gestionDesBudgetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionBudget GestionBudget;
            GestionBudget = new FrmGestionBudget();
            GestionBudget.ShowDialog();
            GestionBudget.Close();
        }

        private void présentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void gestionDesÉlèvesAdhérantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAjout GestionEleve;
            GestionEleve = new btnAjout();
            GestionEleve.ShowDialog();
            GestionEleve.Close();
        }

        private void gestionDeLaComptabilitéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionComptabilite GestionComptabilite;
            GestionComptabilite = new FrmGestionComptabilite();
            GestionComptabilite.ShowDialog();
            GestionComptabilite.Close();
        }

        private void btn_deconnexion_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
            FrmConnexion FrmConnect;
            FrmConnect = new FrmConnexion();
            FrmConnect.ShowDialog(); // ouverture du formulaire
            FrmConnect.Close(); // fermeture du formulaire 
        }
    }
}
