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
    public class AdherantDAO
    {
        private static AdherantDAO unAdherantDAO;
        // Accesseur en lecture, renvoi une instance
        public static AdherantDAO GetunAdherantDAO()
        {
            if (unAdherantDAO == null)
            {
                unAdherantDAO = new AdherantDAO();
            }
            return unAdherantDAO;
        }

        // Cette méthode retourne une List contenant les objets Adherants
        //contenus dans la table Identification
        public static List<AdherantBO> GetAdherants()
        {
            int id;
            string nom;
            string prenom;
            DateTime dateNaissance;
            char sexe;
            string email;
            int numeroTel;
            DateTime dateMaj;
            int numParent;
            int classe;
            char prelevement;
            string login;
            string mdp;
            char archive;

            AdherantBO unAdherant;
            // Connexion à la BD
            SqlConnection maConnexion =
            ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Adherants
            List<AdherantBO> lesAdherants = new List<AdherantBO>();
            SqlCommand cmd = new SqlCommand(" SELECT * FROM ADHERANT Where archive_adherant = @Archive", maConnexion);

            SqlParameter adhArchive =
                new SqlParameter("@Archive", SqlDbType.Char);

            adhArchive.Value = 'N';
            cmd.Parameters.Add(adhArchive);

            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                id = Int32.Parse(monReader["id_adherant"].ToString());
                if (monReader["nom_adherant"] == DBNull.Value)
                {
                    nom = default(string);
                }
                else
                {
                    nom = monReader["nom_adherant"].ToString();
                }
                if (monReader["prenom_adherant"] == DBNull.Value)
                {
                    prenom = default(string);
                }
                else
                {
                    prenom = monReader["prenom_adherant"].ToString();
                }
                dateNaissance = DateTime.Parse(monReader["ddn_adherant"].ToString());
                sexe = Char.Parse(monReader["sexe_adherant"].ToString());
                if (monReader["email_adherant"] == DBNull.Value)
                {
                    email = default(string);
                }
                else
                {
                    email = monReader["email_adherant"].ToString();
                }
                numeroTel = Int32.Parse(monReader["numtel_adherant"].ToString());
                dateMaj = DateTime.Parse(monReader["date_maj_adherant"].ToString());
                numParent = Int32.Parse(monReader["numparent_adherant"].ToString());
                classe = Int32.Parse(monReader["id_classe"].ToString());
                prelevement = Char.Parse(monReader["autoprelev_adherant"].ToString());
                if (monReader["login_adherant"] == DBNull.Value)
                {
                    login = default(string);
                }
                else
                {
                    login = monReader["login_adherant"].ToString();
                }
                if (monReader["mdp_adherant"] == DBNull.Value)
                {
                    mdp = default(string);
                }
                else
                {
                    mdp = monReader["mdp_adherant"].ToString();
                }
                archive = Char.Parse(monReader["archive_adherant"].ToString());
                unAdherant = new AdherantBO(id, nom, prenom, dateNaissance, sexe,
                    email, numeroTel, dateMaj, numParent, classe, prelevement, login, mdp,
                    archive);
                lesAdherants.Add(unAdherant);
            }
            // Fermeture de la connexion
            maConnexion.Close();
            return lesAdherants;
        }

        public static AdherantBO TrouveAdherant(int idAdherant)
        {

            int id;
            string nom;
            string prenom;
            DateTime dateNaissance;
            char sexe;
            string email;
            int numeroTel;
            DateTime dateMaj;
            int numParent;
            int classe;
            char prelevement;
            string login;
            string mdp;
            char archive;
            AdherantBO unAdherant;
            // Connexion à la BD
            SqlConnection maConnexion =
            ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand("Select * from Adherant where id_adherant = @Id", maConnexion);    

            SqlParameter adhId =
                new SqlParameter("@Id", SqlDbType.Int);

            adhId.Value = idAdherant;

            cmd.Parameters.Add(adhId);

            SqlDataReader monReader = cmd.ExecuteReader();

            monReader.Read();


            id = Int32.Parse(monReader["id_adherant"].ToString());
            if (monReader["nom_adherant"] == DBNull.Value)
            {
                nom = default(string);
            }
            else
            {
                nom = monReader["nom_adherant"].ToString();
            }
            if (monReader["prenom_adherant"] == DBNull.Value)
            {
                prenom = default(string);
            }
            else
            {
                prenom = monReader["prenom_adherant"].ToString();
            }
            dateNaissance = DateTime.Parse(monReader["ddn_adherant"].ToString());
            sexe = Char.Parse(monReader["sexe_adherant"].ToString());
            if (monReader["email_adherant"] == DBNull.Value)
            {
                email = default(string);
            }
            else
            {
                email = monReader["email_adherant"].ToString();
            }
            numeroTel = Int32.Parse(monReader["numtel_adherant"].ToString());
            dateMaj = DateTime.Parse(monReader["date_maj_adherant"].ToString());
            numParent = Int32.Parse(monReader["numparent_adherant"].ToString());
            classe = Int32.Parse(monReader["id_classe"].ToString());
            prelevement = Char.Parse(monReader["autoprelev_adherant"].ToString());
            if (monReader["login_adherant"] == DBNull.Value)
            {
                login = default(string);
            }
            else
            {
                login = monReader["login_adherant"].ToString();
            }
            if (monReader["mdp_adherant"] == DBNull.Value)
            {
                mdp = default(string);
            }
            else
            {
                mdp = monReader["mdp_adherant"].ToString();
            }
            archive = Char.Parse(monReader["archive_adherant"].ToString());
            unAdherant = new AdherantBO(id, nom, prenom, dateNaissance, sexe,
                email, numeroTel, dateMaj, numParent, classe, prelevement, login, mdp,
                archive);
            maConnexion.Close();

            return unAdherant;
        }
    

        // Cette méthode insert un nouvel Adherant passé en paramètre dans
        //la BD
        public static int AjoutAdherant(AdherantBO unAdherant)
        {
            int nbEnr;
            ConnexionBD.GetConnexionBD().CloseConnexion();
            SqlConnection maConnexion =
            ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand("Insert INTO ADHERANT(nom_adherant, prenom_adherant," +
                " ddn_adherant, sexe_adherant, email_adherant, numtel_adherant, numparent_adherant," +
                " autoprelev_adherant, login_adherant, mdp_adherant, archive_adherant, id_classe, date_maj_adherant)" +
                " values(@Nom, @Prenom, @Naissance, @Sexe, @Email, @Numtel, @Telparent," +
                " @Autoprelev, @Login, @Mdp, @Archive, @Classe, @dateMaj)", maConnexion);

            SqlParameter adhNom =
                new SqlParameter("@Nom", SqlDbType.VarChar);
            SqlParameter adhPrenom =
                new SqlParameter("@Prenom", SqlDbType.VarChar);
            SqlParameter adhDdn =
                new SqlParameter("@Naissance", SqlDbType.Date);
            SqlParameter adhSexe =
                new SqlParameter("@Sexe", SqlDbType.VarChar);
            SqlParameter adhEmail =
                new SqlParameter("@Email", SqlDbType.VarChar);
            SqlParameter adhTelPerso =
                new SqlParameter("@NumTel", SqlDbType.Int);
            SqlParameter adhTelParent =
                new SqlParameter("@TelParent", SqlDbType.Int);
            SqlParameter adhAutoPrelev =
                new SqlParameter("@Autoprelev", SqlDbType.Char);
            SqlParameter adhLogin =
                new SqlParameter("@Login", SqlDbType.VarChar);
            SqlParameter adhMdp =
                new SqlParameter("@Mdp", SqlDbType.VarChar);
            SqlParameter adhArchive =
                new SqlParameter("@Archive", SqlDbType.Char);
            SqlParameter adhClasse =
                new SqlParameter("@Classe", SqlDbType.Int);
            SqlParameter adhDateMaj =
                new SqlParameter("@dateMaj", SqlDbType.DateTime);

            adhNom.Value = unAdherant.Nom;
            adhPrenom.Value = unAdherant.Prenom;
            adhDdn.Value = unAdherant.Naissance;
            adhSexe.Value = unAdherant.Sexe;
            adhEmail.Value = unAdherant.Email;
            adhTelPerso.Value = unAdherant.NumTel;
            adhTelParent.Value = unAdherant.NumParent;
            adhAutoPrelev.Value = unAdherant.AutoPrelev;
            adhArchive.Value = 'N';
            adhLogin.Value = unAdherant.Login;
            adhMdp.Value = unAdherant.Mdp;
            adhClasse.Value = unAdherant.Classe;
            adhDateMaj.Value = DateTime.Now;


            cmd.Parameters.Add(adhNom);
            cmd.Parameters.Add(adhPrenom);
            cmd.Parameters.Add(adhDdn);
            cmd.Parameters.Add(adhSexe);
            cmd.Parameters.Add(adhEmail);
            cmd.Parameters.Add(adhTelPerso);
            cmd.Parameters.Add(adhTelParent);
            cmd.Parameters.Add(adhAutoPrelev);
            cmd.Parameters.Add(adhArchive);
            cmd.Parameters.Add(adhLogin);
            cmd.Parameters.Add(adhMdp);
            cmd.Parameters.Add(adhClasse);
            cmd.Parameters.Add(adhDateMaj);


            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
        // Cette méthode modifie un Adherant passé en paramètre dans la BD
        public static int UpdateAdherant(AdherantBO unAdherant)
        {
            int nbEnr;
            ConnexionBD.GetConnexionBD().CloseConnexion();
            SqlConnection maConnexion =
            ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand("Update ADHERANT set nom_adherant = @Nom," +
                "  prenom_adherant = @Prenom, ddn_adherant = @Naissance, sexe_adherant = @Sexe," +
                " email_adherant = @Email, numtel_adherant = @Numtel, numparent_adherant = @Telparent," +
                " autoprelev_adherant = @Autoprelev, login_adherant = @Login, mdp_adherant = @Mdp," +
                " archive_adherant = @Archive, id_classe = @Classe, date_maj_adherant = @DateMaj" +
                " WHERE id = @IdAdherant",maConnexion);

            SqlParameter adhDateMaj =
                new SqlParameter("@DateMaj", SqlDbType.DateTime);
            SqlParameter adhId =
                new SqlParameter("@IdAdherant", SqlDbType.Int);
            SqlParameter adhNom =
                new SqlParameter("@Nom", SqlDbType.VarChar);
            SqlParameter adhPrenom =
                new SqlParameter("@Prenom", SqlDbType.VarChar);
            SqlParameter adhDdn =
                new SqlParameter("@Naissance", SqlDbType.Date);
            SqlParameter adhSexe =
                new SqlParameter("@Sexe", SqlDbType.VarChar);
            SqlParameter adhEmail =
                new SqlParameter("@Email", SqlDbType.VarChar);
            SqlParameter adhTelPerso =
                new SqlParameter("@NumTel", SqlDbType.Int);
            SqlParameter adhTelParent =
                new SqlParameter("@TelParent", SqlDbType.Int);
            SqlParameter adhAutoPrelev =
                new SqlParameter("@Autoprelev", SqlDbType.Char);
            SqlParameter adhLogin =
                new SqlParameter("@Login", SqlDbType.VarChar);
            SqlParameter adhMdp =
                new SqlParameter("@Mdp", SqlDbType.VarChar);
            SqlParameter adhArchive =
                new SqlParameter("@Archive", SqlDbType.Char);
            SqlParameter adhClasse =
                new SqlParameter("@Classe", SqlDbType.Int);

            adhId.Value = unAdherant.Id;
            adhNom.Value = unAdherant.Nom;
            adhPrenom.Value = unAdherant.Prenom;
            adhDdn.Value = unAdherant.Naissance;
            adhSexe.Value = unAdherant.Sexe;
            adhEmail.Value = unAdherant.Email;
            adhTelPerso.Value = unAdherant.NumTel;
            adhTelParent.Value = unAdherant.NumParent;
            adhAutoPrelev.Value = unAdherant.AutoPrelev;
            adhArchive.Value = unAdherant.Archive;
            adhLogin.Value = unAdherant.Login;
            adhMdp.Value = unAdherant.Mdp;
            adhClasse.Value = unAdherant.Classe;
            adhDateMaj.Value = unAdherant.DateMaj;

            cmd.Parameters.Add(adhId);
            cmd.Parameters.Add(adhNom);
            cmd.Parameters.Add(adhPrenom);
            cmd.Parameters.Add(adhDdn);
            cmd.Parameters.Add(adhSexe);
            cmd.Parameters.Add(adhEmail);
            cmd.Parameters.Add(adhTelPerso);
            cmd.Parameters.Add(adhTelParent);
            cmd.Parameters.Add(adhAutoPrelev);
            cmd.Parameters.Add(adhArchive);
            cmd.Parameters.Add(adhLogin);
            cmd.Parameters.Add(adhMdp);
            cmd.Parameters.Add(adhClasse);
            cmd.Parameters.Add(adhDateMaj);

            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
        // Cette méthode supprime de la BD un Adherant dont l'id est passé
        //en paramètre
        public static int DeleteAdherant(int id)
        {
            int nbEnr;
            ConnexionBD.GetConnexionBD().CloseConnexion();
            // Connexion à la BD
            
            SqlConnection maConnexion =
            ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand("Update ADHERANT set archive_adherant =" +
                " @Archive WHERE id_adherant = @IdAdherant", maConnexion);

            SqlParameter adhArchive =
                new SqlParameter("@Archive", SqlDbType.Char);
            SqlParameter adhId =
                new SqlParameter("@IdAdherant", SqlDbType.Int);

            adhArchive.Value = 'O';
            adhId.Value = id;

            cmd.Parameters.Add(adhArchive);
            cmd.Parameters.Add(adhId);

            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
    }
  
}
