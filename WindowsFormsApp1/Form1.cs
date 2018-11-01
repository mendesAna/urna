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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.MaxLength = 2;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int candidato;
            candidato = Convert.ToInt32(textBox1.Text);



            switch (candidato)
            {




                case 19:

                    pictureBox1.Image = Properties.Resources._19;
                    MessageBox.Show("Voto confirmado");
                    textBox1.Clear();
                    pictureBox1.Image = Properties.Resources.Fim;


                    break;

                case 51:

                    pictureBox1.Image = Properties.Resources._51;
                    MessageBox.Show("Voto confirmado");
                    textBox1.Clear();
                    pictureBox1.Image = Properties.Resources.Fim;

                    break;

                case 12:

                    pictureBox1.Image = Properties.Resources._12;
                    MessageBox.Show("Voto confirmado");
                    textBox1.Clear();
                    pictureBox1.Image = Properties.Resources.Fim;


                    break;

                case 27:

                    pictureBox1.Image = Properties.Resources._27;
                    MessageBox.Show("Voto confirmado");
                    textBox1.Clear();
                    pictureBox1.Image = Properties.Resources.Fim;


                    break;

                case 13:

                    pictureBox1.Image = Properties.Resources._13;
                    MessageBox.Show("Voto confirmado");
                    textBox1.Clear();
                    pictureBox1.Image = Properties.Resources.Fim;


                    break;

                case 45:

                    pictureBox1.Image = Properties.Resources._45;
                    MessageBox.Show("Voto confirmado");
                    textBox1.Clear();
                    pictureBox1.Image = Properties.Resources.Fim;


                    break;

                case 17:

                    pictureBox1.Image = Properties.Resources._17;
                    MessageBox.Show("Voto confirmado");
                    textBox1.Clear();
                    pictureBox1.Image = Properties.Resources.Fim;


                    break;

                case 18:

                    pictureBox1.Image = Properties.Resources._18;
                    MessageBox.Show("Voto confirmado");
                    textBox1.Clear();
                    pictureBox1.Image = Properties.Resources.Fim;


                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 2)

                textBox1.Text = textBox1.Text.Substring(0, 2);
            {

                switch (textBox1.Text)



                {
                    case "12": pictureBox1.Image = Properties.Resources._12; break;
                    case "13": pictureBox1.Image = Properties.Resources._13; break;
                    case "17": pictureBox1.Image = Properties.Resources._17; break;
                    case "45": pictureBox1.Image = Properties.Resources._45; break;
                    case "50": pictureBox1.Image = Properties.Resources._50; break;
                    case "18": pictureBox1.Image = Properties.Resources._18; break;
                    case "51": pictureBox1.Image = Properties.Resources._51; break;
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int BRANCO = 0;
            switch (textBox1.Text)
            {

                case "": BRANCO++; break;

            }

            MessageBox.Show("Fim");
            textBox1.Clear();
            pictureBox1.Image = null;

        }
    }
}