using StatePattern;
// Przykład wykorzystania kasy samoobsługowej jako aplikacji zawierającej różne stany (ekrany z kolejnymi krokami)
SelfCheckout selfCheckout = new SelfCheckout();
selfCheckout.OnNextClick();
selfCheckout.ScanProduct(new Product("Lolipop"));
selfCheckout.ScanProduct(new Product("Water"));
selfCheckout.ScanProduct(new Product("Bread"));
selfCheckout.SummaryShoppingBasket();
selfCheckout.OnNextClick();
selfCheckout.SummaryShoppingBasket();