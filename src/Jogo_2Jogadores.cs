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
using static System.Net.Mime.MediaTypeNames;

namespace Bingo
{
    public partial class Jogo_2Jogadores : Form
    {
        int [,]mat = new int[5, 5];
        int[,] mat2 = new int[5, 5];
        int rand1 = 0;
        string jogador1 = null;
        string jogador2 = null;
        public Jogo_2Jogadores(string nome1, string nome2, string nome3, string nome4)
        {
            InitializeComponent();
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer("jogo_sound.wav");
            sp.PlayLooping();

            label1.Text = "Nome do jogador: " + nome1;
            label2.Text = "Nome do jogador: " + nome2;
            jogador1 = nome1;
            jogador2 = nome2;
            Cartela();
            Cartela2();
        }
      

        private void Cartela()
        {
            //criar num random dentro da matriz
            Random randNum = new Random();
            for (int i = 0; i < 5; i++)
            {
                mat[0, i] = randNum.Next(1, 16);
                for (int j = 0; j < i; j++)
                {
                    if (mat[0, i] == mat[0, j])
                        i--;
                }

            }
            //labels para dentro da matriz
            lb1.Text = mat[0, 0].ToString();
            lb6.Text = mat[0, 1].ToString();
            lb11.Text = mat[0, 2].ToString();
            lb16.Text = mat[0, 3].ToString();
            lb21.Text = mat[0, 4].ToString();

            for (int i = 0; i < 5; i++)
            {
                mat[1, i] = randNum.Next(17, 31);
                for (int j = 0; j < i; j++)
                {
                    if (mat[1, i] == mat[1, j])
                        i--;
                }
                lb2.Text = mat[1, 0].ToString();
                lb7.Text = mat[1, 1].ToString();
                lb12.Text = mat[1, 2].ToString();
                lb17.Text = mat[1, 3].ToString();
                lb22.Text = mat[1, 4].ToString();

            }
            for (int i = 0; i < 5; i++)
            {
                mat[2, i] = randNum.Next(32, 46);
                for (int j = 0; j < i; j++)
                {
                    if (mat[2, i] == mat[2, j])
                        i--;
                }
                lb3.Text = mat[2, 0].ToString();
                lb8.Text = mat[2, 1].ToString();

                lb18.Text = mat[2, 3].ToString();
                lb23.Text = mat[2, 4].ToString();
            }

            for (int i = 0; i < 5; i++)
            {
                mat[3, i] = randNum.Next(47, 61);
                for (int j = 0; j < i; j++)
                {
                    if (mat[3, i] == mat[3, j])
                        i--;
                }
                lb4.Text = mat[3, 0].ToString();
                lb9.Text = mat[3, 1].ToString();
                lb14.Text = mat[3, 2].ToString();
                lb19.Text = mat[3, 3].ToString();
                lb24.Text = mat[3, 4].ToString();
            }

            for (int i = 0; i < 5; i++)
            {
                mat[4, i] = randNum.Next(62, 76);
                for (int j = 0; j < i; j++)
                {
                    if (mat[4, i] == mat[4, j])
                        i--;
                }

                lb5.Text = mat[4, 0].ToString();
                lb10.Text = mat[4, 1].ToString();
                lb15.Text = mat[4, 2].ToString();
                lb20.Text = mat[4, 3].ToString();
                lb25.Text = mat[4, 4].ToString();
            }
            System.Threading.Thread.Sleep(1000);
        }

        private void Cartela2()
        {

            Random randNum2 = new Random();
            for (int i = 0; i < 5; i++)
            {
                mat2[0, i] = randNum2.Next(1, 16);
                for (int j = 0; j < i; j++)
                {
                    if (mat2[0, i] == mat2[0, j])
                        i--;
                }
                lb26.Text = mat2[0, 0].ToString();
                lb31.Text = mat2[0, 1].ToString();
                lb36.Text = mat2[0, 2].ToString();
                lb41.Text = mat2[0, 3].ToString();
                lb46.Text = mat2[0, 4].ToString();
            }
            

            for (int i = 0; i < 5; i++)
            {
                mat2[1, i] = randNum2.Next(17, 31);
                for (int j = 0; j < i; j++)
                {
                    if (mat2[1, i] == mat2[1, j])
                        i--;
                }
                lb27.Text = mat2[1, 0].ToString();
                lb32.Text = mat2[1, 1].ToString();
                lb37.Text = mat2[1, 2].ToString();
                lb42.Text = mat2[1, 3].ToString();
                lb47.Text = mat2[1, 4].ToString();

            }
            for (int i = 0; i < 5; i++)
            {
                mat2[2, i] = randNum2.Next(32, 46);
                for (int j = 0; j < i; j++)
                {
                    if (mat2[2, i] == mat2[2, j])
                        i--;
                }
                lb28.Text = mat2[2, 0].ToString();
                lb33.Text = mat2[2, 1].ToString();

                lb43.Text = mat2[2, 3].ToString();
                lb48.Text = mat2[2, 4].ToString();
            }

            for (int i = 0; i < 5; i++)
            {
                mat2[3, i] = randNum2.Next(47, 61);
                for (int j = 0; j < i; j++)
                {
                    if (mat2[3, i] == mat2[3, j])
                        i--;
                }
                lb29.Text = mat2[3, 0].ToString();
                lb34.Text = mat2[3, 1].ToString();
                lb39.Text = mat2[3, 2].ToString();
                lb44.Text = mat2[3, 3].ToString();
                lb49.Text = mat2[3, 4].ToString();
            }

            for (int i = 0; i < 5; i++)
            {
                mat2[4, i] = randNum2.Next(62, 76);
                for (int j = 0; j < i; j++)
                {
                    if (mat2[4, i] == mat2[4, j])
                        i--;
                }
                lb30.Text = mat2[4, 0].ToString();
                lb35.Text = mat2[4, 1].ToString();
                lb40.Text = mat2[4, 2].ToString();
                lb45.Text = mat2[4, 3].ToString();
                lb50.Text = mat2[4, 4].ToString();

            }
            //colocar para dormir 1seg, caso contrário as cartelas ficavam iguais
            System.Threading.Thread.Sleep(1000);
        }

