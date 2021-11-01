using System;
using System.Collections.Generic;

namespace ClassMethodDemo
{
    public class CustomerManager
    {
        private readonly List<Customer> _customers = new List<Customer>();

        public void Add(Customer customer)
        {
            _customers.Add(customer);
            Console.WriteLine($"Customer Added : {customer.FirstName} {customer.LastName}");
        }

        public void Delete(Customer customer)
        {
            _customers.Remove(customer);
            Console.WriteLine($"Customer Deleted : {customer.FirstName} {customer.LastName}");
        }

        public List<Customer> GetAll()
        {
            return _customers;
        }
    }
}