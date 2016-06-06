using System;
using System.Threading;
using System.Globalization;
using System.Windows.Forms;

namespace Culture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(CultureInfo ci in CultureInfo.GetCultures(CultureTypes.AllCultures))
            {
                MessageBox.Show(ci.EnglishName+ " - " + ci.Name);
            }
        }
    }
}
