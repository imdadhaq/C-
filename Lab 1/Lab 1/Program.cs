using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        { //Number 1 
            Console.WriteLine("Hello");
            Console.WriteLine("IMDAD");
            Console.WriteLine(); 
            
            //Number 2
            int x = 5, y = 7;
            Console.WriteLine(x);
            Console.WriteLine(y);
            int sum = x + y;
                Console.WriteLine("Sum of two number is "+sum);
                Console.WriteLine();
                
            //Number 3 
            int a = 15, b = 3;
            int div = (a / b);
            Console.WriteLine(div);
            Console.WriteLine();
            
            //Number4
            Console.WriteLine("Answer of number a."+-5+8*6);
            Console.WriteLine("Answer of number b."+(55+9)%9);
            Console.WriteLine("Answer of number c."+ 20+(-3*5)/8);
            Console.WriteLine();
            
            //Number 5 
            int number1 = 4, number2 = 3;
            int sumation = number1 + number2;
            int multiply = (number1 * number2);
            int subtraction = number1 - number2;
            int divide = number1 / number2;
            float reminder = number1 % number2;
            Console.WriteLine(sumation);
            Console.WriteLine(multiply);
            Console.WriteLine(subtraction);
            Console.WriteLine(divide);
            Console.WriteLine(reminder);
            Console.WriteLine();
            //number 6
            Console.WriteLine((25.5*3.5-3.5*3.5)/(40.5-4.5));
            Console.WriteLine();
            
            //Number 7 
             double width = 5.5, height = 8.5;
             double  area = width * height;
             Console.WriteLine(area);
            double perimeter = 2 * (width + height);
            Console.WriteLine(perimeter);

        }
    }
}