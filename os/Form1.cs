using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace taskoo
{
    public partial class Form1 : Form
    {
        int x, y = 100;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle((Brushes.Green), x, y, 50, 50);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.D)
            {
                x += 5;
            }
            if (e.KeyData == Keys.A)
            {
                x -= 5;
            }
            if (e.KeyData == Keys.W)
            {
                y -= 5;
            }
            if (e.KeyData == Keys.S)
            {
                y += 5;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void moveTimer_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }
        

        
    }
}
