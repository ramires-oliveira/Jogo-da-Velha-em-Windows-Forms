﻿namespace Jogo_da_Velha {
    partial class FrmJogo {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCronometro = new System.Windows.Forms.Label();
            this.panelSeleciona = new System.Windows.Forms.Panel();
            this.cmdConfirma = new System.Windows.Forms.Button();
            this.rbO = new System.Windows.Forms.RadioButton();
            this.rbX = new System.Windows.Forms.RadioButton();
            this.lblNome = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPontos0 = new System.Windows.Forms.Label();
            this.lblPontosX = new System.Windows.Forms.Label();
            this.lblEmpates = new System.Windows.Forms.Label();
            this.lblOPontos = new System.Windows.Forms.Label();
            this.lblXPontos = new System.Windows.Forms.Label();
            this.cmdIrRanking = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panelSeleciona.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblCronometro);
            this.panel1.Controls.Add(this.panelSeleciona);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cmd);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 287);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(35, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tempo de jogo: ";
            // 
            // lblCronometro
            // 
            this.lblCronometro.AutoSize = true;
            this.lblCronometro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCronometro.ForeColor = System.Drawing.Color.Red;
            this.lblCronometro.Location = new System.Drawing.Point(183, 248);
            this.lblCronometro.Name = "lblCronometro";
            this.lblCronometro.Size = new System.Drawing.Size(55, 24);
            this.lblCronometro.TabIndex = 14;
            this.lblCronometro.Text = "00:00";
            // 
            // panelSeleciona
            // 
            this.panelSeleciona.Controls.Add(this.cmdConfirma);
            this.panelSeleciona.Controls.Add(this.rbO);
            this.panelSeleciona.Controls.Add(this.rbX);
            this.panelSeleciona.Controls.Add(this.lblNome);
            this.panelSeleciona.Controls.Add(this.comboBox1);
            this.panelSeleciona.Location = new System.Drawing.Point(16, 12);
            this.panelSeleciona.Name = "panelSeleciona";
            this.panelSeleciona.Size = new System.Drawing.Size(267, 198);
            this.panelSeleciona.TabIndex = 13;
            // 
            // cmdConfirma
            // 
            this.cmdConfirma.BackColor = System.Drawing.Color.Black;
            this.cmdConfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConfirma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmdConfirma.Location = new System.Drawing.Point(147, 119);
            this.cmdConfirma.Name = "cmdConfirma";
            this.cmdConfirma.Size = new System.Drawing.Size(91, 30);
            this.cmdConfirma.TabIndex = 13;
            this.cmdConfirma.Text = "Confirmar";
            this.cmdConfirma.UseVisualStyleBackColor = false;
            this.cmdConfirma.Click += new System.EventHandler(this.cmdConfirma_Click);
            // 
            // rbO
            // 
            this.rbO.AutoSize = true;
            this.rbO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rbO.Location = new System.Drawing.Point(13, 148);
            this.rbO.Name = "rbO";
            this.rbO.Size = new System.Drawing.Size(85, 17);
            this.rbO.TabIndex = 12;
            this.rbO.Text = "Jogar com O";
            this.rbO.UseVisualStyleBackColor = false;
            // 
            // rbX
            // 
            this.rbX.AutoSize = true;
            this.rbX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rbX.Location = new System.Drawing.Point(13, 106);
            this.rbX.Name = "rbX";
            this.rbX.Size = new System.Drawing.Size(84, 17);
            this.rbX.TabIndex = 11;
            this.rbX.Text = "Jogar com X";
            this.rbX.UseVisualStyleBackColor = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(10, 20);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(212, 18);
            this.lblNome.TabIndex = 10;
            this.lblNome.Text = "Por favor escolha um jogador: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(563, 192);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(99, 80);
            this.button8.TabIndex = 8;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.cmd_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(458, 192);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(99, 80);
            this.button7.TabIndex = 7;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.cmd_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(353, 192);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 80);
            this.button6.TabIndex = 6;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.cmd_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(563, 106);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 80);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.cmd_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(458, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 80);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.cmd_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(353, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 80);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.cmd_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(563, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 80);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.cmd_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(458, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 80);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.cmd_Click);
            // 
            // cmd
            // 
            this.cmd.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd.Location = new System.Drawing.Point(353, 20);
            this.cmd.Name = "cmd";
            this.cmd.Size = new System.Drawing.Size(99, 80);
            this.cmd.TabIndex = 0;
            this.cmd.UseVisualStyleBackColor = false;
            this.cmd.Click += new System.EventHandler(this.cmd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblPontos0);
            this.panel2.Controls.Add(this.lblPontosX);
            this.panel2.Controls.Add(this.lblEmpates);
            this.panel2.Controls.Add(this.lblOPontos);
            this.panel2.Controls.Add(this.lblXPontos);
            this.panel2.Location = new System.Drawing.Point(12, 321);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 134);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Empates";
            // 
            // lblPontos0
            // 
            this.lblPontos0.AutoSize = true;
            this.lblPontos0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPontos0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontos0.Location = new System.Drawing.Point(197, 35);
            this.lblPontos0.Name = "lblPontos0";
            this.lblPontos0.Size = new System.Drawing.Size(88, 24);
            this.lblPontos0.TabIndex = 4;
            this.lblPontos0.Text = "O Pontos";
            // 
            // lblPontosX
            // 
            this.lblPontosX.AutoSize = true;
            this.lblPontosX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPontosX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontosX.Location = new System.Drawing.Point(35, 35);
            this.lblPontosX.Name = "lblPontosX";
            this.lblPontosX.Size = new System.Drawing.Size(87, 24);
            this.lblPontosX.TabIndex = 3;
            this.lblPontosX.Text = "X Pontos";
            // 
            // lblEmpates
            // 
            this.lblEmpates.AutoSize = true;
            this.lblEmpates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblEmpates.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpates.Location = new System.Drawing.Point(388, 92);
            this.lblEmpates.Name = "lblEmpates";
            this.lblEmpates.Size = new System.Drawing.Size(24, 26);
            this.lblEmpates.TabIndex = 2;
            this.lblEmpates.Text = "0";
            // 
            // lblOPontos
            // 
            this.lblOPontos.AutoSize = true;
            this.lblOPontos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOPontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOPontos.Location = new System.Drawing.Point(230, 92);
            this.lblOPontos.Name = "lblOPontos";
            this.lblOPontos.Size = new System.Drawing.Size(24, 26);
            this.lblOPontos.TabIndex = 1;
            this.lblOPontos.Text = "0";
            // 
            // lblXPontos
            // 
            this.lblXPontos.AutoSize = true;
            this.lblXPontos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblXPontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXPontos.Location = new System.Drawing.Point(66, 92);
            this.lblXPontos.Name = "lblXPontos";
            this.lblXPontos.Size = new System.Drawing.Size(24, 26);
            this.lblXPontos.TabIndex = 0;
            this.lblXPontos.Text = "0";
            // 
            // cmdIrRanking
            // 
            this.cmdIrRanking.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdIrRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIrRanking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmdIrRanking.Location = new System.Drawing.Point(536, 372);
            this.cmdIrRanking.Name = "cmdIrRanking";
            this.cmdIrRanking.Size = new System.Drawing.Size(144, 40);
            this.cmdIrRanking.TabIndex = 9;
            this.cmdIrRanking.Text = "Ranking Final";
            this.cmdIrRanking.UseVisualStyleBackColor = false;
            this.cmdIrRanking.Click += new System.EventHandler(this.cmdIrRanking_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(716, 481);
            this.Controls.Add(this.cmdIrRanking);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo";
            this.Load += new System.EventHandler(this.FrmJogo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSeleciona.ResumeLayout(false);
            this.panelSeleciona.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPontos0;
        private System.Windows.Forms.Label lblPontosX;
        private System.Windows.Forms.Label lblEmpates;
        private System.Windows.Forms.Label lblOPontos;
        private System.Windows.Forms.Label lblXPontos;
        private System.Windows.Forms.Button cmdIrRanking;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton rbO;
        private System.Windows.Forms.RadioButton rbX;
        private System.Windows.Forms.Panel panelSeleciona;
        private System.Windows.Forms.Button cmdConfirma;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblCronometro;
        private System.Windows.Forms.Label label2;
    }
}