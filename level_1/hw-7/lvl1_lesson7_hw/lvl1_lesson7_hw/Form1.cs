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
        private int countClickComm = 0;
        private int finResult = 123;
        private int returnResult = 0;

        public Form1()
        {
            InitializeComponent();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            returnResult = int.Parse(lblResult.Text);
            countClickComm++;
            lblResult.Text = "0";   
        }

        private void btnPlusOne_Click(object sender, EventArgs e)
        {
            countClickComm++;
            returnResult = int.Parse(lblResult.Text); //Сохраним для возможности вернуться на шаг назад
            lblResult.Text = (int.Parse(lblResult.Text)+1).ToString();
            if (finResult == int.Parse(lblResult.Text))                
            {
                var textmsg = "Поздравляем! Вы выиграли. Вы достигли результата за " + countClickComm.ToString() + " ходов";
                MessageBox.Show(textmsg,"Finish");
            } 
        }

        private void btnMultiTwo_Click(object sender, EventArgs e)
        {
            countClickComm++;
            returnResult = int.Parse(lblResult.Text); //Сохраним для возможности вернуться на шаг назад
            lblResult.Text = (int.Parse(lblResult.Text) *2).ToString();
            if (finResult == int.Parse(lblResult.Text))
            {
                var textmsg = "Поздравляем! Вы выиграли. Вы достигли результата за " + countClickComm.ToString() + " ходов";
                MessageBox.Show(textmsg,"Finish");
            }
           
        }

        private void игратьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            countClickComm = 0;
            var textmsg = "Добро пожаловать в игру Удвоитель.\nЦель игры достигнуть числа " + this.finResult.ToString() + " за наименьшее количество ходов";
            MessageBox.Show(textmsg,"start");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            countClickComm--;//По идее если делаем шаг назад, то нужно уменьшить и кол-во шагов, хотя хз, может быть и правильнее добавить кол-во ходов
            lblResult.Text = returnResult.ToString();
        }
    }
}
