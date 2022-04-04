using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpTutorial.Algos
{
    public class Order
    {
        public string Customer { get; set; }
        public decimal Price { get; set; }

        public Order(string Customer, decimal price )
        {
            this.Customer = Customer;
            this.Price = price;
        }
    }
    public class Customer
    {
        public string CustomerName { get; set; }
        public decimal TotalExpentures { get; set; }
    }
    public class SuperClient
    {

        public IEnumerable<string> GetSuperCustomers(List<Order> orders)
        {
            List<string> result = new List<string>();

            List<Customer> superClients = orders
                .GroupBy(c => c.Customer)
                .Select(cl => new Customer
                {
                    CustomerName = cl.First().Customer,
                    TotalExpentures = cl.Sum(c => c.Price),
                }).Where(ex => ex.TotalExpentures>=100).ToList();


            foreach (var client in superClients)
                result.Add(client.CustomerName);
                //yield return client.CustomerName;

            return result;

        }
    }
}
