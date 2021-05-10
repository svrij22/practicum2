using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace practicum2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Random random = new Random();
            num1Text.Text = random.Next(1, 10).ToString();
            num2Text.Text = random.Next(1, 10).ToString();
            num3Text.Text = random.Next(1, 10).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;
            
            try
            {
                num1 = Int32.Parse(num1Text.Text);
                num2 = Int32.Parse(num2Text.Text);
                num3 = Int32.Parse(num3Text.Text);

                CheckRunner.CheckAllMethods(num1, num2, num3);
                MessageBox.Show("OK");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            
            String output = MethodRunner.RunAllMethods(num1,num2,num3);
            methodOutput.Text = output;

            output = LambdaRunner.RunAllMethods(num1,num2,num3);
            lambdaOutput.Text = output;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            num1Text.Text = random.Next(1, 10).ToString();
            num2Text.Text = random.Next(1, 10).ToString();
            num3Text.Text = random.Next(1, 10).ToString();
        }
    }
}
