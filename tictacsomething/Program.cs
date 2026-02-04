using System;

namespace tictacsomething;

class Program
{
    static void Main(string[] args)
    {
        
        int[,] maze = 
        {
            { 0, 0, 0 },
            { 0, 0, 0 },
            { 0, 0, 0 }
        };

        DisplayMap(maze);

        while (true)
        {
            Console.WriteLine("Enter a number (1 - 9 ): ");
            string userinput = Console.ReadLine();

            int.TryParse(userinput, out int useroutput);
            
            switch (useroutput)
            {
                case 1:
                    maze[0, 0] = 8;
                    break;
                case 2:
                    maze[0, 1] = 8;
                    break;
                case 3:
                    maze[0, 2] = 8;
                    break;
                case 4:
                    maze[1, 0] = 8;
                    break;
                case 5:
                    maze[1, 1] = 8;
                    break;
                case 6:
                    maze[1, 2] = 8;
                    break;
                case 7:
                    maze[2, 0] = 8;
                    break;
                case 8:
                    maze[2, 1] = 8;
                    break;
                case 9:
                    maze[2, 2] = 8;
                    break;
                default:
                    Console.WriteLine("Enter a valid number...");
                    break;
            }
        
            DisplayMap(maze);
            CheckMaze(maze);
        }
    }
    
    //functions
    
    static void CheckMaze(int[,] maze)
    {
        //checking rows
        for (int i = 0; i < 3; i++)
        {
            if (maze[i, 0] == 8 && maze[i,1] == 8 && maze[i,2] == 8)
            {
                Console.WriteLine("All 8's");
            }
        }
        
        for (int i = 0; i < 3; i++)
        {
            if (maze[0, i] == 8 && maze[1,i] == 8 && maze[2,i] == 8)
            {
                Console.WriteLine("All 8's");
            }
        }

        if (maze[0, 0] == 8 && maze[1, 1] == 8 && maze[2, 2] == 8)
        {
            Console.WriteLine("All 8's");

        }
        
        if (maze[0, 2] == 8 && maze[1, 1] == 8 && maze[2, 0] == 8)
        {
            Console.WriteLine("All 8's");

        }
        
    }

    static void DisplayMap(int[,] maze)
    {
        
        for (int i = 0; i < 3; i++)
        {
            for (int x = 0; x < 3; x++)
            {
                Console.Write(maze[i,x]);
            }
            Console.WriteLine();
        }
        
    }
}