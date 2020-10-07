using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trial1 //This is the title of the program, "Trial 1"
{
    public partial class Welcome : Form //This is the title of the form, "Welcome"
    {
        public Welcome()
        {
            InitializeComponent(); //This locates the necessary code
        }

        private void Form1_Load(object sender, EventArgs e) //This activates Form1 or the Welcome Form
        {

        }

        private void Label1_Click(object sender, EventArgs e) //Generates the "Welcome, click next to continue" 
        {

        }

        private void Next_Click(object sender, EventArgs e) //This means when the user clicks, this form will be hidden (close), and the second form "Sysselect" will open
        {
            this.Hide();
            SysSelect f2 = new SysSelect();
            f2.Show();
        }
    }
    }
