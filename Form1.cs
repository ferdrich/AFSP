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
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            //oF.Filter = "txt files (*.txt)| *.txt|All files (*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                treeViewLeft.CheckBoxes = true;
                //Table create
                foreach (var file in fileDialog.FileNames)
               {
                    //treeViewLeft.Nodes.Add()

                    
                   fileListView.Items.Add(file);
                    //Table fill
               }
                //Table show
            }
            //Fill table
            //splitContainer2.Panel1. Add Table
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "Select the directory that you want to share with the comunity.";
            folderDialog.ShowNewFolderButton = false;

            // Default to the My Documents folder.
            //folderDialog.RootFolder = Environment.SpecialFolder.Personal;
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(folderDialog.SelectedPath);
                System.IO.FileSystemInfo[] files = di.GetFiles();
                foreach (var file in files)
                {
                    fileListView.Items.Add(file);
                }
                
            }
        }
    }
}