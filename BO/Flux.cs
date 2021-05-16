using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Flux
    {
        private int id_flux;
        private string libelle_flux;
        private int montant_flux;
        private DateTime date_flux;
        private int id_adherent;
        private int id_type_flux;
        private int id_budget;

        public Flux(string libelle_flux, int montant_flux, int id_adherent, int id_type_flux, int id_budget)
        {
            this.libelle_flux = libelle_flux;
            this.montant_flux = montant_flux;
            this.id_adherent = id_adherent;
            this.id_type_flux = id_type_flux;
            this.id_budget = id_budget;
        }

        // Constructuer de l'Utilisateur
        public Flux(int idFlux, string LibelleFlux, int montantFlux,DateTime DateFlux, int IdAdherent,int IdTypeFlux,int IdBudget)
        {
            id_flux = idFlux;
            libelle_flux = LibelleFlux;
            montant_flux = montantFlux;
            date_flux = DateFlux;
            id_adherent = IdAdherent;
            id_type_flux = IdTypeFlux;
            id_budget = IdBudget;
        }

        public int Id { get => id_flux; set => id_flux = value; }
        public string Libelle { get => libelle_flux; set => libelle_flux = value; }
        public int Montant { get => montant_flux; set => montant_flux = value; }
        public DateTime Date { get => date_flux; set => date_flux = value; }
        public int Id_adherent { get => id_adherent; set => id_adherent = value; }
        public int Id_type_flux { get => id_type_flux; set => id_type_flux = value; }
        public int Id_budget { get => id_budget; set => id_budget = value; }
    }
}
