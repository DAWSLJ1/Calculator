using System.Security.Cryptography.X509Certificates;

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
            Console.WriteLine("4. Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Binary();
                    break;
                case 2:
                    Console.Clear();
                    Crypto();
                    break;
                case 3:
                    Console.Clear();
                    Mat();
                    break;
                case 4:
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
            Console.WriteLine("What process would you like to do");
            Console.WriteLine();
            Console.WriteLine("1. Addition/Subtraction");
            Console.WriteLine("2. Conversion between hexadecimal, binary & decimal");
            Console.WriteLine("3. Add BCD numbers");
            Console.WriteLine("4. Convert decimal to binary coded decimal");
            Console.WriteLine("5. Exit");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    BinaryAddSub();
                    break;
                case 2:
                    BinaryConvHexDec();
                    break;
                case 3:
                    BinaryBCD();
                    break;
                case 4:
                    BinaryConvDecBin();
                    break;
                case 5:
                    Binary();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    Console.ReadLine();
                    Binary();
                    break;
            }

        }
        public static void BinaryAddSub()
        {
            bool on = true;
            while (on)
            {
                string input = (Console.ReadLine());
                if (input == "exit")
                {
                    on = false;
                }
                else
                {
                    int input2 = Convert.ToInt32(Console.ReadLine());

                }
            }
            Binary();
        }
        public static void BinaryConvHexDec()
        {

        }
        public static void BinaryBCD()
        {

        }
        public static void BinaryConvDecBin()
        {

        }
        public static void Crypto()
        {

        } 
        public static void Mat()
        {

        }
    }
}
