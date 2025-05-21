using System.Runtime.CompilerServices;

namespace ClassTest
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Player player1 = new Player("Obama");
            player1.SayHello();

            Player player2 = new Player("Juan");
            player2.SayHello();

            Console.WriteLine(Player.health);

            PlayerActions.Pactions pactions = PlayerActions.Pactions.NoEnemy;
            pactions++;
            Console.WriteLine(pactions);
    }

    private class Player
        {
            public string name = "-"; //Class variable/field
            public static int health = 100;
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
        static private class PlayerActions
        {
            public enum Pactions //No lo puedo declarar en el main(no se PQ)
            {
                NoEnemy,
                NoPathToEnemy,
                MovingTowardEnemy,
                AttackingEnemy,
            }
        }
    }
}

