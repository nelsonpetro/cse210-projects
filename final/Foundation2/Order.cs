using System;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public void SetProducts(List<Product> products)
    {
        _products = products;
    }

    public List<Product> GetProducts()
    {
        return _products;
    }

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    public Customer GetCustomer()
    {
        return _customer;
    }

    public string PackingLabel()
    {

        string label = "";
        foreach(Product product in _products)
        {
            label += $"Product # {_products.IndexOf(product)+1}: {product.GetName()} - ID: {product.GetId()}\n";
        }
        return $"Packing Label\n{label}";
    }

    public string ShippingLabel()
    {
        return $"Shipping Label\n{_customer.GetName()}\n{_customer.GetAddress().GetAddress()}";
    }

    public string TotalCost()
    {
        double totalCost = 0.0;
        foreach(Product product in _products)
        {
            totalCost += product.TotalPrice();
        }
        if(_customer.IsUsa())
        {
            totalCost += 5.0;
        }
        else
        {
            totalCost += 35.0;
        }
        return $"Total Cost: ${totalCost}";
    }
}