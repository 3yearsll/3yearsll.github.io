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

namespace Textbox
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            richTextBox1.Font = new Font(str, richTextBox1.Font.Size);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float size = float.Parse(textBox2.Text);
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, size);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 nf1 = new Form1();
            nf1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("NewTxt.txt",true))
            {
                writer.Write(this.richTextBox1.Text);
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                Clipboard.SetDataObject(richTextBox1.SelectedText);
                richTextBox1.SelectedText = "";
            }
            else
            {
                MessageBox.Show("你没有选中任何内容");
            }
                
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                Clipboard.SetDataObject(richTextBox1.SelectedText);
                
            }
            else
            {
                MessageBox.Show("你没有选中任何内容");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(this.Font, FontStyle.Bold);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(this.Font, FontStyle.Italic);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(this.Font, FontStyle.Underline);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(this.Font,FontStyle.Strikeout);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectAll();
            this.richTextBox1.SelectionBackColor = Color.LightBlue;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectedText = "";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.richTextBox1.Focus();
            this.richTextBox1.SelectionBackColor = Color.White;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionFont = new Font(this.Font.FontFamily,this.Font.Size,FontStyle.Regular);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            DialogResult re = cd.ShowDialog();
            if (re == DialogResult.OK)
            {
                richTextBox1.SelectionColor = cd.Color;
            }
        }
    }
    
}
