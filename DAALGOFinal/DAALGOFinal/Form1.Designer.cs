namespace DAALGOFinal
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBFS = new System.Windows.Forms.Button();
            this.btnDFS = new System.Windows.Forms.Button();
            this.btnUCS = new System.Windows.Forms.Button();
            this.btnGBFS = new System.Windows.Forms.Button();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.AllowDrop = true;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1130, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(71, 38);
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(301, 59);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(545, 39);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Design and Analysis of Algorithms";
            this.lblTitle.Visible = false;
            // 
            // btnBFS
            // 
            this.btnBFS.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBFS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBFS.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBFS.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnBFS.Location = new System.Drawing.Point(243, 590);
            this.btnBFS.Name = "btnBFS";
            this.btnBFS.Size = new System.Drawing.Size(150, 40);
            this.btnBFS.TabIndex = 2;
            this.btnBFS.Text = "BFS";
            this.btnBFS.UseVisualStyleBackColor = false;
            this.btnBFS.Click += new System.EventHandler(this.btnBFS_Click);
            this.btnBFS.MouseEnter += new System.EventHandler(this.btnBFS_MouseEnter);
            this.btnBFS.MouseLeave += new System.EventHandler(this.btnBFS_MouseLeave);
            // 
            // btnDFS
            // 
            this.btnDFS.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDFS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDFS.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDFS.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnDFS.Location = new System.Drawing.Point(443, 590);
            this.btnDFS.Name = "btnDFS";
            this.btnDFS.Size = new System.Drawing.Size(150, 40);
            this.btnDFS.TabIndex = 2;
            this.btnDFS.Text = "DFS";
            this.btnDFS.UseVisualStyleBackColor = false;
            this.btnDFS.Click += new System.EventHandler(this.btnDFS_Click);
            this.btnDFS.MouseEnter += new System.EventHandler(this.btnDFS_MouseEnter);
            this.btnDFS.MouseLeave += new System.EventHandler(this.btnDFS_MouseLeave);
            // 
            // btnUCS
            // 
            this.btnUCS.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUCS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUCS.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUCS.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnUCS.Location = new System.Drawing.Point(643, 590);
            this.btnUCS.Name = "btnUCS";
            this.btnUCS.Size = new System.Drawing.Size(150, 40);
            this.btnUCS.TabIndex = 2;
            this.btnUCS.Text = "UCS";
            this.btnUCS.UseVisualStyleBackColor = false;
            this.btnUCS.Click += new System.EventHandler(this.btnUCS_Click);
            this.btnUCS.MouseEnter += new System.EventHandler(this.btnUCS_MouseEnter);
            this.btnUCS.MouseLeave += new System.EventHandler(this.btnUCS_MouseLeave);
            // 
            // btnGBFS
            // 
            this.btnGBFS.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnGBFS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGBFS.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGBFS.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnGBFS.Location = new System.Drawing.Point(843, 590);
            this.btnGBFS.Name = "btnGBFS";
            this.btnGBFS.Size = new System.Drawing.Size(150, 40);
            this.btnGBFS.TabIndex = 2;
            this.btnGBFS.Text = "GBFS";
            this.btnGBFS.UseVisualStyleBackColor = false;
            this.btnGBFS.Click += new System.EventHandler(this.btnGBFS_Click);
            this.btnGBFS.MouseEnter += new System.EventHandler(this.btnGBFS_MouseEnter);
            this.btnGBFS.MouseLeave += new System.EventHandler(this.btnGBFS_MouseLeave);
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblMainTitle.Font = new System.Drawing.Font("Century", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.ForeColor = System.Drawing.Color.White;
            this.lblMainTitle.Location = new System.Drawing.Point(146, 117);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(865, 371);
            this.lblMainTitle.TabIndex = 1;
            this.lblMainTitle.Text = "Design and Analysis of Algorithms";
            this.lblMainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDetails
            // 
            this.lblDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblDetails.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.ForeColor = System.Drawing.Color.White;
            this.lblDetails.Location = new System.Drawing.Point(191, 117);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(802, 405);
            this.lblDetails.TabIndex = 3;
            this.lblDetails.Text = "Design and Analysis of Algorithms";
            this.lblDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDetails.Visible = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.btnGBFS);
            this.Controls.Add(this.btnUCS);
            this.Controls.Add(this.btnDFS);
            this.Controls.Add(this.btnBFS);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnExit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBFS;
        private System.Windows.Forms.Button btnDFS;
        private System.Windows.Forms.Button btnUCS;
        private System.Windows.Forms.Button btnGBFS;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Label lblDetails;
    }
}

