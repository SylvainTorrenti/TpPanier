using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpPanier
{
    public class Basket
    {
        public DateTime CreationDate { get; private set; }
        public int BasketNumber { get; private set; } = 0;

        private List<Article> _articles = new List<Article>();

        private List<BasketLine> _basketlines = new List<BasketLine>();

        public Basket() 
        {
            CreationDate= DateTime.Now;
            BasketNumber += 1;
        } 
        public void AddArticle(BasketLine basket)
        {
            _basketlines.Add(basket);
        }
        public float Total()//total du panier
        {
            float Somme = 0;
            for (int i = 0; i < _basketlines.Count; i++)
            {
                Somme += _basketlines.ElementAt(i).CalculatePrice();
            }
            return Somme;
        }
        //public void ArticleNumber()//nombre article different
        //{

        //}
        //public override string? ToString()//afficher article trié ordre de reference
        //{
        //    return 
        //}
        //public void DeleteArticle(Article article)//supr la ligne de l'article. si inexistant ne fait rien
        //{

        //}
        //public void DeleteAll()// efface TOUT le panier
        //{

        //}
        public void AfficherLaListeDesLignes()
        {
            for (int i = 0; i < _basketlines.Count; i++)
            {
                Console.WriteLine($"{_basketlines.ElementAt(i)}");
            }
        }
    }
}
