using System;

namespace Part_3___Keyboard_input
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Greetings
            Console.WriteLine("Hey kid, this is a robbery. I just have a few questions...");

            Console.WriteLine("what is your name?: ");
            String userName = Console.ReadLine();

            Console.WriteLine("Very Good. Now how old are you?: ");
            string userAgeString = Console.ReadLine();
            int userAge = Convert.ToInt32(userAgeString);

            Console.WriteLine("Interesting. Can you tell me the year?: ");

            DateTime currentYear = DateTime.Today;
            int currentYearint = currentYear.Year;
            int userYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("you answered " + userYear + ". ");
            Console.WriteLine("Comparing answer.....");
            Console.WriteLine("intriguing.... I found that it's really " + currentYearint);

            int userYearOfBirth = (currentYearint - userAge);
            Console.WriteLine("So.. Mr. " + userName + ", I see you were born in the year " + userYearOfBirth + ". That makes you quite old.");


            ///Adder 
            Console.WriteLine("Welcome to the Triad Integer Adder, ");

            Console.WriteLine("please enter integer #1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter integer #2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter integer #3: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
   
            int total = (num1 + num2 + num3);

            Console.WriteLine("the answer is: " + total);


            ///Distance
            Console.WriteLine("Ok. Now we will calculate the average of 3 distances in Km's.");

            Console.WriteLine("please enter distance #1: ");
            int dst1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter distance #2: ");
            int dst2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter distance #3: ");
            int dst3 = Convert.ToInt32(Console.ReadLine());

            float dstAverage = ((dst1 + dst2 + dst3) / 3);

            Console.WriteLine("the average is: " + dstAverage);


            ///Hypotenuse
            Console.WriteLine("For this one we will calculate the hypotenuse of a triangle using sides A and B.");
            Console.WriteLine("please enter the value of Side A in cm: ");
            double sideA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the value of Side B in cm: ");
            double sideB = Convert.ToInt32(Console.ReadLine());

            double sideC = Math.Sqrt((sideA * sideA) + (sideB * sideB));

            Console.WriteLine("The Hypotenuse would be: " + sideC + "km");

            Console.ReadLine();
            ///
            ///
            ///need to fix de

        }
    }
}
