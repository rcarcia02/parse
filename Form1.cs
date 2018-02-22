using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parse
{
    public partial class frmChooseFile : Form
    {
        public frmChooseFile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog box.
            if (result == DialogResult.OK) // Test result.
            {
                string fileName = openFileDialog1.FileName; // Will be in form M://...etc.

                using (StreamReader sr = new StreamReader(fileName, Encoding.Default))
                {
                    string text = sr.ReadToEnd();
                    string[] lines = text.Split(' ');
                    foreach (string s in lines)
                    {
                        listBox1.Items.Add(s);
                    }
                }
            }
        }
    }
}
