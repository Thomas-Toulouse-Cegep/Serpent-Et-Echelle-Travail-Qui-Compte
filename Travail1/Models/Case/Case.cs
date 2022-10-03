using Travail1.Models.Point;
using Travail1.Models;

namespace Travail1.Models.Case
{
    public class Case
    {
        protected Points points;
        protected int position;
        protected int largeur;

        public int Points { get => points.ObtenirPoints(0); set => points.ObtenirPoints(0); }

        public Case(Points points, int position)
        {
            this.points = points;
            this.position = position;
            this.largeur = 100;
        }

        private PointF ObtenirCoordonees()
        {
            int y = (7 - (position / 8));
            int x = (position % 8);
            if ((position / 8) % 2 == 1)
            {
                x = 7 - x;
            }
            return new PointF { X = x * largeur, Y = y * largeur };
        }

        public virtual void Dessiner(Graphics graphics)
        {
            var coordonees = ObtenirCoordonees();
            var font = new Font("Calibri", 20);
            graphics.FillRectangle(Brushes.White, coordonees.X, coordonees.Y, largeur, largeur);
            graphics.DrawString((position + 1).ToString(), font, Brushes.Black, coordonees.X + 30, coordonees.Y + 30);
        }
    }
}