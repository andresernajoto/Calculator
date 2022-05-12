using System;

namespace Calculator {
    class Program {
        static void Main(string[] args) {

            // calculating variables
            int num1, num2, total;

            // reading of calculation operator
            Console.WriteLine("1 - sum\n2 - subtract\n3 - multiply\n4 - divide\n0 - exit");
            Console.Write("\nChoose one of the operations above: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // calculation structure
            while (num != 0) {
                switch (num) {
                    // does the sum
                    case 1:
                        // reading of values
                        Console.Write("Enter the first number: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        num2 = int.Parse(Console.ReadLine());
                        
                        // calculating values
                        total = num1 + num2;
                        Console.WriteLine("The sum of typed numbers is: " + total);
                        
                        // console reseting
                        Console.Write("\nPress enter: ");
                        Console.ReadLine();
                        Console.Clear();

                        // reading again the calculation operator
                        Console.WriteLine("1 - sum\n2 - subtract\n3 - multiply\n4 - divide\n0 - exit");
                        Console.Write("\nChoose one of the operations above: ");
                        num = int.Parse(Console.ReadLine());
                        break;
                    // does the subtraction
                    case 2:
                        // reading of values
                        Console.Write("Enter the first number: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        num2 = int.Parse(Console.ReadLine());

                        // calculating values
                        total = num1 - num2;
                        Console.WriteLine("The subtraction of typed numbers is: " + total);

                        // console reseting
                        Console.Write("\nPress enter: ");
                        Console.ReadLine();
                        Console.Clear();

                        // reading again the calculation operator
                        Console.WriteLine("1 - sum\n2 - subtract\n3 - multiply\n4 - divide\n0 - exit");
                        Console.Write("\nChoose one of the operations above: ");
                        num = int.Parse(Console.ReadLine());
                        break;
                    // does the multiplication
                    case 3:
                        // reading of values
                        Console.Write("Enter the first number: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        num2 = int.Parse(Console.ReadLine());

                        // calculating values
                        total = num1 * num2;
                        Console.WriteLine("The multiplication of typed numbers is: " + total);

                        // console reseting
                        Console.Write("\nPress enter: ");
                        Console.ReadLine();
                        Console.Clear();

                        // reading again the calculation operator
                        Console.WriteLine("1 - sum\n2 - subtract\n3 - multiply\n4 - divide\n0 - exit");
                        Console.Write("\nChoose one of the operations above: ");
                        num = int.Parse(Console.ReadLine());
                        break;
                    // does the division
                    case 4:
                        // reading of values
                        Console.Write("Enter the first number: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        num2 = int.Parse(Console.ReadLine());

                        // calculating values
                        total = num1 / num2;
                        Console.WriteLine("The division of typed numbers is: " + total);

                        // console reseting
                        Console.Write("\nPress enter: ");
                        Console.ReadLine();
                        Console.Clear();

                        // reading again the calculation operator
                        Console.WriteLine("1 - sum\n2 - subtract\n3 - multiply\n4 - divide\n0 - exit");
                        Console.Write("\nChoose one of the operations above: ");
                        num = int.Parse(Console.ReadLine());
                        break;
                    // in case the provided number isn't in the menu
                    default:
                        // request the correct operation
                        Console.Write("\nInvalid number typed! Try again: ");
                        num = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        break;
                }
            
            }
        }
    }
}
