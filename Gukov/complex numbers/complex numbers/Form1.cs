using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryComplexNumb;

namespace complex_numbers
{
    public partial class Form1 : Form
    {
        ComplexNum a = new ComplexNum();
        ComplexNum b = new ComplexNum(0);
        ComplexNum c = new ComplexNum(0,0);
        public Form1()
        {
            InitializeComponent();
            labelIm.Visible = false;
            labelRe.Visible = false;
            boxIm2.Visible = false;
            boxRe2.Visible = false;
            buttonStart.Visible = false;
            boxRe.Text = "1";
            boxIm.Text = "1";
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonStart.Visible = true;
            if (comboBox.SelectedIndex < 3)
            {
                buttonStart.Location = new Point(76, 100);
                labelIm.Visible = true;
                labelRe.Visible = true;
                boxIm2.Visible = true;
                boxRe2.Visible = true;
            }
            else
            {
                buttonStart.Location = new Point(76, 76);
                labelIm.Visible = false;
                labelRe.Visible = false;
                boxIm2.Visible = false;
                boxRe2.Visible = false;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (comboBox.SelectedIndex < 3)
            {
                b.Re = Convert.ToDouble(boxRe2.Text);
                b.Im = Convert.ToDouble(boxIm2.Text);
            }
            a.Re = Convert.ToDouble(boxRe.Text);
            a.Im = Convert.ToDouble(boxIm.Text);
            switch (comboBox.SelectedIndex)
            {
                case 0:
                    c = a + b;
                    labelOut.Text = c.ToString();
                    break;
                case 1:
                    c = a - b;
                    labelOut.Text = c.ToString();
                    break;
                case 2:
                    c = a * b;
                    labelOut.Text = c.ToString();
                    break;
                case 3:
                    // a.abs().ToString()
                    labelOut.Text = string.Format("{0:F4}",a.abs());
                    break;
                case 4:
                    labelOut.Text = string.Format("{0:F4}", a.argument());
                    break;
            }
        }
    }
}
