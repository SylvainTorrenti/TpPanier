using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpPanier
{
    public class Article : IComparable
    {
        public int Reference { get; private set; }

        public string Designation { get; private set; }

        public float Price { get; private set; }

        public Article(int reference, string designation, float price)
        {
            Reference = reference;
            Designation = designation;
            Price = price;
        }
        public void AddArticle(BasketLine basketLine)
        {
            basketLine.AddToList(this);
        }
        public int CompareTo(object? obj)
        {
            if (obj == null) return 1;
            Article otherArticle = obj as Article;
            if (otherArticle != null)
                return Reference.CompareTo(otherArticle.Reference);
            else
                throw new ArgumentException("Les articles ne sont pas les même");
        }

        public override string? ToString()
        {
            return $@"
La référence de l'article est {Reference}
La designation de l'article est {Designation}
Le prix de l'article est {Price} euros";
        }

    }
}
