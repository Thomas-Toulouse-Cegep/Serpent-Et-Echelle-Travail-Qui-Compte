using Travail1.Models.Case;

namespace Travail1.Models.Point
{
    public class Points
    {
        private Random random = new Random();
        private int valeur;
        private int chance;

        public Points(int valeur)
        {
            this.valeur = valeur;
        }

        public virtual int ajouterpoint(int pointCourant, int pointTotal)
        {
            valeur = pointTotal + pointCourant;
            return valeur;
        }

        public virtual int ObtenirPoints()
        {
            return valeur;
        }
    }
}