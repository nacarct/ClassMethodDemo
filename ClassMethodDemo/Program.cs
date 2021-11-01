using System;
using System.Collections.Generic;

namespace ClassMethodDemo
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();

            Customer customer1 = new Customer()
            {
                Id = 1, 
                IdentityNumber = "12345678901", 
                FirstName = "Temuçin", 
                LastName = "Nacar"
            };
            
            

            Customer customer2 = new Customer()
            {
                Id = 2,
                IdentityNumber = "22344618951",
                FirstName = "Emre",
                LastName = "Tatar"
            };
            
            Customer customer3 = new Customer()
            {
                Id = 3,
                IdentityNumber = "51354652485",
                FirstName = "Mehmet",
                LastName = "Yanar"
            };

            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Delete(customer3);

            foreach (var customer in customerManager.GetAll())
            {
                Console.WriteLine($"Identity Number : {customer.IdentityNumber} | Id : {customer.Id} | FirstName : {customer.FirstName} | LastName : {customer.LastName}");
            }

        }
    }
}