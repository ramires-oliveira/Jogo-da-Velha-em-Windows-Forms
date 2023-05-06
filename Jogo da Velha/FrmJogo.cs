using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_Velha
{
    public partial class FrmJogo : Form
    {
        public List<Jogador> ListaDeJogadores = new List<Jogador>();
        Jogador P1 = new Jogador();
        Jogador P2 = new Jogador();
        int minutos = 0; int segundo = 0;


        int PontosX = 0, PontosO = 0, Empates = 0, Rodadas = 0;
        bool turno = true, jogofinal = false;
        string[] texto = new string[9];

        public FrmJogo(List<Jogador> ListaJog)
        {
            InitializeComponent();
            
            ListaDeJogadores = ListaJog;

            foreach (var item in ListaDeJogadores)
            {
                comboBox1.Items.Add(item.Nome);
            }

            bloqueiaJogo();
        }

        private void FrmJogo_Load(object sender, EventArgs e)
        {

        }

        private void cmdIrRanking_Click(object sender, EventArgs e)
        {
            FrmRanking frmranking = new FrmRanking(ListaDeJogadores);
            this.Hide();
            timer1.Enabled = false;
            frmranking.minuto1 = Converte(minutos);
            frmranking.segundo1 = Converte(segundo);
            frmranking.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in ListaDeJogadores)
            {
                comboBox1.Items.Add(item.Nome);
            }
        }

        private void cmdConfirma_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "" || rbX.Checked == false && rbO.Checked == false)
            {
                MessageBox.Show("Necessário escolher um jogador e se irá jogar com X ou O para iniciar!");
                return;
            }

            var nome = comboBox1.Text;

            var confirmaNome = ListaDeJogadores.Where(x => x.Nome == nome);
            if (confirmaNome.Count() == 0)
            {
                MessageBox.Show("Nome não encontrado na lista de jogadores");
                return;
            }

            P1 = ListaDeJogadores.FirstOrDefault(x => x.Nome == nome);
            P2 = ListaDeJogadores.FirstOrDefault(x => x.Nome != nome);

            if (rbX.Checked == true)
            {
                P1.Tipo = "X";
                P2.Tipo = "O";
            }
            else
            {
                P1.Tipo = "O";
                P2.Tipo = "X";

            }

            MessageBox.Show($"{ P1.Nome} é o jogador {P1.Tipo}\n{ P2.Nome} é o jogador {P2.Tipo}");
            MessageBox.Show("Para finalizar o jogo após as partidas, basta clicar em Ranking Final");

            habilitaJogo();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundo++;

            if (segundo > 59)
            {
                minutos++;
                segundo = 0;
            }

            lblCronometro.Text = Converte(minutos) + ":" + Converte(segundo);
        }

        public string Converte(int numero)
        {
            if (numero < 10)
            {
                return "0" + numero.ToString();
            }
            else
            {
                return numero.ToString();
            }
        }

        private void cmd_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            int buttonIndex = btn.TabIndex;

            if (btn.Text == "" && jogofinal == false)
            {
                if (turno)
                {
                    btn.Text = "X";
                    texto[buttonIndex] = btn.Text;
                    Rodadas++;
                    turno = !turno;
                    Checagem(1);
                }
                else
                {
                    btn.Text = "O";
                    texto[buttonIndex] = btn.Text;
                    Rodadas++;
                    turno = !turno;
                    Checagem(2);
                }
            }
        }


        public void Checagem(int ChecagemPlayer)
        {
            string suporte;

            if (ChecagemPlayer == 1)
            {
                suporte = "X";
            }
            else
            {
                suporte = "O";
            }

            //Verificar Horizontal
            for (int horizontal = 0; horizontal < 8; horizontal += 3)
            {
                if (suporte == texto[horizontal])
                {
                    if (texto[horizontal] == texto[horizontal + 1] && texto[horizontal] == texto[horizontal + 2])
                    {
                        Vencedor(ChecagemPlayer);
                        return;
                    }
                }
            }

            //Verificar Vertical
            for (int vertical = 0; vertical < 3; vertical++)
            {
                if (suporte == texto[vertical])
                {
                    if (texto[vertical] == texto[vertical + 3] && texto[vertical] == texto[vertical + 6])
                    {
                        Vencedor(ChecagemPlayer);
                        return;
                    }
                }
            }

            //Verificar Diagonal
            if (texto[0] == suporte)
            {
                if (texto[0] == texto[4] && texto[0] == texto[8])
                {
                    Vencedor(ChecagemPlayer);
                    return;
                }//Diagonal Principal
            }

            if (texto[2] == suporte)
            {
                if (texto[2] == texto[4] && texto[2] == texto[6])
                {
                    Vencedor(ChecagemPlayer);
                    return;
                }//Diagonal Segundaria
            }

            if (Rodadas == 9 && jogofinal == false)
            {
                Empates++;
                
                lblEmpates.Text = Convert.ToString(Empates);
                
                MessageBox.Show("Empate !");
                
                jogofinal = true;

                limparJogo();
                
                return;
            }
        }

        public void Vencedor(int PlayerVitorioso)
        {
            jogofinal = true;

            if (PlayerVitorioso == 1)
            {
                PontosX++;

                lblXPontos.Text = Convert.ToString(PontosX);
                
                MessageBox.Show("Jogador X ganhou");
                
                if (P1.Tipo == "X")
                {
                    P1.Pontos = PontosX;
                }
                else if (P2.Tipo == "X")
                {
                    P2.Pontos = PontosX;
                }

                turno = true;
            }
            else
            {
                PontosO++;

                lblOPontos.Text = Convert.ToString(PontosO);
                
                MessageBox.Show("Jogador O ganhou");
                
                if (P1.Tipo == "O")
                {
                    P1.Pontos = PontosO;
                }
                else if (P2.Tipo == "O")
                {
                    P2.Pontos = PontosO;
                }

                turno = false;
            }

            limparJogo();
        }

        private void limparJogo()
        {
            Rodadas = 0;
            jogofinal = false;

            cmd.Text = "";
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";

            for (int i = 0; i < 9; i++)
            {
                texto[i] = "";
            }
        }

        private void bloqueiaJogo()
        {
            cmd.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
        }

        private void habilitaJogo()
        {
            cmd.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
        }
    }
}
