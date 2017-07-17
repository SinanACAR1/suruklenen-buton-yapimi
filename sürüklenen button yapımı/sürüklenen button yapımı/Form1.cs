using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool sürüklensinmi = false;
        Point ilkkonumual;

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            sürüklensinmi = true;
            ilkkonumual = e.Location;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (sürüklensinmi)
            {
                button1.Left = e.X + button1.Left - (ilkkonumual.X);
                button1.Top = e.Y + button1.Top - (ilkkonumual.Y);
            
            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            sürüklensinmi = false;
        }
    }
}
