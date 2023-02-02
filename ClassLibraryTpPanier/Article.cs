using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpPanier
{
    public class Article : IComparable
    {
        #region Props
        /// <summary>
        /// Reference
        /// </summary>
        public int Reference { get; private set; }
        /// <summary>
        /// Designation
        /// </summary>
        public string Designation { get; private set; }
        /// <summary>
        /// price
        /// </summary>
        public float Price { get; private set; }
        #endregion
        #region Constructeur
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="reference"></param>
        /// <param name="designation"></param>
        /// <param name="price"></param>
        public Article(int reference, string designation, float price)
        {
            Reference = reference;
            Designation = designation;
            Price = price;
        }
        #endregion
        #region Methode
        /// <summary>
        /// Ajout d'un article
        /// </summary>
        /// <param name="basketLine"></param>
        public void AddArticle(BasketLine basketLine)
        {
            basketLine.AddToList(this);
        }
        /// <summary>
        /// Verifie qu'un article est identique
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public override bool Equals(object? obj)
        {
            Article otherArticle = obj as Article;
            if (otherArticle != null)
                return Reference.Equals(otherArticle.Reference);
            else
                throw new ArgumentException("Les articles ne sont pas les même");
        }
        /// <summary>
        /// Permet de comparer des objets
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public int CompareTo(object? obj)
        {
            if (obj == null) return 1;
            Article otherArticle = obj as Article;
            if (otherArticle != null)
                return Reference.CompareTo(otherArticle.Reference);
            else
                throw new ArgumentException("Les articles ne sont pas les même");
        }
        /// <summary>
        /// Affiche toutes les caractéristique de l'objet
        /// </summary>
        /// <returns></returns>
        public override string? ToString()
        {
            return $@"
La référence de l'article est {Reference}
La designation de l'article est {Designation}
Le prix de l'article est {Price} euros";
        }


    } 
    #endregion
}
