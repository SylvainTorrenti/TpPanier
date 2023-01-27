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

        private List<BasketLine> _basketlines = new List<BasketLine>();

        public Basket() 
        {
            CreationDate= DateTime.Now;
            BasketNumber += 1;
        } 
        public void AddArticle(Article article)
        {            
            if ()
            {

            }
            AddBasketLine(new BasketLine(article));
        }
        public void AddBasketLine(BasketLine basketline)
        {
            _basketlines.Add(basketline);
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
        public int ArticleNumber()//nombre article different
        {
            return _basketlines.Count;
        }
        public override string? ToString()//afficher article trié ordre de reference
        {
            _basketlines.Sort();
            return $@"
Il y a {ArticleNumber()} article dans le panier.
Les article sont {AfficherLaListeDesArticles()}
Le prix du panier est de {Total()}";
        }
        //public void DeleteArticle(Article article)//supr la ligne de l'article. si inexistant ne fait rien
        //{

        //}
        public void DeleteAll()
        {
            _basketlines.Clear();
        }
        public void AfficherLaListeDesLignes()
        {
            for (int i = 0; i < _basketlines.Count; i++)
            {
                Console.WriteLine($"{_basketlines.ElementAt(i)}");
                Console.WriteLine("----------------------");
            }
            
        }
        public void AfficherLaListeDesArticles()
        {
            for (int i = 0; i < _basketlines.Count; i++)
            {
                Console.WriteLine($"{_basketlines.ElementAt(i).Reference}");
                Console.WriteLine("----------------------");
            }

        }
    }
}
