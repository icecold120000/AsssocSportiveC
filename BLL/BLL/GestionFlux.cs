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
    public class GestionFlux
    {
        private static GestionFlux uneGestionFlux; // objet BLL

        
        public static GestionFlux GetGestionFlux()
        {
            if (uneGestionFlux == null)
            {
                uneGestionFlux = new GestionFlux();
            }
            return uneGestionFlux;
        }

         public static void SetchaineConnexion(ConnectionStringSettings chset)
         {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
         }

        public static List<Flux> GetFlux(int idType)
        {
            return FluxDAO.GetFlux(idType);
        }

        public static void AjoutFlux(Flux unFlux, SqlConnection myConnection)
        {
            FluxDAO.AjouterFlux(unFlux, myConnection);
        }

        public static void DeleteFlux(int idFlux)
        {
            FluxDAO.DeleteFlux(idFlux);
        }


        public static void UpdateFlux(Flux unFlux, SqlConnection myConnection)
        {
            FluxDAO.UpdateFlux(unFlux, myConnection);
        }
    }
}
