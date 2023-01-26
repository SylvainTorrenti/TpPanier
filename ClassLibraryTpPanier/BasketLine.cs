using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpPanier
{
    public class BasketLine
    {

        private List<Article> _articles = new List<Article>();
        public Article Article { get;private set; }

        public int Quantity { get; private set; }

        public BasketLine()
        {
        }

        public BasketLine(Article article)
        {
            _articles.Add(article);
            Quantity += 1;
        }

        public void AddToList(Article article)
        {
            if ()
            {

            }
            _articles.Add(article);
            Quantity += 1;
        }
        public void AfficherLaListeDesArticles()
        {
               Console.WriteLine($"Il y a {Quantity} {_articles.ElementAt(0).Designation}");           
        }
        public float CalculatePrice()
        {
            return Quantity * _articles.ElementAt(0).Price;
        }
        public override string? ToString()
        {
            return $@"
Il y a {Quantity} {_articles.ElementAt(0).Designation} dans cette ligne
son prix est de {CalculatePrice()} euros";
        }
    }
}
