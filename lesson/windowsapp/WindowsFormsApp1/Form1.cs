using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class 我的第一个窗口 : Form
    {
        private static int bcount = 0;
        public 我的第一个窗口()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (bcount%13) 
            {
                case 0:this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.iu2;bcount++; break;
                case 1:this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Jisoo1;bcount++; break;
                case 2: this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.允儿1; bcount++; break;
                case 3: this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.彩英1; bcount++; break;
                case 4: this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.彩英2; bcount++; break;
                case 5: this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.彩英3; bcount++; break;
                case 6: this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.彩英4; bcount++; break;
                case 7: this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.彩英5; bcount++; break;
                case 8: this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.霉霉1; bcount++; break;
                case 9: this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.飞鸟1; bcount++; break;
                case 10: this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.飞鸟2; bcount++; break;
                case 11: this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.允儿2; bcount++; break;
                case 12: this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.允儿3; bcount++; break;
                case 13: this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.允儿4; bcount++; break;
            }
        }

        private void 我的第一个窗口_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

       

       

        
    }
}
