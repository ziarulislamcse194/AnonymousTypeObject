using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypeObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new {Id = 1, Name = "A", Address = "Dhanmondi", LoyaltyPoint = 1200};
            var product = new {Id = 1, Name = "B", Unite = "kg", SalesPrice = 125};
            var student = new {Id = 1, Name = "C", RegNo = "001"};

            var customers = new[]
            {
                new {Id = 1, Name = "A", Address = "Dhanmondi", LoyaltyPoint = 120},
                new {Id = 2, Name = "B", Address = "mohmmodpur", LoyaltyPoint = 150},
                new {Id = 3, Name = "C", Address = "nirpur", LoyaltyPoint = 200},
            };


            //ShowCustomer(customers);

            // Expando Object
            dynamic aValue = new ExpandoObject();
            aValue.Message = "New Message";
            Console.WriteLine(aValue.Message);


            //object type

            //object aValue = customer;
            //dynamic retriveCustomer = aValue;
            //Console.WriteLine(retriveCustomer.Name);

            //dynamic aCustomer = customer;
            //Console.WriteLine(aCustomer.Name+" "+aCustomer.Address);

            //dynamic customerList2 = 2;
            //customerList2 = customers;


            //foreach (var c in customers)
            //{
            //    Console.WriteLine(c.Id+" "+c.Name+" "+c.Address+" "+c.LoyaltyPoint);
            //}

            Console.ReadKey();
        }


        public static void ShowCustomer(dynamic customers)
        {
            foreach (var c in customers)
            {
                Console.WriteLine(c.Id + " " + c.Name + " " + c.Address + " " + c.LoyaltyPoint);
            }
        }
    }
}
