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
    public partial class Days : Form
    {
        public Days()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime currentDate = dateTimePicker1.Value.Date;
            DateTime eventDate = dateTimePicker2.Value.Date;

            MessageBox.Show("До спектакля: " + ClassLibrary1.Class1.GetDays(currentDate, eventDate) + " дней");
        }
    }
}
