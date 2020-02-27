using System;

namespace MethodsDanielWidell
{
    class Program
    {
        static double OperationsViaCase(
            double inputA,
            double inputB,
            int flag)
        {
            switch (flag)
            {
                case 1: return (inputA + inputB);
                case 2: return (inputA - inputB);
                case 3: return (inputA * inputB);
                case 4:
                    {
                        if (inputB == 0)
                            Console.WriteLine("Only a god may divide by 0.");
                        else
                            return (inputA / inputB);
                        break;
                    }
                default: break;
            }
            return double.NaN; 
        }
            static void Main(string[] args)
            {
                Console.WriteLine("Daniel Widell");
                double inputA;
                double inputB;
                int flag;

                Console.WriteLine("Enter the first number: ");
                inputA = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the second number: ");
                inputB = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Select desired operation: \n 1. Add 2. Subtract 3. Multiply 4. Divide");

                flag = Convert.ToInt32(Console.ReadLine());
            if (flag == 1)
            {
                Console.WriteLine("The sum of " + inputA + " and " + inputB + " is: " + OperationsViaCase(inputA, inputB, flag));
            }
            if (flag == 2)
            {
                Console.WriteLine("The difference between " + inputA + " and " + inputB + " is: " + OperationsViaCase(inputA, inputB, flag));
            }
            if (flag == 3)
            {
                Console.WriteLine("The multiplication of " + inputA + " and " + inputB + " is: " + OperationsViaCase(inputA, inputB, flag));
            }
            if (flag == 4)
            {
                Console.WriteLine("The division of " + inputA + " by " + inputB + " is: " + OperationsViaCase(inputA, inputB, flag));
            }
            else
            {
                Console.WriteLine("Please enter a valid number between 1 and 4.");
            }
            }
        }
    }

    

