using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Media;
using System.Reflection;
using System.Diagnostics;

namespace Counting_numbers
{
    public partial class Form1 : Form
    {
        Random random;

        int i = 0;

        int k = 3;

        SpeechSynthesizer synthesizer;

        int score = 0;

        bool flag = false;

        int num;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == num.ToString())
                score += 5;

            else
                score -= 5;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == num.ToString())
                score += 5;

            else
                score -= 5;
        }

        private void unvisible()
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;

            groupBox1.Visible = false;

            this.BackgroundImage = Properties.Resources.UI;


        }

        private void visible()
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

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;

            groupBox1.Visible = true;

            this.BackgroundImage = Properties.Resources.BG;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            transparent();

            timer1.Start();
            label2.Text = score.ToString();

            label3.Text = "Note : Listen the sound carefully and press the button according to speech";

            label4.Text = "(Increase the volume to listen carefully)";

            label5.Text = "";

            unvisible();
        }

        private void transparent()
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;

            groupBox1.BackColor = Color.Transparent;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;

            if(k != 0)
            {
                label5.Text = k.ToString();
                k--;
            }

            if (i == 4)
            {
                timer1.Interval = 1300;
                flag = true;
                visible();

                label5.Visible = false;
            }

            if(i == 15)
            {
                flag = false;

                horror obj = new horror();


                this.Hide();

                obj.ShowDialog();

                this.Close();

            }
            
            if(flag)
            {
                random = new Random();
                synthesizer = new SpeechSynthesizer();

                synthesizer.Volume = 100;

                num = random.Next(1, 9);
                label2.Text = score.ToString();

                //label3.Text = num.ToString();

                synthesizer.SpeakAsync(num.ToString());
            }
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == num.ToString())
                score += 5;

            else
                score -= 5;

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == num.ToString())
                score += 5;

            else
                score -= 5;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == num.ToString())
                score += 5;

            else
                score -= 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == num.ToString())
                score += 5;

            else
                score -= 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == num.ToString())
                score += 5;

            else
                score -= 5;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == num.ToString())
                score += 5;

            else
                score -= 5;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == num.ToString())
                score += 5;

            else
                score -= 5;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
