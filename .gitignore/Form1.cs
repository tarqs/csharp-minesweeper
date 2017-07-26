using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Grid grid = new Minesweeper.Grid();
            InitializeComponent();
            this.AutoSize = false;
            this.Width = 420;
            this.Height = 420;

            for(int i=0; i < 7; i++)
            {
                for(int j = 0; j < 7; j++)
                {
                    this.Controls.Add(grid.griddy[i][j]);
                }
            }
        }


        // row 0 eventhandlers
        private void Cell1_Click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(1);
            this.grid.RevealCell(0, 0);
        }

        private void Cell2_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(2);
            this.grid.RevealCell(0, 1);
        }

        private void Cell3_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(2);
            this.grid.RevealCell(0, 2);
        }

        private void Cell4_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(2);
            this.grid.RevealCell(0, 3);
        }

        private void Cell5_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(2);
            this.grid.RevealCell(0, 4);
        }

        private void Cell6_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(2);
            this.grid.RevealCell(0, 5);
        }

        private void Cell7_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(2);
            this.grid.RevealCell(0, 6);
        }

        private void Cell8_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(3);
            this.grid.RevealCell(0, 7);
        }

        // row 1 eventhandlers
        private void Cell9_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(8);
            this.grid.RevealCell(1, 0);
        }

        private void Cell10_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(0);
            this.grid.RevealCell(1, 1);
        }

        private void Cell11_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(0);
            this.grid.RevealCell(1, 2);
        }

        private void Cell12_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(0);
            this.grid.RevealCell(1, 3);
        }

        private void Cell13_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(0);
            this.grid.RevealCell(1, 4);
        }

        private void Cell14_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(0);
            this.grid.RevealCell(1, 5);
        }

        private void Cell15_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(0);
            this.grid.RevealCell(1, 6);
        }

        private void Cell16_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(4);
            this.grid.RevealCell(1, 7);
        }


        // row 2 eventhandlers
        private void Cell17_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(8);
            this.grid.RevealCell(2, 0);
        }

        private void Cell18_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(0);
            this.grid.RevealCell(2, 1);
        }

        private void Cell19_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(0);
            this.grid.RevealCell(2, 2);
        }

        private void Cell20_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(0);
            this.grid.RevealCell(2, 3);
        }

        private void Cell21_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(0);
            this.grid.RevealCell(2, 4);
        }

        private void Cell22_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(0);
            this.grid.RevealCell(2, 5);
        }

        private void Cell23_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(0);
            this.grid.RevealCell(2, 6);
        }

        private void Cell24_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(4);
            this.grid.RevealCell(2, 7);
        }


        // row 3 eventhandlers
        private void Cell25_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(8);
            this.grid.RevealCell(3, 0);
        }

        private void Cell26_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(0);
            this.grid.RevealCell(3, 1);
        }

        private void Cell27_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(0);
            this.grid.RevealCell(3, 2);
        }

        private void Cell28_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(0);
            this.grid.RevealCell(3, 3);
        }

        private void Cell29_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(0);
            this.grid.RevealCell(3, 4);
        }

        private void Cell30_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(0);
            this.grid.RevealCell(3, 5);
        }

        private void Cell31_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(0);
            this.grid.RevealCell(3, 6);
        }

        private void Cell32_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(4);
            this.grid.RevealCell(3, 7);
        }


        // row 4 eventhandlers
        private void Cell33_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(8);
            this.grid.RevealCell(4, 0);
        }

        private void Cell34_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(0);
            this.grid.RevealCell(4, 1);
        }

        private void Cell35_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(0);
            this.grid.RevealCell(4, 2);
        }

        private void Cell36_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(0);
            this.grid.RevealCell(4, 3);
        }

        private void Cell37_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(0);
            this.grid.RevealCell(4, 4);
        }

        private void Cell38_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(0);
            this.grid.RevealCell(4, 5);
        }

        private void Cell39_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(0);
            this.grid.RevealCell(4, 6);
        }

        private void Cell40_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(4);
            this.grid.RevealCell(4, 7);
        }


        // row 5 eventhandlers
        private void Cell41_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(8);
            this.grid.RevealCell(5, 0);
        }

        private void Cell42_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(0);
            this.grid.RevealCell(5, 1);
        }

        private void Cell43_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(0);
            this.grid.RevealCell(5, 2);
        }

        private void Cell44_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(0);
            this.grid.RevealCell(5, 3);
        }

        private void Cell45_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(0);
            this.grid.RevealCell(5, 4);
        }

        private void Cell46_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(0);
            this.grid.RevealCell(5, 5);
        }

        private void Cell47_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(0);
            this.grid.RevealCell(5, 6);
        }

        private void Cell48_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(4);
            this.grid.RevealCell(5, 7);
        }


        // row 6 eventhandlers
        private void Cell49_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(8);
            this.grid.RevealCell(6, 0);
        }

        private void Cell50_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(0);
            this.grid.RevealCell(6, 1);
        }

        private void Cell51_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(0);
            this.grid.RevealCell(6, 2);
        }

        private void Cell52_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(0);
            this.grid.RevealCell(6, 3);
        }

        private void Cell53_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(0);
            this.grid.RevealCell(6, 4);
        }

        private void Cell54_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(0);
            this.grid.RevealCell(6, 5);
        }

        private void Cell55_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(0);
            this.grid.RevealCell(6, 6);
        }

        private void Cell56_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(4);
            this.grid.RevealCell(6, 7);
        }

        // row 7 event handlers
        private void Cell57_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(7);
            this.grid.RevealCell(7, 0);
        }

        private void Cell58_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(6);
            this.grid.RevealCell(7, 1);
        }

        private void Cell59_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(6);
            this.grid.RevealCell(7, 2);
        }

        private void Cell60_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(6);
            this.grid.RevealCell(7, 3);
        }

        private void Cell61_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(6);
            this.grid.RevealCell(7, 4);
        }

        private void Cell62_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(6);
            this.grid.RevealCell(7, 5);
        }

        private void Cell63_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(6);
            this.grid.RevealCell(7, 6);
        }

        private void Cell64_click(object sender, EventArgs e)
        {
            this.grid.CheckNeighbours(5);
            this.grid.RevealCell(7, 7);
        }




    }
}

