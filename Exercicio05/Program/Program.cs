using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            String repeat = "s";
            while (repeat.Equals("s"))
            {
                Console.WriteLine("Enter a first value");
                String value1 = Console.ReadLine();

                Console.WriteLine("Enter a second value");
                String value2 = Console.ReadLine();

                Console.WriteLine("======Informe a operação======");
                Console.WriteLine("1 -> ADIÇÃO");
                Console.WriteLine("2 -> SUBTRAÇÃO");
                Console.WriteLine("3 -> MULTIPLICAÇÃO");
                Console.WriteLine("4 -> DIVISÃO");
                Console.WriteLine("5 -> SOBRA DA DIVISÃO");
                String operation = Console.ReadLine();
                int operationCoverted = Convert.ToInt32(operation);

                decimal convertedValue1 = 0.00m;
                decimal convertedValue2 = 0.00m;

                decimal.TryParse(value1, out convertedValue1);
                decimal.TryParse(value2, out convertedValue2);

                switch (operationCoverted)
                {
                    case 1:
                        Console.WriteLine($"Result is {convertedValue1} + {convertedValue2} = {(convertedValue1 + convertedValue2)}");
                        break;
                    case 2:
                        Console.WriteLine($"Result is {convertedValue1} - {convertedValue2} = {(convertedValue1 - convertedValue2)}");
                        break;
                    case 3:
                        Console.WriteLine($"Result is {convertedValue1} * {convertedValue2} = {(convertedValue1 * convertedValue2)}");
                        break;
                    case 4:
                        Console.WriteLine($"Result is {convertedValue1} / {convertedValue2} = {(convertedValue1 / convertedValue2)}");
                        break;
                    case 5:
                        Console.WriteLine($"Result is {convertedValue1} % {convertedValue2} = {(convertedValue1 % convertedValue2)}");
                        break;
                }

                Console.WriteLine("Do you want to continue? y/n");
                repeat = Console.ReadLine();
                Console.WriteLine("");
            }
        }
    }
}
