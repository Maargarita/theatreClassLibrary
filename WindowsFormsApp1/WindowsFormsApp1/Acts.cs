using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Acts : Form
    {
        public Acts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int acts = Convert.ToInt32(textBox1.Text);

            MessageBox.Show("Продолжительность спектакля: " + ClassLibrary1.Class1.TotalTime(acts));
        }
    }
}
