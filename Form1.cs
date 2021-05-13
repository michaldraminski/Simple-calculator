using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_kalkulator
{
    public partial class Form1 : Form
    {
        string operation="";
        double first, second;

        public void UpdateColorControls(Control myControl)
        {
            if ((myControl is Button) && blue_mode.Checked)
            {
                myControl.BackColor = Color.White;
                myControl.ForeColor = Color.Black;
            }
            else if ((myControl is Button) && night_mode.Checked)
            {
                myControl.BackColor = Color.Black;
                myControl.ForeColor = Color.White;
            }
        }

        private void Value(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (display.Text == "0")
                display.Text = "";
            if (b.Text == ",")
            {
                if (display.Text.Contains(",") == false)
                    display.Text = display.Text + ",";
            }
            else
                display.Text = display.Text + b.Text;
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (display.Text!="")
            {
                display.Text = display.Text.Remove(display.Text.Length - 1, 1);
            }
            if (display.Text == "")
            {
                display.Text = "0";
            }
        }

        private void ce_Click(object sender, EventArgs e)
        {
            display.Text = "0";
            String f, s;
            f = Convert.ToString(first);
            s = Convert.ToString(second);
            s = "";
            f = "";
        }

        private void c_Click(object sender, EventArgs e)
        {
            display.Text = "0";
        }

        private void changesign_Click(object sender, EventArgs e)
        {
            display.Text = Convert.ToString(-float.Parse(display.Text));
        }

        private void Operation_Function(object sender, EventArgs e)
        {
            if (display.Text != "")
            {
                try
                {
                    Button b = (Button)sender;
                    first = Double.Parse(display.Text);
                    operation = b.Text;
                    display.Text = "";
                }
                catch
                {};
            }
           
        }

        private void equals_Click(object sender, EventArgs e)
        {
            if (operation != "")
            {
                try
                {
                    second = double.Parse(display.Text);
                    switch (operation)
                    {
                        case "+":
                            display.Text = Convert.ToString(Convert.ToDouble(first) + Convert.ToDouble(second));
                            break;
                        case "-":
                            display.Text = Convert.ToString(Convert.ToDouble(first) - Convert.ToDouble(second));
                            break;
                        case "*":
                            display.Text = Convert.ToString(Convert.ToDouble(first) * Convert.ToDouble(second));
                            break;
                        case "/":
                            display.Text = Convert.ToString(Convert.ToDouble(first) / Convert.ToDouble(second));
                            break;
                        default:
                            break;
                    }
                }
                catch
                {

                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zegarek.Text = DateTime.Now.ToString("T");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            zegarek.ForeColor = Color.DarkSlateGray;
            night_mode.ForeColor = Color.DarkSlateGray;
            blue_mode.ForeColor = Color.DarkSlateGray;
            UpdateColorControls(button0);
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.SteelBlue;
            zegarek.ForeColor = Color.White;
            night_mode.ForeColor = Color.White;
            blue_mode.ForeColor = Color.White;
            foreach(var button in this.Controls.OfType<Button>())
            {
                UpdateColorControls(button);
            }
            
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
