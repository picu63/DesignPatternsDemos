namespace MultipleDesignPatternsInOne.ShoppingBaskets;

public class ShoppingBasket
{
    public Guid Id { get; } = Guid.NewGuid();
    public ShoppingBasket AddProduct(Product product)
    {
        Console.WriteLine($"Adding {product} to shopping basket: {Id}");
        products.Add(product);
        return this;
    }

    private readonly List<Product> products = new();

    public IReadOnlyList<Product> Products => products;

    public decimal GetAmount() => Products.Select(p => p.EntityPrice).Sum();
}