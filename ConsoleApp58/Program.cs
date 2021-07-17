using System;
using System.Collections.Generic;
using System.Threading;
using System.Text.RegularExpressions;
namespace wow
{
    class ship
    {
        static Random random = new Random();
        public ship() { }
        public void filling(char[,] map, int ship_rate, int size, int ship_id1)
        {
            string ship3 = ship_id1.ToString();
            char[] ship0 = ship3.ToCharArray();
            int x, y;
            int direction = 0;
            int countShip = 0;
            int count_tact = 0;//счетчик
            while (countShip < size)
            {
                count_tact++;
                if (count_tact > 5000)
                {
                    break;
                }
                x = random.Next(1, 11);
                y = random.Next(1, 11);

                int temp_x = x;
                int temp_y = y;

                direction = random.Next(0, 4);
                char bar = '1';
                int v = bar - '0';
                bool set = true;

                for (int i = 0; i < ship_rate; i++)
                {
                    if (x < 0 || y < 0 || x > 10 || y > 10)
                    {
                        set = false;
                        break;
                    }
                    if (map[x, y] >= '1' || map[x, y + 1] >= '1' || map[x, y - 1] >= '1' ||
                     map[x + 1, y] >= '1' || map[x + 1, y + 1] >= '1' || map[x + 1, y - 1] >= '1' ||
                     map[x - 1, y] >= '1' || map[x - 1, y + 1] >= '1' || map[x - 1, y - 1] >= '1' || map[x, y] >= '2' || map[x, y + 1] >= '2' || map[x, y - 1] >= '2' ||
                     map[x + 1, y] >= '2' || map[x + 1, y + 1] >= '2' || map[x + 1, y - 1] >= '2' ||
                     map[x - 1, y] >= '2' || map[x - 1, y + 1] >= '2' || map[x - 1, y - 1] >= '2' || map[x, y] >= '3' || map[x, y + 1] >= '3' || map[x, y - 1] >= '3' ||
                     map[x + 1, y] >= '3' || map[x + 1, y + 1] >= '3' || map[x + 1, y - 1] >= '3' ||
                     map[x - 1, y] >= '3' || map[x - 1, y + 1] >= '3' || map[x - 1, y - 1] >= '3' || map[x, y] >= '4' || map[x, y + 1] >= '4' || map[x, y - 1] >= '4' ||
                     map[x + 1, y] >= '4' || map[x + 1, y + 1] >= '4' || map[x + 1, y - 1] >= '4' ||
                     map[x - 1, y] >= '4' || map[x - 1, y + 1] >= '4' || map[x - 1, y - 1] >= '4' || map[x, y] >= '5' || map[x, y + 1] >= '5' || map[x, y - 1] >= '5' ||
                     map[x + 1, y] >= '5' || map[x + 1, y + 1] >= '5' || map[x + 1, y - 1] >= '5' ||
                     map[x - 1, y] >= '5' || map[x - 1, y + 1] >= '5' || map[x - 1, y - 1] >= '5' || map[x, y] >= '6' || map[x, y + 1] >= '6' || map[x, y - 1] >= '6' ||
                     map[x + 1, y] >= '6' || map[x + 1, y + 1] >= '6' || map[x + 1, y - 1] >= '6' ||
                     map[x - 1, y] >= '6' || map[x - 1, y + 1] >= '6' || map[x - 1, y - 1] >= '6' || map[x, y] >= '7' || map[x, y + 1] >= '7' || map[x, y - 1] >= '7' ||
                     map[x + 1, y] >= '7' || map[x + 1, y + 1] >= '7' || map[x + 1, y - 1] >= '7' ||
                     map[x - 1, y] >= '7' || map[x - 1, y + 1] >= '7' || map[x - 1, y - 1] >= '7' || map[x, y] >= '8' || map[x, y + 1] >= '8' || map[x, y - 1] >= '8' ||
                     map[x + 1, y] >= '8' || map[x + 1, y + 1] >= '8' || map[x + 1, y - 1] >= '8' ||
                     map[x - 1, y] >= '8' || map[x - 1, y + 1] >= '8' || map[x - 1, y - 1] >= '8' || map[x, y] >= '9' || map[x, y + 1] >= '9' || map[x, y - 1] >= '9' ||
                     map[x + 1, y] >= '9' || map[x + 1, y + 1] >= '9' || map[x + 1, y - 1] >= '9' ||
                     map[x - 1, y] >= '9' || map[x - 1, y + 1] >= '9' || map[x - 1, y - 1] >= '9' || map[x, y] >= '0' || map[x, y + 1] >= '0' || map[x, y - 1] >= '0' ||
                     map[x + 1, y] >= '0' || map[x + 1, y + 1] >= '0' || map[x + 1, y - 1] >= '0' ||
                     map[x - 1, y] >= '0' || map[x - 1, y + 1] >= '0' || map[x - 1, y - 1] >= '0')
                    {
                        set = false;
                        break;
                    }
                    try
                    {
                        switch (direction)
                        {
                            case 0:
                                x++;
                                break;
                            case 1:
                                y++;
                                break;
                            case 2:
                                x--;
                                break;
                            case 3:
                                y--;
                                break;
                        }
                    }
                    catch (Exception)
                    {
                        set = false;
                        break;
                    }
                }
                if (set == true)
                {
                    x = temp_x;
                    y = temp_y;
                    for (int i = 0; i < ship_rate; i++)
                    {
                        map[x, y] = ship0[0];

                        switch (direction)
                        {
                            case 0:
                                x++;
                                break;
                            case 1:
                                y++;
                                break;
                            case 2:
                                x--;
                                break;
                            case 3:
                                y--;
                                break;
                        }
                    }
                    countShip++;
                }

            }
        }
    }
    //класс я 
    class Iam
    {
        public Iam() { }
        public char[,] arrangement(char[,] map)
        {
            int[] ships = { 4, 3, 3, 2, 2, 2, 1, 1, 1, 1 };
            //===========================================    
            for (int i = 0; i < ships.Length; i++)
            {
                ship ship1 = new ship();
                ship1.filling(map, ships[i], 1, i);
            }

            return map;
        }
    }
    class bot
    {
        public bot() { }
        public char[,] arrangement_bot(char[,] map)
        {
            int[] ships = { 4, 3, 3, 2, 2, 2, 1, 1, 1, 1 };
            for (int i = 0; i < ships.Length; i++)
            {
                ship ship1 = new ship();
                ship1.filling(map, ships[i], 1, i);
            }
            return map;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> word = new Dictionary<int, string>(10);
            word.Add(1, "A");
            word.Add(2, "B");
            word.Add(3, "C");
            word.Add(4, "D");
            word.Add(5, "E");
            word.Add(6, "F");
            word.Add(7, "G");
            word.Add(8, "H");
            word.Add(9, "I");
            word.Add(10, "J");
            Random random = new Random();
            int first__step = random.Next(0, 2), end_game = 0;//первый ход и выбор когда игра кончится или продолжится
            string name = null;//имя
            bool flag = true;//зациклить вайл
                             //массивы куда мы передадми значния с методов//массивы куда мы передадми значния с методов
            Console.WriteLine();
            char[] word_MAS = { 'A', 'B', 'C', 'D', 'I', 'F', 'G', 'H', 'I', 'J' };
            char[,] Array_human = {
                {'|', 'I','Z','З','U','V','S',']','Q','W','X', ' '},
                {'A', '-','-','-','-','-','-','-','-','-','-', ' '},
               {'B', '-','-','-','-','-','-','-','-','-','-', ' '},
               {'C', '-','-','-','-','-','-','-','-','-','-', ' '},
               {'D', '-','-','-','-','-','-','-','-','-','-', ' '},
               {'I', '-','-','-','-','-','-','-','-','-','-', ' '},
               {'F', '-','-','-','-','-','-','-','-','-','-', ' '},
               {'G', '-','-','-','-','-','-','-','-','-','-', ' '},
               {'H', '-','-','-','-','-','-','-','-','-','-', ' '},
               {'I', '-','-','-','-','-','-','-','-','-','-', ' '},
               {'J', '-','-','-','-','-','-','-','-','-','-', ' '},
            {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ' },
            };

            char[,] Array_bot =
            {
                {'|', 'I', 'Z' ,'З','U','V','T',']','Q','W','X', ' '},
                {word_MAS[0], ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
               {word_MAS[1], ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
               {word_MAS[2], ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
               {word_MAS[3], ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
               {word_MAS[4], ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
               {word_MAS[5], ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
               {word_MAS[6], ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
               {word_MAS[7], ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
               {word_MAS[8], ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
               {word_MAS[9], ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
               {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ' },
                };
            Console.WriteLine();
            Iam i = new Iam();
            bot Bot = new bot();
            char[,] my_map = i.arrangement(Array_human);
            Console.WriteLine();
            char[,] bot_map = Bot.arrangement_bot(Array_bot);
            char[,] copy_botMap = new char[Array_bot.GetLength(0), Array_bot.GetLength(1)];
            char[,] copy_mymap = new char[Array_human.GetLength(0), Array_human.GetLength(1)];
            Array.Copy(bot_map, copy_botMap, bot_map.Length);
            Array.Copy(my_map, copy_mymap, bot_map.Length);
            int life_me = 20;
            int life_bot = 20;
            //бросаем кубик==================================================
            if (first__step == 0)
            {
                name = "Вы";
                flag = false;
            }
            else if (first__step == 1)
            {
                name = "Жорик";
                flag = true;
            }
            //начало============================================================
            while (end_game == 0)
            {
                Console.Clear();
                Console.WriteLine($"                                Добро пожаловать в игру War ship. Игра находится в раннем доступе!");
                Console.WriteLine("         Ваше поле");
                Get_array(my_map);
                Console.WriteLine("\n   Поле противника");
                Get_array2(bot_map);
                //реализация игры игрока=========================================
                if (first__step == 0)
                {
                    name = "Игрок";
                    Console.WriteLine($"Играет {name}");
                    while (flag == false)
                    {
                        int y = 0;
                        char x = ' ';
                        char lower = ' ';
                        string letter = ""; //временная константа
                        int u = -1;
                        //==================                      
                        while (true)
                        {
                            Regex regex = new Regex(@"[A-Ja-j]");
                            try
                            {
                                Console.WriteLine("Введите кординату от A до J");
                                lower = char.Parse(Console.ReadLine());
                                letter = lower.ToString();
                                regex = new Regex(@"[A-Ja-j]");
                                if (!regex.IsMatch(letter))
                                {
                                    throw new Exception("Что-то странное ввели не понимаю");
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"{ex.Message}, повторите попытку");
                            }
                            if (regex.IsMatch(letter))
                            {
                                x = char.ToUpper(lower);
                                break;
                            }
                        }
                        //===============                                
                        Console.WriteLine("Введите кординату от 1 до 10");
                        while (true)
                        {
                            try
                            {
                                y = int.Parse(Console.ReadLine());
                                if (y < 1 || y > 10)
                                {
                                    throw new Exception("Интервал от 1 до 10");
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"{ex.Message}, повторите попытку");
                            }
                            if (y > 0 && y < 11)
                            {
                                Console.WriteLine("true");
                                break;
                            }
                        }


                        foreach (var item in word)
                        {
                            char[] c = item.Value.ToCharArray();
                            for (int t = 0; t < c.Length; t++)
                            {
                                u++;
                                if (x == c[t])
                                {
                                    if (copy_botMap[u + 1, y] == '0' || copy_botMap[u + 1, y] == '1' || copy_botMap[u + 1, y] == '2' || copy_botMap[u + 1, y] == '3'
                                       || copy_botMap[u + 1, y] == '4' || copy_botMap[u + 1, y] == '5' || copy_botMap[u + 1, y] == '6' || copy_botMap[u + 1, y] == '7'
                                       || copy_botMap[u + 1, y] == '7' || copy_botMap[u + 1, y] == '8' || copy_botMap[u + 1, y] == '9')
                                    {
                                        copy_botMap[u + 1, y] = '$';
                                        bot_map[u + 1, y] = '+';
                                        life_me--;
                                        Console.WriteLine($" попал в точку {word[u + 1]}:{y}, осталось жизней {life_me}");
                                        if (Get_death(bot_map, '0') == 0 || Get_death(bot_map, '2') == 0 || Get_death(bot_map, '1') == 0 || Get_death(bot_map, '3') == 0
                                             || Get_death(bot_map, '5') == 0 || Get_death(bot_map, '4') == 0 ||
                                            Get_death(bot_map, '6') == 0 || Get_death(bot_map, '9') == 0 ||
                                            Get_death(bot_map, '7') == 0 || Get_death(bot_map, '8') == 0)
                                        {
                                            Console.WriteLine("Корабль убит");
                                            bot_map[u + 1, y] = 'X';
                                        }
                                    }
                                    else if (copy_botMap[u + 1, y] == '$' || copy_botMap[u + 1, y] == ' ')
                                    {
                                        Console.WriteLine(u);
                                        Console.WriteLine($"{name} попал в точку {word[u + 1]}:{y}. {name} очень плохо играет, Жорик умнее , осталось жизней {life_me}");
                                        flag = true;
                                        copy_botMap[u + 1, y] = '*';
                                        bot_map[u + 1, y] = '*';
                                        first__step = 1;
                                    }
                                }
                            }
                        }

                        //выбор на какую позицию будет ходить игрок================                     
                        if (life_bot == 0)
                        {
                            break;
                        }
                        else if (life_me == 0)
                        {
                            break;
                        }
                    }
                }
                //реализация игры бота=========================================
                else if (first__step == 1)
                {
                    name = "Жорик";
                    Console.WriteLine($"Играет {name}");
                    while (flag == true)
                    {
                        Thread.Sleep(1000);
                        int x = random.Next(1, 11), y = random.Next(1, 11);
                        if (my_map[x, y] == '$')
                        {
                            while (true)
                            {
                                x = random.Next(1, 11);
                                y = random.Next(1, 11);
                                if (my_map[x, y] != '$')
                                {
                                    break;
                                }
                            }
                        }
                        //============================================================================
                        else if (my_map[x, y] == '5' || my_map[x, y] == '4' || my_map[x, y] == '3' || my_map[x, y] == '2')
                        {
                            Array_human[x, y] = '$';
                            life_bot--;
                            Console.WriteLine($"{name} попал в точку {word[x]}:{y}, осталось жизней {life_bot}");
                            //===================================================
                            if (my_map[x, y] == '$')
                            {
                                while (true)
                                {
                                    if (my_map[x + 1, y] == '5' || my_map[x + 1, y] == '4' || my_map[x + 1, y] == '3' || my_map[x + 1, y] == '2')
                                    {
                                        x++;
                                        Array_human[x, y] = '$';
                                        life_bot--;
                                        Console.WriteLine($"{name} попал в точку {word[x]}:{y}, осталось жизней {life_bot}");
                                    }
                                    else if (my_map[x - 1, y] == '5' || my_map[x - 1, y] == '4' || my_map[x - 1, y] == '3' || my_map[x - 1, y] == '2')
                                    {
                                        x--;
                                        Array_human[x, y] = '$';
                                        life_bot--;
                                        Console.WriteLine($"{name} попал в точку {word[x]}:{y}, осталось жизней {life_bot}");
                                    }
                                    else if (my_map[x, y + 1] == '5' || my_map[x, y + 1] == '4' || my_map[x, y + 1] == '3' || my_map[x, y + 1] == '2')
                                    {
                                        y++;
                                        Array_human[x, y] = '$';
                                        life_bot--;
                                        Console.WriteLine($"{name} попал в точку {word[x]}:{y}, осталось жизней {life_bot}");
                                    }
                                    else if (my_map[x, y - 1] == '5' || my_map[x, y - 1] == '4' || my_map[x, y - 1] == '3' || my_map[x, y - 1] == '2')
                                    {
                                        y--;
                                        Array_human[x, y] = '$';
                                        life_bot--;
                                        Console.WriteLine($"{name} попал в точку {word[x]}:{y}, осталось жизней {life_bot}");
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                            //===================================================
                        }

                        else if (my_map[x, y] == '$' || my_map[x, y] == '-')
                        {
                            my_map[x, y] = '*';
                            Console.WriteLine($"{name} попал в точку {word[x]}:{y}. {name} очень плохо играет, что промахнулся , осталось жизней {life_bot}");
                            flag = false;
                            first__step = 0;
                        }
                        else if (life_bot == 0)
                        {
                            break;
                        }
                        else if (life_me == 0)
                        {
                            break;
                        }
                    }
                }
                Console.WriteLine("0 - продолжить игру \n1 - завершить игру досрочно с проигрышем");

                end_game = int.Parse(Console.ReadLine());
            }
            Console.Read();
        }
        static void Get_array(char[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Get_array2(char[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == '5')
                        array[i, j] = ' ';
                    else if (array[i, j] == '4')
                        array[i, j] = ' ';
                    else if (array[i, j] == '3')
                        array[i, j] = ' ';
                    else if (array[i, j] == '2')
                        array[i, j] = ' ';
                    else if (array[i, j] == '1')
                        array[i, j] = ' ';
                    else if (array[i, j] == '0')
                        array[i, j] = ' ';
                    else if (array[i, j] == '6')
                        array[i, j] = ' ';
                    else if (array[i, j] == '7')
                        array[i, j] = ' ';
                    else if (array[i, j] == '8')
                        array[i, j] = ' ';
                    else if (array[i, j] == '9')
                        array[i, j] = ' ';
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static int Get_death(char[,] array, char c)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == c)
                    {
                        sum++;
                    }
                }
            }
            return sum;
        }
        static void Get_death_(char[,] array, char[,] array2, char lem)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == lem)
                    {
                        array2[i, j] = 'X';
                    }
                }
            }
        }
    }
}