        //lista para gerar num random dos numeros sorteados
        private List<int> numerosSorteados = new List<int>();    
        private void button1_Click(object sender, EventArgs e)
        {
            Random randNum3 = new Random();


            // gera um número aleatório que não foi sorteado antes
            do
            {
                rand1 = randNum3.Next(1, 76);
            } while (numerosSorteados.Contains(rand1));

            // adiciona o número sorteado à lista
            numerosSorteados.Add(rand1);

            listBox1.Items.Clear();
            listBox1.Items.Add(rand1);

            x1();
            x2();
            linha1();
            bingo();
        }

        PictureBox[,] picMat = new PictureBox[5, 5];
        PictureBox[,] picMat2 = new PictureBox[5, 5];
        // inciar picMat e picMat2
        private void picArray()
        {
            // picturebox mat1
            picMat[0, 0] = pic1;
            picMat[0, 1] = pic6;
            picMat[0, 2] = pic11;
            picMat[0, 3] = pic16;
            picMat[0, 4] = pic21;
            picMat[1, 0] = pic2;
            picMat[1, 1] = pic7;
            picMat[1, 2] = pic12;
            picMat[1, 3] = pic17;
            picMat[1, 4] = pic22;
            picMat[2, 0] = pic3;
            picMat[2, 1] = pic8;
            picMat[2, 2] = pic13;
            picMat[2, 3] = pic18;
            picMat[2, 4] = pic23;
            picMat[3, 0] = pic4;
            picMat[3, 1] = pic9;
            picMat[3, 2] = pic14;
            picMat[3, 3] = pic19;
            picMat[3, 4] = pic24;
            picMat[4, 0] = pic5;
            picMat[4, 1] = pic10;
            picMat[4, 2] = pic15;
            picMat[4, 3] = pic20;
            picMat[4, 4] = pic25;
            //pic para mat2
            picMat2[0, 0] = pic26;
            picMat2[0, 1] = pic31;
            picMat2[0, 2] = pic36;
            picMat2[0, 3] = pic41;
            picMat2[0, 4] = pic46;
            picMat2[1, 0] = pic27;
            picMat2[1, 1] = pic32;
            picMat2[1, 2] = pic37;
            picMat2[1, 3] = pic42;
            picMat2[1, 4] = pic47;
            picMat2[2, 0] = pic28;
            picMat2[2, 1] = pic33;
            picMat2[2, 2] = pic38;
            picMat2[2, 3] = pic43;
            picMat2[2, 4] = pic48;
            picMat2[3, 0] = pic29;
            picMat2[3, 1] = pic34;
            picMat2[3, 2] = pic39;
            picMat2[3, 3] = pic44;
            picMat2[3, 4] = pic49;
            picMat2[4, 0] = pic30;
            picMat2[4, 1] = pic35;
            picMat2[4, 2] = pic40;
            picMat2[4, 3] = pic45;
            picMat2[4, 4] = pic50;
        
    }

        private void x1()
        {
            picArray(); //chamar a funcao das picbox com as matriz picMax e picMax2

            //for para verificar se o num rand = matriz, caso seja iguala a 0
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (rand1 == mat[i, j])
                    {
                        mat[i, j] = 0;

                        // mostra as picturebox 
                        picMat[i, j].Visible = true;
                    }
                }
            }

