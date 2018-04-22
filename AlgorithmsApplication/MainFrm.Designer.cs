namespace AlgorithmsApplication
{
    partial class MainFrm
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algorithmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dFSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bFSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kruskalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblMode = new System.Windows.Forms.Label();
            this.lblModeName = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.menuStrip1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(827, 27);
            this.pnlMenu.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.algorithmsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(827, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // algorithmsToolStripMenuItem
            // 
            this.algorithmsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dFSToolStripMenuItem,
            this.bFSToolStripMenuItem,
            this.kruskalToolStripMenuItem,
            this.primToolStripMenuItem});
            this.algorithmsToolStripMenuItem.Name = "algorithmsToolStripMenuItem";
            this.algorithmsToolStripMenuItem.Size = new System.Drawing.Size(78, 23);
            this.algorithmsToolStripMenuItem.Text = "Algorithms";
            // 
            // dFSToolStripMenuItem
            // 
            this.dFSToolStripMenuItem.Name = "dFSToolStripMenuItem";
            this.dFSToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dFSToolStripMenuItem.Text = "DFS";
            this.dFSToolStripMenuItem.Click += new System.EventHandler(this.dFSToolStripMenuItem_Click);
            // 
            // bFSToolStripMenuItem
            // 
            this.bFSToolStripMenuItem.Name = "bFSToolStripMenuItem";
            this.bFSToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bFSToolStripMenuItem.Text = "BFS";
            this.bFSToolStripMenuItem.Click += new System.EventHandler(this.bFSToolStripMenuItem_Click);
            // 
            // kruskalToolStripMenuItem
            // 
            this.kruskalToolStripMenuItem.Name = "kruskalToolStripMenuItem";
            this.kruskalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kruskalToolStripMenuItem.Text = "Kruskal";
            // 
            // primToolStripMenuItem
            // 
            this.primToolStripMenuItem.Name = "primToolStripMenuItem";
            this.primToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.primToolStripMenuItem.Text = "Prim";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 23);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // pnlTop
            // 
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 27);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(827, 43);
            this.pnlTop.TabIndex = 1;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlBottom.Controls.Add(this.lblModeName);
            this.pnlBottom.Controls.Add(this.lblMode);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 485);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(827, 34);
            this.pnlBottom.TabIndex = 2;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.pnlRight);
            this.pnlCenter.Controls.Add(this.pnlLeft);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 70);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(827, 415);
            this.pnlCenter.TabIndex = 3;
            // 
            // pnlRight
            // 
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(419, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(408, 415);
            this.pnlRight.TabIndex = 1;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(410, 415);
            this.pnlLeft.TabIndex = 0;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Location = new System.Drawing.Point(12, 8);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(55, 17);
            this.lblMode.TabIndex = 0;
            this.lblMode.Text = "Mode : ";
            // 
            // lblModeName
            // 
            this.lblModeName.AutoSize = true;
            this.lblModeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeName.Location = new System.Drawing.Point(62, 8);
            this.lblModeName.Name = "lblModeName";
            this.lblModeName.Size = new System.Drawing.Size(0, 17);
            this.lblModeName.TabIndex = 1;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 519);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlMenu);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrm";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algorithmsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dFSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bFSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kruskalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem primToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblModeName;
        private System.Windows.Forms.Label lblMode;
    }
}

