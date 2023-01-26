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

        public int Quantity { get;private set; }

        public BasketLine()
        {
        }
        public void AddToList(Article article)
        {
            _articles.Add(article);
        }
        public int CountArticle()
        {
            return _articles.Count;
        } 
        public void AfficherLaListeDesArticles()
        {
            Console.WriteLine("La liste des articles est :");
            for (int i = 0; i < _articles.Count; i++)
            {
                Console.WriteLine(@$"
Il y a {CountArticle()} {_articles.ElementAt(i).Designation}");
            }
        }

    }
}
