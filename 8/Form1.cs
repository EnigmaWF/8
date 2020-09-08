using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t = Convert.ToString(textBox1.Text);
            string[] arr = t.Split(' ');
            int n = 0;//счетчик 
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i].IndexOf('а') == 0) || (arr[i].IndexOf('a') == 0)) // ru "a" or en "a"
                {
                    n++;
                }
            }
            label1.Text = "количество слов на а " + n;
            /*8.Дана строка, содержащая слова, разделенные одним или несколькими пробелами. 
             * Подсчитать количество слов, начинающихся на букву а.*/
        }
    }
}