                lb1.Text = mat[0, 0].ToString();
                lb6.Text = mat[0, 1].ToString();
                lb11.Text = mat[0, 2].ToString();
                lb16.Text = mat[0, 3].ToString();
                lb21.Text = mat[0, 4].ToString();
                lb2.Text = mat[1, 0].ToString();
                lb7.Text = mat[1, 1].ToString();
                lb12.Text = mat[1, 2].ToString();
                lb17.Text = mat[1, 3].ToString();
                lb22.Text = mat[1, 4].ToString();
                lb3.Text = mat[2, 0].ToString();
                lb8.Text = mat[2, 1].ToString();
                //free
                lb18.Text = mat[2, 3].ToString();
                lb23.Text = mat[2, 4].ToString();
                lb4.Text = mat[3, 0].ToString();
                lb9.Text = mat[3, 1].ToString();
                lb14.Text = mat[3, 2].ToString();
                lb19.Text = mat[3, 3].ToString();
                lb24.Text = mat[3, 4].ToString();
                lb5.Text = mat[4, 0].ToString();
                lb10.Text = mat[4, 1].ToString();
                lb15.Text = mat[4, 2].ToString();
                lb20.Text = mat[4, 3].ToString();
                lb25.Text = mat[4, 4].ToString(); 
        }

        
        private void x2()
            {
            picArray();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (rand1 == mat2[i, j])
                    {
                        mat2[i, j] = 0;

                        // mostra as picturebox 
                        picMat2[i, j].Visible = true;
                    }
                }
            }

                lb26.Text = mat2[0, 0].ToString();
                lb31.Text = mat2[0, 1].ToString();
                lb36.Text = mat2[0, 2].ToString();
                lb41.Text = mat2[0, 3].ToString();
                lb46.Text = mat2[0, 4].ToString();
                lb27.Text = mat2[1, 0].ToString();
                lb32.Text = mat2[1, 1].ToString();
                lb37.Text = mat2[1, 2].ToString();
                lb42.Text = mat2[1, 3].ToString();
                lb47.Text = mat2[1, 4].ToString();
                lb28.Text = mat2[2, 0].ToString();
                lb33.Text = mat2[2, 1].ToString();
                //free
                lb43.Text = mat2[2, 3].ToString();
                lb48.Text = mat2[2, 4].ToString();
                lb29.Text = mat2[3, 0].ToString();
                lb34.Text = mat2[3, 1].ToString();
                lb39.Text = mat2[3, 2].ToString();
                lb44.Text = mat2[3, 3].ToString();
                lb49.Text = mat2[3, 4].ToString();
                lb30.Text = mat2[4, 0].ToString();
                lb35.Text = mat2[4, 1].ToString();
                lb40.Text = mat2[4, 2].ToString();
                lb45.Text = mat2[4, 3].ToString();
                lb50.Text = mat2[4, 4].ToString();
    
        }

        private bool linharepetir = false; // indica quando "Linha!" vai ser efetuada

        //criei esta função para só ter de repetir 1 vez este processo
        private void verificarLinha(int[,] matriz, string jogador)
        {
            //verifica se a mensagem já foi mostrada
            if (linharepetir) return;

            if (matriz[0, 0] == 0 && matriz[1, 0] == 0 && matriz[2, 0] == 0 && matriz[3, 0] == 0 && matriz[4, 0] == 0)
            {
                MessageBox.Show("Linha de " + jogador);
                linharepetir = true; //coloca o bool a true caso a msg tenha sido mostrada
                return;
            }
            if (matriz[0, 1] == 0 && matriz[1, 1] == 0 && matriz[2, 1] == 0 && matriz[3, 1] == 0 && matriz[4, 1] == 0)
            {
                MessageBox.Show("Linha de " + jogador);
                linharepetir = true;
                return;
            }
            if (matriz[0, 2] == 0 && matriz[1, 2] == 0 && matriz[2, 2] == 0 && matriz[3, 2] == 0 && matriz[4, 2] == 0)
            {
                MessageBox.Show("Linha de " + jogador);
                linharepetir = true;
                return;
            }
            if (matriz[0, 3] == 0 && matriz[1, 3] == 0 && matriz[2, 3] == 0 && matriz[3, 3] == 0 && matriz[4, 3] == 0)
            {
                MessageBox.Show("Linha de " + jogador);
                linharepetir = true;
                return;
            }
            if (matriz[0, 4] == 0 && matriz[1, 4] == 0 && matriz[2, 4] == 0 && matriz[3, 4] == 0 && matriz[4, 4] == 0)
            {
                MessageBox.Show("Linha de " + jogador);
                linharepetir = true;
                return;
            }
        }

        //verifica se linha foi feita na mat e mat2
        private void linha1()
        {
            verificarLinha(mat, jogador1);
            verificarLinha(mat2, jogador2);
        }

        private void bingo()
        {
            if (verificaCartela(mat)) //verifica se foi feito bingo na mat, ou seja, na cartela
            {
                MessageBox.Show("Bingo na Cartela 1!");
                button1.Enabled = false; //não deixa gerar mais números
            }
            else if (verificaCartela(mat2))
            {
                MessageBox.Show("Bingo na Cartela 2!");
                button1.Enabled = false;
            }
        }

        //verifica se todos os números da matriz foram igualados a 0,ou seja, bingooo!
        private bool verificaCartela(int[,] cartela)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (cartela[i, j] != 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu form1 = new Menu();
            form1.Show();
            this.Close();
        }
    }
}
