using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lvl1_lesson7_hw_task2
{
    public partial class Form1 : Form
    {
        
        private int RndRes;//загаданное число
        private string msgtxt;           
        
        
        public Form1()
        {
            InitializeComponent();

            Random rnd = new Random();
            RndRes = rnd.Next(1, 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UsrTextBox.Text != RndRes.ToString())
            {
                 msgtxt = "Не угадали, попробуйте ещё раз!";
            }
            else
            {
                msgtxt = "А вы везунчик";
            }
            MessageBox.Show(msgtxt, "Результат проверки:");
        }
    }
}
