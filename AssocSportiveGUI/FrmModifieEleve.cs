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
using System.Data.SqlClient;
using System.Configuration;

namespace AssocSportiveGUI
{
    public partial class FrmModifieEleve : Form
    {
        private TextBox textbox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private ListBox listBox7;
        private TextBox textBox8;
        private TextBox textBox9;



        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
        private ErrorProvider errorProvider5;
        private ErrorProvider errorProvider6;
        private ErrorProvider errorProvider7;
        private ErrorProvider errorProvider8;
        private ErrorProvider errorProvider9;

        private AdherantBO adherantAModifier;

        public FrmModifieEleve(int idAdherant)
        {
            InitializeComponent();
            GestionAdherant.SetchaineConnexion(ConfigurationManager
                .ConnectionStrings["AssocAdherant"]);

            adherantAModifier = GestionAdherant.TrouverAdherant(idAdherant);

            textbox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            listBox7 = new ListBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();



            errorProvider1 = new ErrorProvider();

            SuspendLayout();

            txtNom.Name = "textBox1";
            txtPrenom.Name = "textBox2";
            txtDateNaissance.Name = "textBox3";
            txtEmail.Name = "textBox4";
            txtTelephone.Name = "textBox5";
            txtNumParents.Name = "textBox6";
            lstClasse.Name = "textBox7";
            txtLogin.Name = "textBox8";
            txtMDP.Name = "textBox9";

            txtNom.TabIndex = 1;
            txtNom.Text = adherantAModifier.Nom;
            txtNom.Validating += new CancelEventHandler(txtNom_Validating);

            textBox2.TabIndex = 2;
            txtPrenom.Text = adherantAModifier.Prenom;
            textBox2.Validating += new CancelEventHandler(this.txtPrenom_Validating);

            textBox3.TabIndex = 3;
            txtDateNaissance.Text = adherantAModifier.Naissance.ToString("dd/MM/yyyy");
            textBox3.Validating += new CancelEventHandler(this.txtDateNaissance_Validating);

            textBox4.TabIndex = 4;
            txtEmail.Text = adherantAModifier.Email;
            textBox4.Validating += new CancelEventHandler(this.txtEmail_Validating);

            textBox5.TabIndex = 5;
            txtTelephone.Text = adherantAModifier.NumTel.ToString();
            textBox5.Validating += new CancelEventHandler(txtNumTelephone_Validating);

            textBox6.TabIndex = 6;
            txtNumParents.Text = adherantAModifier.NumParent.ToString();
            textBox6.Validating += new CancelEventHandler(txtNumParents_Validating);

            listBox7.TabIndex = 7;
            lstClasse.SelectedItem = adherantAModifier.Classe;
            listBox7.Validating += new CancelEventHandler(txtClasse_Validating);

            textBox8.TabIndex = 8;
            txtLogin.Text = adherantAModifier.Login;
            textBox8.Validating += new CancelEventHandler(txtLogin_Validating);

            textBox9.TabIndex = 9;
            txtMDP.Text = adherantAModifier.Mdp;
            textBox9.Validating += new CancelEventHandler(txtMDP_Validating);

            if (adherantAModifier.Sexe != ' ')
            {
                if (adherantAModifier.Sexe == 'G')
                {
                    optSexe1.Checked = true;
                }
                else
                {   
                    if(adherantAModifier.Sexe == 'F')
                    {
                        optSexe2.Checked = true;
                    }
                    
                }
            }

            if (adherantAModifier.Archive != ' ')
            {
                if (adherantAModifier.Archive == 'O')
                {
                    optArchive1.Checked = true;
                }
                else
                {
                    if(adherantAModifier.Archive == 'N')
                    { 
                        optArchive2.Checked = true;
                    }
                        
                }
            }

            if (adherantAModifier.AutoPrelev != ' ')
            {
                if (adherantAModifier.AutoPrelev == 'O')
                {
                    optPrelev1.Checked = true;
                }
                else
                {
                    if (adherantAModifier.AutoPrelev == 'N')
                    {
                        optPrelev2.Checked = true;
                    }

                }
            }

        }
        private void ValidateForm()
        {
            bool bValidName = ValidateName();
            bool bValidFirstName = ValidateFirstName();
            bool bValidEmail = ValidateEmail();
            bool bValidDateNaissance = ValidateDateNaissance();
            bool bValidNumero = ValidateNumTelephone();
            bool bValidNumeroParents = ValidateNumTelephoneParents();
            bool bValidClasse = ValidateClasse();
            bool bValidLogin = ValidateLogin();
            bool bValidMotDePasse = ValidateMotDePasse();

        }

