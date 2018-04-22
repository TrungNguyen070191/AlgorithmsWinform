using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AlgorithmsApplication
{
    public partial class MainFrm : Form
    {
        private string modeName = "Unknow";
        public MainFrm()
        {
            InitializeComponent();
            InitForm();
        }

        private void InitForm(){
            lblModeName.Text = this.modeName;

            var optionsModule = new AlgorithmsApplication.Modules.OptionsControl();
            optionsModule.Dock = DockStyle.Fill;    
            this.pnlTop.Controls.Add(optionsModule);

            var graphModule = new AlgorithmsApplication.Modules.GraphControl();
            optionsModule.Dock = DockStyle.Fill;
            this.pnlLeft.Controls.Add(graphModule);

            var displayDataModule = new AlgorithmsApplication.Modules.DisplayDataControl();
            displayDataModule.Dock = DockStyle.Fill;
            this.pnlRight.Controls.Add(displayDataModule);

        }

        private void dFSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.modeName = "DFS";
            lblModeName.Text = this.modeName;
        }

        private void bFSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.modeName = "BFS";
            lblModeName.Text = this.modeName;
        }
    }
}
