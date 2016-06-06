using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //comparison of two ints
            int count = 4;
            for(int i=1;i<=count;i++)
            {
                MessageBox.Show("Current value of i is -"+i);
            }
            //set int for comparison
            for (int i=1;i<=5;i++)
            {
                if (i == 2) continue;
                if (i == 3) break;
                MessageBox.Show("execut " + i + " times !!");
            }
            //for each loop
            string[] days = { "Sunday","Monday","TuesDay","Wednsday","Thursday","Friday","Saturday"};
            foreach(string day in days)
            {
                MessageBox.Show("The Day is : "+day);
            }
            //while
            int cnt = 1;
            while(cnt<=4)
            {
                MessageBox.Show("The value of i is : "+cnt);
                cnt += 1;
            }
            //do while loop
            int c = 4;
            do{
                MessageBox.Show(" Loop Exectued :"+c);
                c++;
            } while (c <= 4);

        }
    }
}
