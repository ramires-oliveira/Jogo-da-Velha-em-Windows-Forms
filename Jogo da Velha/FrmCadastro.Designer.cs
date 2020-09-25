namespace Jogo_da_Velha {
    partial class FrmCadastro {
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
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.cmdCadastrar = new System.Windows.Forms.Button();
            this.cmdVoltarMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJogador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNomeJogador.Location = new System.Drawing.Point(34, 43);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(143, 20);
            this.lblNomeJogador.TabIndex = 0;
            this.lblNomeJogador.Text = "Nome do Jogador: ";
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Location = new System.Drawing.Point(173, 43);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(224, 20);
            this.txtNomeJogador.TabIndex = 1;
            // 
            // cmdCadastrar
            // 
            this.cmdCadastrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmdCadastrar.Location = new System.Drawing.Point(81, 102);
            this.cmdCadastrar.Name = "cmdCadastrar";
            this.cmdCadastrar.Size = new System.Drawing.Size(104, 35);
            this.cmdCadastrar.TabIndex = 2;
            this.cmdCadastrar.Text = "Cadastrar";
            this.cmdCadastrar.UseVisualStyleBackColor = false;
            this.cmdCadastrar.Click += new System.EventHandler(this.cmdCadastrar_Click);
            // 
            // cmdVoltarMenu
            // 
            this.cmdVoltarMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdVoltarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVoltarMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmdVoltarMenu.Location = new System.Drawing.Point(219, 102);
            this.cmdVoltarMenu.Name = "cmdVoltarMenu";
            this.cmdVoltarMenu.Size = new System.Drawing.Size(95, 35);
            this.cmdVoltarMenu.TabIndex = 3;
            this.cmdVoltarMenu.Text = "Menu";
            this.cmdVoltarMenu.UseVisualStyleBackColor = false;
            this.cmdVoltarMenu.Click += new System.EventHandler(this.cmdVoltarMenu_Click);
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(429, 186);
            this.Controls.Add(this.cmdVoltarMenu);
            this.Controls.Add(this.cmdCadastrar);
            this.Controls.Add(this.txtNomeJogador);
            this.Controls.Add(this.lblNomeJogador);
            this.Name = "FrmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastro";
            this.Load += new System.EventHandler(this.FrmCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Button cmdCadastrar;
        private System.Windows.Forms.Button cmdVoltarMenu;
    }
}