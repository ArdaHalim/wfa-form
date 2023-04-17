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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class2 Obj2 = new Class2();

            Obj2.SetValues2("arda", "halim", 17, true, "Göteborg");

            textBox1.Text = Obj2.GetFname();
            textBox2.Text = Obj2.GetLname();
            textBox3.Text = Convert.ToString(Obj2.GetAge());
            textBox4.Text = Convert.ToString(Obj2.GetStudent());
            textBox5.Text = Obj2.GetAdress();
        }
    }
}
