using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Customer
    {
        int Id { get; set; }
        string Name { get; set; }

        string City { get; set; }
        int total { get; set; }
        int perunitCost { get; set; }
        int totalCost { get; set; }

        string paid_notpaid { get; set; }


        List<Customer> Details = new List<Customer>();
        public void CustomerList()
        {
            Details.Add(new Customer
            {
                Id = 1,
                Name = "Anush",
                City = "delhi",
                total = 100,
                perunitCost = 15,
                totalCost = total * perunitCost,
                paid_notpaid = "paid"
            });
            Details.Add(new Customer
            {
                Id = 2,
                Name = "kiran",
                City = "Delhi",
                total = 100,
                perunitCost = 15,
                totalCost = total * perunitCost,
                paid_notpaid = "paid"

            });
            Details.Add(new Customer
            {
                Id = 3,
                Name = "rahul",
                City = "up",
                total = 100,
                perunitCost = 15,
                totalCost = total * perunitCost,
                paid_notpaid = "paid"


            });
            Details.Add(new Customer
            {
                Id = 4,
                Name = "Anush Gupta",
                City = "Noida",
                total = 100,
                perunitCost = 15,
                totalCost = total * perunitCost,
                paid_notpaid = "paid"


            });
            Details.Add(new Customer
            {
                Id = 5,
                Name = "Akash",
                City = "Noida",
                total = 100,
                perunitCost = 15,
                totalCost = total * perunitCost,
                paid_notpaid = "Not paid"

            });
            Details.Add(new Customer
            {
                Id = 6,
                Name = "muku;",
                City = "Noida",
                total = 200,
                perunitCost = 15,
                totalCost = total * perunitCost,
                paid_notpaid = "paid"


            });
            Details.Add(new Customer
            {
                Id = 7,
                Name = "kaka",
                City = "Noida",
                total = 100,
                perunitCost = 15,
                totalCost = total * perunitCost,
                paid_notpaid = "paid"


            });
            Details.Add(new Customer
            {
                Id = 8,
                Name = "ramu",
                City = "Noida",
                total = 100,
                perunitCost = 15,
                totalCost = total * perunitCost,
                paid_notpaid = "paid"


            });
            Details.Add(new Customer
            {
                Id = 9,
                Name = "kalu",
                City = "Noida",
                total = 100,
                perunitCost = 15,
                totalCost = total * perunitCost,
                paid_notpaid = "paid"


            });
            Details.Add(new Customer
            {
                Id = 10,
                Name = "Rahulgupta",
                City = "Noida",
                total = 100,
                perunitCost = 15,
                totalCost = total * perunitCost,
                paid_notpaid = "paid"


            });
        }
        public void CustomerDetails(int Id)
        {
            for (int i = 0; i <= Details.Count; i++)
            {
                if (Id == Details[i].Id)
                {
                    Console.WriteLine("ID:" + Details[i].Id + "\tName:" + Details[i].Name + "\tCity:" + Details[i].City + "\tTotalCost:" + Details[i].totalCost + "\tPaid_NotPaid:" + Details[i].paid_notpaid);
                }

                    

                    
                
            }
            
        }

    }
    
}
    
 



    

