using System;
using Calculator.Entities;

namespace Calculator {
    class Program {
        static void Main(string[] args) {

            // values to calculate
            double num1, num2;

            // instantiation of Operations class
            Operations op = new Operations();

            // reading of the operator to be calculated
            Console.WriteLine("1 - sum\n2 - subtract\n3 - multiply\n4 - divide\n5 - rest of division\n6 - exponentiation\n0 - exit");
            Console.Write("\nChoose one of the operations above: ");
            int num = int.Parse(Console.ReadLine());

            // calculation structure
            while (num != 0) {
                switch (num) {
                    // sum calcule
                    case 1:
                        // reading values
                        Console.Write("Enter the first number: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        num2 = int.Parse(Console.ReadLine());

                        // show the result
                        Console.WriteLine("Result: " + op.Summing(num1, num2));
                        
                        // console reset
                        Console.Write("\nPress enter: ");
                        Console.ReadLine();
                        Console.Clear();

                        // reading of the operator to be calculated again
                        Console.WriteLine("1 - sum\n2 - subtract\n3 - multiply\n4 - divide\n5 - rest of division\n6 - exponentiation\n0 - exit");
                        Console.Write("\nChoose one of the operations above: ");
                        num = int.Parse(Console.ReadLine());
                        break;
                    // subtraction calcule
                    case 2:
                        // reading values
                        Console.Write("Enter the first number: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        num2 = int.Parse(Console.ReadLine());

                        // show the result
                        Console.WriteLine("Result: " + op.Subtracting(num1, num2));

                        // console reset
                        Console.Write("\nPress enter: ");
                        Console.ReadLine();
                        Console.Clear();

                        // reading of the operator to be calculated again
                        Console.WriteLine("1 - sum\n2 - subtract\n3 - multiply\n4 - divide\n5 - rest of division\n6 - exponentiation\n0 - exit");
                        Console.Write("\nChoose one of the operations above: ");
                        num = int.Parse(Console.ReadLine());
                        break;
                    // multiplication calcule
                    case 3:
                        // reading values
                        Console.Write("Enter the first number: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        num2 = int.Parse(Console.ReadLine());

                        // show the result
                        Console.WriteLine("Result: " + op.Multiplying(num1, num2));

                        // console reset
                        Console.Write("\nPress enter: ");
                        Console.ReadLine();
                        Console.Clear();

                        // reading of the operator to be calculated again
                        Console.WriteLine("1 - sum\n2 - subtract\n3 - multiply\n4 - divide\n5 - rest of division\n6 - exponentiation\n0 - exit");
                        Console.Write("\nChoose one of the operations above: ");
                        num = int.Parse(Console.ReadLine());
                        break;
                    // division calcule
                    case 4:
                        // reading values
                        Console.Write("Enter the first number: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        num2 = int.Parse(Console.ReadLine());

                        // show the result
                        Console.WriteLine("Result: " + op.Dividing(num1, num2));

                        // console reset
                        Console.Write("\nPress enter: ");
                        Console.ReadLine();
                        Console.Clear();

                        // reading of the operator to be calculated again
                        Console.WriteLine("1 - sum\n2 - subtract\n3 - multiply\n4 - divide\n5 - rest of division\n6 - exponentiation\n0 - exit");
                        Console.Write("\nChoose one of the operations above: ");
                        num = int.Parse(Console.ReadLine());
                        break;
                    // rest of division calcule
                    case 5:
                        // reading values
                        Console.Write("Enter the first number: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        num2 = int.Parse(Console.ReadLine());

                        // show the result
                        Console.WriteLine("Result: " + op.RestOfDivision(num1, num2));

                        // console reset
                        Console.Write("\nPress enter: ");
                        Console.ReadLine();
                        Console.Clear();

                        // reading of the operator to be calculated again
                        Console.WriteLine("1 - sum\n2 - subtract\n3 - multiply\n4 - divide\n5 - rest of division\n6 - exponentiation\n0 - exit");
                        Console.Write("\nChoose one of the operations above: ");
                        num = int.Parse(Console.ReadLine());
                        break;
                    // exponentiation calcule
                    case 6:
                        // reading values
                        Console.Write("Enter the first number: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        num2 = int.Parse(Console.ReadLine());

                        // show the result
                        Console.WriteLine("Result: " + op.Exponentiation(num1, num2));

                        // console reset
                        Console.Write("\nPress enter: ");
                        Console.ReadLine();
                        Console.Clear();

                        // reading of the operator to be calculated again
                        Console.WriteLine("1 - sum\n2 - subtract\n3 - multiply\n4 - divide\n5 - rest of division\n6 - exponentiation\n0 - exit");
                        Console.Write("\nChoose one of the operations above: ");
                        num = int.Parse(Console.ReadLine());
                        break;
                    // in case the provided number isn't in the menu
                    default:
                        // request the correct operation
                        Console.Write("\nInvalid number typed! Try again: ");
                        num = int.Parse(Console.ReadLine());
                        break;
                }
            }
        }
    }
}
