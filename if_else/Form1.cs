using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_else
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int totalMarks = 59;

            if(totalMarks>=80){MessageBox.Show("Got Higher First Class ");}
            else if(totalMarks>=60){MessageBox.Show("Got First Class");}
            else if(totalMarks>=40){MessageBox.Show("Just Pass Only");}
            else {MessageBox.Show("Failed");}
        }
    }
}
