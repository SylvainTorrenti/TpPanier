using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpPanier
{
    public class BasketLine
    {
        #region Props
        /// <summary>
        /// Nombre de ligne
        /// </summary>
        private static int BasketLineNumber { get; set; } = 0;
        /// <summary>
        /// Numero de la ligne
        /// </summary>
        public int Number { get; private set; }
        /// <summary>
        /// Reference
        /// </summary>
        public int Reference { get; private set; }
        /// <summary>
        /// Designation
        /// </summary>
        public string Designation { get; private set; }
        /// <summary>
        /// Article
        /// </summary>
        public Article Article { get; private set; }
        /// <summary>
        /// Quantité
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// Constructeur sans quantité
        /// </summary>
        /// <param name="article"></param> 
	#endregion
        #region Constructeur
        public BasketLine(Article article)
        {
            Reference = article.Reference;
            BasketLineNumber += 1;
            Number = BasketLineNumber;
            Article = article;
            Quantity += 1;
            Designation = article.Designation;
        }
        /// <summary>
        /// Constructeur avec quantité
        /// </summary>
        /// <param name="article"></param>
        /// <param name="quantity"></param>
        public BasketLine(Article article, int quantity)
        {
            Reference = article.Reference;
            BasketLineNumber += 1;
            Number = BasketLineNumber;
            Article = article;
            Quantity = quantity;
        } 
        #endregion
        #region methode
        /// <summary>
        /// Ajout d'un article à la ligne
        /// </summary>
        /// <param name="article"></param>
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
        /// <summary>
        /// Affiche les articles
        /// </summary>
        public void AfficherLaListeDesArticles()
        {
            Console.WriteLine($"Il y a {Quantity} {Article.Reference}");
        }
        /// <summary>
        /// Calcul le prix
        /// </summary>
        /// <returns></returns>
        public float CalculatePrice()
        {
            return Quantity * Article.Price;
        }
        /// <summary>
        /// Affiche les details de la ligne
        /// </summary>
        /// <returns></returns>
        public override string? ToString()
        {
            return $@"
Dans la ligne numero {Number}
Il y a {Quantity} {Article.Designation} dans cette ligne
son prix est de {CalculatePrice()} euros";
        } 
        #endregion
    }
}
