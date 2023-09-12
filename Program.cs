internal class Calculator
{
    private static void Main(string[] args)
    {
        do
        {
            double num1 = 0;
            double num2 = 0;
            double solution = 0;


            Console.WriteLine("\tcalculator");
            Console.WriteLine("----------------------------------");
            Console.Write("\tinput first num:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\tinput second num:");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\tChoose operator:");
            Console.WriteLine("\t+:Add");
            Console.WriteLine("\t-:Subtract");
            Console.WriteLine("\t*:Multiply");
            Console.WriteLine("\t/:Divide");
            Console.WriteLine("\tEnter option:");

            switch (Console.ReadLine())
            {
                case "+":
                    solution = num1 + num2;
                    Console.WriteLine($"Answer:{num1}+{num2}=" + solution); break;

                case "-":
                    solution = num1 - num2;
                    Console.WriteLine($"Answer:{num1}-{num2}=" + solution); break;

                case "*":
                    solution = num1 * num2;
                    Console.WriteLine($"Answer:{num1}*{num2}=" + solution); break;

                case "/":
                    solution = num1 / num2;
                    Console.WriteLine($"Answer:{num1}/{num2}=" + solution); break;

                default:
                    Console.WriteLine("Not a valid operator");
                    break;


            }
            Console.WriteLine("Make another calculation?(\tY=yes,N=NO:");

        } while (Console.ReadLine().ToUpper() == "Y");

        Console.WriteLine("See ya!");
        Console.ReadKey();



     }


}