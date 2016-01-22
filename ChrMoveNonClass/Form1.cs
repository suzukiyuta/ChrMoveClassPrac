using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
       


        public Form1()
        {
            InitializeComponent();
        }   

        /** 直線移動キャラ生成*/
        private void button1_Click(object sender, EventArgs e)
        {
            CStraight.InstantiateChr();
        }

        /** 重力キャラ生成*/
        private void button2_Click(object sender, EventArgs e)
        {
            CGravity.InstantiateChr();
        }

        /** 加速キャラ生成*/
        private void button3_Click(object sender, EventArgs e)
        {
            InstantiateChr(CHRTYPE.CHR_ADD);
        }

       
}
