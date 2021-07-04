using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogIn
{
    public partial class Form1 : Form
    {
        //登录成功后的跳转界面
        Form2 f2 = new Form2();
        //用户名
        private static string name = "21900387";
        //密码
        private static string password = "cxwcxwcxw.";
        //密码输入错误的尝试次数(错三次退出界面)
        private static int trycount = 0;
        //图片轮流播放计数器
        private static int i = 1;
        //设置登录按钮是否可用
        void Enable()
        {
            if( textBox1.Text.Length>0 && textBox2.Text.Length > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
        //判断用户名是否超过八位
        bool UserNameIsFull()
        {
            return  textBox1.Text.Length > 8;
        }
        //判断密码是否符合规则
        bool PassWordIsLegal()
        {
            int count1 = 0;
            int count2 = 0;
            string str = textBox2.Text;
            char[] cha = str.ToCharArray();
            foreach(char ch in cha)
            {
                if (char.IsLetter(ch)){ count1++; }
                if (char.IsPunctuation(ch)){ count2++; }
            }
            return count1 > 0 && count2 > 0;
        }
        //判断密码长度是否符合要求
        bool PasswordLength()
        {
            return textBox2.Text.Length >= 8 && textBox2.Text.Length <= 14;
        }

        public Form1()
        {
            InitializeComponent();
        }
        
        //用户名输入
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (char.IsNumber(e.KeyChar)||e.KeyChar==8)
            {
                
                label3.Text = "";
                e.Handled = false;
            }
            else 
            {
                e.Handled = true;
                label3.Text = "请输入数字!"; 
            }
            if (UserNameIsFull())
            {
                label3.Text = "用户名最多不能超过八位";
            }
            Enable();
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar)||char.IsNumber(e.KeyChar)|| e.KeyChar == 8)
            {
                
                label4.Text = "";
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                label4.Text = "密码不符合要求";
            }
            Enable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Equals(name) && textBox2.Text.Equals(password) && PasswordLength() && PassWordIsLegal())
            {
                f2.Show();
            }
            else
            {
                if (!name.Equals(textBox1.Text))
                {
                    DialogResult = MessageBox.Show("用户名不存在是否注册","用户名不存在", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                }
               
                trycount++;
            }
            if (DialogResult == DialogResult.OK)
            {
                Form3 f3 = new Form3();
                f3.Show();
            }
            if (trycount == 3)
            {
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Enable();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Enable();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           //设置图片轮流播放
            string Path1 = @".\pictures\"+i.ToString()+".png";
            FileStream pFileStream = new FileStream(Path1, FileMode.Open, FileAccess.Read);
            pictureBox1.Image = Image.FromStream(pFileStream);
            i++;
            //图片播完后重置计数器从头重新播放
            if (i > 7)
            {
                i = 1;
            }
            pFileStream.Close();
            pFileStream.Dispose();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;//启用控件
            this.timer1.Interval = 3000;//每三秒执行一次
        }
    }
}
