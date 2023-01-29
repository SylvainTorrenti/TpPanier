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
            CreationDate = DateTime.Now;
            BasketNumber += 1;
        }
        public void AddArticle(Article article)
        {
            if (_basketlines.Count == 0)
            {
                Console.WriteLine($"La ligne {article.Reference} est ajouté");
                BasketLine basketline = new BasketLine(article);
                _basketlines.Add(basketline);
            }
            else
            {
                for (int i = 0; i < _basketlines.Count; i++)
                {
                    if (_basketlines.ElementAt(i).Reference == article.Reference)
                    {
                        Console.WriteLine($"La ligne {article.Reference} existe déjà donc ça quantité est ajouté");
                        _basketlines.ElementAt(i).Quantity += 1;                       
                    }
                }
                Console.WriteLine($"La ligne {article.Reference} est ajouté");
                BasketLine basketLine = new BasketLine(article);
                _basketlines.Add(basketLine);

            }          
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
