using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class AdherantBO
    {
        private int id_adherant;
        private string nom_adherant;
        private string prenom_adherant;
        private DateTime ddn_adherant;
        private char sexe_adherant;
        private string email_adherant;
        private int numtel_adherant;
        private DateTime date_maj_adherant;
        private int numparent_adherant;
        private char autoprelev_adherant;
        private string login_adherant;
        private string mdp_adherant;
        private char archive_adherant;
        private int classe_adherant;

        public AdherantBO(int id, string nom, string prenom)
        {
            id_adherant = id;
            nom_adherant = nom;
            prenom_adherant = prenom;
        }

        public AdherantBO(int id, string nom, string prenom, 
            DateTime ddn,char sexe, string email, int numTel_Ad, DateTime dateMaj,
            int numParent,int classe,char autoprelev,string loginAdherant,
            string mdpAdherant,char archiveAdherant)
        {
            id_adherant = id;
            nom_adherant = nom;
            prenom_adherant = prenom;
            ddn_adherant = ddn;
            sexe_adherant = sexe;
            email_adherant = email;
            numtel_adherant = numTel_Ad;
            dateMaj = date_maj_adherant;
            numparent_adherant = numParent;
            classe_adherant = classe;
            autoprelev_adherant = autoprelev;
            login_adherant = loginAdherant;
            mdp_adherant = mdpAdherant;
            archive_adherant = archiveAdherant;
        }

        public AdherantBO(string nom, string prenom,
            DateTime ddn, char sexe, string email, int numTel_Ad, DateTime dateMaj,
            int numParent, int classe, char autoprelev, string loginAdherant,
            string mdpAdherant, char archiveAdherant)
        {
            nom_adherant = nom;
            prenom_adherant = prenom;
            ddn_adherant = ddn;
            sexe_adherant = sexe;
            email_adherant = email;
            numtel_adherant = numTel_Ad;
            dateMaj = date_maj_adherant;
            numparent_adherant = numParent;
            classe_adherant = classe;
            autoprelev_adherant = autoprelev;
            login_adherant = loginAdherant;
            mdp_adherant = mdpAdherant;
            archive_adherant = archiveAdherant;
        }

        public AdherantBO(string nom, string prenom,
            DateTime ddn, char sexe, string email, int numTel_Ad, 
            int numParent,int classe, char autoprelev, string loginAdherant,
            string mdpAdherant, char archiveAdherant)
        {
            nom_adherant = nom;
            prenom_adherant = prenom;
            ddn_adherant = ddn;
            sexe_adherant = sexe;
            email_adherant = email;
            numtel_adherant = numTel_Ad;
            numparent_adherant = numParent;
            classe_adherant = classe;
            autoprelev_adherant = autoprelev;
            login_adherant = loginAdherant;
            mdp_adherant = mdpAdherant;
            archive_adherant = archiveAdherant;
        }

        public int Id { get => id_adherant; set => id_adherant = value; }
        public string Nom { get => nom_adherant; set => nom_adherant = value; }
        public string Prenom { get => prenom_adherant; set => prenom_adherant = value; }
        public DateTime Naissance { get => ddn_adherant; set => ddn_adherant = value; }
        public char Sexe { get => sexe_adherant; set => sexe_adherant = value; }
        public string Email { get => email_adherant; set => email_adherant = value; }
        public int NumTel { get => numtel_adherant; set => numtel_adherant = value; }
        public DateTime DateMaj { get => date_maj_adherant; set => date_maj_adherant = value; }
        public int NumParent { get => numparent_adherant; set => numparent_adherant = value; }
        public char AutoPrelev { get => autoprelev_adherant; set => autoprelev_adherant = value; }
        public string Login { get => login_adherant; set => login_adherant = value; }
        public string Mdp { get => mdp_adherant; set => mdp_adherant = value; }
        public char Archive { get => archive_adherant; set => archive_adherant = value; }
        public int Classe { get => classe_adherant; set => classe_adherant = value; }
    }
}
