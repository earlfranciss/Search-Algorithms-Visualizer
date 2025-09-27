using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAALGOFinal
{
    public partial class MainTraverse : Form
    {
        public MainTraverse()
        {
            InitializeComponent();
            traversalpanel.BackColor = Color.FromArgb(160, Color.Black);
            pnlMenu.BackColor = Color.FromArgb(190, Color.Black);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MainTraverse_Load(object sender, EventArgs e)
        {

        }


        private void btnBFS_Click(object sender, EventArgs e)
        {
            btnBFS.Checked = true;
            btnDFS.Checked = false;
            btnUCS.Checked = false;
            btnGBFS.Checked = false;
            bfs1.Visible = true;
            dfs1.Visible = false;
            ucs2.Visible = false;
            gbfs1.Visible = false;
        }

        private void btnDFS_Click(object sender, EventArgs e)
        {
            btnDFS.Checked = true;
            btnBFS.Checked = false;
            btnUCS.Checked = false;
            btnGBFS.Checked = false;
            bfs1.Visible = false;
            dfs1.Visible = true;
            ucs2.Visible = false;
            gbfs1.Visible = false;
        }

        private void btnUCS_Click(object sender, EventArgs e)
        {
            btnUCS.Checked = true;
            btnBFS.Checked = false;
            btnDFS.Checked = false;
            btnGBFS.Checked = false;
            bfs1.Visible = false;
            dfs1.Visible = false;
            ucs2.Visible = true;
            gbfs1.Visible = false;
        }

        private void btnGBFS_Click(object sender, EventArgs e)
        {
            btnGBFS.Checked = true;
            btnBFS.Checked = false;
            btnDFS.Checked = false;
            btnUCS.Checked = false;
            bfs1.Visible = false;
            dfs1.Visible = false;
            ucs2.Visible = false;
            gbfs1.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            this.Hide();
            m.ShowDialog();
            this.Close();
        }

        private void ucs2_Load(object sender, EventArgs e)
        {

        }
    }
}
