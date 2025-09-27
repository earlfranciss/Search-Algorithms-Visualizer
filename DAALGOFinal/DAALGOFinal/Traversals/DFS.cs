using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAALGOFinal.Traversals
{

    public partial class DFS : UserControl
    {
        bool stopcreate;
        int[,] matrix;
        int countnodes;
        String[] vertices;
        Graphics graph;

        public DFS()
        {
            InitializeComponent();
            InitializeGraph();

        }
        public void InitializeGraph()
        {
            //Set initialization
            graph = picGraph.CreateGraphics();
            stopcreate = false;
            matrix = new int[50, 50];
            vertices = new string[50];
            countnodes = 0;
        }

        private void btnCreateNodes_Click(object sender, EventArgs e)
        {
            stopcreate = false;
        }

        private void btnCreateEdge_Click(object sender, EventArgs e)
        {
            if (stopcreate == true)
            {
                //NEWLY ADDED (cmbEdge1.SelectedItem)
                //define adjacent nodes
                int Edge1 = Convert.ToInt32(cmbEdge1.SelectedItem);
                int Edge2 = Convert.ToInt32(cmbEdge2.SelectedItem);

                //split coordinates
                String[] c1 = vertices[Edge1].Split('-');
                String[] c2 = vertices[Edge2].Split('-');

                //cast to int
                //Edge 1
                int xCoordinate1 = Convert.ToInt32(c1[0]);
                int yCoordinate1 = Convert.ToInt32(c1[1]);
                //Edge 2
                int xCoordinate2 = Convert.ToInt32(c2[0]);
                int yCoordinate2 = Convert.ToInt32(c2[1]);

                //draw a line
                graph.DrawLine(new Pen(Brushes.Green, 3), (xCoordinate1 + 12), (yCoordinate1 + 12), (xCoordinate2 + 12), (yCoordinate2 + 12));

                //calculate distance
                double x = (double)(xCoordinate2 - xCoordinate1);
                double y = (double)(yCoordinate2 - yCoordinate1);
                double d = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                int a = (int)(xCoordinate1 + xCoordinate2) / 2;
                int b = (int)((yCoordinate1 + yCoordinate2) / 2) - 5;
                graph.DrawString(Math.Round(d, 2).ToString(), new Font("Arial", 12), Brushes.Maroon, a, b);

                //adjacency matrix(Undirected graph: no arrows)
                matrix[Edge1, Edge2] = Convert.ToInt32(d);
                matrix[Edge2, Edge1] = Convert.ToInt32(d);

                dataGridView1.Rows[Edge1].Cells[Edge2].Value = 1;
                dataGridView1.Rows[Edge2].Cells[Edge1].Value = 1;
            }
        }

        private void picGraph_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && stopcreate != true)
            {
                //defines location of x and y coordinate
                Rectangle rect = new Rectangle(e.X, e.Y, 35, 35);

                //node's color
                graph.FillEllipse(Brushes.Black, rect);

                //number inside nodes
                graph.DrawString(countnodes.ToString(), new Font("Arial", 12), Brushes.White, e.X + 10, e.Y + 10);

                vertices[countnodes] = e.X + "-" + e.Y;
                countnodes++;
                dataGridView1.Columns.Add("", (countnodes - 1).ToString());
                dataGridView1.AutoResizeColumns();
                dataGridView1.Rows.Add();
                dataGridView1.Rows[countnodes - 1].HeaderCell.Value = (countnodes - 1).ToString();
                dataGridView1.AutoResizeColumns();
                adjacentmatrix();

                cmbEdge1.Items.Add((countnodes - 1).ToString());
                cmbEdge2.Items.Add((countnodes - 1).ToString());
                cmbSource.Items.Add((countnodes - 1).ToString());
                cmbDestination.Items.Add((countnodes - 1).ToString());

            }
            else
            {
                stopcreate = true;

            }
        }

        public void adjacentmatrix()
        {
            for (int i = 0; i < countnodes; i++)
                for (int j = 0; j < countnodes; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value == null)
                        dataGridView1.Rows[i].Cells[j].Value = 0;
        }

        public void dfsTraversal()
        {
            //set source and destination
            int source = Convert.ToInt32(cmbSource.Text);
            int destination = Convert.ToInt32(cmbDestination.Text);
            colorNodes(source, Brushes.Yellow);
            colorNodes(destination, Brushes.Red);


            Stack<int> b = new Stack<int>();
            int[] visited = new int[countnodes];
            visited[source] = 1;
            b.Push(source);
            int x = source;
            Thread.Sleep(200);

            while (b.Count > 0) //if queue is not empty
            {
                x = Convert.ToInt32(b.Pop().ToString());
                Thread.Sleep(500);
                colorNodes(x, Brushes.Green);

                for (int i = 0; i < countnodes; i++)
                {
                    Thread.Sleep(200);
                    if (matrix[x, i] != 0 && visited[i] != 1)
                    {
                        if (!b.Contains(i))
                        {
                            b.Push(i);
                            visited[x] = 1;
                        }
                    }
                }

                lblPath.Text += " " + x + " ";

                if (x == destination)
                    break;
            }

        }

        private void btnTraverse_Click(object sender, EventArgs e)
        {
            lblPath.Text = "";
            dfsTraversal();
        }

        public void colorNodes(int node, Brush c)
        {
            String[] s = vertices[node].Split('-');

            int x = Convert.ToInt32(s[0]);
            int y = Convert.ToInt32(s[1]);

            Rectangle rect = new Rectangle(x, y, 35, 35);
            graph.FillEllipse(c, rect);
            graph.DrawString(node.ToString(), new Font("Arial", 12), Brushes.White, new Point(x + 8, y + 8));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text Documents (*.text)|*.text";

            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(save.FileName, true);
                String nodes = "";


                for (int i = 0; i < countnodes; i++)
                {
                    nodes = i + "-" + vertices[i];
                    for (int j = 0; j < countnodes; j++)
                    {
                        if (matrix[i, j] != 0)
                        {
                            nodes = nodes + "\t" + j + "-" + vertices[j];
                        }
                    }
                    sw.WriteLine(nodes);

                }


                MessageBox.Show("File Saved");
                sw.Close();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text Documents (*.text)|*.text";
            open.ValidateNames = true;

            if (open.ShowDialog() == DialogResult.OK)
            {
                cmbSource.Items.Clear();
                cmbDestination.Items.Clear();
                cmbEdge1.Items.Clear();
                cmbEdge2.Items.Clear();
                lblPath.Text = "";
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                Graphics g = picGraph.CreateGraphics();
                g.Clear(Color.White);
                try
                {
                    String line = "";
                    StreamReader sr = new StreamReader(open.FileName);

                    do
                    {
                        countnodes++;
                        cmbEdge1.Items.Add((countnodes - 1).ToString());
                        cmbEdge2.Items.Add((countnodes - 1).ToString());
                        cmbSource.Items.Add((countnodes - 1).ToString());
                        cmbDestination.Items.Add((countnodes - 1).ToString());

                        dataGridView1.Columns.Add("", (countnodes - 1).ToString());
                        dataGridView1.AutoResizeColumns();
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[countnodes - 1].HeaderCell.Value = (countnodes - 1).ToString();
                        dataGridView1.AutoResizeRows();

                        line = sr.ReadLine();
                        String[] adjacent = line.Split('\t');
                        String[] nodes = adjacent[0].Split('-');
                        int node1 = Convert.ToInt32(nodes[0]);
                        int x1 = Convert.ToInt32(nodes[1]);
                        int y1 = Convert.ToInt32(nodes[2]);

                        vertices[node1] = x1 + "-" + y1;
                        Rectangle rect = new Rectangle(x1, y1, 35, 35);
                        g.FillEllipse(Brushes.Black, rect);
                        g.DrawString(node1.ToString(), new Font("Arial", 12), Brushes.White, x1 + 8, y1 + 8);

                        for (int i = 1; i < adjacent.Length; i++)
                        {
                            nodes = adjacent[i].Split('-');
                            int node2 = Convert.ToInt32(nodes[0]);
                            int x2 = Convert.ToInt32(nodes[1]);
                            int y2 = Convert.ToInt32(nodes[2]);

                            vertices[node2] = x2 + "-" + y2;
                            rect = new Rectangle(x2, y2, 35, 35);
                            g.FillEllipse(Brushes.Black, rect);
                            g.DrawString(node2.ToString(), new Font("Arial", 12), Brushes.White, x2 + 8, y2 + 8);
                            g.DrawLine(new Pen(Brushes.Green, 3), (float)(x1 + 12), (float)(y1 + 12), (float)(x2 + 12), (float)(y2 + 12));

                            double x = (double)(x2 - x1);
                            double y = (double)(y2 - y1);
                            double d = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                            int a = (int)(x1 + x2) / 2;
                            int b = (int)((y1 + y2) / 2) - 5;
                            g.DrawString(Math.Round(d, 2).ToString(), new Font("Arial", 12), Brushes.Maroon, a, b);

                            matrix[node1, node2] = Convert.ToInt32(d);
                            matrix[node2, node1] = Convert.ToInt32(d);

                            setAdjacent(node1, node2);
                        }
                        adjacentmatrix();
                        dataGridView1.AutoResizeColumns();
                        dataGridView1.AutoResizeRows();
                    } while (sr.Peek() != -1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbSource.Items.Clear();
            cmbDestination.Items.Clear();
            cmbEdge1.Items.Clear();
            cmbEdge2.Items.Clear();
            cmbEdge1.Text = "";
            cmbEdge2.Text = "";
            lblPath.Text = "";
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            Graphics g = picGraph.CreateGraphics();
            g.Clear(Color.White);
            countnodes = 0;
        }

        public void setAdjacent(int edge1, int edge2)
        {
            for (int i = 0; i < countnodes; i++)
            {
                for (int j = 0; j < countnodes; j++)
                {
                    if (i == edge1 && j == edge2)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = 1;
                        dataGridView1.Rows[j].Cells[i].Value = 1;
                    }
                }
            }
        }

        private void BFS_Load(object sender, EventArgs e)
        {
            
        }
    }
}


