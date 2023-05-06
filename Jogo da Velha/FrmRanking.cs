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
    public partial class FrmRanking : Form
    {
        public List<Jogador> ListaDeJogadores = new List<Jogador>();
        public string minuto1;
        public string segundo1;
        int maiorponto = 0;
        string nome;
        bool empate = false;

        public FrmRanking(List<Jogador> ListaJog)
        {
            InitializeComponent();

            ListaDeJogadores = ListaJog;
            var pontos = ListaDeJogadores.Select(x => x.Pontos);
            
            if (pontos.First() == pontos.Last())
            {
                empate = true;
            }

            foreach (var item in ListaDeJogadores.OrderByDescending(x => x.Pontos))
            {
                listBox1.Items.Add($"Jogador: {item.Nome}     -     {item.Tipo}     -     { item.Pontos} pontos");
                if (item.Pontos > maiorponto)
                {
                    maiorponto = item.Pontos;
                    nome = item.Nome;
                }
            }
        }

        private void FrmRanking_Load(object sender, EventArgs e)
        {
            lblCronometro.Text = $"{minuto1}:{segundo1}";
            if(!empate)
                notifyIcon1.ShowBalloonTip(10,"Parabéns", $"{nome} é o vencedor com {maiorponto} ponto(s)",ToolTipIcon.None);
            else
                notifyIcon1.ShowBalloonTip(10,"Jogo empatado"," Nenhum jogador venceu !",ToolTipIcon.None);

        }

        private void lblCronometro_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
