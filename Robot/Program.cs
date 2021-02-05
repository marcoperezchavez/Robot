using System;

namespace Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            string direction = "FFRFLFLF";
            string size = "5x5";
            int sizeX = Convert.ToInt32(size[0]);
            int sizeY = Convert.ToInt32(size[2]);
            GetDirection(direction.ToUpper(), sizeX, sizeY);
            //1,4,West
        }

        public static void GetDirection(string direction, int sizeX, int sizeY)
        {
            string route = "";
            int x = 1;
            int y = 1;

            foreach (var d in direction)
            {
                switch (d.ToString())
                {
                    case "F":
                        if (route == "")
                        {
                            route = "north";
                            y++;
                        }
                        else if (route == "north")
                        {
                            if (sizeY > y) y++;

                        }
                        else if (route == "west")
                        {
                            if (1 < x) x--;

                        }
                        else if (route == "south")
                        {
                            if (1 < y) y--;
                        }
                        else if (route == "east")
                        {
                            if (sizeX > x) x++;
                        }
                        break;
                    case "R":
                    case "L":
                        if (route == "north")
                        {
                            if (d.ToString() == "R")
                            {
                                route = "east";
                            }
                            else
                            {
                                route = "west";
                            }

                        }
                        else if (route == "west")
                        {
                            if (d.ToString() == "R")
                            {
                                route = "north";
                            }
                            else
                            {
                                route = "south";
                            }
                        }
                        else if (route == "south")
                        {
                            if (d.ToString() == "R")
                            {
                                route = "west";
                            }
                            else
                            {
                                route = "east";
                            }
                        }
                        else if (route == "east")
                        {
                            if (d.ToString() == "R")
                            {
                                route = "south";
                            }
                            else
                            {
                                route = "north";
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"{x},{y},{route}");
            Console.ReadLine();
        }
    }
}
