using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpPanier
{
    public class Basket
    {
        #region props
        /// <summary>
        /// Date de creation
        /// </summary>
        public DateTime CreationDate { get; private set; }
        /// <summary>
        /// Numero du panier
        /// </summary>
        public int BasketNumber { get; private set; } = 0;
        /// <summary>
        /// Liste des lignes presente dans le panier 
        /// </summary>
        private List<BasketLine> _basketlines = new List<BasketLine>(); 
        #endregion
        #region Constructeur
        /// <summary>
        /// Construvteur
        /// </summary>
        public Basket()
        {
            CreationDate = DateTime.Now;
            BasketNumber += 1;
        } 
        #endregion
        #region Methode
        /// <summary>
        /// Ajout d'un article
        /// </summary>
        /// <param name="article"></param>
        public void AddArticle(Article article)
        {
            if (_basketlines.Count == 0)
            {
                Console.WriteLine($"La ligne {article.Reference} est ajouté");
                BasketLine basketline = new BasketLine(article);
                _basketlines.Add(basketline);
            }
            else if (_basketlines.Count != 0)
            {
                bool Present = true;
                for (int i = 0; i < _basketlines.Count; i++)
                {

                    while (_basketlines.ElementAt(i).Reference == article.Reference && Present == true)
                    {
                        Console.WriteLine($"La ligne {article.Reference} existe déjà donc ça quantité est ajouté");
                        _basketlines.ElementAt(i).Quantity += 1;
                        Present = false;
                    }
                }
                if (Present == true)
                {
                    Console.WriteLine($"La ligne {article.Reference} est ajouté");
                    BasketLine basketLine = new BasketLine(article);
                    _basketlines.Add(basketLine);
                }

            }

        }
        /// <summary>
        /// ajout d'un article en indiquant la qt
        /// </summary>
        /// <param name="article"></param>
        /// <param name="quantity"></param>
        public void AddArticleWithQt(Article article, int quantity)
        {
            if (_basketlines.Count == 0)
            {
                Console.WriteLine($"La ligne {article.Reference} est ajouté");
                BasketLine basketline = new BasketLine(article, quantity);
                _basketlines.Add(basketline);
            }
            else if (_basketlines.Count != 0)
            {
                bool Present = true;
                for (int i = 0; i < _basketlines.Count; i++)
                {

                    while (_basketlines.ElementAt(i).Reference == article.Reference && Present == true)
                    {
                        Console.WriteLine($"La ligne {article.Reference} existe déjà donc ça quantité est ajouté");
                        _basketlines.ElementAt(i).Quantity += quantity;
                        Present = false;
                    }
                }
                if (Present == true)
                {
                    Console.WriteLine($"La ligne {article.Reference} est ajouté");
                    BasketLine basketLine = new BasketLine(article, quantity);
                    _basketlines.Add(basketLine);
                }

            }

        }
        /// <summary>
        /// Calcul le total du panier
        /// </summary>
        /// <returns></returns>
        public float Total()
        {
            float Somme = 0;
            for (int i = 0; i < _basketlines.Count; i++)
            {
                Somme += _basketlines.ElementAt(i).CalculatePrice();
            }
            return Somme;
        }
        /// <summary>
        /// Indique le nombre d'article present dans le panier
        /// </summary>
        /// <returns></returns>
        public int ArticleNumber()
        {
            int NbArticle = 0;
            for (int i = 0; i < _basketlines.Count; i++)
            {
                NbArticle += _basketlines.ElementAt(i).Quantity;
            }
            return NbArticle;
        }
        /// <summary>
        /// Affiche les articles
        /// </summary>
        /// <returns></returns>
        public override string? ToString()
        {
            _basketlines.Sort();
            return $@"
Il y a {ArticleNumber()} article dans le panier.
Le prix du panier est de {Total()}";
        }
        /// <summary>
        /// Supprime toute les lignes
        /// </summary>
        public void DeleteAll()
        {
            _basketlines.Clear();
        }
        /// <summary>
        /// Affiche les lignes
        /// </summary>
        public void AfficherLaListeDesLignes()
        {
            for (int i = 0; i < _basketlines.Count; i++)
            {
                Console.WriteLine($"{_basketlines.ElementAt(i)}");
                Console.WriteLine("----------------------");
            }

        }
        /// <summary>
        /// Affiche les articles
        /// </summary>
        public void AfficherLaListeDesArticles()
        {
            for (int i = 0; i < _basketlines.Count; i++)
            {
                Console.WriteLine($"{_basketlines.ElementAt(i).Quantity} {_basketlines.ElementAt(i).Designation}");
                Console.WriteLine("----------------------");
            }

        } 
        #endregion
    }
}
