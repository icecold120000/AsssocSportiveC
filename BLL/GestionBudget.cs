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
    public class GestionBudget
    {
        private static GestionBudget uneGestionBudgets; // objet BLL

        // Accesseur en lecture
        public static GestionBudget GetGestionBudgets()
        {
            if (uneGestionBudgets == null)
            {
                uneGestionBudgets = new GestionBudget();
            }
            return uneGestionBudgets;
        }
        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion
        //de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }
        public static List<BudgetBO> GetBudgets()
        {
            return BudgetDAO.GetBudgets();
        }

        public static List<BudgetBO> GetBudget(string libelle)
        {
            return BudgetDAO.GetBudget(libelle);
        }

        public static BudgetBO TrouverBudget(int idBudget)
        {
            return BudgetDAO.TrouveBudget(idBudget);
        }

        public static void AjoutBudget(BudgetBO unBudget)
        {
            BudgetDAO.AjoutBudget(unBudget);
        }

        public static void ModifieMontant(BudgetBO unBudget)
        {
            BudgetDAO.UpdateMontant(unBudget);
        }

    }
}
