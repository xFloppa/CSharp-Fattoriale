using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fattoriale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            int num, i, fatt;
            num = Convert.ToInt32(textBox1.Text);
            fatt = 1;
                for (i = 1; i <= num; i++){
                fatt = fatt * i;
                }
            textBox2.Text = fatt.ToString();

        }

    }
}
