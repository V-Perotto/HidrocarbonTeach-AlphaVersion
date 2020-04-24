namespace QuimicaOrganica
{
    partial class frmHidrocarbonetos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHidrocarbonetos));
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.picFormula = new System.Windows.Forms.PictureBox();
            this.txtNumCarbo = new System.Windows.Forms.TextBox();
            this.txtPrefixo = new System.Windows.Forms.TextBox();
            this.txtLigacao = new System.Windows.Forms.TextBox();
            this.txtIntermediario = new System.Windows.Forms.TextBox();
            this.txtComposto = new System.Windows.Forms.TextBox();
            this.txtAromatico = new System.Windows.Forms.TextBox();
            this.txtHeteroAtomo = new System.Windows.Forms.TextBox();
            this.txtCadeia = new System.Windows.Forms.TextBox();
            this.lblNumCarbo = new System.Windows.Forms.Label();
            this.lblPrefixo = new System.Windows.Forms.Label();
            this.lblTipoLigacao = new System.Windows.Forms.Label();
            this.lblIntermediario = new System.Windows.Forms.Label();
            this.lblSufixo = new System.Windows.Forms.Label();
            this.lblComposto = new System.Windows.Forms.Label();
            this.lblAromatico = new System.Windows.Forms.Label();
            this.lblHeteroAtomo = new System.Windows.Forms.Label();
            this.lblCadeia = new System.Windows.Forms.Label();
            this.txtSaturacao = new System.Windows.Forms.TextBox();
            this.lblSaturacao = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtInfixo = new System.Windows.Forms.TextBox();
            this.lvlInfixo = new System.Windows.Forms.Label();
            this.lblFormula = new System.Windows.Forms.Label();
            this.txtFormula = new System.Windows.Forms.TextBox();
            this.lblClassificacao = new System.Windows.Forms.Label();
            this.txtClassificacao = new System.Windows.Forms.TextBox();
            this.lblConexao = new System.Windows.Forms.Label();
            this.txtConexao = new System.Windows.Forms.TextBox();
            this.btnLista = new System.Windows.Forms.Button();
            this.lblLista = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFormula)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.Location = new System.Drawing.Point(223, 8);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(115, 33);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // picFormula
            // 
            this.picFormula.Image = ((System.Drawing.Image)(resources.GetObject("picFormula.Image")));
            this.picFormula.Location = new System.Drawing.Point(387, 103);
            this.picFormula.Name = "picFormula";
            this.picFormula.Size = new System.Drawing.Size(435, 355);
            this.picFormula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFormula.TabIndex = 1;
            this.picFormula.TabStop = false;
            this.picFormula.Click += new System.EventHandler(this.picFormula_Click);
            // 
            // txtNumCarbo
            // 
            this.txtNumCarbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtNumCarbo.Location = new System.Drawing.Point(679, 28);
            this.txtNumCarbo.Name = "txtNumCarbo";
            this.txtNumCarbo.ReadOnly = true;
            this.txtNumCarbo.Size = new System.Drawing.Size(49, 26);
            this.txtNumCarbo.TabIndex = 2;
            this.txtNumCarbo.TextChanged += new System.EventHandler(this.txtNumCarbo_TextChanged);
            // 
            // txtPrefixo
            // 
            this.txtPrefixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtPrefixo.Location = new System.Drawing.Point(69, 109);
            this.txtPrefixo.Name = "txtPrefixo";
            this.txtPrefixo.ReadOnly = true;
            this.txtPrefixo.Size = new System.Drawing.Size(63, 26);
            this.txtPrefixo.TabIndex = 4;
            this.txtPrefixo.TextChanged += new System.EventHandler(this.txtPrefixo_TextChanged);
            // 
            // txtLigacao
            // 
            this.txtLigacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtLigacao.Location = new System.Drawing.Point(135, 140);
            this.txtLigacao.Name = "txtLigacao";
            this.txtLigacao.ReadOnly = true;
            this.txtLigacao.Size = new System.Drawing.Size(153, 26);
            this.txtLigacao.TabIndex = 6;
            this.txtLigacao.TextChanged += new System.EventHandler(this.txtLigacao_TextChanged);
            // 
            // txtIntermediario
            // 
            this.txtIntermediario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtIntermediario.Location = new System.Drawing.Point(115, 172);
            this.txtIntermediario.Name = "txtIntermediario";
            this.txtIntermediario.ReadOnly = true;
            this.txtIntermediario.Size = new System.Drawing.Size(30, 26);
            this.txtIntermediario.TabIndex = 7;
            this.txtIntermediario.TextChanged += new System.EventHandler(this.txtIntermediario_TextChanged);
            // 
            // txtComposto
            // 
            this.txtComposto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtComposto.Location = new System.Drawing.Point(96, 204);
            this.txtComposto.Name = "txtComposto";
            this.txtComposto.ReadOnly = true;
            this.txtComposto.Size = new System.Drawing.Size(132, 26);
            this.txtComposto.TabIndex = 8;
            this.txtComposto.TextChanged += new System.EventHandler(this.txtComposto_TextChanged);
            // 
            // txtAromatico
            // 
            this.txtAromatico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtAromatico.Location = new System.Drawing.Point(97, 316);
            this.txtAromatico.Name = "txtAromatico";
            this.txtAromatico.ReadOnly = true;
            this.txtAromatico.Size = new System.Drawing.Size(49, 26);
            this.txtAromatico.TabIndex = 9;
            this.txtAromatico.TextChanged += new System.EventHandler(this.txtAromatico_TextChanged);
            // 
            // txtHeteroAtomo
            // 
            this.txtHeteroAtomo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtHeteroAtomo.Location = new System.Drawing.Point(223, 358);
            this.txtHeteroAtomo.Name = "txtHeteroAtomo";
            this.txtHeteroAtomo.ReadOnly = true;
            this.txtHeteroAtomo.Size = new System.Drawing.Size(115, 26);
            this.txtHeteroAtomo.TabIndex = 12;
            this.txtHeteroAtomo.TextChanged += new System.EventHandler(this.txtMistura_TextChanged);
            // 
            // txtCadeia
            // 
            this.txtCadeia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtCadeia.Location = new System.Drawing.Point(96, 390);
            this.txtCadeia.Name = "txtCadeia";
            this.txtCadeia.ReadOnly = true;
            this.txtCadeia.Size = new System.Drawing.Size(242, 26);
            this.txtCadeia.TabIndex = 13;
            this.txtCadeia.TextChanged += new System.EventHandler(this.txtCadeia_TextChanged);
            // 
            // lblNumCarbo
            // 
            this.lblNumCarbo.AutoSize = true;
            this.lblNumCarbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblNumCarbo.Location = new System.Drawing.Point(507, 31);
            this.lblNumCarbo.Name = "lblNumCarbo";
            this.lblNumCarbo.Size = new System.Drawing.Size(169, 20);
            this.lblNumCarbo.TabIndex = 11;
            this.lblNumCarbo.Text = "Nº Total de Carbonos";
            // 
            // lblPrefixo
            // 
            this.lblPrefixo.AutoSize = true;
            this.lblPrefixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblPrefixo.Location = new System.Drawing.Point(6, 111);
            this.lblPrefixo.Name = "lblPrefixo";
            this.lblPrefixo.Size = new System.Drawing.Size(61, 20);
            this.lblPrefixo.TabIndex = 12;
            this.lblPrefixo.Text = "Prefixo";
            // 
            // lblTipoLigacao
            // 
            this.lblTipoLigacao.AutoSize = true;
            this.lblTipoLigacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblTipoLigacao.Location = new System.Drawing.Point(5, 143);
            this.lblTipoLigacao.Name = "lblTipoLigacao";
            this.lblTipoLigacao.Size = new System.Drawing.Size(128, 20);
            this.lblTipoLigacao.TabIndex = 13;
            this.lblTipoLigacao.Text = "Tipo de Ligação";
            // 
            // lblIntermediario
            // 
            this.lblIntermediario.AutoSize = true;
            this.lblIntermediario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblIntermediario.Location = new System.Drawing.Point(7, 175);
            this.lblIntermediario.Name = "lblIntermediario";
            this.lblIntermediario.Size = new System.Drawing.Size(106, 20);
            this.lblIntermediario.TabIndex = 14;
            this.lblIntermediario.Text = "Intermediário";
            // 
            // lblSufixo
            // 
            this.lblSufixo.AutoSize = true;
            this.lblSufixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblSufixo.Location = new System.Drawing.Point(148, 175);
            this.lblSufixo.Name = "lblSufixo";
            this.lblSufixo.Size = new System.Drawing.Size(37, 20);
            this.lblSufixo.TabIndex = 15;
            this.lblSufixo.Text = "+ O";
            // 
            // lblComposto
            // 
            this.lblComposto.AutoSize = true;
            this.lblComposto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblComposto.Location = new System.Drawing.Point(6, 207);
            this.lblComposto.Name = "lblComposto";
            this.lblComposto.Size = new System.Drawing.Size(85, 20);
            this.lblComposto.TabIndex = 16;
            this.lblComposto.Text = "Composto";
            // 
            // lblAromatico
            // 
            this.lblAromatico.AutoSize = true;
            this.lblAromatico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblAromatico.Location = new System.Drawing.Point(6, 319);
            this.lblAromatico.Name = "lblAromatico";
            this.lblAromatico.Size = new System.Drawing.Size(85, 20);
            this.lblAromatico.TabIndex = 17;
            this.lblAromatico.Text = "Aromático";
            // 
            // lblHeteroAtomo
            // 
            this.lblHeteroAtomo.AutoSize = true;
            this.lblHeteroAtomo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblHeteroAtomo.Location = new System.Drawing.Point(6, 360);
            this.lblHeteroAtomo.Name = "lblHeteroAtomo";
            this.lblHeteroAtomo.Size = new System.Drawing.Size(214, 20);
            this.lblHeteroAtomo.TabIndex = 18;
            this.lblHeteroAtomo.Text = "Presença de Heteroátomos";
            // 
            // lblCadeia
            // 
            this.lblCadeia.AutoSize = true;
            this.lblCadeia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblCadeia.Location = new System.Drawing.Point(7, 393);
            this.lblCadeia.Name = "lblCadeia";
            this.lblCadeia.Size = new System.Drawing.Size(61, 20);
            this.lblCadeia.TabIndex = 19;
            this.lblCadeia.Text = "Cadeia";
            // 
            // txtSaturacao
            // 
            this.txtSaturacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtSaturacao.Location = new System.Drawing.Point(96, 424);
            this.txtSaturacao.Name = "txtSaturacao";
            this.txtSaturacao.ReadOnly = true;
            this.txtSaturacao.Size = new System.Drawing.Size(132, 26);
            this.txtSaturacao.TabIndex = 14;
            this.txtSaturacao.TextChanged += new System.EventHandler(this.txtSaturacao_TextChanged);
            // 
            // lblSaturacao
            // 
            this.lblSaturacao.AutoSize = true;
            this.lblSaturacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblSaturacao.Location = new System.Drawing.Point(6, 427);
            this.lblSaturacao.Name = "lblSaturacao";
            this.lblSaturacao.Size = new System.Drawing.Size(85, 20);
            this.lblSaturacao.TabIndex = 21;
            this.lblSaturacao.Text = "Saturação";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblNome.Location = new System.Drawing.Point(9, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 20);
            this.lblNome.TabIndex = 22;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtNome.Location = new System.Drawing.Point(64, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(153, 26);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtInfixo
            // 
            this.txtInfixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtInfixo.Location = new System.Drawing.Point(188, 108);
            this.txtInfixo.Name = "txtInfixo";
            this.txtInfixo.ReadOnly = true;
            this.txtInfixo.Size = new System.Drawing.Size(109, 26);
            this.txtInfixo.TabIndex = 5;
            this.txtInfixo.TextChanged += new System.EventHandler(this.txtInfixo_TextChanged);
            // 
            // lvlInfixo
            // 
            this.lvlInfixo.AutoSize = true;
            this.lvlInfixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lvlInfixo.Location = new System.Drawing.Point(137, 111);
            this.lvlInfixo.Name = "lvlInfixo";
            this.lvlInfixo.Size = new System.Drawing.Size(48, 20);
            this.lvlInfixo.TabIndex = 24;
            this.lvlInfixo.Text = "Infixo";
            // 
            // lblFormula
            // 
            this.lblFormula.AutoSize = true;
            this.lblFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblFormula.Location = new System.Drawing.Point(559, 63);
            this.lblFormula.Name = "lblFormula";
            this.lblFormula.Size = new System.Drawing.Size(70, 20);
            this.lblFormula.TabIndex = 26;
            this.lblFormula.Text = "Fórmula";
            // 
            // txtFormula
            // 
            this.txtFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtFormula.Location = new System.Drawing.Point(632, 60);
            this.txtFormula.Name = "txtFormula";
            this.txtFormula.ReadOnly = true;
            this.txtFormula.Size = new System.Drawing.Size(97, 26);
            this.txtFormula.TabIndex = 3;
            this.txtFormula.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // lblClassificacao
            // 
            this.lblClassificacao.AutoSize = true;
            this.lblClassificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblClassificacao.Location = new System.Drawing.Point(5, 238);
            this.lblClassificacao.Name = "lblClassificacao";
            this.lblClassificacao.Size = new System.Drawing.Size(110, 20);
            this.lblClassificacao.TabIndex = 28;
            this.lblClassificacao.Text = "Classificação";
            // 
            // txtClassificacao
            // 
            this.txtClassificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtClassificacao.Location = new System.Drawing.Point(119, 235);
            this.txtClassificacao.Name = "txtClassificacao";
            this.txtClassificacao.ReadOnly = true;
            this.txtClassificacao.Size = new System.Drawing.Size(172, 26);
            this.txtClassificacao.TabIndex = 10;
            this.txtClassificacao.TextChanged += new System.EventHandler(this.txtNucleos_TextChanged);
            // 
            // lblConexao
            // 
            this.lblConexao.AutoSize = true;
            this.lblConexao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblConexao.Location = new System.Drawing.Point(5, 270);
            this.lblConexao.Name = "lblConexao";
            this.lblConexao.Size = new System.Drawing.Size(74, 20);
            this.lblConexao.TabIndex = 30;
            this.lblConexao.Text = "Conexão";
            // 
            // txtConexao
            // 
            this.txtConexao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtConexao.Location = new System.Drawing.Point(96, 267);
            this.txtConexao.Name = "txtConexao";
            this.txtConexao.ReadOnly = true;
            this.txtConexao.Size = new System.Drawing.Size(195, 26);
            this.txtConexao.TabIndex = 11;
            this.txtConexao.TextChanged += new System.EventHandler(this.txtConexao_TextChanged);
            // 
            // btnLista
            // 
            this.btnLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnLista.Location = new System.Drawing.Point(223, 44);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(115, 33);
            this.btnLista.TabIndex = 31;
            this.btnLista.Text = "Abrir Lista";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblLista.Location = new System.Drawing.Point(10, 52);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(198, 20);
            this.lblLista.TabIndex = 32;
            this.lblLista.Text = "Lista de Hidrocarbonetos";
            // 
            // frmHidrocarbonetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(833, 469);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.lblConexao);
            this.Controls.Add(this.txtConexao);
            this.Controls.Add(this.lblClassificacao);
            this.Controls.Add(this.txtClassificacao);
            this.Controls.Add(this.lblFormula);
            this.Controls.Add(this.txtFormula);
            this.Controls.Add(this.lvlInfixo);
            this.Controls.Add(this.txtInfixo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblSaturacao);
            this.Controls.Add(this.txtSaturacao);
            this.Controls.Add(this.lblCadeia);
            this.Controls.Add(this.lblHeteroAtomo);
            this.Controls.Add(this.lblAromatico);
            this.Controls.Add(this.lblComposto);
            this.Controls.Add(this.lblSufixo);
            this.Controls.Add(this.lblIntermediario);
            this.Controls.Add(this.lblTipoLigacao);
            this.Controls.Add(this.lblPrefixo);
            this.Controls.Add(this.lblNumCarbo);
            this.Controls.Add(this.txtCadeia);
            this.Controls.Add(this.txtHeteroAtomo);
            this.Controls.Add(this.txtAromatico);
            this.Controls.Add(this.txtComposto);
            this.Controls.Add(this.txtIntermediario);
            this.Controls.Add(this.txtLigacao);
            this.Controls.Add(this.txtPrefixo);
            this.Controls.Add(this.txtNumCarbo);
            this.Controls.Add(this.picFormula);
            this.Controls.Add(this.btnPesquisar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(849, 508);
            this.MinimumSize = new System.Drawing.Size(849, 508);
            this.Name = "frmHidrocarbonetos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hidrocarbonetos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHidrocarbonetos_FormClosing);
            this.Load += new System.EventHandler(this.frmHidrocarbonetos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFormula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.PictureBox picFormula;
        private System.Windows.Forms.TextBox txtNumCarbo;
        private System.Windows.Forms.TextBox txtPrefixo;
        private System.Windows.Forms.TextBox txtLigacao;
        private System.Windows.Forms.TextBox txtIntermediario;
        private System.Windows.Forms.TextBox txtComposto;
        private System.Windows.Forms.TextBox txtAromatico;
        private System.Windows.Forms.TextBox txtHeteroAtomo;
        private System.Windows.Forms.TextBox txtCadeia;
        private System.Windows.Forms.Label lblNumCarbo;
        private System.Windows.Forms.Label lblPrefixo;
        private System.Windows.Forms.Label lblTipoLigacao;
        private System.Windows.Forms.Label lblIntermediario;
        private System.Windows.Forms.Label lblSufixo;
        private System.Windows.Forms.Label lblComposto;
        private System.Windows.Forms.Label lblAromatico;
        private System.Windows.Forms.Label lblHeteroAtomo;
        private System.Windows.Forms.Label lblCadeia;
        private System.Windows.Forms.TextBox txtSaturacao;
        private System.Windows.Forms.Label lblSaturacao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtInfixo;
        private System.Windows.Forms.Label lvlInfixo;
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.TextBox txtFormula;
        private System.Windows.Forms.Label lblClassificacao;
        private System.Windows.Forms.TextBox txtClassificacao;
        private System.Windows.Forms.Label lblConexao;
        private System.Windows.Forms.TextBox txtConexao;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Label lblLista;
    }
}