        // Validation du nom
        private bool ValidateName()
        {
            bool bStatus = true;
            if (txtNom.Text == "")
            {
                errorProvider1.SetError(txtNom, "Veuillez entrer votre nom");
                bStatus = false;
            }
            else
                errorProvider1.SetError(txtNom, "");
            return bStatus;
        }
        private void txtNom_Validating(object sender, CancelEventArgs e)
        {
            ValidateName();
        }

        // Validation du prénom
        private bool ValidateFirstName()
        {
            bool bStatus = true;
            if (txtPrenom.Text == "")
            {
                errorProvider2.SetError(textBox2, "Veuillez entrer votre prénom");
                bStatus = false;
            }
            else
                errorProvider2.SetError(textBox2, "");
            return bStatus;
        }
        private void txtPrenom_Validating(object sender, CancelEventArgs e)
        {
            ValidateFirstName();
        }

        // Validation de l'email
        private bool ValidateEmail()
        {
            bool bStatus = true;
            if (txtEmail.Text == "")
            {
                errorProvider3.SetError(textBox3, "Veuillez entrer votre email");
                bStatus = false;
            }
            else
                errorProvider3.SetError(textBox3, "");
            return bStatus;
        }
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmail();
        }


        // Validation de la date de naissance
        private bool ValidateDateNaissance()
        {
            bool bStatus = true;
            if (txtDateNaissance.Text == "")
            {
                errorProvider4.SetError(textBox4, "Veuillez entrer votre date de naissance");
                bStatus = false;
            }
            else
                errorProvider4.SetError(textBox4, "");
            return bStatus;
        }
        private void txtDateNaissance_Validating(object sender, CancelEventArgs e)
        {
            ValidateDateNaissance();
        }

        // Validation du numéro de téléphone
        private bool ValidateNumTelephone()
        {
            bool bStatus = true;
            if (txtTelephone.Text == "")
            {
                errorProvider5.SetError(textBox5, "Veuillez entrer votre numéro de téléphone");
                bStatus = false;
            }
            else
                errorProvider5.SetError(textBox5, "");
            return bStatus;
        }
        private void txtNumTelephone_Validating(object sender, CancelEventArgs e)
        {
            ValidateDateNaissance();
        }

        // Validation du numéro de téléphone des parents

        private bool ValidateNumTelephoneParents()
        {
            bool bStatus = true;
            if (txtNumParents.Text == "")
            {
                errorProvider6.SetError(textBox6, "Veuillez entrer le numéro de téléphone des parents");
                bStatus = false;
            }
            else
                errorProvider6.SetError(textBox6, "");
            return bStatus;
        }
        private void txtNumParents_Validating(object sender, CancelEventArgs e)
        {
            ValidateNumTelephoneParents();
        }

        // Validation de la classe
        private bool ValidateClasse()
        {
            bool bStatus = true;
            if (lstClasse.Text == "")
            {
                errorProvider7.SetError(listBox7, "Veuillez selectionner votre classe");
                bStatus = false;
            }
            else
                errorProvider7.SetError(listBox7, "");
            return bStatus;
        }
        private void txtClasse_Validating(object sender, CancelEventArgs e)
        {
            ValidateClasse();
        }

        // Validation du login
        private bool ValidateLogin()
        {
            bool bStatus = true;
            if (txtLogin.Text == "")
            {
                errorProvider8.SetError(textBox8, "Veuillez entrer votre login");
                bStatus = false;
            }
            else
                errorProvider8.SetError(textBox8, "");
            return bStatus;
        }
        private void txtLogin_Validating(object sender, CancelEventArgs e)
        {
            ValidateLogin();
        }

        // Validation du mot de passe

