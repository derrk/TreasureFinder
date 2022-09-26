using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4_Alexia_Derrik
{
    internal class NavigationSystem
    {   
        // establish number of rows and columns in the system
        public static int userRows = 5;
        public static int userColumns = 9;

        // add nav system map
        public char[,] mapper = new char[userRows, userColumns];
        public char[,] gameMap = new char[userRows, userColumns];

       
        public NavigationSystem()
        {
            Random randomNumber = new Random();
            // generate random location for island
            int islandCol = randomNumber.Next(0, userColumns);
            int islandRow = randomNumber.Next(0, userRows);

            GenerateMap(mapper, gameMap, islandRow, islandCol);
        }

        public void GenerateMap(char[,] mapper, char[,] gameMap, int x, int y)
        {
            for (int i = 0; i < userRows; i++)
            {
                for (int j = 0; j < userColumns; j++)
                {
                    gameMap[i, j] = '~';
                    if (mapper[i, j] == mapper[x, y])
                    {
                        mapper[i, j] = 'I';
                    }   else
                    {
                        mapper[i, j] = '~';
                    }
                }
            }
        }






    }
}
