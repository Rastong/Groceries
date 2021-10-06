using System;
using System.Collections.Generic;
using System.Linq;

namespace Gas_Station_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> total = new List<string>();
            List<double> Price = new List<double>();

            // Dictionary Adding
            Dictionary<string, double> Groceries = new Dictionary<string, double>();
            Groceries.Add("baja blast", 1.89);
            Groceries.Add("doughnut", 0.99);
            Groceries.Add("reeses", 1.09);
            Groceries.Add("slushy", 0.99);
            Groceries.Add("gatorade", 2.19);
            Groceries.Add("cigarettes", 5.99);
            Groceries.Add("lottery tickets", 2.00);
            Groceries.Add("cheetos", 0.79);
            bool runProgram = true;
            Console.WriteLine("Hello, welcom to Gilberry Gas Station!");
            while (runProgram)
            {
                foreach (KeyValuePair<string, double> groc in Groceries)
                {
                    Console.WriteLine($"{groc.Key} {groc.Value}");
                }


                // Ask to enter an items name

                bool RealItem = true;
                string input = "";


                while (RealItem)
                {
                    RealItem = true;
                    bool YesOrNo = true;
                    Console.WriteLine("What can I get for you today?");
                    input = Console.ReadLine();

                    foreach (KeyValuePair<string, double> NotValid in Groceries)
                    {

                        YesOrNo = true;
                        if (NotValid.Key == input)
                        {
                            YesOrNo = true;
                            total.Add(NotValid.Key);
                            Price.Add(NotValid.Value);
                            Console.WriteLine($"Added {NotValid.Key} at {NotValid.Value}");
                            break;
                        }
                        else
                        {
                            YesOrNo = false;
                        }
                    }
                    if (YesOrNo)
                    {
                        RealItem = false;
                    }
                    else
                    {
                        Console.WriteLine($"{input} is not a valid option, please try something else.");
                    }
                }
                bool lolAgain = false;
                while (!lolAgain)
                {
                    Console.WriteLine("Would you like to add another item?");
                    string TryAgain = Console.ReadLine();
                    lolAgain = false;
                    if (TryAgain == "yes")
                    {
                        runProgram = true;
                        Console.Clear();
                        lolAgain = true;
                    }
                    else if (TryAgain == "no")
                    {
                        runProgram = false;
                        lolAgain = true;
                    }
                    else
                    {
                        lolAgain = false;
                        Console.WriteLine("not a vaild option, please try again.");
                    }
                }
            }
            Console.WriteLine("Thanks for your order!");
            Console.WriteLine("Here is what you got:");
            double price = 0;
            foreach (KeyValuePair<string, double> groc in Groceries)
            {
                for(int i = 0; i < total.Count; i++)
                {
                    if (groc.Key == total[i])
                    {
                        Console.WriteLine(String.Format("{0,-10} | {1,-10}", $"{groc.Key}", $"{groc.Value}"));
                        price += groc.Value;
                    }
                }
                
            }
            Console.WriteLine($"Your average cost of items is {price / total.Count}");
        }
    }
}
