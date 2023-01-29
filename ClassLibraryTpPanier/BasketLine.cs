using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpPanier
{
    public class BasketLine
    {
        private static int BasketLineNumber { get; set; } = 0;
        public int Number { get; private set; }
        public int Reference { get; private set; }
        public Article Article { get; private set; }

        public int Quantity { get; set; }

        public BasketLine(Article article)
        {
            Reference = article.Reference;
            BasketLineNumber += 1;
            Number = BasketLineNumber;
            Article = article;
            Quantity += 1;
        }

        public void AddToList(Article article)
        {
            if (Reference.Equals(article.Reference))
            {
                Quantity += 1;            
            }
            else
            {
                Console.WriteLine("Vous esseyer de rentrer un mauvais produit!");
            }

        }
        public void AfficherLaListeDesArticles()
        {
            Console.WriteLine($"Il y a {Quantity} {Article.Reference}");
        }
        public float CalculatePrice()
        {
            return Quantity * Article.Price;
        }
        public override string? ToString()
        {
            return $@"
Dans la ligne numero {Number}
Il y a {Quantity} {Article.Designation} dans cette ligne
son prix est de {CalculatePrice()} euros";
        }
    }
}
