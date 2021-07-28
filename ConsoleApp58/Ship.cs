using System;

namespace wow
{
    class Ship
    {
        static Random random = new Random();
        public Ship() { }
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
                    if (map[x, y] >= '0' || map[x, y + 1] >= '0' || map[x, y - 1] >= '0' ||
                     map[x + 1, y] >= '0' || map[x + 1, y + 1] >= '0' || map[x + 1, y - 1] >= '0' ||
                     map[x - 1, y] >= '0' || map[x - 1, y + 1] >= '0' || map[x - 1, y - 1] >= '0' )
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
}
