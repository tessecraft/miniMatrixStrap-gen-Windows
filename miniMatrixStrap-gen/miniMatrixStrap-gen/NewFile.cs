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
    public partial class NewFile : Form
    {

        public int width = 0;
        public int height = 0;

        public NewFile()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = 4;
            numericUpDown2.Value = 20;  //TODO: Rと仕様相談
        }
    }
}
