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
using System.Data.SqlClient;

namespace AssocSportiveGUI
{
    public partial class FrmAjoutEleve : Form
    {

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;


        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.ErrorProvider errorProvider7;
        private System.Windows.Forms.ErrorProvider errorProvider8;
        private System.Windows.Forms.ErrorProvider errorProvider9;

        public FrmAjoutEleve()
        {

            InitializeComponent();


            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();

            this.errorProvider1 = new System.Windows.Forms.ErrorProvider();

            this.SuspendLayout();

            txtNom.Name = "textBox1";
            this.textBox2.Name = "textBox2";
            this.textBox3.Name = "textBox3";
            this.textBox4.Name = "textBox4";
            this.textBox5.Name = "textBox5";
            this.textBox6.Name = "textBox6";
            this.textBox7.Name = "textBox7";
            this.textBox8.Name = "textBox8";
            this.textBox9.Name = "textBox9";

            this.txtNom.TabIndex = 1;
            this.txtNom.Text = "";
            this.txtNom.Validating += new CancelEventHandler(this.textBox1_Validating);

            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "";
            this.textBox2.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);

            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "";
            this.textBox3.Validating += new System.ComponentModel.CancelEventHandler(this.textBox3_Validating);

            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "";
            this.textBox4.Validating += new System.ComponentModel.CancelEventHandler(this.textBox4_Validating);

            this.textBox5.TabIndex = 5;
            this.textBox5.Text = "";
            this.textBox5.Validating += new System.ComponentModel.CancelEventHandler(this.textBox5_Validating);

            this.textBox6.TabIndex = 6;
            this.textBox6.Text = "";
            this.textBox6.Validating += new System.ComponentModel.CancelEventHandler(this.textBox6_Validating);

            this.textBox7.TabIndex = 7;
            this.textBox7.Text = "";
            this.textBox7.Validating += new System.ComponentModel.CancelEventHandler(this.textBox6_Validating);

            this.textBox8.TabIndex = 8;
            this.textBox8.Text = "";
            this.textBox8.Validating += new System.ComponentModel.CancelEventHandler(this.textBox6_Validating);

            this.textBox9.TabIndex = 9;
            this.textBox9.Text = "";
            this.textBox9.Validating += new System.ComponentModel.CancelEventHandler(this.textBox6_Validating);

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
                errorProvider1.SetError(txtNom, "Veuillez entre votre nom");
                bStatus = false;
            }
            else
                errorProvider1.SetError(txtNom, "");
            return bStatus;
        }
        private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateName();
        }


        // Validation du prénom
        private bool ValidateFirstName()
        {
            bool bStatus = true;
            if (txtPrenom.Text == "")
            {
                errorProvider2.SetError(textBox2, "Veuillez entre votre prénom");
                bStatus = false;
            }
            else
                errorProvider2.SetError(textBox2, "");
            return bStatus;
        }
        private void textBox2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateFirstName();
        }


        // Validation de l'email
        private bool ValidateEmail()
        {
            bool bStatus = true;
            if (txtEmail.Text == "")
            {
                errorProvider3.SetError(textBox3, "Veuillez entre votre email");
                bStatus = false;
            }
            else
                errorProvider3.SetError(textBox3, "");
            return bStatus;
        }
        private void textBox3_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateEmail();
        }


        // Validation de la date de naissance
        private bool ValidateDateNaissance()
        {
            bool bStatus = true;
            if (textBox4.Text == "")
            {
                errorProvider4.SetError(textBox4, "Veuillez entre votre date de naissance");
                bStatus = false;
            }
            else
                errorProvider4.SetError(textBox4, "");
            return bStatus;
        }
        private void textBox4_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateDateNaissance();
        }


        // Validation du numéro de téléphone
        private bool ValidateNumTelephone()
        {
            bool bStatus = true;
            if (textBox5.Text == "")
            {
                errorProvider5.SetError(textBox5, "Veuillez entre votre numéro de téléphone");
                bStatus = false;
            }
            else
                errorProvider5.SetError(textBox5, "");
            return bStatus;
        }
        private void textBox5_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateDateNaissance();
        }


        // Validation du numéro de téléphone des parents

        private bool ValidateNumTelephoneParents()
        {
            bool bStatus = true;
            if (textBox6.Text == "")
            {
                errorProvider6.SetError(textBox6, "Veuillez entre votre numéro de téléphone");
                bStatus = false;
            }
            else
                errorProvider6.SetError(textBox6, "");
            return bStatus;
        }
        private void textBox6_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateNumTelephoneParents();
        }

        // Validation de la classe
        private bool ValidateClasse()
        {
            bool bStatus = true;
            if (textBox7.Text == "")
            {
                errorProvider7.SetError(textBox7, "Veuillez selectionner votre classe");
                bStatus = false;
            }
            else
                errorProvider7.SetError(textBox7, "");
            return bStatus;
        }
        private void textBox7_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateClasse();
        }

        // Validation du login
        private bool ValidateLogin()
        {
            bool bStatus = true;
            if (textBox8.Text == "")
            {
                errorProvider8.SetError(textBox8, "Veuillez entre votre login");
                bStatus = false;
            }
            else
                errorProvider8.SetError(textBox8, "");
            return bStatus;
        }
        private void textBox8_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateLogin();
        }


        // Validation du mot de passe

        private bool ValidateMotDePasse()
        {
            bool bStatus = true;
            if (textBox9.Text == "")
            {
                errorProvider9.SetError(textBox9, "Veuillez entre votre mot de passe");
                bStatus = false;
            }
            else
                errorProvider9.SetError(textBox9, "");
            return bStatus;
        }
        private void textBox9_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateMotDePasse();
        }


        private void btnEnregistrer_Click(object sender, EventArgs e)
        {

            // Pour la conversion 

            char optionArchive = ' ';
            char optionPrelevement = ' ';
            char optionSexe = ' ';
            int numTelephone = ' ';
            int numTelephoneParents = ' ';
            DateTime dateNaissance = new DateTime();

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

            // Si les options de sexe sont bien renseignés


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

            // Si les options d'auto-prélèvement sont bien renseignés

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

            AdherantBO unAdherant = new AdherantBO(txtNom.Text, txtPrenom.Text, dateNaissance,
                optionSexe, txtEmail.Text, numTelephone, numTelephoneParents, lstClasse.SelectedIndex,
                optionPrelevement, txtLogin.Text, txtMDP.Text, optionArchive);
            GestionAdherant.AjoutAdherant(unAdherant);

            ActiveForm.Close();
        }


    }
}
