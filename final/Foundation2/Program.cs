using System;

class Program
{
    static void Main(string[] args)
    {

        List<Order> orders = new List<Order>();

        while(true)
        {
            Menu menu =  new Menu();
            menu.DisplayMenu();

            Console.Write("\nPlease, select one option: ");
            int choice = int.Parse(Console.ReadLine());

            if(choice == 1)
            {
                List<Product> products = new List<Product>();

                Console.Write("Please enter the Customer's name: ");
                string customerName = Console.ReadLine();
                Console.WriteLine("\nPlease, enter the Customer's Address by parts.");
                Console.Write("Please, enter the street: ");
                string street = Console.ReadLine();
                Console.Write("Please, enter the city: ");
                string city = Console.ReadLine();
                Console.Write("Please, enter the state/province: ");
                string state = Console.ReadLine();
                Console.Write("Please, enter the country code (i.e. US, CA, MX): ");
                string country = Console.ReadLine();
                Console.Write("\nHow many products are in this order?: ");
                int productsNum = int.Parse(Console.ReadLine());
                for(int i = 0; i < productsNum; i++)
                {
                    Console.WriteLine($"\nProduct #{i+1}");
                    Console.Write("Please, enter the product's name: ");
                    string productName = Console.ReadLine();
                    Console.Write("Please, enter the product's ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Please, enter the quantity: ");
                    int quantity = int.Parse(Console.ReadLine());
                    Console.Write("Please, enter the price: ");
                    double price = double.Parse(Console.ReadLine());

                    Product product = new Product(productName, id, price, quantity);

                    products.Add(product);
                }
                
                Address address = new Address(street, city, state, country);
                Customer customer = new Customer(customerName, address);
                Order order = new Order(products, customer);

                orders.Add(order);
            }
            else if (choice == 2)
            {
                foreach(Order finalOrder in orders)
                {
                    Console.WriteLine($"\nOrder #{orders.IndexOf(finalOrder)+1}\n");
                    Console.WriteLine(finalOrder.PackingLabel());
                    Console.WriteLine(finalOrder.ShippingLabel());
                    Console.WriteLine(finalOrder.TotalCost());
                    Console.WriteLine();
                }
            }
            else
            {
                break;
            }
        }
    }
}