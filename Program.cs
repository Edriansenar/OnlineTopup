using System;
using System.ComponentModel.Design;

namespace OnlineTopup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Online Game Topup");

            int passWord = 12345;

            Console.WriteLine("Enter UserName: ");

            Console.ReadLine();

            Console.WriteLine("Enter Password: ");
            int pass = Convert.ToInt16(Console.ReadLine());

            if (passWord == pass)
            {
                Console.WriteLine("Success Login!");

                Console.WriteLine("What game would you like to topup?");

                string[] choices = new string[] { "[1] Mobile Legends ", "[2] League Of Legends", "[3] Honor of Kings", "[4] Call of Duty", "[5] Teamfight Tactics", "[6] Exit." };

                Console.WriteLine("TOPUP:");

                foreach (var topup in choices)
                {
                    Console.WriteLine(topup);

                }
                Console.WriteLine("Enter topup:");

                int userChoice = Convert.ToInt16(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("How much do you want to topup?");
                        string[] mltopup = new string[] { "[1] 50 Diamonds ", "[2] 100 Diamonds", "[3] 500 Diamonds", "[4] 5,000 Diamonds", "[5] 10,000 Diamonds" };

                        Console.WriteLine("Enter Topup:");

                        foreach (var topup1 in mltopup)
                        {
                            Console.WriteLine(topup1);

                        }

                        int mlChoice = Convert.ToInt16(Console.ReadLine());

                        switch (mlChoice)
                        {
                            case 1:
                                Console.WriteLine("Thank you for purchasing 50 Diamonds");
                                break;
                            case 2:
                                Console.WriteLine("Thank you for purchasing 100 Diamonds");
                                break;
                            case 3:
                                Console.WriteLine("Thank you for purchasing 500 Diamonds");
                                break;
                            case 4:
                                Console.WriteLine("Thank you for purchasing 5,000 Diamonds");
                                break;
                            case 5:
                                Console.WriteLine("Thank you for purchasing 10,000 Diamonds");
                                break;
                        }

                        break;
                    case 2:
                        Console.WriteLine("How much do you want to topup?");
                        string[] loltopup = new string[] { "[1] 50 RP ", "[2] 100 RP", "[3] 500 RP", "[4] 5,000 RP", "[5] 10,000 RP" };

                        Console.WriteLine("Enter Topup:");

                        foreach (var topup2 in loltopup)
                        {
                            Console.WriteLine(topup2);

                        }

                        int lolChoice = Convert.ToInt16(Console.ReadLine());

                        switch (lolChoice)
                        {
                            case 1:
                                Console.WriteLine("Thank you for purchasing 50 RP");
                                break;
                            case 2:
                                Console.WriteLine("Thank you for purchasing 100 RP");
                                break;
                            case 3:
                                Console.WriteLine("Thank you for purchasing 500 RP");
                                break;
                            case 4:
                                Console.WriteLine("Thank you for purchasing 5,000 RP");
                                break;
                            case 5:
                                Console.WriteLine("Thank you for purchasing 10,000 RP");
                                break;
                        }

                        break;
                    case 3:
                        Console.WriteLine("How much do you want to topup?");
                        string[] hoktopup = new string[] { "[1] 50 Tokens ", "[2] 100 Tokens", "[3] 500 Tokens", "[4] 5,000 Tokens", "[5] 10,000 Tokens" };

                        Console.WriteLine("Enter Topup:");

                        foreach (var topup3 in hoktopup)
                        {
                            Console.WriteLine(topup3);

                        }

                        int hokChoice = Convert.ToInt16(Console.ReadLine());

                        switch (hokChoice)
                        {
                            case 1:
                                Console.WriteLine("Thank you for purchasing 50 Tokens");
                                break;
                            case 2:
                                Console.WriteLine("Thank you for purchasing 100 Tokens");
                                break;
                            case 3:
                                Console.WriteLine("Thank you for purchasing 500 Tokens");
                                break;
                            case 4:
                                Console.WriteLine("Thank you for purchasing 5,000 Tokens");
                                break;
                            case 5:
                                Console.WriteLine("Thank you for purchasing 10,000 Tokens");
                                break;
                        }

                        break;
                    case 4:
                        Console.WriteLine("How much do you want to topup?");
                        string[] codtopup = new string[] { "[1] 50 Garena Shells ", "[2] 100 Garena Shells", "[3] 500 Garena Shells", "[4] 5,000 Garena Shells", "[5] 10,000 Garen Shells" };

                        Console.WriteLine("Enter Topup:");

                        foreach (var topup4 in codtopup)
                        {
                            Console.WriteLine(topup4);

                        }

                        int codChoice = Convert.ToInt16(Console.ReadLine());

                        switch (codChoice)
                        {
                            case 1:
                                Console.WriteLine("Thank you for purchasing 50 Garena Shells");
                                break;
                            case 2:
                                Console.WriteLine("Thank you for purchasing 100 Garena Shells");
                                break;
                            case 3:
                                Console.WriteLine("Thank you for purchasing 500 Garena Shells");
                                break;
                            case 4:
                                Console.WriteLine("Thank you for purchasing 5,000 Garena Shells");
                                break;
                            case 5:
                                Console.WriteLine("Thank you for purchasing 10,000 Garena Shells");
                                break;
                        }

                        break;
                    case 5:
                        Console.WriteLine("How much do you want to topup?");
                        string[] tfttopup = new string[] { "[1] 50 RP ", "[2] 100 RP", "[3] 500 RP", "[4] 5,000 RP", "[5] 10,000 RP" };

                        Console.WriteLine("Enter Topup:");

                        foreach (var topup5 in tfttopup)
                        {
                            Console.WriteLine(topup5);

                        }

                        int tftChoice = Convert.ToInt16(Console.ReadLine());

                        switch (tftChoice)
                        {
                            case 1:
                                Console.WriteLine("Thank you for purchasing 50 RP");
                                break;
                            case 2:
                                Console.WriteLine("Thank you for purchasing 100 RP");
                                break;
                            case 3:
                                Console.WriteLine("Thank you for purchasing 500 RP");
                                break;
                            case 4:
                                Console.WriteLine("Thank you for purchasing 5,000 RP");
                                break;
                            case 5:
                                Console.WriteLine("Thank you for purchasing 10,000 RP");
                                break;
                        }
                        break;

                    default:
                        break;
                }

            }
            else
            {
                Console.WriteLine("Incorrect Password. Try again.");
            }
            }
        }

        }
    
