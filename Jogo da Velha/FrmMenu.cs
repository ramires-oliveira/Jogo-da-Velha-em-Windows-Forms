using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_Velha {
    public partial class frmMenuPrincipal : Form {

        public List<Jogador> ListaDeJogadores = new List<Jogador>();
        Jogador P = new Jogador();

        public frmMenuPrincipal() {
            InitializeComponent();
        }

        private void jogoToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmJogo frmjogo = new FrmJogo(ListaDeJogadores);
            this.Hide();
            frmjogo.ShowDialog();
        }

        private void cadastrarJogadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastro frmcadastro = new FrmCadastro();
            this.Hide();
            frmcadastro.ShowDialog();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.unifenas.br/computacaoalfenas.asp");

        }
    }
}
