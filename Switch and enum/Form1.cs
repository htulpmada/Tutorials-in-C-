using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_enum_and_Exception_handle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum Temperature
        {
            Low,
            Medium,
            High
        };
        public enum Colors
        {
            red,blue,green,yellow
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string inVal = "green";
            Colors newColor = (Colors)Enum.Parse(typeof(Colors), inVal);
            //check type
            if(newColor == Colors.green)
            {
                MessageBox.Show(newColor.ToString());
            }
            //Loop through all values in enum
            foreach (Colors iColor in Enum.GetValues(typeof(Colors))) { MessageBox.Show(iColor.ToString());}
            Temperature value = Temperature.Medium;
            if(value==Temperature.Medium)
            {
                MessageBox.Show("Temperature is Medium.. ");
            }
            try
            {
                int val = 100;
                int div = 0;
                int resultVal;
                resultVal = (val / div);
                MessageBox.Show("The result is :" + resultVal);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception catch here - details : " + ex.ToString());
            }
            finally { MessageBox.Show("Enter Finally block "); }
            findStatus("A+");
        }
        public void findStatus(string val) 
        {
            switch(val)
            {
                case "A+":
                    MessageBox.Show("Excellent !!");
                    break;
                case "A":
                    MessageBox.Show("Very Good !!");
                    break;
                case "B":
                    MessageBox.Show("Good !!");
                    break;
                case "C":
                    MessageBox.Show("Passed !!");
                    break;
                case "D":
                    MessageBox.Show("Failed !!");
                    break;
                default:
                    MessageBox.Show("Out of Range !!");
                    break;
            }
        }
    }
}
