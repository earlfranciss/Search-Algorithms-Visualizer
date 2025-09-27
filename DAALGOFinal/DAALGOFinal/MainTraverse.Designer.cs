namespace DAALGOFinal
{
    partial class MainTraverse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainTraverse));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMini = new System.Windows.Forms.Button();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnGBFS = new Guna.UI2.WinForms.Guna2Button();
            this.btnUCS = new Guna.UI2.WinForms.Guna2Button();
            this.btnDFS = new Guna.UI2.WinForms.Guna2Button();
            this.btnBFS = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.traversalpanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ucs2 = new DAALGOFinal.Traversals.UCS();
            this.gbfs1 = new DAALGOFinal.Traversals.GBFS();
            this.dfs1 = new DAALGOFinal.Traversals.DFS();
            this.bfs1 = new DAALGOFinal.Traversals.BFS();
            this.pnlTopBar.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.traversalpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.AllowDrop = true;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1429, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(71, 43);
            this.btnExit.TabIndex = 1;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMini
            // 
            this.btnMini.AllowDrop = true;
            this.btnMini.BackColor = System.Drawing.Color.Transparent;
            this.btnMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMini.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMini.FlatAppearance.BorderSize = 0;
            this.btnMini.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnMini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMini.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMini.ForeColor = System.Drawing.Color.White;
            this.btnMini.Location = new System.Drawing.Point(1355, 2);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(71, 38);
            this.btnMini.TabIndex = 1;
            this.btnMini.TabStop = false;
            this.btnMini.Text = "_";
            this.btnMini.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMini.UseVisualStyleBackColor = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.Transparent;
            this.pnlTopBar.Controls.Add(this.label1);
            this.pnlTopBar.Controls.Add(this.btnExit);
            this.pnlTopBar.Controls.Add(this.btnMini);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1500, 43);
            this.pnlTopBar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "DAALGO";
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnBack);
            this.pnlMenu.Controls.Add(this.btnGBFS);
            this.pnlMenu.Controls.Add(this.btnUCS);
            this.pnlMenu.Controls.Add(this.btnDFS);
            this.pnlMenu.Controls.Add(this.btnBFS);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 43);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(280, 807);
            this.pnlMenu.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BorderColor = System.Drawing.Color.Transparent;
            this.btnBack.BorderRadius = 27;
            this.btnBack.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnBack.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.Transparent;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnBack.HoverState.ForeColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(11, 705);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(330, 64);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Main Menu";
            this.btnBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBack.UseTransparentBackground = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGBFS
            // 
            this.btnGBFS.BackColor = System.Drawing.Color.Transparent;
            this.btnGBFS.BorderRadius = 27;
            this.btnGBFS.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnGBFS.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnGBFS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGBFS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGBFS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGBFS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGBFS.FillColor = System.Drawing.Color.Black;
            this.btnGBFS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGBFS.ForeColor = System.Drawing.Color.White;
            this.btnGBFS.Location = new System.Drawing.Point(10, 337);
            this.btnGBFS.Name = "btnGBFS";
            this.btnGBFS.Size = new System.Drawing.Size(330, 64);
            this.btnGBFS.TabIndex = 6;
            this.btnGBFS.Text = "Greedy Best-First Search";
            this.btnGBFS.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGBFS.UseTransparentBackground = true;
            this.btnGBFS.Click += new System.EventHandler(this.btnGBFS_Click);
            // 
            // btnUCS
            // 
            this.btnUCS.BackColor = System.Drawing.Color.Transparent;
            this.btnUCS.BorderRadius = 27;
            this.btnUCS.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnUCS.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnUCS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUCS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUCS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUCS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUCS.FillColor = System.Drawing.Color.Black;
            this.btnUCS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUCS.ForeColor = System.Drawing.Color.White;
            this.btnUCS.Location = new System.Drawing.Point(10, 237);
            this.btnUCS.Name = "btnUCS";
            this.btnUCS.Size = new System.Drawing.Size(330, 64);
            this.btnUCS.TabIndex = 6;
            this.btnUCS.Text = "Uniform-Cost Search";
            this.btnUCS.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUCS.UseTransparentBackground = true;
            this.btnUCS.Click += new System.EventHandler(this.btnUCS_Click);
            // 
            // btnDFS
            // 
            this.btnDFS.BackColor = System.Drawing.Color.Transparent;
            this.btnDFS.BorderRadius = 27;
            this.btnDFS.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnDFS.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnDFS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDFS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDFS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDFS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDFS.FillColor = System.Drawing.Color.Black;
            this.btnDFS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDFS.ForeColor = System.Drawing.Color.White;
            this.btnDFS.Location = new System.Drawing.Point(10, 137);
            this.btnDFS.Name = "btnDFS";
            this.btnDFS.Size = new System.Drawing.Size(330, 64);
            this.btnDFS.TabIndex = 6;
            this.btnDFS.Text = "Depth-First Search";
            this.btnDFS.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDFS.UseTransparentBackground = true;
            this.btnDFS.Click += new System.EventHandler(this.btnDFS_Click);
            // 
            // btnBFS
            // 
            this.btnBFS.BackColor = System.Drawing.Color.Transparent;
            this.btnBFS.BorderRadius = 27;
            this.btnBFS.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnBFS.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnBFS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBFS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBFS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBFS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBFS.FillColor = System.Drawing.Color.Black;
            this.btnBFS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBFS.ForeColor = System.Drawing.Color.White;
            this.btnBFS.Location = new System.Drawing.Point(10, 37);
            this.btnBFS.Name = "btnBFS";
            this.btnBFS.Size = new System.Drawing.Size(330, 64);
            this.btnBFS.TabIndex = 6;
            this.btnBFS.Text = " Breadth First Search";
            this.btnBFS.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBFS.UseTransparentBackground = true;
            this.btnBFS.Click += new System.EventHandler(this.btnBFS_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.traversalpanel);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(280, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1220, 807);
            this.panel2.TabIndex = 0;
            // 
            // traversalpanel
            // 
            this.traversalpanel.BackColor = System.Drawing.Color.DimGray;
            this.traversalpanel.Controls.Add(this.ucs2);
            this.traversalpanel.Controls.Add(this.gbfs1);
            this.traversalpanel.Controls.Add(this.dfs1);
            this.traversalpanel.Controls.Add(this.bfs1);
            this.traversalpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.traversalpanel.Location = new System.Drawing.Point(0, 0);
            this.traversalpanel.Name = "traversalpanel";
            this.traversalpanel.Size = new System.Drawing.Size(1190, 787);
            this.traversalpanel.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 787);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1190, 20);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1190, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 807);
            this.panel3.TabIndex = 1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 23;
            this.guna2Elipse1.TargetControl = this.traversalpanel;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 20;
            this.guna2Elipse2.TargetControl = this;
            // 
            // ucs2
            // 
            this.ucs2.BackColor = System.Drawing.Color.Transparent;
            this.ucs2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucs2.Location = new System.Drawing.Point(0, 0);
            this.ucs2.Name = "ucs2";
            this.ucs2.Size = new System.Drawing.Size(1190, 787);
            this.ucs2.TabIndex = 10;
            this.ucs2.Visible = false;
            // 
            // gbfs1
            // 
            this.gbfs1.BackColor = System.Drawing.Color.Transparent;
            this.gbfs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbfs1.Location = new System.Drawing.Point(0, 0);
            this.gbfs1.Name = "gbfs1";
            this.gbfs1.Size = new System.Drawing.Size(1190, 787);
            this.gbfs1.TabIndex = 9;
            this.gbfs1.Visible = false;
            // 
            // dfs1
            // 
            this.dfs1.BackColor = System.Drawing.Color.Transparent;
            this.dfs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dfs1.Location = new System.Drawing.Point(0, 0);
            this.dfs1.Name = "dfs1";
            this.dfs1.Size = new System.Drawing.Size(1190, 787);
            this.dfs1.TabIndex = 7;
            this.dfs1.Visible = false;
            // 
            // bfs1
            // 
            this.bfs1.BackColor = System.Drawing.Color.Transparent;
            this.bfs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bfs1.Location = new System.Drawing.Point(0, 0);
            this.bfs1.Name = "bfs1";
            this.bfs1.Size = new System.Drawing.Size(1190, 787);
            this.bfs1.TabIndex = 0;
            this.bfs1.Visible = false;
            // 
            // MainTraverse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1500, 850);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainTraverse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainTraverse_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.traversalpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel pnlMenu;
        public Guna.UI2.WinForms.Guna2Button btnBFS;
        public Guna.UI2.WinForms.Guna2Button btnGBFS;
        public Guna.UI2.WinForms.Guna2Button btnUCS;
        public Guna.UI2.WinForms.Guna2Button btnDFS;
        public Guna.UI2.WinForms.Guna2Button btnBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel traversalpanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        public Traversals.BFS bfs1;
        public Traversals.GBFS gbfs1;
        public Traversals.DFS dfs1;
        public Traversals.UCS ucs2;
    }
}