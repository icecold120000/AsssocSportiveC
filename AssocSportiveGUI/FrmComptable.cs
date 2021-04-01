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
    public partial class FrmComptable : Form
    {
        public FrmComptable()
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

        private void gestionDeComptabilitéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionComptabilite GestionComptabilite;
            GestionComptabilite = new FrmGestionComptabilite();
            GestionComptabilite.ShowDialog();
            GestionComptabilite.Close();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
            FrmConnexion FrmConnect;
            FrmConnect = new FrmConnexion();
            FrmConnect.ShowDialog(); // ouverture du formulaire
            FrmConnect.Close(); // fermeture du formulaire 
        }
    }
}
