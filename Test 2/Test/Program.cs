namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(suma(1,2));
            int age = 10;
            add(age);
            Console.WriteLine(age);
        }

        static int suma(int x, int y)
        {
            return x + y;
        }
        static int suma(int x, int y, int z)// Esto no funciona con la plantilla basica de C#
        {
            return x + y;
        }
        static int add(int x)
        {
            return x++;
        }
    }
}
