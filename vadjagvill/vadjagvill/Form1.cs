using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace vadjagvill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 Obj = new Class1();
            Obj.SetValue(3, 6);
            textBox1.Text = Convert.ToString(Obj.GetX());
            textBox2.Text = Convert.ToString(Obj.GetY());
        }
    }
}
