using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AlgorithmsApplication.Modules
{
    public partial class DisplayDataControl : UserControl
    {
        public DisplayDataControl()
        {
            InitializeComponent();
        }

        private void Txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Txt1.Text = null;
            Txt1.Text = Globalgraph.Ketqua;
        }

       
    }
}
