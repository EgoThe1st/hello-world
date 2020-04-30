using System;

namespace Madaras_homework
{
    class Homework
    {
        static void Main(string[] args)
        {
            string variants = "";
            while (variants != "0")
            {
                Console.WriteLine("Please choose your desired action and press enter! \n" +
                "1. A greeting \n" +
                "2. Combine strings \n" +
                "3. Find the largest number of three \n" +
                "4. Switch the value of two numbers \n" +
                "5. Find the largest number of two \n" +
                "6. Find out is a number even or odd \n" +
                "7. Ievadit skaitlus un izvadit lielako \n" +
                "8. Ievadit 10 skaitlus un noteikt pozitivos, negativos un 0 \n" +
                "9. Printet zvaigznites \n" +
                "10. Ievadit bezgaligi daudz skaitlus un izvadit lielako un mazako \n" +
                "11. Megini uzminet skaitli starp 1 un 10 \n" +
                "12. Kapinat skaitli \n" +
                "13. Uzzimet skaitlu piramidu \n" +
                "0. End the program");
                variants = Console.ReadLine();
                switch (variants)
                {
                    case ("1"):
                        Vards();
                        break;
                    case ("2"):
                        Teikums();
                        break;
                    case ("3"):
                        LielakaisNoTris();
                        break;
                    case ("4"):
                        MainaVietam();
                        break;
                    case ("5"):
                        {
                            Console.WriteLine("Please insert first integer for comparison");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Please insert second integer for comparison");
                            int b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Largest integer was " + LielakaisNoDiviem(a, b));
                            break;
                        }
                    case ("6"):
                        {
                            Console.WriteLine("Please insert a number");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Your inserted number was even: " + ParaNepara(a));
                            break;
                        }
                    case ("7"):
                        Console.WriteLine("Lielakais skaitlis bija " + LielakaisNoPieciem());
                        break;
                    case ("8"):
                        PozitiviNegativiNulle();
                        break;
                    case ("9"):
                        Zvaigznites();
                        break;
                    case ("10"):
                        {
                            Console.WriteLine("To use for loop press 1. To use while loop press 2");
                            string subVariants = Console.ReadLine();
                            switch (subVariants)
                            {
                                case ("1"):
                                    BezgaligiSkaitliFor();
                                    break;
                                case ("2"):
                                    BezgaligiSkaitliWhile();
                                    break;
                            }
                        }
                        break;
                    case ("11"):
                        MiniSkaitli();
                        break;
                    case ("12"):
                        Console.WriteLine("Ludzu ievadiet kapinamo un pakapi");
                        Console.WriteLine("Rezultats ir " + Kapinasana(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())));
                        break;
                    case ("13"):
                        Console.WriteLine("Ludzu ievadit lidz kadam skaitlim velaties veidot piramidu");
                        SkaitluPiramida(Convert.ToInt32(Console.ReadLine()));
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please input a valid option!");
                        break;
                }
            }
        }

        static void Vards()
        {
            Console.WriteLine("Please insert your name");
            String vards = Console.ReadLine();
            Console.WriteLine("Hello " + vards);
        }

        static void Teikums()
        {
            String teikums = "";
            for (int i = 1; i != 4; i++)
            {
                Console.WriteLine("Please insert the string #" + i);
                string teksts = Console.ReadLine();
                teikums = teikums + teksts;
            }
            Console.WriteLine(teikums);
        }

