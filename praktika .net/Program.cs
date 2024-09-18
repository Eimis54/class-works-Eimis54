using System;
using System.Security.Cryptography;

class Program
{
    // 1 užduotis.
    //    static void SetConsoleColor(string color)
    //    {
    //        if (color == "green")
    //            Console.ForegroundColor = ConsoleColor.Green;
    //        else if (color == "red")
    //            Console.ForegroundColor = ConsoleColor.Red;
    //        else
    //            Console.ResetColor();
    //    }

    //    static void Main(string[] args)
    //    {
    //        Console.Write("Įveskite skaičių: ");
    //        string input = Console.ReadLine();

    //        try
    //        {
    //            int number = int.Parse(input);

    //            if (number % 2 == 0)
    //            {
    //                SetConsoleColor("green");
    //                Console.WriteLine($"{number} yra lyginis.");
    //            }
    //            else
    //            {
    //                SetConsoleColor("green");
    //                Console.WriteLine($"{number} yra nelyginis.");
    //            }
    //        }
    //        catch (FormatException)
    //        {
    //            SetConsoleColor("red");
    //            Console.WriteLine("Klaida: neteisinga įvestis. Naudokite skaičių");
    //        }
    //        finally
    //        {
    //            SetConsoleColor("default");
    //        }
    //    }
    // 2 užduotis.
    //static void Main(string[] args)
    //{
    //    Console.Write("Įveskite skaičių: ");
    //    string input = Console.ReadLine();

    //    try
    //    {
    //        int number = int.Parse(input);

    //        switch (number)
    //        {
    //            case 1:
    //                Console.WriteLine("Žiema");
    //                break;
    //            case 2:
    //                Console.WriteLine("Žiema");
    //                break;
    //            case 3:
    //                Console.WriteLine("Pavasaris");
    //                break;
    //            case 4:
    //                Console.WriteLine("Pavasaris");
    //                break;
    //            case 5:
    //                Console.WriteLine("Pavasaris");
    //                break;
    //            case 6:
    //                Console.WriteLine("Vasara");
    //                break;
    //            case 7:
    //                Console.WriteLine("Vasara");
    //                break;
    //            case 8:
    //                Console.WriteLine("Vasara");
    //                break;
    //            case 9:
    //                Console.WriteLine("Ruduo");
    //                break;
    //            case 10:
    //                Console.WriteLine("Ruduo");
    //                break;
    //            case 11:
    //                Console.WriteLine("Ruduo");
    //                break;
    //            case 12:
    //                Console.WriteLine("Žiema");
    //                break;
    //            default:
    //                Console.WriteLine("Nėra tokio mėnesio");
    //                break;
    //        }
    //    }
    //    catch (FormatException)
    //    {
    //        Console.WriteLine("Klaida: neteisinga įvestis. Naudokite skaičių");
    //    }
    //}
    //3 užduotis.
    //static void Main()
    //{
    //    const int n = 1551;

    //    string numberStr = n.ToString();

    //    int firstDigit = int.Parse(numberStr[0].ToString());
    //    int secondDigit = int.Parse(numberStr[1].ToString());
    //    int thirdDigit = int.Parse(numberStr[2].ToString());
    //    int lastDigit = int.Parse(numberStr[3].ToString());

    //    int product = firstDigit * lastDigit;

    //    int sum = secondDigit + thirdDigit;

    //    if (product >= sum)
    //    {
    //        Console.WriteLine($"Pateikto keturženklio skaičiaus pirmojo ir paskutinio skaičiaus sandauga ({product}) yra didesne arba lygi antrojo ir trečiojo skaičiaus sumai ({sum}).");
    //    }
    //    else
    //    {
    //        Console.WriteLine($"Pateiktojo keturženklio skaičiaus pirmojo ir paskutinio skaičiaus sandauga ({product}) yra mažesnė už antrojo ir trečiojo skaičiaus sumą  ({sum}).");
    //    }
    //}
    //4 užduotis
    //static void Main()
    //{
    //    try
    //    {
    //        int i, number, fakt = 1;
    //        Console.WriteLine("Irasykite skaiciu, kuriam norite atrasti faktoriala: ");
    //        number = int.Parse(Console.ReadLine());
    //        for (i = 1; i <= number; i++)
    //        {
    //            fakt = fakt * i;
    //        }
    //        Console.WriteLine("Skaičiaus " + number + " faktorialas yra " + fakt);
    //    }
    //    catch (FormatException)
    //    {
    //        Console.WriteLine("Klaida: Neteisinga įvestis. Įveskite skaičių");
    //    }
    //}
    // 5 užduotis
//    static void Main()
//    {
//        try
//        {
//            Console.WriteLine("Įrašykite skaičių ir sužinosite skaičiaus ilgį: ");
//            long num = long.Parse(Console.ReadLine());

//            string numStr = num.ToString();
//            Console.WriteLine("Nurodyto skaičiaus ilgis yra: " + numStr.Length);

//            string reversedStr = ReverseString(numStr);
//            long reversedNum = long.Parse(reversedStr);

//            Console.WriteLine("Atitikmuo: " + reversedNum);
//        }
//        catch (FormatException)
//        {
//            Console.WriteLine("Klaida: Neteisinga įvestis. Įveskite skaičių");
//        }
//    }
//    static string ReverseString(string input)
//    {
//        char[] charArray = input.ToCharArray();
//        Array.Reverse(charArray);
//        return new string(charArray);
//    }
//}
    //6 užduotis
    //    static void Main()
    //    {
    //        try
    //        {
    //            int a, b;
    //            Console.WriteLine("Įveskite a ir b skaičius (a <= b), kad būtų suskaičiuotas jų suma ir vidurkis iš jų diapozono:");
    //            Console.Write("Įveskite a skaičių: ");
    //            a = int.Parse(Console.ReadLine());
    //            Console.Write("Įveskite b skaičių: ");
    //            b = int.Parse(Console.ReadLine());

    //            if (a > b)
    //            {
    //                Console.WriteLine("Klaida: a turi būti mažesnis arba lygus b.");
    //                return;
    //            }

    //            int suma = 0;
    //            int count = 0;

    //            for (int i = a; i <= b; i++)
    //            {
    //                suma += i;
    //                count++;
    //            }

    //            double vidurkis = (double)suma / count;

    //            Console.WriteLine("Suma: " + suma);
    //            Console.WriteLine("Vidurkis: " + vidurkis);
    //        }
    //        catch (FormatException)
    //        {
    //            Console.WriteLine("Klaida: Neteisinga įvestis. Įveskite skaičių.");
    //        }
    //    }
    //}
    // 7 užduotis
//    public static bool IsSymmetrical(int number)
//    {
//        string original = number.ToString();
//        string reversed = ReverseString(original);

//        return original == reversed;
//    }

//    public static bool IsSymmetrical(string number)
//    {
//        string reversed = ReverseString(number);

//        return number == reversed;
//    }

//    private static string ReverseString(string input)
//    {
//        char[] charArray = input.ToCharArray();
//        Array.Reverse(charArray);
//        return new string(charArray);
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("IsSymmetrical(7227)  ➔  " + IsSymmetrical(7227));
//        Console.WriteLine("IsSymmetrical(12567) ➔  " + IsSymmetrical(12567));
//        Console.WriteLine("IsSymmetrical(44444444) ➔  " + IsSymmetrical(44444444));
//        Console.WriteLine("IsSymmetrical(9393) ➔  " + IsSymmetrical(9393));

//        Console.WriteLine("IsSymmetrical(\"12321\") ➔  " + IsSymmetrical("12321"));
//    }
//}
