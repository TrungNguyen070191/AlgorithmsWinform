using AlgorithmsApplication.Modules;
using AlgorithmsApplication.Utilities;
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

        public void dFSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.modeName = "DFS";
            lblModeName.Text = this.modeName;
            Int32[] Mangdfs=Globalgraph.g.DFS();
            var displayDataModule = new AlgorithmsApplication.Modules.DisplayDataControl();
            displayDataModule.Dock = DockStyle.Fill;
            for (int i = 0; i <= Globalgraph.len; i++)
            {
                Globalgraph.Ketqua += "next->" + Mangdfs[i].ToString() + Environment.NewLine;
                
            }
            
            this.pnlRight.Controls.Add(displayDataModule);
                
            
        }

        public void bFSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.modeName = "BFS";
            lblModeName.Text = this.modeName;
            Globalgraph.g.BFS();
            Int32[] Mangbfs = Globalgraph.g.BFS();
            for (int i = 0; i <= Globalgraph.len; i++)
            {
                Globalgraph.Ketqua += "next->" + Mangbfs[i].ToString() + Environment.NewLine;

            }

        }
    }
}
