using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo
{
    public partial class Insersão_Jogadores : Form
    {
        public Insersão_Jogadores(int contador)
        {
            InitializeComponent();
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer("jogadores_sound.wav");//som do menu
            sp.PlayLooping();

            label1.Text = "Jogador 1";
            label2.Text = "Jogador 2";
            label3.Text = "Jogador 3";

            //2 jogadores:
            button1.Enabled = true;
            button4.Enabled = false;
            button3.Enabled = false;
            button1.Visible = true;
            button4.Visible = false;
            button3.Visible = false;
            label3.Visible = false;

            //se tiver 3 jogadores:
            if (contador == 3)
            {
                pictureBox3.Visible = true;
                textBox3.Visible = true;
                button1.Visible= false;
                button4.Visible = false;
                button3.Visible = true;
                button1.Enabled = false;
                button4.Enabled = false;
                button3.Enabled = true;
                label3.Visible= true;
            }
            else if (contador== 4)
            {
                pictureBox3.Visible = true;
                textBox3.Visible = true;
                button1.Visible = false;
                button3.Visible= false;
                button4.Visible = true;
                button1.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = true;
                label3.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //strings para colocar o nome dos jogadores aparecer no form seguinte a partir do textbox
            string nome1 = textBox1.Text;
            string nome2 = textBox2.Text;

            Jogo_2Jogadores form4 = new Jogo_2Jogadores(nome1, nome2);
            form4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nome1 = textBox1.Text;
            string nome2 = textBox2.Text;
            string nome3 = textBox3.Text;

            Jogo_3jogadores form5 = new Jogo_3jogadores(nome1, nome2, nome3);
            form5.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Quantidade_Jogadores form2 = new Quantidade_Jogadores();
            form2.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Quantidade_Jogadores form2 = new Quantidade_Jogadores();
            form2.Show();
            this.Hide();
        }
    }
}
