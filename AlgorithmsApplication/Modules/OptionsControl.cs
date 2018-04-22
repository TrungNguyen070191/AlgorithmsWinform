using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AlgorithmsApplication.Modules
{
    public partial class OptionsControl : UserControl
    {
        public OptionsControl()
        {
            InitializeComponent();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            Stream fileStream = null;
            //Update - remove parenthesis
            if (openFileDialog1.ShowDialog() == DialogResult.OK && (fileStream = openFileDialog1.OpenFile()) != null)
            {
                string fileName = openFileDialog1.FileName;
                txtUrl.Text = fileName;
                using (fileStream)
                {
                    // TODO
                }
            }
        }
    }
}
