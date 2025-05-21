namespace Test_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PlayerName = "Obamo";

            Console.WriteLine(PlayerName);
        }

        private static string playerName;
        private static string PlayerName
        {
            get
            {
                if (playerName == null)
                {
                    return "Unknow";
                }
                return playerName;
            }
            set
            {
                if (value == "Obama")
                {
                    throw new Exception("Cannot name player Obama");
                }
                playerName = value;
            }
        }

    }
}
