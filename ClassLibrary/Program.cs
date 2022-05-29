using System;
using Library;

public class pogram
{
    public static void Main()
    {
        Customer obj = new Customer();
        obj.CustomerList();
    A:
        Console.WriteLine("Press 1 to Enter:");
        int input = Convert.ToInt32(Console.ReadLine());
        switch (input)
        {
            case 1:
                Console.Write("Enter Id: ");
                obj.CustomerDetails(Convert.ToInt32(Console.ReadLine()));
                break;



        }

    }
}