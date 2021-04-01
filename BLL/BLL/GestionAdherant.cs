using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAL;

namespace BLL
{
    public class GestionAdherant
    {
        private static GestionAdherant uneGestionAdherants; // objet BLL

        // Accesseur en lecture
        public static GestionAdherant GetGestionAdherants()
        {
            if (uneGestionAdherants == null)
            {
                uneGestionAdherants = new GestionAdherant();
            }
            return uneGestionAdherants;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion
        //de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }
        // Méthode qui renvoit une List d'objets Utilisateur en faisant appel à
        //la méthode GetUtilisateurs() de la DAL
        public static List<AdherantBO> GetAdherants()
        {
            return AdherantDAO.GetAdherants();
        }

        public static void AjoutAdherant(AdherantBO unAdherant)
        {
            AdherantDAO.AjoutAdherant(unAdherant);
        }

        public static void DeleteAdherant(int idAdherant)
        {
            AdherantDAO.DeleteAdherant(idAdherant);
        }

        public static AdherantBO TrouverAdherant(int idAdherant)
        {
            return AdherantDAO.TrouveAdherant(idAdherant);
        }

        public static void ModifierAdherant(AdherantBO unAdherant)
        {
            AdherantDAO.UpdateAdherant(unAdherant);
        }

    }
}
