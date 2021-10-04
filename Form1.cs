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

namespace QuizPRG282
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Cameron\Google Drive\Belgium Campus\Year 2\PRG282\Git\QuizPRG282\Names.txt";
            string txt;

            using (TextReader textReader = File.OpenText(path))
            {

                while ((txt = textReader.ReadLine()) != null )
                {
                    lbDisplay.Items.Add(txt);
                }

            }

        }
    }
}