        private bool ValidateMotDePasse()
        {
            bool bStatus = true;
            if (txtMDP.Text == "")
            {
                errorProvider9.SetError(textBox9, "Veuillez entrer votre mot de passe");
                bStatus = false;
            }
            else
                errorProvider9.SetError(textBox9, "");
            return bStatus;
        }
        private void txtMDP_Validating(object sender, CancelEventArgs e)
        {
            ValidateMotDePasse();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            char optionArchive = ' ';
            char optionPrelevement = ' ';
            char optionSexe = ' ';
            int numTelephone = ' ';
            int numTelephoneParents = ' ';
            DateTime dateNaissance = new DateTime();
            DateTime dateMaj = DateTime.Now;


            // Les champs a remplir
            if (txtNom.Text == "")
            {
                MessageBox.Show("Erreur votre champ est vide." +
                    " Veuillez saisir un nom", "Erreur"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (txtPrenom.Text == "")
            {
                MessageBox.Show("Erreur votre champ est vide. " +
                    "Veuillez saisir un prénom", "Erreur"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (txtDateNaissance.Text == "")
            {
                MessageBox.Show("Erreur votre champ est vide." +
                    " Veuillez saisir une date de naissance", "Erreur"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dateNaissance = Convert.ToDateTime(txtDateNaissance.Text);
            }

            if (txtEmail.Text == "")
            {
                MessageBox.Show("Erreur votre champ est vide. " +
                    "Veuillez saisir un email", "Erreur"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (txtTelephone.Text == "")
            {
                MessageBox.Show("Erreur votre champ est vide. " +
                    "Veuillez saisir un téléphone", "Erreur"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                numTelephone = (int)Int64.Parse(txtTelephone.Text);
            }

            if (txtNumParents.Text == "")
            {
                MessageBox.Show("Erreur votre champ est vide. " +
                    "Veuillez saisir un numéro des parents", "Erreur"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                numTelephoneParents = (int)Int64.Parse(txtNumParents.Text);
            }


            if (txtLogin.Text == "")
            {
                MessageBox.Show("Erreur votre champ est vide. " +
                    "Veuillez saisir un login", "Erreur"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (txtMDP.Text == "")
            {
                MessageBox.Show("Erreur votre champ est vide. " +
                    "Veuillez saisir un mot de passe", "Erreur"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // Les options de sexe a cocher

            if (optSexe1.Checked == false && optSexe2.Checked == false)
            {
                MessageBox.Show("Erreur votre champ est vide. " +
                    "Veuillez selectionner un sexe", "Erreur"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // Sexe

            if (optSexe1.Checked == true)
            {
                optionSexe = Convert.ToChar(optSexe1.Text);
            }
            else
            {
                if (optSexe2.Checked == true)
                {
                    optionSexe = Convert.ToChar(optSexe2.Text);
                }

            } 

            // Classe 
            if (lstClasse.SelectedItem == null)
            {
                MessageBox.Show("Erreur votre champ est vide. " +
                    "Veuillez selectionner une classe", "Erreur"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (optPrelev1.Checked == false && optPrelev2.Checked == false)
            {
                MessageBox.Show("Erreur votre champ est vide. " +
                    "Veuillez selectionner l'autorisation ou non de l'auto-prélèvement", "Erreur"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Auto-Prélèvement
            if (optPrelev1.Checked == true)
            {
                optionPrelevement = Convert.ToChar(optPrelev1.Text);
            }
            else
            {
                if (optPrelev2.Checked == true)
                {
                    optionPrelevement = Convert.ToChar(optPrelev2.Text);
                }

            }

            // Archive
            if (optArchive1.Checked == true)
            {
                optionArchive = Convert.ToChar(optArchive1.Text);
            }
            else
            {
                if (optArchive2.Checked == true)
                {
                    optionArchive = Convert.ToChar(optArchive2.Text);
                }

            }

            AdherantBO adh = new AdherantBO(txtNom.Text, txtPrenom.Text, dateNaissance,
                optionSexe, txtEmail.Text, numTelephone, dateMaj, numTelephoneParents, lstClasse.SelectedIndex,
                optionPrelevement, txtLogin.Text, txtMDP.Text, optionArchive);

            GestionAdherant.ModifierAdherant(adh);

            ActiveForm.Close();
        }

        private void FrmModifieEleve_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'classeAdherent2.CLASSE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.cLASSETableAdapter.Fill(this.classeAdherent2.CLASSE);

        }
    }
}
