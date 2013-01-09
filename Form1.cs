using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFSP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog oF = new OpenFileDialog();
            oF.Filter = "txt files (*.txt)| *.txt|All files (*.*)|*.*";
            if (oF.ShowDialog() == DialogResult.OK)
            {
                string[] files = oF.FileNames;
                //Table create
                foreach (var file in files)
                {
                    //Table fill
                }
                //Table show
            }
            //Fill table
            //splitContainer2.Panel1. Add Table
        }
    }
}