using MultipleDesignPatternsInOne;
using MultipleDesignPatternsInOne.Orders;
using MultipleDesignPatternsInOne.ShoppingBaskets;

var milk = new Product("Milk", 1.2m);
var shoppingBasket = new ShoppingBasket()
    .AddProduct(milk)
    .AddProduct(milk)
    .AddProduct(new Product("Chips", 10.99m))
    .AddProduct(new Product("Water", 0.30m));
var orderProvider = new OrderProvider();
new ShoppingBasketProcessor(new LoginProcessor(), new OrderFactory(orderProvider), orderProvider).Process(shoppingBasket);