﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lvl1_lesson5_hw
{
    class MyString
    {
        public string Msg { get; set; }
        
        // а) Вывести только те слова сообщения,  которые содержат не более чем n букв;
        public string GetMsg(int n)
        {
            string[] str = this.Msg.Split(' ');
            string newmsg = "";
            foreach (var item in str)
            {
                if (item.Length <= n)
                {
                    newmsg = newmsg + " " + item;
                }
            }
            return newmsg;
        }


        internal void DeleteToEndSymbol(char sym)
        {
            StringBuilder strbl = new StringBuilder(this.Msg);
        }
    }
}
