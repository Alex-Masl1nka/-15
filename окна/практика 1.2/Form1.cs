using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace практика_1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;
            Text = "Мили - километры";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "Указанное число миль равно: "+Convert.ToString(float.Parse(textBox2.Text) * 1.60934)+"км";
        }
    }
}
