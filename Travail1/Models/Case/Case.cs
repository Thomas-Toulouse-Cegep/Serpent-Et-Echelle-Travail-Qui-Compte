using Travail1.Models.Point;
using Travail1.Models;

namespace Travail1.Models.Case
{
    public class Case
    {
        private Points points;
        private int position;
        private int largeur;
        private int smallur;
        public int Points { get => points.ObtenirPoints(smallur); set => smallur = value; }

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

        public void Dessiner(Graphics graphics)
        {
            var coordonees = ObtenirCoordonees();
            var font = new Font("Calibri", 20);
            graphics.DrawRectangle(Pens.Black, coordonees.X, coordonees.Y, largeur, largeur);
            graphics.DrawString((position + 1).ToString(), font, Brushes.Black, coordonees.X + 30, coordonees.Y + 30);
        }
    }
}