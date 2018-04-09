using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lvl1_lesson7_hw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblResult.Text = "0";   
        }

        private void btnPlusOne_Click(object sender, EventArgs e)
        {
            lblResult.Text = (int.Parse(lblResult.Text)+1).ToString();
            
        }

        private void btnMultiTwo_Click(object sender, EventArgs e)
        {
            lblResult.Text = (int.Parse(lblResult.Text) *2).ToString();
        }
    }
}
