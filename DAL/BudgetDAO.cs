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
    public class BudgetDAO
    {
        private static BudgetDAO unBudgetDAO;
        // Accesseur en lecture, renvoi une instance
        public static BudgetDAO GetunBudgetDAO()
        {
            if (unBudgetDAO == null)
            {
                unBudgetDAO = new BudgetDAO();
            }
            return unBudgetDAO;
        }

        // Cette méthode retourne une List contenant les objets Adherants
        //contenus dans la table Identification
        public static List<BudgetBO> GetBudgets()
        {
            int id;
            string libellé;
            int montantInitial;

            BudgetBO unBudget;
            // Connexion à la BD
            SqlConnection maConnexion =
            ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Adherants
            List<BudgetBO> lesBudgets = new List<BudgetBO>();
            SqlCommand cmd = new SqlCommand(" SELECT * FROM BUDGET", maConnexion);


            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                id = Int32.Parse(monReader["id_budget"].ToString());
                if (monReader["lbl_budget"] == DBNull.Value)
                {
                    libellé = default(string);
                }
                else
                {
                    libellé = monReader["lbl_budget"].ToString();
                }
                montantInitial = Int32.Parse(monReader["montantInitial_budget"].ToString());
                unBudget = new BudgetBO(id, libellé, montantInitial);
                lesBudgets.Add(unBudget);
            }
            // Fermeture de la connexion
            maConnexion.Close();
            return lesBudgets;
        }

        public static List<BudgetBO> GetBudget(string libelle)
        {
            int montantInitial;

            BudgetBO unBudget;
            // Connexion à la BD
            SqlConnection maConnexion =
            ConnexionBD.GetConnexionBD().GetSqlConnexion();
            List<BudgetBO> lesBudgets = new List<BudgetBO>();
            // Création d'une liste vide d'objets Adherants
            SqlCommand cmd = new SqlCommand(" SELECT * FROM BUDGET WHERE lbl_budget = @Libelle", maConnexion);

            SqlParameter budLbl =
            new SqlParameter("@Libelle", SqlDbType.VarChar);

            budLbl.Value = libelle;

            cmd.Parameters.Add(budLbl);

            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            { 
                montantInitial = Int32.Parse(monReader["montantInitial_budget"].ToString());
                unBudget = new BudgetBO(montantInitial);
                lesBudgets.Add(unBudget);
            }

            // Fermeture de la connexion
            maConnexion.Close();
            return lesBudgets;
        }

        public static BudgetBO TrouveBudget(int idBudget)
        {

            int id;
            string nom;
            int montant;
            BudgetBO unBudget;
            // Connexion à la BD
            SqlConnection maConnexion =
            ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand("Select * from Budget where id_budget = @Id", maConnexion);

            SqlParameter budId =
                new SqlParameter("@Id", SqlDbType.Int);

            budId.Value = idBudget;

            cmd.Parameters.Add(budId);

            SqlDataReader monReader = cmd.ExecuteReader();

            monReader.Read();


            id = Int32.Parse(monReader["id_budget"].ToString());
            if (monReader["lbl_budget"] == DBNull.Value)
            {
                nom = default(string);
            }
            else
            {
                nom = monReader["nom_adherant"].ToString();
            }
            montant = Int32.Parse(monReader["montantInitial_budget"].ToString());

            unBudget = new BudgetBO(id, nom, montant);
            maConnexion.Close();

            return unBudget;
        }

        public static int AjoutBudget(BudgetBO unBudget)
        {
            int nbEnr;
            SqlConnection maConnexion =
            ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand("Insert INTO Budget(lbl_budget, montantInitial_budget" +
                " ) values(@Libellé, @Montant)", maConnexion);

            SqlParameter budgetLibellé =
                new SqlParameter("@Libellé", SqlDbType.VarChar);
            SqlParameter budgetMontant =
                new SqlParameter("@Montant", SqlDbType.Int);


            budgetLibellé.Value = unBudget.Libellé;
            budgetMontant.Value = unBudget.Montant;

            cmd.Parameters.Add(budgetLibellé);
            cmd.Parameters.Add(budgetMontant);


            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

        public static int UpdateMontant(BudgetBO unBudget)
        {
            int nbEnr;
            ConnexionBD.GetConnexionBD().CloseConnexion();
            SqlConnection maConnexion =
            ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand("Update Budget set @Montant," +
                " WHERE id = @IdBudget", maConnexion);


            SqlParameter idBudget =
                new SqlParameter("@IdBudget", SqlDbType.Int);
            SqlParameter budgetMontant =
                new SqlParameter("@Montant", SqlDbType.Int);


            idBudget.Value = unBudget.Id_budget;
            budgetMontant.Value = unBudget.Montant;

            cmd.Parameters.Add(idBudget);
            cmd.Parameters.Add(budgetMontant);


            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
    }
}
