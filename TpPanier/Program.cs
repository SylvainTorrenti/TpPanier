using TpPanier;

Article article1 = new Article(5,"Jouet",25);
Article article2 = new Article(5, "Jouet", 25);
Article article3 = new Article(5, "Livre", 25);
BasketLine BasketLine1 = new BasketLine();

article1.AddArticle(BasketLine1);
article2.AddArticle(BasketLine1);
article3.AddArticle(BasketLine1);
BasketLine1.AfficherLaListeDesArticles();
