using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Informe a data de seu aniversário");
                DateTime data = DateTime.Parse(Console.ReadLine());

                int age = DateTime.Today.Year - data.Year;

                if (data.DayOfYear < DateTime.Today.DayOfYear)
                {
                    age = age - 1;
                    Console.WriteLine($"Your age is {age}!");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
