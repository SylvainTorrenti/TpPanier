using TpPanier;

Article article1 = new Article(1, "Jouet", 25);
Article article2 = new Article(2, "livre", 45);
Article article3 = new Article(3, "console", 200);
Article article4 = new Article(3, "console", 200);
Article article5 = new Article(1, "Jouet", 25);
Basket Basket1 = new Basket();
Basket1.AddArticle(article1);
Basket1.AddArticle(article2);
Basket1.AddArticle(article3);
Basket1.AddArticleWithQt(article4, 7);
Basket1.AddArticleWithQt(article5, 4);
Basket1.AfficherLaListeDesLignes();
Console.WriteLine($"Le panier vaut {Basket1.Total()} euros ");
Console.WriteLine("----------------------");
Console.WriteLine($"Il y a {Basket1.ArticleNumber()} articles dans le panier");
Console.WriteLine("----------------------");
Basket1.AfficherLaListeDesArticles();