        static void LielakaisNoTris()
        {
            Console.WriteLine("Please insert an integer");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please insert another integer");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please insert third integer");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a < b)
                a = b;
            if (a < c)
                a = c;
            Console.WriteLine("Biggest number was " + a);
        }

        static void MainaVietam()
        {
            int a = 3;
            int b = 9;
            Console.WriteLine("a = " + a + " b = " + b);
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("a = " + a + " b = " + b);
        }

        static int LielakaisNoDiviem(int a, int b)
        {
            if (a < b)
                a = b;
            return a;
        }

        static bool ParaNepara(int a)
        {
            if (a % 2 == 0)
                return true;
            return false;
        }

        static int LielakaisNoPieciem()
        {
            int a, b;
            Console.WriteLine("Please insert the #1 number");
            a = Convert.ToInt32(Console.ReadLine());
            b = a;
            for (int i = 2; i < 6; i++)
            {
                Console.WriteLine("Please insert #" + i + " number");
                a = Convert.ToInt32(Console.ReadLine());
                if (b < a)
                    b = a;
            }
            return b;
        }

        static void PozitiviNegativiNulle()
        {
            int poz = 0, neg = 0, nulle = 0, a;
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("Please insert integer #" + i);
                a = Convert.ToInt32(Console.ReadLine());
                if (a > 0)
                    poz++;
                if (a < 0)
                    neg++;
                if (a == 0)
                    nulle++;
            }
            Console.WriteLine("There were " + poz + " positive numbers");
            Console.WriteLine("There were " + neg + " negative numbers");
            Console.WriteLine("There were " + nulle + " zeros");
        }

        static void Zvaigznites()
        {
            Console.WriteLine("If you wish your stars to increment insert 1. If you wish your stars to decrement, insert 2. If you wish your stars to increment and then decrement, insert 3.");
            String variants = Console.ReadLine();
            Console.WriteLine("Please insert how many stars would you like to have at the maximum amount of stars");
            int g = Convert.ToInt32(Console.ReadLine());
            switch (variants)
            {
                case ("1"):
                    for (int i = 0; i < g; i++)
                    {
                        for (int j = -1; j < i; j++)
                            Console.Write("*");
                        Console.WriteLine();
                    }
                    break;
                case ("2"):
                    for (int i = g; i > 0; i--)
                    {
                        for (int j = i; j > 0; j--)
                            Console.Write("*");
                        Console.WriteLine();
                    }
                    break;
                case ("3"):
                    for (int i = 0; i < g; i++)
                    {
                        for (int j = -1; j < i; j++)
                            Console.Write("*");
                        Console.WriteLine();
                    }
                    for (int i = g; i > 0; i--)
                    {
                        for (int j = i - 1; j > 0; j--)
                            Console.Write("*");
                        Console.WriteLine();
                    }
                    break;
                default:
                    return;
            }
        }

        static void BezgaligiSkaitliFor()
        {
            int max, min;
            string a;
            Console.WriteLine("Please insert numbers you wish to compare. If you wish to stop entering numbers write \"stop\"");
            for (a = Console.ReadLine(), max = Convert.ToInt32(a), min = max; a != "stop"; a = Console.ReadLine())
            {
                if (max < Convert.ToInt32(a))
                    max = Convert.ToInt32(a);
                if (min > Convert.ToInt32(a))
                    min = Convert.ToInt32(a);
            }
            Console.WriteLine("Lielakais skaitlis bija " + max + " Mazakais skaitlis bija " + min);
        }

        static void BezgaligiSkaitliWhile()
        {
            int max, min;
            string a;
            Console.WriteLine("Please insert numbers you wish to compare. If you wish to stop entering numbers write \"stop\"");
            a = Console.ReadLine();
            if (a == "stop")
            {
                Console.WriteLine("Sequence was stopped without any numbers being entered");
                return;
            }
            max = Convert.ToInt32(a);
            min = max;
            while (a != "stop")
            {
                if (max < Convert.ToInt32(a))
                    max = Convert.ToInt32(a);
                if (min > Convert.ToInt32(a))
                    min = Convert.ToInt32(a);
                a = Console.ReadLine();
            }
            Console.WriteLine("Lielakais skaitlis bija " + max + " Mazakais skaitlis bija " + min);
        }

        static void MiniSkaitli()
        {
            Random random = new Random();
            int cipars = random.Next(1, 10);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ludzu ievadi savu minejumu");
                int minejums = Convert.ToInt32(Console.ReadLine());
                if (minejums == cipars)
                {
                    Console.WriteLine("Tu uzmineji! Apsveicu ar uzvaru!");
                    return;
                }
                Console.WriteLine("Tu neuzmineji.");
            }
            Console.WriteLine("Tev neizdevas uzminet ar 5 meginajumiem. Tu zaudeji.");
        }

        static double Kapinasana(double a, double b)
        {
            double c = a;
            switch(b)
            {
                case double x when (b > 0):
                    for (int i = 1; i < b; i++)
                        c = c * a;
                    break;
                case double x when (b <= 0):
                    for (int i = 0; i >= b; i--)
                        c = c / a;
                    break;
            }
            return c;
        }

        static void SkaitluPiramida(int a)
        {
            for(int vieta = 1, rinda = 1; vieta <= a; rinda++)
            {
                for (int i = 1; i <= rinda && vieta <= a; vieta++, i++)
                    Console.Write(vieta + " ");
                Console.WriteLine();
            }

        }
    }
}







