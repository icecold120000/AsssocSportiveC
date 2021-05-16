using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BO;
using System.Data;

namespace DAL
{
    public class FluxDAO
    {
        private static FluxDAO unfluxDAO;

        public static FluxDAO GetunFLuxDAO()
        {
            if(unfluxDAO == null)
            {
                unfluxDAO = new FluxDAO();
            }
            return unfluxDAO;
        }

        public static List<Flux> GetFlux(int idType)
        {
            int id;
            int montant;
            DateTime date;
            string libelle;
            int idAdherent;
            int idTypeFlux;
            int idBudget;

            Flux unFlux;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            List<Flux> lesFlux = new List<Flux>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT * FROM FLUX where id_type_flux = @idType";

            SqlParameter fluxTypeId = new SqlParameter("@idType", SqlDbType.Int);

            fluxTypeId.Value = idType;

            cmd.Parameters.Add(fluxTypeId);

            SqlDataReader monReader = cmd.ExecuteReader();
            while (monReader.Read())
            {
                id = Int32.Parse(monReader["id_flux"].ToString());
                montant = Int32.Parse(monReader["montant_flux"].ToString());

                if (monReader["libelle_flux"] == DBNull.Value)
                {
                    libelle = default(string);
                }
                else
                {
                    libelle = monReader["libelle_flux"].ToString();
                }

                date = DateTime.Parse(monReader["date_flux"].ToString());
                idAdherent = Int32.Parse(monReader["id_adherent"].ToString());
                idTypeFlux = Int32.Parse(monReader["id_type_flux"].ToString());
                idBudget = Int32.Parse(monReader["id_budget"].ToString());

                unFlux = new Flux(id, libelle, montant, date, idAdherent,idTypeFlux, idBudget);
                lesFlux.Add(unFlux);
            }
            // Fermeture de la connexion
            maConnexion.Close();
            return lesFlux;
        }
        public static int AjouterFlux(Flux unFLux)
        {
            int nbEnr;
            ConnexionBD.GetConnexionBD().CloseConnexion();
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand("Insert INTO FLUX(montant_flux, libelle_flux," +
                " date_flux,id_adherent, id_type_flux, id_budget)" +
            " values(@Montant,@Libelle, @Date, @Adherent, @TypeFlux, @Budget)", maConnexion);

            SqlParameter fluxMontant =
               new SqlParameter("@Montant", SqlDbType.Int);
            SqlParameter fluxLibelle =
                new SqlParameter("@Libelle", SqlDbType.VarChar);
            SqlParameter fluxDate =
                new SqlParameter("@Date", SqlDbType.DateTime);
            SqlParameter fluxAdherent =
                new SqlParameter("@Adherent", SqlDbType.Int);
            SqlParameter fluxType =
                new SqlParameter("@TypeFlux", SqlDbType.Int);
            SqlParameter fluxBudget =
                new SqlParameter("@Budget", SqlDbType.Int);

            fluxMontant.Value = unFLux.Montant;
            fluxLibelle.Value = unFLux.Libelle;
            fluxDate.Value = DateTime.Now;
            fluxAdherent.Value = unFLux.Id_adherent;
            fluxType.Value = unFLux.Id_type_flux;
            fluxBudget.Value = unFLux.Id_budget;

            cmd.Parameters.Add(fluxMontant);
            cmd.Parameters.Add(fluxLibelle);
            cmd.Parameters.Add(fluxDate);
            cmd.Parameters.Add(fluxAdherent);
            cmd.Parameters.Add(fluxType);
            cmd.Parameters.Add(fluxBudget);


            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

        // Cette méthode supprime de la BD un Adherant dont l'id est passé
        //en paramètre
        public static int DeleteFlux(int id)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion =
            ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand("DELETE FROM FLUX WHERE id_flux = @idFlux", maConnexion);

            SqlParameter fluxId =
                new SqlParameter("@idFLux", SqlDbType.Int);

            fluxId.Value = id;
            cmd.Parameters.Add(fluxId);

            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
    }
}

