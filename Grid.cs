using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{

    public class Grid : Form
    {
        static int bombAmount;
        private readonly int size = 8;
        public Cell[][] griddy = new Cell[8][];
        for (int i = 0; i < size; i += 1) {
            griddy[i] = new Cell[size];
        }
        Random rand1 = new Random();
        int chance;

        //
        // methods
        //

        // Decide bombcount in Neighbours
        public void CheckNeighbours(int cswitch)
        {

            switch (cswitch)
            {
                // Left upper corner (i = 0, j = 0)
                case 1:
                    for (int i = 0; i <= 1 ; i++)
                    {
                        for (int j = 0; j < 1; j++)
                        {
                            if (i == 0 && j == 0) { }
                            else
                            {
                                if (griddy[i][j].HasBomb == true)
                                {
                                    griddy[0][0].NeighbourBombCount++;
                                }
                            }
                        }
                    }
                    break;

                // Upper edge (i = 0, 0 < j < 7)
                case 2:
                    for (int i = 0; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            if (i == 0 && j == 0) { }
                            else
                            {
                                if (griddy[i][j].HasBomb == true)
                                {
                                    griddy[0][0].NeighbourBombCount++;
                                }
                            }
                        }
                    }
                    break;

                // Right upper corner (i = 0, j = 7)
                case 3:
                    for (int i = 0; i <= 1; i++)
                    {
                        for (int j = -1; j <= 0; j++)
                        {
                            if (i == 0 && j == 0) { }
                            else
                            {
                                if (griddy[i][j].HasBomb == true)
                                {
                                    griddy[0][0].NeighbourBombCount++;
                                }
                            }
                        }
                    }
                    break;

                // Right edge (0 < i < 7, j = 7)
                case 4:
                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 0; j++)
                        {
                            if (i == 0 && j == 0) { }
                            else
                            {
                                if (griddy[i][j].HasBomb == true)
                                {
                                    griddy[0][0].NeighbourBombCount++;
                                }
                            }
                        }
                    }
                    break;

                // Right down corner (i = 7, j = 7)
                case 5:
                    for (int i = -1; i <= 0; i++)
                    {
                        for (int j = -1; j <= 0; j++)
                        {
                            if (i == 0 && j == 0) { }
                            else
                            {
                                if (griddy[i][j].HasBomb == true)
                                {
                                    griddy[0][0].NeighbourBombCount++;
                                }
                            }
                        }
                    }
                    break;

                // Bottom edge (i = 7, 0 < j < 7)
                case 6:
                    for (int i = -1; i <= 0; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            if (i == 0 && j == 0) { }
                            else
                            {
                                if (griddy[i][j].HasBomb == true)
                                {
                                    griddy[0][0].NeighbourBombCount++;
                                }
                            }
                        }
                    }
                    break;

                // Left down corner (i = 7, j = 0)
                case 7:
                    for (int i = -1; i <= 0; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            if (i == 0 && j == 0) { }
                            else
                            {
                                if (griddy[i][j].HasBomb == true)
                                {
                                    griddy[0][0].NeighbourBombCount++;
                                }
                            }
                        }
                    }
                    break;

                // Left edge (i = 0, 0 < j < 7)
                case 8:
                    for (int i = 0; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            if (i == 0 && j == 0) { }
                            else
                            {
                                if (griddy[i][j].HasBomb == true)
                                {
                                    griddy[0][0].NeighbourBombCount++;
                                }
                            }
                        }
                    }
                    break;

                default:
                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            if (i == 0 && j == 0) { }
                            else
                            {
                                if (griddy[i][j].HasBomb == true)
                                {
                                    griddy[0][0].NeighbourBombCount++;
                                }
                            }
                        }
                    }
                    break;

            }
        }


        // Reveal Cell
        public void RevealCell(int i, int j)
        {
            if (griddy[i][j].HasBomb == true)
            {
                griddy[i][j].Text = "B";
            }
            else if(griddy[i][j].NeighbourBombCount > 0)
            {
                griddy[i][j].Text = griddy[i][j].NeighbourBombCount.ToString();
            }
            else
            {
                griddy[i][j].Text = "";
            }

            griddy[i][j].IsRevealed = true;
        }

        //
        // constructor
        //
        public Grid()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    griddy[i][j] = new Cell();
                    griddy[i][j].Name = "grid" + i.ToString() + j.ToString();
                    griddy[i][j].Location = new System.Drawing.Point(i * 49, j * 49);
                    

                    chance = rand1.Next(0, 6);
                    if (chance % 6 == 0 && bombAmount < 10)
                    {
                        griddy[i][j].HasBomb = true;
                        bombAmount++;
                    }
                    
                }
            }
        }
    }
}
