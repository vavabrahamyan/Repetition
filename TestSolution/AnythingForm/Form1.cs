using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnythingForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            if (checkBox_Add.Checked)
            {
                string str = "Addation:" + (numericUpDown1.Value + numericUpDown2.Value).ToString();
                if (label1.Text == "")
                    label1.Text = str;
                else if (label2.Text == "")
                    label2.Text = str;
                else if (label3.Text == "")
                    label3.Text = str;
                else
                    label4.Text = str;
            }
            if (checkBox_Remve.Checked)
            {
                string str = "Removing:" + (numericUpDown1.Value - numericUpDown2.Value).ToString();
                if (label1.Text == "")
                    label1.Text = str;
                else if (label2.Text == "")
                    label2.Text = str;
                else if (label3.Text == "")
                    label3.Text = str;
                else
                    label4.Text = str;
            }
            if (checkBox_Multiple.Checked)
            {
                string str = "Multipling:" + (numericUpDown1.Value * numericUpDown2.Value).ToString();
                if (label1.Text == "")
                    label1.Text = str;
                else if (label2.Text == "")
                    label2.Text = str;
                else if (label3.Text == "")
                    label3.Text = str;
                else
                    label4.Text = str;
            }
            if (checkBox_Divide.Checked && numericUpDown2.Value != 0)
            {
                string str = "Dividing:" + (numericUpDown1.Value / numericUpDown2.Value).ToString();
                if (label1.Text == "")
                    label1.Text = str;
                else if (label2.Text == "")
                    label2.Text = str;
                else if (label3.Text == "")
                    label3.Text = str;
                else
                    label4.Text = str;
            }
        }
    }
}
