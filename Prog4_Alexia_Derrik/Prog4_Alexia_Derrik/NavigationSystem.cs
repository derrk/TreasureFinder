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
        //
        public static int guessRow, guessColumn;
       

        public NavigationSystem(int userRows, int userColumns)
        {
            Random randomNumber = new Random();
            // generate random location for island
            int islandCol = randomNumber.Next(0, userColumns);
            int islandRow = randomNumber.Next(0, userRows);
            // user guesses count
            int guessCount = 0;

            char Mapper = GenerateMap(mapper, gameMap, islandRow, islandCol);
            PrintMap(gameMap);
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
                        char islLoc = mapper[i, j];
                    }   else
                    {
                        mapper[i, j] = '~';
                    }
                }
            }
            return mapper[userRows,userColumns];
        }


        public static string PrintMap(char[,]? gameMap)
        {
           // char[,] gameMap = new char[userRows, userColumns];
            //char text;
            String text = "";
            for (int i = 0; i < userRows + 1; i++)
            {
               
                for(int j = 0; j < userColumns; j++)
                {
                    if (i == 0)
                    {
                        text = text + "  ";
                        for (i = 0; i < userColumns; i++)
                        {
                            text = text + i + " ";
                        }
                        text = text + "\n" + 0;
                        i = 1;
                    }

                    gameMap[i, j] = '~';

                
                    text = text + gameMap[i,j];
                    
                }
                if (i < userColumns - 1)
                {
                    text = text + "\n" + i;
                }

                
            }
            return text;
            // gameMap[userRows,userColumns];
        }

        public char EvaluateGuess(int guessRow, int guessCol, int IslandRow, int IslandCol)
        {
            if (mapper[guessRow, guessCol] == '~')
            {
                if (guessRow < IslandRow && guessRow != 0 && guessRow != userRows)
                {
                    return 'N';
                }
                else if (guessRow > IslandRow && guessRow != 0 && guessRow != userRows)
                {
                    return 'S';
                }
                else if (guessCol < IslandCol && guessCol != 0 && guessCol != userColumns)
                {
                    return 'E';
                }
                else if (guessCol > IslandCol && guessCol != 0 && guessCol != userColumns)
                {
                    return 'W';
                }
            }
            else if (mapper[guessRow, guessCol] == 'I')
            {
                return 'I';
            }
          
                return '~';
                   
        }






    }
}
