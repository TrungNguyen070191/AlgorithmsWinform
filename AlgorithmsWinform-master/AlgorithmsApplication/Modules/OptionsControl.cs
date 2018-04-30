using System;
using System.Windows.Forms;
using System.IO;
using AlgorithmsApplication.Utilities;

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
            String line;
            //Update - remove parenthesis
            if (openFileDialog1.ShowDialog() == DialogResult.OK && (fileStream = openFileDialog1.OpenFile()) != null)
            {
                string fileName = openFileDialog1.FileName;
                txtUrl.Text = fileName;
                using (fileStream)
                {
                   
                    StreamReader sr = new StreamReader(fileName);


                    line = sr.ReadLine();
                    Int32[] tmp = new Int32[2];
                    int j = 0;
                    for (int i = 0; i < line.Length; i++)
                    {
                        
                        if (line.Substring(i, 1) != " ")
                        {
                            tmp[j] = Convert.ToInt32(line.Substring(i, 1));
                            j++;
                        }
                    }
                   
                   Globalgraph.g = new Graph(tmp[0], tmp[1]);
                    //Continue to read until you reach end of file
                    j = 0;
                    line = sr.ReadLine();
                    while (line != null)
                    {
                        Int32[] tmp1 = new Int32[2];
                        for (int i = 0; i < line.Length; i++)
                        {
                            if (line.Substring(i, 1) != " ")
                            {
                                tmp1[j] = Convert.ToInt32(line.Substring(i, 1));
                                j++;
                            }
                        }
                        Globalgraph.g.AddEdge(tmp1[0], tmp1[1]);
                        j = 0;
                        line = sr.ReadLine();
                    }

                    //close the file
                    sr.Close();
                    Console.ReadLine();

                }
            }
        }
    }
    public class Globalgraph
    {
        public static Graph g = new Graph(0, 0);
        public static String Ketqua = "";
        public static int len = 0;
    }
}
