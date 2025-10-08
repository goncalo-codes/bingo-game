using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo
{
    public partial class Menu : Form
    { 
        public Menu()
        {
            InitializeComponent();
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer("menu_sound.wav"); //som do menu
            sp.PlayLooping();
        }


        private void button2_Click(object sender, EventArgs e) //botao saida
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)//botao form2
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\35193\Desktop\trabalhoBingoBONITO\trabalho bingo\trabalho bingo\Bingo\Bingo\bin\Debug\botao_jogar.wav");
    
            Quantidade_Jogadores form2 = new Quantidade_Jogadores();
            form2.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Informações form1 = new Informações();
            form1.Show();
            this.Hide();
        }
    }
}
