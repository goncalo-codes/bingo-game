using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo
{
    public partial class Quantidade_Jogadores : Form
    {
        int contador = 0;//var quantidade jogadores
        
        public Quantidade_Jogadores()
        {
            InitializeComponent();
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer("jogadores_sound.wav");//som do menu
            sp.PlayLooping();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            contador = 2;//quantidade de jogadores
            Insersão_Jogadores form3 = new Insersão_Jogadores(contador);
            form3.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            contador = 3;
            Insersão_Jogadores form3 = new Insersão_Jogadores(contador);
            form3.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            contador = 4;
            Insersão_Jogadores form3 = new Insersão_Jogadores(contador);
            form3.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu form1 = new Menu();
            form1.Show();
            this.Hide();
        }
    }
}
