using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog4_Alexia_Derrik
{
    public partial class NavigationSystem
    {   
        // establish number of rows and columns in the system
        public static int userRows = 5;
        public static int userColumns = 9;

        // add nav system map
        public char[,] mapper = new char[userRows, userColumns];
        public char[,] gameMap = new char[userRows, userColumns];
        // char to send to main class to print the char at current index
        public char text;
        // map print
        public string mapPrint = PrintMap(null);
       

        public NavigationSystem(int userRows, int userColumns)
        {
            Random randomNumber = new Random();
            // generate random location for island
            int islandCol = randomNumber.Next(0, userColumns);
            int islandRow = randomNumber.Next(0, userRows);
            // user guesses count
            int guessCount = 0;

            char Mapper = GenerateMap(mapper, gameMap, islandRow, islandCol);
            //String mapPrint = PrintMap(gameMap);
        }


        public char GenerateMap(char[,] mapper, char[,] gameMap, int x, int y)
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
            return gameMap[userRows,userColumns];
        }

        public static String PrintMap(char[,]? gameMap)
        {
           // char[,] gameMap = new char[userRows, userColumns];
            //char text;
            String text = "";
            for (int i = 0; i < userRows; i++)
            {
                for(int j = 0; j < userColumns; j++)
                {
                    
                    text += gameMap[i, j];
                    if (j == userColumns - 1)
                    {
                        return text;
                    }
                }
                return "\n";
                text = "";
            }
            return "";
        }






    }
}
