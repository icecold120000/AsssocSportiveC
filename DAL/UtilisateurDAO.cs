using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;


namespace DAL
{
    public class UtilisateurDAO
    {
        private static UtilisateurDAO unUtilisateurDAO;
        // Accesseur en lecture, renvoi une instance
        public static UtilisateurDAO GetunUtilisateurDAO()
        {
            if (unUtilisateurDAO == null)
            {
                unUtilisateurDAO = new UtilisateurDAO();
            }
            return unUtilisateurDAO;
        }

        // Cette méthode retourne une List contenant les objets Utilisateurs
        //contenus dans la table Utlisateur
        public static List<Utilisateur> GetUtilisateurs()
        {
            string login;
            string mdp;
            char droit;
            Utilisateur unUtilisateur;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Utilisateurs
            List<Utilisateur> lesUtilisateurs = new List<Utilisateur>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT * FROM UTILISATEUR";
            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                if (monReader["login_user"] == DBNull.Value)
                {
                    login = default(string);
                }
                else
                {
                    login = monReader["login_user"].ToString();
                }

                if (monReader["mdp_user"] == DBNull.Value)
                {
                    mdp = default(string);
                }
                else
                {
                    mdp = monReader["mdp_user"].ToString();
                }
                droit = char.Parse(monReader["droit_user"].ToString());
                unUtilisateur = new Utilisateur(login,mdp, droit);
                lesUtilisateurs.Add(unUtilisateur);
            }
            // Fermeture de la connexion
            maConnexion.Close();
            return lesUtilisateurs;
        }

        public static Utilisateur Requete(string utiLogin, string utiMpd,
            string utiDroit, SqlConnection maConnexion)
        {

            Utilisateur utiConnecte = new Utilisateur(" ", " ", ' ');
            SqlCommand myCommand = default(SqlCommand);
            SqlDataReader myReader = null;
            char droit = ' ';

            if (utiDroit == "administrateur")
            {
                droit = 'A';
            }
            if (utiDroit == "Comptable")
            {
                droit = 'C';
            }

            List<Utilisateur> listeUtilisateur;
            listeUtilisateur = UtilisateurDAO.GetUtilisateurs();
            int nbUtilisateur = listeUtilisateur.Count();

            for (int ind = 0; ind < nbUtilisateur; ind++)
            {
                if (utiLogin == listeUtilisateur[ind].Login &&
                    utiMpd == listeUtilisateur[ind].Mdp &&
                    droit == listeUtilisateur[ind].Droit)
                {

                    myCommand = new SqlCommand("SELECT login_user,mdp_user, " +
                        "droit_user FROM Utilisateur WHERE login_user = @Login" +
                        " AND mdp_user = @Password" +
                        "AND droit_user = @Droit", maConnexion);

                    SqlParameter uLogin =
                        new SqlParameter("@Login", SqlDbType.VarChar);
                    SqlParameter uPassword =
                        new SqlParameter("@Password", SqlDbType.VarChar);
                    SqlParameter uDroit =
                        new SqlParameter("@Droit", SqlDbType.Char);

                    uLogin.Value = utiLogin;
                    uPassword.Value = utiMpd;
                    uDroit.Value = utiDroit;

                    myCommand.Parameters.Add(uLogin);
                    myCommand.Parameters.Add(uPassword);
                    myCommand.Parameters.Add(uDroit);

                    myCommand.Connection.Open();


                    myReader = myCommand.
                       ExecuteReader(CommandBehavior.CloseConnection);


                    if (myReader.Read() == true)
                    {
                        char utiDroitSelectionner;
                        utiDroitSelectionner = Convert.ToChar(utiDroit);
                        utiConnecte = new Utilisateur(utiLogin, utiMpd, utiDroitSelectionner);
                    }
                    else
                    {
                        if (utiLogin != listeUtilisateur[ind].Login)
                        {
                            Console.WriteLine("Erreur, votre utilisateur " +
                                " est incorrect ou n'existe pas");
                        }
                        if (utiMpd != listeUtilisateur[ind].Mdp)
                        {
                            Console.WriteLine("Erreur, votre mot de passe" +
                                " est incorrect");
                        }
                        char utiDroitSelectionner;
                        utiDroitSelectionner = Convert.ToChar(utiDroit);
                        if (utiDroitSelectionner != listeUtilisateur[ind].Droit)
                        {
                            Console.WriteLine("Erreur, vous n'avez pas " +
                                "selectionné le bon droit");
                        }
                    }

                }

            }
            return utiConnecte;
        }

    }
}

