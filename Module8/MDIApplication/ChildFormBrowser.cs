using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIApplication
{
    public partial class ChildFormBrowser : Form
    {
        public ChildFormBrowser()
        {
            InitializeComponent();
        }

        private void ChildFormBrowser_Load(object sender, EventArgs e)
        {

        }

        // method to perform an action when button 1 is clicked
        private void button1_Click(object sender, EventArgs e)
        {
            // tells the browser to go back one page
            webBrowser1.GoBack();
        }

        // method to perform an action when button 2 is clicked
        private void button2_Click(object sender, EventArgs e)
        {
            // tells the browser to go forward one page
            webBrowser1.GoForward();
        }

        // method to perform an action when button 3 is clicked
        private void button3_Click(object sender, EventArgs e)
        {
            // tells the browser to navigate to the website entered 
            // in the text box
            webBrowser1.Navigate(textBox1.Text);
        }

        // method to perform an action when button 4 is clicked
        private void button4_Click(object sender, EventArgs e)
        {
            // tells the browser to go to the home page
            webBrowser1.GoHome();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        // created this button to show a dialog (ColorDialog)
        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();

            // keeps the user from selecting a custom color
            MyDialog.AllowFullOpen = false;

            // allows the user to get help. (Default is false)
            MyDialog.ShowHelp = true;

            //sets the initial color to current text color
            MyDialog.Color = textBox1.ForeColor;

            //update the text box color if user clicks ok
            if (MyDialog.ShowDialog() == DialogResult.OK)
                textBox1.ForeColor = MyDialog.Color;

            
        }
    }
}
