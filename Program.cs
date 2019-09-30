using System;

namespace Light
{
    class Program
    {
        static void Main(string[] args)
        {
            int computerPlayer = 100;
            int personPlayer = 100;
            Console.WriteLine("Now two players have 100 pointes");
            while (computerPlayer > 0 && personPlayer >0)
            {
                Random x = new Random(); // выбор игрока чей ход будет следующим
                int n = x.Next(2);
                //Console.WriteLine(n);
                if (n == 0)
                {
                    Console.WriteLine("First player's step");
                    Random y = new Random();  //выбор хода
                    int i = y.Next(3);
                    switch (i)
                    {
                        case 0:
                            Console.WriteLine("First step: low damage from 18 to 25");
                            Random z = new Random(); // генерация диапазона урона 
                            int j = z.Next(18, 26);
                            computerPlayer = computerPlayer - j;
                            Console.WriteLine("Now first player has: ");
                            Console.WriteLine(computerPlayer);
                            break;
                        case 1:
                            Console.WriteLine("Second step: bigger damage from 10 to 35");
                            Random k = new Random();
                            int m = k.Next(10, 36);
                            computerPlayer = computerPlayer - m;
                            Console.WriteLine("Now first player has: ");
                            Console.WriteLine(computerPlayer);
                            break;
                        case 2:
                            Console.WriteLine("Third step: healing from 18 to 25");
                            Random l = new Random();
                            int p = l.Next(18, 26);
                            computerPlayer = computerPlayer + p;
                            Console.WriteLine("Now first player has: ");
                            Console.WriteLine(computerPlayer);
                            break;

                        default:
                            Console.WriteLine("Error");
                            break;
                    }
                    Console.ReadKey();
                }


                else
                {
                    Console.WriteLine("Second player's step");
                    Random y = new Random();
                    int i = y.Next(3);
                    switch (i)
                    {
                        case 0:
                            Console.WriteLine("First step: low damage from 18 to 25");
                            Random z = new Random();
                            int j = z.Next(18, 26);
                            personPlayer = personPlayer - j;
                            Console.WriteLine("Now second player has: ");
                            Console.WriteLine(personPlayer);
                            break;
                        case 1:
                            Console.WriteLine("Second step: bigger damage from 10 to 35");
                            Random k = new Random();
                            int m = k.Next(10, 36);
                            personPlayer = personPlayer - m;
                            Console.WriteLine("Now second player has: ");
                            Console.WriteLine(personPlayer);
                            break;
                        case 2:
                            Console.WriteLine("Third step: healing from 18 to 25");
                            Random l = new Random();
                            int p = l.Next(18, 26);
                            personPlayer = personPlayer + p;
                            Console.WriteLine("Now second player has: ");
                            Console.WriteLine(personPlayer);
                            break;

                        default:
                            Console.WriteLine("Error");
                            break;
                    }
                    Console.WriteLine("Press enter to continue");
                    Console.ReadKey();

                }
                
            }

            Console.WriteLine("Game is over");



            Console.ReadLine();
        }
    }
}
