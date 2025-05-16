namespace ClassTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Obama");
            player1.SayHello();

            Player player2 = new Player("Juan");
            player2.SayHello();
        }

        class Player
        {
            public string name = "-"; //Class variable/field
            int health = 100;
            public Player(string name)
            {
                this.name = name; // Sino le podes cambiar el nombre en los argumentos y hacer "name = _name"
                Console.WriteLine($"Creating player {name}");
            }

            public void SayHello()
            {
                Console.WriteLine($"Hello {name}" );
            }

            public void HealthCheck()
            {
                Console.WriteLine($"Player health: {health}");
            }
        }
    }
}
