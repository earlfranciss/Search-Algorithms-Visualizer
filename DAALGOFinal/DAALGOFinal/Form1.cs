using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAALGOFinal
{
    public partial class Menu : Form
    {
        private string bfsDetails = "The Breadth First Search (BFS) algorithm is used to search a graph data structure for a node that meets a set of criteria. It starts at the root of the graph and visits all nodes at the current depth level before moving on to the nodes at the next depth level.";
        private string dfsDetails = "Depth-first search is an algorithm for traversing or searching tree or graph data structures. The algorithm starts at the root node (selecting some arbitrary node as the root node in the case of a graph) and explores as far as possible along each branch before backtracking.";
        private string ucsDetails = "Uniform-Cost Search is similar to Dijikstra’s algorithm. In this algorithm from the starting state, we will visit the adjacent states and will choose the least costly state then we will choose the next least costly state from the all unvisited and adjacent states of the visited states, in this way we will try to reach the goal state (note we won’t continue the path through a goal state ), even if we reach the goal state we will continue searching for other possible paths( if there are multiple goals). We will keep a priority queue that will give the least costly next state from all the adjacent states of visited states.";
        private string gbfsDetails = "Greedy Best-First Search is an AI search algorithm that attempts to find the most promising path from a given starting point to a goal. It prioritizes paths that appear to be the most promising, regardless of whether or not they are actually the shortest path. The algorithm works by evaluating the cost of each possible path and then expanding the path with the lowest cost. This process is repeated until the goal is reached.";
        

        public Menu()
        {
            InitializeComponent();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBFS_Click(object sender, EventArgs e)
        {
            MainTraverse m = new MainTraverse();
            m.btnBFS.Checked = true;
            m.bfs1.Visible = true;
            this.Hide();
            m.ShowDialog();
            this.Close();
        }

        private void btnDFS_Click(object sender, EventArgs e)
        { 
            MainTraverse m = new MainTraverse();
            m.btnDFS.Checked = true;
            m.dfs1.Visible = true;
            this.Hide();
            m.ShowDialog();
            this.Close();
        }

        private void btnUCS_Click(object sender, EventArgs e)
        {
            MainTraverse m = new MainTraverse();
            m.btnUCS.Checked = true;
            m.ucs2.Visible = true;
            this.Hide();
            m.ShowDialog();
            this.Close();
        }

        private void btnGBFS_Click(object sender, EventArgs e)
        {
            MainTraverse m = new MainTraverse();
            m.btnGBFS.Checked = true;
            m.gbfs1.Visible = true;
            this.Hide();
            m.ShowDialog();
            this.Close();
        }
        

        private void btnBFS_MouseEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Location = new Point(b.Location.X - 50, b.Location.Y - 7);
            b.Size = new Size(160, 40);
            b.Text = "Breadth First Search";
            lblDetails.Text = bfsDetails;
            lblDetails.Visible = true;
            lblMainTitle.Visible = false;
            lblTitle.Visible = true;
            
        }

        private void btnBFS_MouseLeave(object sender, EventArgs e)
        {
            lblDetails.Visible = false;
            lblMainTitle.Visible = true;
            lblTitle.Visible = false;
            Button b = (Button)sender;
            b.Location = new Point(b.Location.X + 50, b.Location.Y + 7);
            b.Size = new Size(115, 31);
            b.Text = "BFS";
        }

        private void btnGBFS_MouseEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Location = new Point(b.Location.X + 5, b.Location.Y - 7);
            b.Size = new Size(180, 40);
            b.Text = "Greedy Best-First Search";
            lblDetails.Text = gbfsDetails;
            lblDetails.Visible = true;
            lblMainTitle.Visible = false;
            lblTitle.Visible = true;
        }

        private void btnGBFS_MouseLeave(object sender, EventArgs e)
        {
            lblDetails.Visible = false;
            lblMainTitle.Visible = true;
            lblTitle.Visible = false;
            Button b = (Button)sender;
            b.Location = new Point(b.Location.X - 5, b.Location.Y + 7);
            b.Size = new Size(115, 31);
            b.Text = "GBFS";
        }

        private void btnUCS_MouseEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Location = new Point(b.Location.X - 20, b.Location.Y - 7);
            b.Size = new Size(160, 40);
            b.Text = "Uniform-Cost Search";
            lblDetails.Text = ucsDetails;
            lblDetails.Visible = true;
            lblMainTitle.Visible = false;
            lblTitle.Visible = true;
        }

        private void btnUCS_MouseLeave(object sender, EventArgs e)
        {
            lblDetails.Visible = false;
            lblMainTitle.Visible = true;
            lblTitle.Visible = false;
            Button b = (Button)sender;
            b.Location = new Point(b.Location.X + 20, b.Location.Y + 7);
            b.Size = new Size(115, 31);
            b.Text = "UCS";
        }

        private void btnDFS_MouseEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Location = new Point(b.Location.X - 20, b.Location.Y - 7);
            b.Size = new Size(160, 40);
            b.Text = "Depth-First Search";
            lblDetails.Text = dfsDetails;
            lblDetails.Visible = true;
            lblMainTitle.Visible = false;
            lblTitle.Visible = true;
        }

        private void btnDFS_MouseLeave(object sender, EventArgs e)
        {
            lblDetails.Visible = false;
            lblMainTitle.Visible = true;
            lblTitle.Visible = false;
            Button b = (Button)sender;
            b.Location = new Point(b.Location.X + 20, b.Location.Y + 7);
            b.Size = new Size(115, 31);
            b.Text = "DFS";
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }


}
