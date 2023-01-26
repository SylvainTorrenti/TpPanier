using TpPanier;

Article article1 = new Article(5,"Jouet",25);
Article article4 = new Article(5, "Jouet", 25);
Article article2 = new Article(5, "livre", 45);
Article article3 = new Article(5, "console", 200);
BasketLine BasketLine1 = new BasketLine();
BasketLine BasketLine2 = new BasketLine();
BasketLine BasketLine3 = new BasketLine();
Basket Basket1 = new Basket();

article1.AddArticle(BasketLine1);
article4.AddArticle(BasketLine2);
article2.AddArticle(BasketLine2);
article3.AddArticle(BasketLine3);
//BasketLine1.AfficherLaListeDesArticles();
//Console.WriteLine(BasketLine1.CalculatePrice());
//Console.WriteLine(BasketLine1.ToString());

Basket1.AddArticle(BasketLine1);
Basket1.AddArticle(BasketLine2);
Basket1.AddArticle(BasketLine3);
Basket1.AfficherLaListeDesLignes();
Console.WriteLine($"Le panier vaut {Basket1.Total()} euros "); 

