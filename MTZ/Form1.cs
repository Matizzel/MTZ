using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MTZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Рядом 2-е мины. Пока что, вы живы");
            button2.BackColor = Color.Red;
            button4.BackColor = Color.Red;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тут мина, вас разорвало на кусочки");
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тут мина, вам оторвало ноги и вы умерли от шока и потери крови");
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы наступили на замелю. Вы подняли ногу. Ничего не взорвалось. Вы остались живы. Рядом примерно 3-и взрывчатых устройств");
            button6.BackColor = Color.Red;
            button4.BackColor = Color.Red;
            button2.BackColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("А тут была мина. Да, конкретно тут. Вас порвало на клочки");
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы наступили на землю. Вы услышали полутихий щелчёк. Вы рискнули и подняли ногу. Противопехотная мина оказалась сильнее вашей решимости");
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вроде всё тихо. Вы остались живы, однако где-то точно ползает одна минка, где-то рядом...");
            button4.BackColor = Color.Red;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Где-то рядом точно есть мина. Конкретно тут её нет - вам повезло");
            button9.BackColor = Color.Red;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Да, здесь мина. Прям тут. Какая уже разница - вы уже погибли");
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = false;
        }
    }
}
