namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string input = Console.ReadLine();

            switch (input)
            {
                case "a":
                    Console.WriteLine("Vokaal a");
                    break;

                case "e":
                    Console.WriteLine("Vokaal e");
                    break;

                case "i":
                    Console.WriteLine("Vokaal i");
                    break;

                default:
                    Console.WriteLine("Muu täht");
                    break;
            }
        }
    }
}
