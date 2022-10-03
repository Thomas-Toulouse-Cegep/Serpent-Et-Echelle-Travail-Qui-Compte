using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail1.Models.Point
{
    internal class PointNegatif : Points
    {
        private int valeur;

        public PointNegatif(int valeur) : base(valeur)
        {
            this.valeur = valeur;
        }

        public override int ajouterpoint(int pointCourant, int pointTotal)
        {
            pointTotal = pointTotal - pointCourant;
            pointTotal = valeur;
            return pointTotal;
        }
    }
}