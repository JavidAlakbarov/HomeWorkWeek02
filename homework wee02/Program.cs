using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_week02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1)Write a C# that calculates the day of week (ex: Monday) of your birthday

            //DateTime MyBirthDay = new DateTime(1997, 01, 07);
            //Console.WriteLine(MyBirthDay.ToString("dddd"));


            //2)Write a C# that calculates you current life days (how many days past since your birth)

            //DateTime now = DateTime.Now;
            //Console.WriteLine(now);
            //DateTime bday = new DateTime(1997, 01, 07);
            //Console.WriteLine(bday);
            //TimeSpan lifedays = now - bday;
            //Console.WriteLine($"My current life days:{lifedays.Days}");


            //3)Write a C# Sharp program to find the largest of three numbers.

            //Console.WriteLine("Input the 1st number:");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Input the 2nd number:");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Input the 3rd number:");
            //int c = int.Parse(Console.ReadLine());
            //int max;
            //if (a > b && a>c)               
            //    {
            //        Console.WriteLine("The 1st number is the greatest number among three");
            //    }
            //if (b > a && b>c)               
            //    {

            //        Console.WriteLine("The 2nd number is the greatest number among three");
            //    }
            //if (c > b && c>a)                
            //    {

            //        Console.WriteLine("The 3rd number is the greatest number among three");
            //    }


            //4)Write a program in C# Sharp to read any day number in integer and display day name in the word

            //int dayname;
            //Console.WriteLine("Input any day number in integer: ");
            //dayname = Convert.ToInt32(Console.ReadLine());
            //switch (dayname)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid day number");
            //        break;


            //        5)Write a program in C# Sharp which is a Menu-Driven Program to perform a simple calculation.

            //double num1, num2, choices;
            //        Console.WriteLine("Enter the first integer:");
            //        num1 = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine("Enter the second integer:");
            //        num2 = Convert.ToDouble(Console.ReadLine());
            //        //ToDouble calculate edende galig itmesin deye yaziram
            //        Console.WriteLine("Here are the options:");
            //        Console.WriteLine("1-Addition/2-Substraction/3-Multiplication/4-Division/5-Exit");
            //        Console.WriteLine("Input your choice:");
            //        choices = Convert.ToDouble(Console.ReadLine());

            //        switch (choices)
            //        {
            //            case 1:
            //                Console.WriteLine($"The Addition of {num1} and {num2} is :{num1 + num2}");
            //                break;
            //            case 2:
            //                Console.WriteLine($"The Substraction of {num1} and {num2} is :{num1 - num2}");
            //                break;
            //            case 3:
            //                Console.WriteLine($"The Multiplication of {num1} and {num2} is :{num1 * num2}");
            //                break;
            //            case 4:
            //                if (num2 == 0)
            //                {
            //                    Console.WriteLine("Impossible");
            //                }
            //                else
            //                {
            //                    Console.WriteLine($"The Division of {num1} and {num2} is :{num1 / num2}");
            //                }
            //                break;
            //            case 5:
            //                Console.WriteLine("GoodBye");
            //                break;
            //            default:
            //                Console.WriteLine("Input the correct option from 1 to 5 ");
            //                break;
            //        }


            //        6)Write a program in C# to check whether a number is a palindrome (visual simmetric) or not. 

            //string palindrome, reverse = "";
            //Console.WriteLine("Enter a string or number:");
            //palindrome = Console.ReadLine();
            //for (int i = palindrome.Length - 1; i >= 0; i--)
            //{
            //    reverse += palindrome[i].ToString();
            //}
            //if (reverse == palindrome)
            //{
            //    Console.WriteLine("String/Number is a Palindrome", palindrome, reverse);
            //}
            //else
            //{
            //    Console.WriteLine("String/Number is not a Palindrome", palindrome, reverse);
            //}


            //        7)Write a program in C# to create a function to calculate the sum of the individual digits of a given number.
            //int num;
            //int sum;
            //int a;
            //Console.WriteLine($"Enter a Number : ");
            //num = int.Parse(Console.ReadLine());
            //while (num != 0)
            //{
            //    a = num % 10;
            //    num = num / 10;
            //    sum = sum + a;
            //}
            //Console.WriteLine($"The sum of the digits of the number is : {sum} ");









        }









    }
}
