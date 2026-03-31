using System.Runtime.InteropServices;
using ProductApp.Models;

// ex. 1 & 2 - test if object is created successfully

var product1 = new Product("HP laptop", 600.00, 20);

Console.WriteLine(product1.Name);

// ex. 4 - test ProductCount

Console.WriteLine($"Total products: {Product.ProductCount}");

var product2 = new Product("Speakers", 80.00, 4);

Console.WriteLine($"Total products: {Product.ProductCount}");

// ex. 3 - test TotalValue property

Console.WriteLine(product1.TotalValue);
Console.WriteLine(product2.TotalValue);

// ex. 5 - create Product list, log info of products

static void LogProductList(List<Product> list)
{
    double totalSum = 0;

    Console.WriteLine("All list items:");
    foreach (var product in list) // pasidomet kaip dekonstruot reiksmes is item!
    {
        Console.WriteLine(
            $"{product.Name} {product.Price} {product.Quantity} {product.TotalValue}"
        );
        totalSum += product.TotalValue;
    }

    Console.WriteLine($"Total value of products in the list: {totalSum} eur.");
}

static void LogProduct(Product product)
{
    if (product != null)
    {
        Console.WriteLine($"Most expensive car: {product.Name} {product.Price} {product.Quantity}");
    }
    else
    {
        Console.WriteLine("Product is not found.");
    }
}

var carsList = new List<Product>
{
    new Product("Fiat 500", 2000.00, 2),
    new Product("Volvo", 4000.00, 7),
    new Product("Tesla", 30000.00, 5),
    new Product("Nissan", 10000.00, 10),
    new Product("Toyota", 5000.00, 9),
};

LogProductList(carsList);

Product mostExpensiveCar = ProductHelper.MostExpensive(carsList);

// LogProduct(mostExpensiveCar);

// ex. 6 test MostExpensive method with maxPrice parameter

Product maxExpensiveCar = ProductHelper.MostExpensive(carsList, 2000);

// LogProduct(maxExpensiveCar);

// ex. 7 test ApplyDiscount

Console.WriteLine($"Before discount: {product2.Price}, after: {product2.ApplyDiscount(50)}");
Console.WriteLine($"Before discount: {product2.Price}, after: {product2.ApplyDiscount(50, 3)}");
Console.WriteLine(
    $"Before discount: {product2.Price}, after: {product2.ApplyDiscount(50, 3, 79.00)}"
);
