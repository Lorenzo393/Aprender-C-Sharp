namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>();
            List<int> numberList2 = new List<int> {1,2,3,4,5};
            int[] array = { 1, 2, 3 };
            int[] array2 = new int[5]; //Si no se especifica todos los elementos se inicializan en 0
            Console.WriteLine(suma(1, 2));
            Console.WriteLine(suma(1, 2, 3));
            int age = 10;
            add(age);
            Console.WriteLine(age);
            mostrar(array);
            mostrar(array2);
        }

        static int suma(int x, int y)
        {
            return x + y;
        }
        static int suma(int x, int y, int z)
        { // Esto no funciona con la plantilla basica de C#
            return x + y + z;
        }
        static int add(int x)
        {
            return x++;
        }
        static void mostrar(int[] array)
        {
            
            foreach(int i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
