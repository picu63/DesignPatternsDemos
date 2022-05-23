using FactoryMethodPattern;

var shoppingBasket = new ShoppingBasket()
    .AddProduct(new Product("Milk", 1.2m))
    .AddProduct(new Product("Chips", 10.99m))
    .AddProduct(new Product("Water", 0.30m));

new ShoppingBasketProcessor().Process(shoppingBasket);