using System;
using Calculator.Entities;

namespace Calculator {
    class Program {
        static void Main(string[] args) {

            // calculating variables
            int num1, num2, total;

            Operations op = new Operations();

            // reading of calculation operator
            Console.WriteLine("1 - sum\n2 - subtract\n3 - multiply\n4 - divide\n5 - rest of division\n6 - exponentiation\n0 - exit");
            Console.Write("\nChoose one of the operations above: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // calculation structure
            while (num != 0) {
                switch (num) {
                    // does the sum calcule
                    case 1:
                        // reading of values
                        Console.Write("Enter the first number: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        num2 = int.Parse(Console.ReadLine());

                        // show the result
                        Console.WriteLine("Result: " + op.Summing(num1, num2));
                        
                        // console reseting
                        Console.Write("\nPress enter: ");
                        Console.ReadLine();
                        Console.Clear();

                        // reading again the calculation operator
                        Console.WriteLine("1 - sum\n2 - subtract\n3 - multiply\n4 - divide\n5 - rest of division\n6 - exponentiation\n0 - exit");
                        Console.Write("\nChoose one of the operations above: ");
                        num = int.Parse(Console.ReadLine());
                        break;
                    // does the subtraction calcule
                    case 2:
                        // reading of values
                        Console.Write("Enter the first number: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        num2 = int.Parse(Console.ReadLine());

                        // show the result
                        Console.WriteLine("Result: " + op.Subtracting(num1, num2));

                        // console reseting
                        Console.Write("\nPress enter: ");
                        Console.ReadLine();
                        Console.Clear();

                        // reading again the calculation operator
                        Console.WriteLine("1 - sum\n2 - subtract\n3 - multiply\n4 - divide\n5 - rest of division\n6 - exponentiation\n0 - exit");
                        Console.Write("\nChoose one of the operations above: ");
                        num = int.Parse(Console.ReadLine());
                        break;
                    // does the multiplication calcule
                    case 3:
                        // reading of values
                        Console.Write("Enter the first number: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        num2 = int.Parse(Console.ReadLine());

                        // show the result
                        Console.WriteLine("Result: " + op.Multiplying(num1, num2));

                        // console reseting
                        Console.Write("\nPress enter: ");
                        Console.ReadLine();
                        Console.Clear();

                        // reading again the calculation operator
                        Console.WriteLine("1 - sum\n2 - subtract\n3 - multiply\n4 - divide\n5 - rest of division\n6 - exponentiation\n0 - exit");
                        Console.Write("\nChoose one of the operations above: ");
                        num = int.Parse(Console.ReadLine());
                        break;
                    // does the division calcule
                    case 4:
                        // reading of values
                        Console.Write("Enter the first number: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        num2 = int.Parse(Console.ReadLine());

                        // show the result
                        Console.WriteLine("Result: " + op.Dividing(num1, num2));

                        // console reseting
                        Console.Write("\nPress enter: ");
                        Console.ReadLine();
                        Console.Clear();

                        // reading again the calculation operator
                        Console.WriteLine("1 - sum\n2 - subtract\n3 - multiply\n4 - divide\n5 - rest of division\n6 - exponentiation\n0 - exit");
                        Console.Write("\nChoose one of the operations above: ");
                        num = int.Parse(Console.ReadLine());
                        break;
                    // does the rest of division calcule
                    case 5:
                        // reading of values
                        Console.Write("Enter the first number: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        num2 = int.Parse(Console.ReadLine());

                        // show the result
                        Console.WriteLine("Result: " + op.RestOfDivision(num1, num2));

                        // console reseting
                        Console.Write("\nPress enter: ");
                        Console.ReadLine();
                        Console.Clear();

                        // reading again the calculation operator
                        Console.WriteLine("1 - sum\n2 - subtract\n3 - multiply\n4 - divide\n5 - rest of division\n6 - exponentiation\n0 - exit");
                        Console.Write("\nChoose one of the operations above: ");
                        num = int.Parse(Console.ReadLine());
                        break;
                    // does the exponentiation calcule
                    case 6:
                        // reading of values
                        Console.Write("Enter the first number: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        num2 = int.Parse(Console.ReadLine());

                        // show the result
                        Console.WriteLine("Result: " + op.Exponentiation(num1, num2));

                        // console reseting
                        Console.Write("\nPress enter: ");
                        Console.ReadLine();
                        Console.Clear();

                        // reading again the calculation operator
                        Console.WriteLine("1 - sum\n2 - subtract\n3 - multiply\n4 - divide\n5 - rest of division\n6 - exponentiation\n0 - exit");
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
