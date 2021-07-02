using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Designer
{
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
            openFileDialog1.Filter = "XML-File | *.xml";
            saveFileDialog1.Filter = "XML-File | *.xml";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
 
            string filename = openFileDialog1.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            MessageBox.Show("File opened!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //string filename = openFileDialog1.FileName;
                //FileName.Save(saveFileDialog1.FileName);
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
