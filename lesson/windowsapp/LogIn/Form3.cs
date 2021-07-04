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
    public partial class Form3 : Form
    {
        string sex;//性别
        //添加籍贯选项
        public void My_Combobox1()
        {
            comboBox1.Items.Add("上海");
            comboBox1.Items.Add("四川");
            comboBox1.Items.Add("广州");
        }

        //添加具体位置
        public void My_Combobox2()
        {
            comboBox2.Items.Add("松江");
            comboBox2.Items.Add("成都");
            comboBox2.Items.Add("广州");
        }
        //添加民族选项
        public void My_ComboBox3()
        {
            comboBox3.Items.Add("汉族");
            comboBox3.Items.Add("傣族");
            comboBox3.Items.Add("保安族");
        }
        //添加院系选项
        public void My_ComboBox4()
        {
            comboBox4.Items.Add("信息技术系");
            comboBox4.Items.Add("机电系");
            comboBox4.Items.Add("化工系");
        }
        //添加专业选项
        public void My_ComboBox5()
        {
            comboBox5.Items.Add("软件工程");
            comboBox5.Items.Add("大数据");
           
        }
        //添加年级选项
        public void My_ComboBox6()
        {
            comboBox7.Items.Add("20级");
            comboBox7.Items.Add("19级");
            comboBox7.Items.Add("18级");
        }
        //添加班级选项
        public void My_ComboBox7()
        {
            comboBox6.Items.Add("1班");
            comboBox6.Items.Add("2班");
            comboBox6.Items.Add("3班");
        }
        public Form3()
        {
            InitializeComponent();
            //调用方法
            My_Combobox1();
            My_Combobox2();
            My_ComboBox3();
            My_ComboBox4();
            My_ComboBox5();
            My_ComboBox6();
            My_ComboBox7();
        }
        //判断性别
        public void Sex()
        {
            if (radioButton1.Checked == true)
            {
                sex = "男";
            }
            else
            {
                sex = "女";
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {//不输入手机号无法注册
            if (textBox3.Text.Length > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
            if (char.IsNumber(e.KeyChar)||e.KeyChar==8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Length != 11)
            {
                MessageBox.Show("请输入正确的手机号");
            }
            //显示学生信息
            else
            {
                richTextBox1.Text ="学号:"+ textBox1.Text + "\n" +"姓名:"+ textBox2.Text+"\n" +"年龄:"+ numericUpDown1.Value + "岁"+"\n"+"性别:" + sex + "\n" + "院系:" + comboBox4.SelectedItem +"\n"+ "专业:" + comboBox5.SelectedItem + "\n" + "年级:" + comboBox7.SelectedItem + "\n"+"班级:" + comboBox6.SelectedItem + "\n" + "籍贯:" + comboBox1.SelectedItem + comboBox2.SelectedItem + "\n" + "民族:" + comboBox3.SelectedItem + "\n" + "联系方式:" + textBox3.Text;
                //将学生信息保存到记事本中
                StreamWriter rw = new StreamWriter("StudentInformation.txt",true);//true为可以向文件中追加内容
                rw.WriteLine(richTextBox1.Text);
                rw.WriteLine();
                rw.Flush();
                rw.Close();

                MessageBox.Show("注册成功");
            }
        }
    }
}
