namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите что-то");
            var str = Console.ReadLine();
            Console.WriteLine("Укажите глубину эха");
            var deep = int.Parse(Console.ReadLine());
            Echo(str, deep);
            var y = int.Parse(Console.ReadLine());
            var x = byte.Parse(Console.ReadLine());
            var fact = Factorial(y);
            var pow = PowerUp(y, x);
            Console.WriteLine($"Факториал числа введённого числа:{fact}  \nСтепень введённого числа:{pow}");
            Console.ReadKey();  
        }
        static void Echo(string phrase, int deep) 
        {
            
            var modif = phrase;
            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
                Console.BackgroundColor = (ConsoleColor)deep ;
                Console.WriteLine("..." + modif);
            }
            if (deep > 1)
            {
                Echo(modif, deep - 1);
            }
        }
        static decimal Factorial(int x)
        {
            if (x == 0) 
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
            
        }
        private static int PowerUp(int n, byte pow)
        {
            if (pow == 0) { return 1; }
            else
            {
                if (pow == 1) { return n; }
                else
                {
                    return n * PowerUp(n, --pow);
                }
            }
        }
    }
}
