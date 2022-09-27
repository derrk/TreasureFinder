using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Prog4_Alexia_Derrik.NavigationSystem;

namespace Prog4_Alexia_Derrik
{



    public partial class FindTheIslandGame : Form
    {
        public FindTheIslandGame()
        {
            InitializeComponent();
           
        }

    
        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkValues(object sender, EventArgs e)
        {
            NavigationSystem.guessRow = int.Parse(userGuessRows.Text); 
            NavigationSystem.guessColumn = int.Parse(userGuessColumns.Text);
        }

        public void createMap_Click(object sender, EventArgs e)
        {
           

            if (mapSizeRows != null && mapSizeColumns != null)
            {
                createMap.IsAccessible = false;
                // when user clicks on create map button, the values entered are assigned to the navsystem vars for the map size
                NavigationSystem.userRows = Int32.Parse(mapSizeRows.Text);
                NavigationSystem.userColumns = Int32.Parse(mapSizeColumns.Text);

                char[,] printout = new char[Int32.Parse(mapSizeRows.Text + 1), Int32.Parse(mapSizeColumns.Text + 1)];

                //for (int i = 0; i < NavigationSystem.userColumns; i++)
                //{
                //    for (int j = 0; j < NavigationSystem.userRows; j++)
                //    {
                //        printout[i, j] = '~';
                //        Console.Write(printout[i, j]);
                //    }
                //    Console.Write("\n");
                //}

                //NavigationSystem navigationSystem = new NavigationSystem(userRows, userColumns);

              
                MapTextBox.Text = PrintMap(printout);
                //MapTextBox.Text = NavigationSystem.;

            }
            //var instance = new NavigationSystem(Int32.Parse(mapSizeRows.Text), Int32.Parse(mapSizeColumns.Text));
            
        }
    }


}
