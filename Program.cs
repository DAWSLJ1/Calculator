namespace NumeracyCalcAssignment
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Which mode would you like to use:");
            Console.WriteLine();
            Console.WriteLine("1. Binary");
            Console.WriteLine("2. Cryptography");
            Console.WriteLine("3. Matrices");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Binary();
                    break;
                case 2:
                    Crypto();
                    break;
                case 3:
                    Mat();
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    Console.ReadLine();
                    Main();
                    break;
            }
        }
        public static void Binary()
        {
            Console.WriteLine("\tBinary");
            int input = Convert.ToInt32(Console.ReadLine());

        }
        public static void Crypto()
        {

        } 
        public static void Mat()
        {

        }
    }
}
