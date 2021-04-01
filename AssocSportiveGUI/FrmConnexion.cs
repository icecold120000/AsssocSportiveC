using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using BLL;
using BO;
using System.Data.SqlClient;


namespace AssocSportiveGUI
{
    public partial class FrmConnexion : Form
    {

        public FrmConnexion()
        {
            InitializeComponent();
            GestionUtilisateurs.SetchaineConnexion(ConfigurationManager
                .ConnectionStrings["AssocUtilisateur"]);
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {

            if (txtLogin.Text == "")
            {
                MessageBox.Show("Erreur votre champ est vide." +
                    " Veuillez saisir un login", "Erreur"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtMdp.Text == "")
            {
                MessageBox.Show("Erreur votre champ est vide. " +
                    "Veuillez saisir un mot de passe", "Erreur"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(lstDroit.SelectedIndex.ToString() == null)
            {
                MessageBox.Show("Erreur votre champ est vide. " +
                    "Veuillez selectionner un champ", "Erreur"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                SqlConnection myConnexion = default(SqlConnection);

                myConnexion = new SqlConnection(DAL.ConnexionBD.
                GetConnexionBD().GetchaineConnexion());
                {

                        GestionUtilisateurs.Connexion
                        (txtLogin.Text,txtMdp.Text,lstDroit.
                        SelectedIndex.ToString(), myConnexion);

                        
                        if ( lstDroit.Text == "Administrateur")
                        {
                            FrmAdmin FrmAdminis;
                            FrmAdminis = new FrmAdmin();
                            FrmAdminis.ShowDialog();
                            FrmAdminis.Close();
                        }
                        else
                        {
                            if( lstDroit.Text == "Comptable")
                            {
                                FrmComptable FrmCompta;
                                FrmCompta = new FrmComptable();
                                FrmCompta.ShowDialog();
                                FrmCompta.Close();
                            }

                        }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

    }
}
