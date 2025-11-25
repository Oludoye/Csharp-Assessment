    // using System;

    // class Program
    // {
    //     static void Main()
    //     {
    //         // 1️⃣ Ask for user inputs
    //         Console.Write("Enter your first name: ");
    //         string? firstName = Console.ReadLine();

    //         Console.Write("Enter your favorite number: ");
    //         string? numberInput = Console.ReadLine();

    //         // Validate number input
    //         if (!double.TryParse(numberInput, out double favNumber))
    //         {
    //             Console.WriteLine("Invalid number entered. Please restart and enter a valid number.");
    //             return;
    //         }

    //         // 2️⃣ Display name manipulations
    //         Console.WriteLine("\n--- Name Manipulation ---");
    //         Console.WriteLine($"Uppercase: {firstName?.ToUpper()}");
    //         Console.WriteLine($"Lowercase: {firstName?.ToLower()}");

    //         // Reverse the name
    //         char[] nameArray = firstName!.ToCharArray();
    //         Array.Reverse(nameArray);
    //         string reversedName = new string(nameArray);
    //         Console.WriteLine($"Reversed: {reversedName}");

    //         // 3️⃣ Perform math operations
    //         Console.WriteLine("\n--- Math Operations ---");
    //         double square = Math.Pow(favNumber, 2);
    //         double squareRoot = Math.Sqrt(favNumber);
    //         double plusTen = favNumber + 10;
    //         double remainder = favNumber % 3;

    //         // 4️⃣ Display results neatly
    //         Console.WriteLine($"Square of {favNumber}: {square}");
    //         Console.WriteLine($"Square root of {favNumber}: {squareRoot}");
    //         Console.WriteLine($"{favNumber} + 10 = {plusTen}");
    //         Console.WriteLine($"Remainder when {favNumber} ÷ 3 = {remainder}");

    //         Console.WriteLine("\nThanks for using the SweetSharp Text & Math App!");
    //     }
    // }
 
    using System;

class SimpleCalculator
{
    static void Main()
    {
        while (true)   // Loop to run continuously
        {
            // Ask for first number
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

         // Ask for operator
            Console.Write("Enter an operator (+, -, *, /, %): ");
            char op = Convert.ToChar(Console.ReadLine());


            // Ask for second number
            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

           

            double result = 0;
            bool validOperator = true;

            // Perform calculation
            if (op == '+')
            {
                result = num1 + num2;
            }
            else if (op == '-')
            {
                result = num1 - num2;
            }
            else if (op == '*')
            {
                result = num1 * num2;
            }
            else if (op == '/')
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    validOperator = false;
                }
                else
                {
                    result = num1 / num2;
                }
            }
            else if (op == '%')
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Modulus by zero is not allowed.");
                    validOperator = false;
                }
                else
                {
                    result = num1 % num2;
                }
            }
            else
            {
                Console.WriteLine("Invalid operator entered!");
                validOperator = false;
            }

            // Display result
            if (validOperator)
            {
                Console.WriteLine($"Result: {num1} {op} {num2} = {result}");
            }

            // Ask user if they want to continue
            Console.Write("\nDo you want to perform another calculation? (yes/no): ");
            string choice = Console.ReadLine().ToLower();

            if (choice == "no" || choice == "ce")
            {
                Console.WriteLine("Calculator exited.");
                break; // Exit the loop
            }

            Console.WriteLine(); // Add a blank line before restarting
        }
    }
}

