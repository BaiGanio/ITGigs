using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mini4ki
{
    public class Minesweeper
    {
        public class Rating
        {
            private string name;

            private int points;

            public string Player
            {
                get
                {
                    return this.name;
                }

                set
                {
                    this.name = value;
                }
            }

            public int PlayerPoints
            {
                get
                {
                    return this.points;
                }

                set
                {
                    this.points = value;
                }
            }

            public Rating()
            {
            }

            public Rating(string name, int points)
            {
                this.name = name;
                this.points = points;
            }
        }

        private static void Main()
        {
            string command = string.Empty;
            char[,] gameField = CreateGameField();
            char[,] bombs = DropBombs();
            int counter = 0;
            bool shoot = false;
            List<Rating> champions = new List<Rating>(6);
            int row = 0;
            int column = 0;
            bool flag = true;
            const int maxScore = 35;
            bool flag2 = false;

            do
            {
                if (flag)
                {
                    Console.WriteLine(
                        "Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki."
                        + " Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
                    dumpp(gameField);
                    flag = false;
                }

                Console.Write("Daj row i column : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) && int.TryParse(command[2].ToString(), out column)
                        && row <= gameField.GetLength(0) && column <= gameField.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        CurrentRating(champions);
                        break;
                    case "restart":
                        gameField = CreateGameField();
                        bombs = DropBombs();
                        dumpp(gameField);
                        shoot = false;
                        flag = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (bombs[row, column] != '*')
                        {
                            if (bombs[row, column] == '-')
                            {
                                tisinahod(gameField, bombs, row, column);
                                counter++;
                            }

                            if (maxScore == counter)
                            {
                                flag2 = true;
                            }
                            else
                            {
                                dumpp(gameField);
                            }
                        }
                        else
                        {
                            shoot = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nGreshka! nevalidna Komanda\n");
                        break;
                }

                if (shoot)
                {
                    dumpp(bombs);
                    Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " + "Daj si niknejm: ", counter);
                    string niknejm = Console.ReadLine();
                    Rating t = new Rating(niknejm, counter);
                    if (champions.Count < 5)
                    {
                        champions.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].kolko < t.kolko)
                            {
                                champions.Insert(i, t);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((Rating r1, Rating r2) => r2.igra4.CompareTo(r1.igra4));
                    champions.Sort((Rating r1, Rating r2) => r2.kolko.CompareTo(r1.kolko));
                    CurrentRating(champions);

                    gameField = CreateGameField();
                    bombs = DropBombs();
                    counter = 0;
                    shoot = false;
                    flag = true;
                }

                if (flag2)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
                    dumpp(bombs);
                    Console.WriteLine("Daj si imeto, batka: ");
                    string imeee = Console.ReadLine();
                    Rating to4kii = new Rating(imeee, counter);
                    champions.Add(to4kii);
                    CurrentRating(champions);
                    gameField = CreateGameField();
                    bombs = DropBombs();
                    counter = 0;
                    flag2 = false;
                    flag = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void CurrentRating(List<Rating> points)
        {
            Console.WriteLine("\nPoints:");
            if (points.Count > 0)
            {
                for (int i = 0; i < to4kii.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} boxes", i + 1, points[i].Player, points[i].PlayerPoints);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty rating!\n");
            }
        }

        private static void tisinahod(char[,] POLE, char[,] BOMBI, int row, int column)
        {
            char kolkoBombi = kolko(BOMBI, row, column);
            BOMBI[row, column] = kolkoBombi;
            POLE[row, column] = kolkoBombi;
        }

        private static void dumpp(char[,] board)
        {
            int RRR = board.GetLength(0);
            int KKK = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < RRR; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < KKK; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGameField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] DropBombs()
        {
            int Редове = 5;
            int Колони = 10;
            char[,] игрално_поле = new char[Редове, Колони];

            for (int i = 0; i < Редове; i++)
            {
                for (int j = 0; j < Колони; j++)
                {
                    игрално_поле[i, j] = '-';
                }
            }

            List<int> r3 = new List<int>();
            while (r3.Count < 15)
            {
                Random random = new Random();
                int asfd = random.Next(50);
                if (!r3.Contains(asfd))
                {
                    r3.Add(asfd);
                }
            }

            foreach (int i2 in r3)
            {
                int kol = i2 / Колони;
                int row = i2 % Колони;
                if (row == 0 && i2 != 0)
                {
                    kol--;
                    row = Колони;
                }
                else
                {
                    row++;
                }

                игрално_поле[kol, row - 1] = '*';
            }

            return игрално_поле;
        }

        private static void smetki(char[,] pole)
        {
            int kol = pole.GetLength(0);
            int row = pole.GetLength(1);

            for (int i = 0; i < kol; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (pole[i, j] != '*')
                    {
                        char kolkoo = kolko(pole, i, j);
                        pole[i, j] = kolkoo;
                    }
                }
            }
        }

        private static char kolko(char[,] r, int rr, int rrr)
        {
            int brojkata = 0;
            int rows = r.GetLength(0);
            int kols = r.GetLength(1);

            if (rr - 1 >= 0)
            {
                if (r[rr - 1, rrr] == '*')
                {
                    brojkata++;
                }
            }

            if (rr + 1 < rows)
            {
                if (r[rr + 1, rrr] == '*')
                {
                    brojkata++;
                }
            }

            if (rrr - 1 >= 0)
            {
                if (r[rr, rrr - 1] == '*')
                {
                    brojkata++;
                }
            }

            if (rrr + 1 < kols)
            {
                if (r[rr, rrr + 1] == '*')
                {
                    brojkata++;
                }
            }

            if ((rr - 1 >= 0) && (rrr - 1 >= 0))
            {
                if (r[rr - 1, rrr - 1] == '*')
                {
                    brojkata++;
                }
            }

            if ((rr - 1 >= 0) && (rrr + 1 < kols))
            {
                if (r[rr - 1, rrr + 1] == '*')
                {
                    brojkata++;
                }
            }

            if ((rr + 1 < rows) && (rrr - 1 >= 0))
            {
                if (r[rr + 1, rrr - 1] == '*')
                {
                    brojkata++;
                }
            }

            if ((rr + 1 < rows) && (rrr + 1 < kols))
            {
                if (r[rr + 1, rrr + 1] == '*')
                {
                    brojkata++;
                }
            }

            return char.Parse(brojkata.ToString());
        }
    }
}