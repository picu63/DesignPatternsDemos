using StatePattern;
// Przykład wykorzystania kasy samoobsługowej jako aplikacji zawierającej różne stany (ekrany z kolejnymi krokami)
// 1. Ekran powitalny - można przejść do skanowania lub wybrać witaj
// 2. Ekran skanowania
// 3. Ekran skanowania karty lojalnościowej (opcjonalnie)
// 4. Ekran płacenia
// 5. Ekran podsumowania (opcjonalnie)
SelfCheckout selfCheckout = new SelfCheckout();
selfCheckout.OnNextClick(); // patrz 1. (nie jest konieczne)
selfCheckout.ScanProduct(new Product("Lolipop"));
selfCheckout.ScanProduct(new Product("Water"));
selfCheckout.ScanProduct(new Product("Bread"));
selfCheckout.SummaryShoppingBasket();
selfCheckout.OnNextClick();
selfCheckout.OnPreviousClick();
selfCheckout.ScanProduct(new Product("Milk"));
selfCheckout.OnNextClick();
selfCheckout.SummaryShoppingBasket();