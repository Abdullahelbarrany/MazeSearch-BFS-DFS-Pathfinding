using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalMaze_ISA
{
    public partial class Maze : Form
    {
        public Maze()
        {
            InitializeComponent();
            this.Load += Maze_Load;
         

        }

     

        int i, j;
        private void Maze_Load(object sender, EventArgs e)
        {
            board.BackgroundColor = Color.White;
            board.DefaultCellStyle.BackColor = Color.White;

            for (i = 0; i < 21; i++)
            {
                board.Rows.Add();
            }
            foreach (DataGridViewColumn c in board.Columns)
                c.Width = board.Width / board.Columns.Count;
            // formatcell(5, 2);
            MessageBox.Show("Click on the Hero's Location");
        }
        visited ptrav;
        visited pnn;

        void dfs()
        {
            
                pnn = new visited();
                pnn.r = sr;
                pnn.c = sc;
                pnn.parentc = 0;
                pnn.parentr = 0;
                queue.Add(pnn);
                ptrav = new visited();
                ptrav.r = sr;
                ptrav.c = sc;
                int y = 0;
                int first = 0;
                closed.Add(ptrav);
                //MessageBox.Show("" + board.Rows[sr].Cells[sc].Tag);
                while (queue.Count != 0)
                {
                    if (y == queue.Count)
                    {
                        //  MessageBox.Show("3ash bruh");

                        break;
                    }
                    r = queue[y].r;
                    c = queue[y].c;
                    if (r == sr && c == sc)
                    { }
                    else
                    { board.Rows[r].Cells[c].Style.BackColor = Color.Cyan; }

                    if (goal == 1)
                    { }
                    else
                    { explorenodes(r, c); }
                    // nodesleft--;
                    //     if (nodesleft == 0)
                    //    {
                    //       nodesleft = nodesnext;
                    //        nodesnext = 0;
                    //        mc++;

                    ///    }


                    y++;
                }
            }
        void bfs()
        {
             pnn= new visited();
            pnn.r = sr;
            pnn.c = sc;
            pnn.parentc = 0;
            pnn.parentr = 0;
            queue.Add(pnn);
            ptrav = new visited();
            ptrav.r = sr;
            ptrav.c = sc;
            int y=0;
            int first = 0;
            closed.Add(ptrav);
             //MessageBox.Show("" + board.Rows[sr].Cells[sc].Tag);
            while (queue.Count !=0)
            { 
                if (y == queue.Count)
                {
                  //  MessageBox.Show("3ash bruh");
                   
                    break;
            }
                r = queue[y].r;
                c = queue[y].c;
                if (r == sr && c == sc)
                { }
                else
                { board.Rows[r].Cells[c].Style.BackColor = Color.Cyan;}

                if (goal == 1)
                { }
                else
                { explorenodes(r, c); }
                // nodesleft--;
                //     if (nodesleft == 0)
                //    {
                //       nodesleft = nodesnext;
                //        nodesnext = 0;
                //        mc++;

                ///    }

                
                 y++; 
            }
            int gr, gc,b=0;
            visited goalpath =queue[queue.Count -1];
            if (goal == 1)
            { while (b==0)
                {
                   gr= goalpath.r;
                    gc =goalpath.c;
                    board.Rows[gr].Cells[gc].Style.BackColor = Color.Gold;
                    for (j = 0; j < queue.Count; j++)
                    {if (goalpath.parentr == queue[j].r && goalpath.parentc == queue[j].c)
                        {
                            goalpath = queue[j];
                        }
                    
                    }
                    if (goalpath.parentr == 0)
                    {
                        break; 
                    }


                }
            
            
            }
          
        
        }
        void explorenodes(int r, int c)
        {
            int rr,ct=0;
            int cc;
        
            for (i = 0; i < 4; i++)
            {
                rr = r + dr[i];
                cc = c + dc[i];
                if (rr > 19 || rr < 0 || cc > 19 || cc < 0)
                {
                    ct++;

                }
                else
                {
                    for (j = 0; j < obstacles.Count; j++)
                    {
                        if (rr == obstacles[j].r && cc == obstacles[j].c)
                        {
                            ct++;
                            // MessageBox.Show("obstacle");
                        }
                    }
                    for (j = 0; j < closed.Count; j++)
                    {
                        if (rr == closed[j].r)
                        {
                            if (cc == closed[j].c)
                            { ct++; }
                        }
                    }

                    if (rr==g.r&&cc==g.c)
                    {
                        goal = 1;
                      ///  MessageBox.Show("Goal");
                        break;
                    }
                    if (ct == 0)
                    {
                        pnn = new visited();
                        pnn.r = rr;
                        pnn.c = cc;
                        pnn.parentc = c;
                        pnn.parentr = r;
                        queue.Add(pnn);
                        ///  nodesnext++;
                        closed.Add(pnn);
                    }
                }
                ct = 0;   
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        int goal = 0;
        int counter = 0,mc,nodesleft=1,nodesnext,c,r;
        int[] dr = { -1, 1, 0, 0 };
        List<visited> closed = new List<visited>();
        visited g;
        List<visited> obstacles = new List<visited>();
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int[] dc = { 0, 0, 1, -1 };
        int sc, sr;
        public class visited
        {   public int r=0, c=0, parentr=0, parentc=0,heu=0,cost=0;
        }

        private void dFSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bfs();

        }

        List<visited> queue = new List<visited>();
      //cell tag will be the visited node[s]
        private void board_CellClick(object sender, DataGridViewCellEventArgs e)
        {if (counter == 0)
            {
                DataGridViewCellStyle cell = new DataGridViewCellStyle();
                cell.BackColor = Color.Blue;
                cell.Tag = 3;
                board.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = cell;
                counter++;
                sc = e.ColumnIndex;
                sr = e.RowIndex;
              //  MessageBox.Show("" + sc + "   " + sr);
                MessageBox.Show("Click On The Goal's Location");
            }
            else if (counter == 1)
            {
                DataGridViewCellStyle cell = new DataGridViewCellStyle();
                cell.BackColor = Color.Green;
                cell.Tag = 1;
                g = new visited();
                g.r = e.RowIndex;
                g.c = e.ColumnIndex;
                board.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = cell;
                counter++;
                MessageBox.Show("Place the Obstacles");
            }
            else if (counter > 1)
            {
                DataGridViewCellStyle cell = new DataGridViewCellStyle();
                cell.BackColor = Color.Black;
                cell.Tag = 2;
                pnn = new visited();
                pnn.r = e.RowIndex;
                pnn.c = e.ColumnIndex;
                obstacles.Add(pnn);
                board.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = cell;
                counter++;
            }
           
        }
      
        //we can make parent a matrix and falg as colour

      
    }
}
