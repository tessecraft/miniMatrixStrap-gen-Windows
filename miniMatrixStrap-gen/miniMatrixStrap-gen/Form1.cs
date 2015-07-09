using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniMatrixStrap_gen
{
    public partial class Form1 : Form
    {
        Boolean modifiedFiles = false;
        Boolean newFile = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void NewButtonClick(object sender, EventArgs e)
        {
            if (modifiedFiles)
            {
                switch (MessageBox.Show("This file not saved!!\n\nSave?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1))
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        //Saving
                        
                        break;
                    case System.Windows.Forms.DialogResult.No:
                        break;
                    case System.Windows.Forms.DialogResult.Cancel:
                        return;
                }
            }

            //NewFile
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            if (newFile)
            {
                //Save As
                SaveAsButtonClick(null, null);
            }
            else
            {
                //Save
            }

        }

        private void SaveAsButtonClick(object sender, EventArgs e)
        {
            switch (saveFileDialog1.ShowDialog())
            {
                case System.Windows.Forms.DialogResult.OK:
                    //Saving
                    break;
                case System.Windows.Forms.DialogResult.Cancel:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Add Shortcut Keys
        }


    }
}
