using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RLP.Models;

namespace RLP.Models
{
    public class DataManager
    {
        private static List<Customer> customers = new List<Customer>
        {
            new Customer {Id = 1, CompanyName = "Robins grönsaker", EmployeeCount = 3, Address = "Vägen 1"},
            new Customer {Id = 2, CompanyName = "Pascals skate", EmployeeCount = 1, Address = "Gatan 2"},
            new Customer {Id = 3, CompanyName = "Love kök och bar", EmployeeCount = 100, Address = "Allén 3"},
        };
        
        public static void AddCustomer(Customer customer)
        {
            customer.Id = customers.Max(c => c.Id) + 1;
            customers.Add(customer);
        }

        public static Customer[] GetAllCustomers()
        {
            return customers.ToArray();
        }

        public static IEnumerable <Customer> GetCustomerById(int id)
        {
            return customers.Where(c => c.Id == id);
        }

        public static void Remove(Customer customer)
        {
            int i = customer.Id;
            customers.RemoveAt(i);
        }
    }
}
