using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week9G2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int ind = 1;
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Button btn = new Button();
                    btn.Text = ind.ToString();
                    ind++;
                    btn.Location = new Point(j * 50, i * 50);
                    btn.Size = new Size(40, 40);
                    btn.Click += new EventHandler(number_click);
                    Controls.Add(btn);
                }
            }
        }

        private void number_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox1.Text += btn.Text;
        }
    }
}
