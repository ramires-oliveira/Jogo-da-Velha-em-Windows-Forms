﻿using System;
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
    public partial class FrmCadastro : Form
    {
        public List<Jogador> ListaDeJogadores = new List<Jogador>();

        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void cmdCadastrar_Click(object sender, EventArgs e)
        {
            if(ListaDeJogadores.Count < 2)
            {
                Jogador J = new Jogador();
                J.Nome = txtNomeJogador.Text;
                ListaDeJogadores.Add(J);
                txtNomeJogador.Text = "";
            }
            else
            {
                MessageBox.Show("Impossível cadastrar mais de 2 jogadores !");
                txtNomeJogador.Text = "";
            }

            if(ListaDeJogadores.Count == 2)
            {
                frmMenuPrincipal frmmenuprincipal = new frmMenuPrincipal();
                frmmenuprincipal.ListaDeJogadores = ListaDeJogadores;

                this.Hide();
                frmmenuprincipal.ShowDialog();
            }
        }

        private void cmdVoltarMenu_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmmenuprincipal = new frmMenuPrincipal();
            frmmenuprincipal.ListaDeJogadores = ListaDeJogadores;

            this.Hide();
            frmmenuprincipal.ShowDialog();
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
