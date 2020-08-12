using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {

            //Practice Creating Variables
            int numberofCupsOfCoffee = 0;
            string fullName = "Daniel Labios";
            DateTime today = DateTime.Now;
            Console.WriteLine("cups of coffee:" + numberofCupsOfCoffee + "   " + "name:" + fullName + "   " + "today's date:" + today);

            //Practice Getting Input From User
            Console.WriteLine("Please give me your name:");
            var userName = Console.ReadLine();
            if (userName == "Alice")
            {
                Console.WriteLine("Hello Alice, would you like to join our cannibal colony?");
            }
            else
            {
                Console.WriteLine($"Hello, {userName}! It is nice to meat you! Chop! Chop!");
            }
            /*Console.WriteLine("Please, give me your name:");
            var userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}! It is nice to meat you! Chop! Chop!");*/

            //Practice Getting Different Types of Input From the User
            Console.WriteLine("Can you give me a number?: ");
            string firstNumberAsString = Console.ReadLine();
            Console.WriteLine("Can you also give me a second number?");
            string secondNumberAsString = Console.ReadLine();

            //Convert String Input Into Numbers
            var firstOperand = double.Parse(firstNumberAsString);
            var secondOperand = double.Parse(secondNumberAsString);

            //Doing Math
            double sum = (firstOperand + secondOperand);
            double difference = (secondOperand - firstOperand);
            double product = (firstOperand * secondOperand);
            double quotient = (firstOperand / secondOperand);
            double remainder = (firstOperand % secondOperand);
            Console.WriteLine($"Thanks, {userName}. Fun Facts! If you have {firstOperand} bodies and add {secondOperand} bodies to the"
            + $" meatlocker, you get {sum} bodies! If you have {secondOperand} bodies in your meatlocker, and you eat {firstOperand} bodies"
            + $", you are left with {difference} bodies. If you have {firstOperand} bodies, and you cut each one up into {secondOperand}"
            + $" pieces, you have {product} pieces of body parts! Finally, if you have {firstOperand} bodies, and stash them into "
            + $"{secondOperand} meatlockers, each locker will have {quotient} bodies in them with {remainder} left over.");


        }
    }
}
