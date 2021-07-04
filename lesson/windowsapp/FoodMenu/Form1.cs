using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodMenu
{
    public partial class Form1 : Form
    {
        private int money = 0;
        private int count = 0;
        private int count1 = 0;
        private int count2 = 0;
        private int count3 = 0;
        private int count4 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            money += 68;
            count1++;
            count++;
            label2.Text = "总消费"+money + "元";
            label3.Text = "您点了" + count1 + "道牛排";
            label7.Text = "共" + count + "道菜";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            money += 30;
            count2++;
            count++;
            label2.Text = "总消费" + money + "元";
            label7.Text = "共" + count + "道菜";
            label4.Text = "您点了" + count2 + "道白菜粉条";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            money += 15;
            count3++;
            count++;
            label5.Text = "您点了" + count3 + "道炸鸡腿"; 
            label7.Text = "共" + count + "道菜";
            label2.Text = "总消费" + money + "元";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            money += 10;
            count4++;
            count++;
            label2.Text = "总消费" + money + "元";
            label7.Text = "共" + count + "道菜";
            label6.Text = "您点了" + count4 + "道蛋炒饭";
        }

        
    }
}
