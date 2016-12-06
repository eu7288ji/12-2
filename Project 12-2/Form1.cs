using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_12_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start(); //initialize timer start
        }

        private void timer1_Tick(object sender, EventArgs e) //form date timer
        {
            DateTime dateTime = DateTime.Now; //initializing dateTime to get called
            this.Text = dateTime.ToString(); //shows date and time within form text area
        }

        private void btnExit_Click(object sender, EventArgs e) //close
        {
            this.Close(); //close on click
        }
    }
}
