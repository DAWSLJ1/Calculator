using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace NumeracyCalcAssignment
{
    internal class Program
    {
        static void Main()
        {
            //Used AI to ask to create ascii art: "Can you create an ascii art of the word "Calculator" and write it as a c#"
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"  _____      _            _       _             
 / ____|    | |          | |     | |            
| |     __ _| | ___ _   _| | __ _| |_ ___  _ __ 
| |    / _` | |/ __| | | | |/ _` | __/ _ \| '__|
| |___| (_| | | (__| |_| | | (_| | || (_) | |   
 \_____\__,_|_|\___|\__,_|_|\__,_|\__\___/|_|   
");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Which mode would you like to use:");
            Console.WriteLine();
            Console.WriteLine("1. Binary");
            Console.WriteLine("2. Cryptography");
            Console.WriteLine("3. Matrices");
            Console.WriteLine("4. Calculator");
            Console.WriteLine("5. Exit");
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
                    Console.Clear();
                    Calc();
                    break;
                case 5:
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
                    Console.Clear();
                    BinaryAddSub();
                    break;
                case 2:
                    Console.Clear();
                    BinaryConvHexDec();
                    break;
                case 3:
                    Console.Clear();
                    BinaryBCD();
                    break;
                case 4:
                    Console.Clear();
                    BinaryConvDecBin();
                    break;
                case 5:
                    Console.Clear();
                    Main();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    Console.ReadLine();
                    Console.Clear();
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
            Console.Clear();
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
            Console.WriteLine("What process would you like to do");
            Console.WriteLine();
            Console.WriteLine("1. Caesar Cypher");
            Console.WriteLine("2. Affine Cypher");
            Console.WriteLine("3. Brute Fore Algorithm");
            Console.WriteLine("4. Exit");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.Clear();
                    CryptoCaesar();
                    break;
                case 2:
                    Console.Clear();
                    CryptoAffine();
                    break;
                case 3:
                    Console.Clear();
                    CryptoBrute();
                    break;
                case 4:
                    Console.Clear();
                    Main();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    Console.ReadLine();
                    Console.Clear();
                    Crypto();
                    break;
            }
        }
        public static void CryptoCaesar()
        {
            Console.WriteLine("=== Caesar Cipher ===");
            Console.WriteLine();

            Console.Write("Enter a statement: ");
            string text = Console.ReadLine();

            Console.Write("Enter the shift amount: ");
            int shift = Convert.ToInt32(Console.ReadLine());

            string encrypted = CaesarCipher(text, shift);

            Console.WriteLine();
            Console.WriteLine("Encrypted text:");
            Console.WriteLine(encrypted);

            Console.WriteLine("\nPress Enter to return to the menu...");
            Console.ReadLine();
            Console.Clear();
            Crypto();
        }
        public static string CaesarCipher(string text, int shift)
        {
            char[] result = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];

                if (char.IsLetter(c))
                {
                    char start = char.IsUpper(c) ? 'A' : 'a';

                    result[i] = (char)(((c - start + shift) % 26 + 26) % 26 + start);
                }
                else
                {
                    result[i] = c;
                }
            }

            return new string(result);
        }
        public static void CryptoAffine()
        {

        }
        public static void CryptoBrute()
        {

        }
        public static void Mat()
        {
            Console.WriteLine("What process would you like to do");
            Console.WriteLine();
            Console.WriteLine("1. 2x2 Matrices");
            Console.WriteLine("2. Functions");
            Console.WriteLine("3. Dot Product");
            Console.WriteLine("4. Scalar Multiplication");
            Console.WriteLine("5. Determinant/Inverse");
            Console.WriteLine("6. Exit");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.Clear();
                    Mat2x2();
                    break;
                case 2:
                    Console.Clear();
                    MatFunction();
                    break;
                case 3:
                    Console.Clear();
                    MatDot();
                    break;
                case 4:
                    MatScalar();
                    break;
                case 5:
                    MatDetInv();
                    break;
                case 6:
                    Console.Clear();
                    Main();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    Console.ReadLine();
                    Console.Clear();
                    Mat();
                    break;
            }
        }
        public static void Mat2x2()
        {

        }
        public static void MatFunction()
        {

        }
        public static void MatDot()
        {

        }
        public static void MatScalar()
        {

        }
        public static void MatDetInv()
        {

        }
        public static void Calc()
        {
            Console.WriteLine("Enter Equation");
            string input;
            bool on = true;
            while (on)
            {
                input = (Console.ReadLine());
                if (input == "exit")
                {
                    on = false;
                }
                else
                {
                    int input2 = Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.Clear();
            Main();
        }
    }
}
