using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Utilisateur
    {
        private int id_Utilisateur;
        private string login_Utilisateur;
        private string mdp_Utilisateur;
        private char droit_Utilisateur;


        // Constructuer de l'Utilisateur
        public Utilisateur(string login,string mdp,char droit)
        {
            login_Utilisateur = login;
            mdp_Utilisateur = mdp;
            droit_Utilisateur = droit;

        }
        public Utilisateur(int id, string login, string mdp, char droit)
        {
            id_Utilisateur = id;
            login_Utilisateur = login;
            mdp_Utilisateur = mdp;
            droit_Utilisateur = droit;

        }
        public int Id { get => id_Utilisateur; set => id_Utilisateur = value; }
        public string Login { get => login_Utilisateur; set => login_Utilisateur = value; }
        public string Mdp { get => mdp_Utilisateur; set => mdp_Utilisateur = value; }
        public char Droit { get => droit_Utilisateur; set => droit_Utilisateur = value; }

    }
}
