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
        public FrmAjoutFlux(int typeFlux)
        {
            InitializeComponent();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            int montantFlux;

            if(txtLibelle.Text == " ")
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
                montantFlux = (int)Int64.Parse(txtMontant.Text);
            }



        }

    }
}
