namespace FactoryMethodPattern;

public class ShoppingBasket
{
    public ShoppingBasket AddProduct(Product product)
    {
        products.Add(product);
        return this;
    }

    private List<Product> products = new();

    public IReadOnlyList<Product> Products => products;

    public decimal GetAmount() => Products.Select(p => p.Amount).Sum();
}