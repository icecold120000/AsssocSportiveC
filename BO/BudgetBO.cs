using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class BudgetBO
    {
        private int id_budget;
        private string libellé;
        private int montantInitial;

        public BudgetBO(int id_budget, string libellé, int montant)
        {
            this.id_budget = id_budget;
            this.libellé = libellé;
            this.montantInitial = montant;
        }

        public BudgetBO(string libellé, int montant)
        {
            this.libellé = libellé;
            this.montantInitial = montant;
        }

        public BudgetBO( int montant)
        {
            this.montantInitial = montant;
        }

        public int Id_budget { get => id_budget; set => id_budget = value; }
        public string Libellé { get => libellé; set => libellé = value; }
        public int Montant { get => montantInitial; set => montantInitial = value; }
    }
}
