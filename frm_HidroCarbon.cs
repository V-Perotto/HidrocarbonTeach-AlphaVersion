using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuimicaOrganica
{
    public partial class frmHidrocarbonetos : Form
    {
        Thread Lista;

        public frmHidrocarbonetos()
        {
            InitializeComponent();
        }

        private void frmHidrocarbonetos_Load(object sender, EventArgs e)
        {
            txtNome.ReadOnly = false;
        }

        private void frmHidrocarbonetos_FormClosing(object sender, FormClosingEventArgs exit)
        {
                string message = "Você tem certeza de fechar o QuimicaTeach?";
                string caption = "Fechando QuimicaTeach";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                // cancel the closure of the form.
                exit.Cancel = true;
            }
            
            // If the no button was pressed ...
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtInfixo_TextChanged(object sender, EventArgs e)
        {
            // Alcano, Alceno, Alcino, Alcadieno, Cicloalcano, Cicloalceno
        }

        private void txtNumCarbo_TextChanged(object sender, EventArgs e)
        {
            // Numeração de Carbonos da Cadeia Principal
        }

        private void txtAromatico_TextChanged(object sender, EventArgs e)
        {
            // Sim ou Não (Alicíclica (“não aromática”))
        }

        private void txtPrefixo_TextChanged(object sender, EventArgs e)
        {
            // Quantidade de Carbonos da Cadeia Principal

            //  1 = met;   2 = en;    3 = prop;
            //  4 = but;   5 = pent;  6 = hex;
            //  7 = hept;  8 = oct;   9 = non;  10 = dec;
        }

        private void txtSaturacao_TextChanged(object sender, EventArgs e)
        {
            // Saturada ou Insaturada
        }

        private void txtLigacao_TextChanged(object sender, EventArgs e)
        {
            // Somente simples, Dupla, Tripla, Duas Duplas
        }

        private void txtIntermediario_TextChanged(object sender, EventArgs e)
        {
            // an, en, in, dien
        }

        private void txtComposto_TextChanged(object sender, EventArgs e)
        {
            // Exemplo:   ET (2 carbonos) + EN (uma dupla ligação) + O = Eteno
        }

        private void txtMistura_TextChanged(object sender, EventArgs e)
        {
            // Heterogênea ou Homogênea
        }

        private void txtCadeia_TextChanged(object sender, EventArgs e)
        {
            // Aberta (ou Alifática ou Acíclica), Fechada (ou Cíclica), Mista (Aberta e Fechada)
        }

        private void txtNucleos_TextChanged(object sender, EventArgs e)
        {
            // Mononucleada ou Polinucleada
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            // Pesquisa pelo nome do Elemento Químico
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            // Total de Carbonos
        }

        private void txtConexao_TextChanged(object sender, EventArgs e)
        {
            // Quanto ao tipo de conexão entre os anéis aromáticos
            // Condensada ou Isolada
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // Este System.Environment.CurrentDirectory pega aonde o arquivo da minha pasta Hidrocarbon está.
            // Se adicionar o nome do Hidrocarboneto, ele procurará na pasta e mostrará.
            // Exemplo:
            // System.Environment.CurrentDirectory + \\Imagens\\Hidrocarboneto.png
            string nome_arquivo = System.Environment.CurrentDirectory;

            if (txtNome.Text == "Benzeno")
            {
                txtPrefixo.Text = "6 hex";
                txtInfixo.Text = "Alceno";
                txtLigacao.Text = "Dupla";
                txtIntermediario.Text = "en";
                txtComposto.Text = "ciclohex-1,3,5-trieno";
                txtAromatico.Text = "Sim";
                txtClassificacao.Text = "Mononucleada";
                txtConexao.Visible = false;
                lblConexao.Visible = false;

                txtHeteroAtomo.Visible = false;
                lblHeteroAtomo.Visible = false;
                txtCadeia.Text = "Fechada (ou Cíclica)";
                txtSaturacao.Visible = false;
                lblSaturacao.Visible = false;

                txtNumCarbo.Text = "C6";
                txtFormula.Text = "C6H6";

                try
                {
                    switch (txtNome.Text)
                    {
                        case "Benzeno":
                            picFormula.Image = Image.FromFile(nome_arquivo + "\\Imagens\\Benzeno.png");
                            break;
                        default:
                            MessageBox.Show("Não encontrado");
                            break;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível encontrar a imagem.");
                    throw;
                }
                
            }

            if (txtNome.Text == "Octano")
            {
                txtPrefixo.Text = "8 oct";
                txtInfixo.Text = "Alcano";
                txtLigacao.Text = "Simples";
                txtIntermediario.Text = "an";
                txtComposto.Text = "Alifático";
                txtAromatico.Text = "Não";
                txtClassificacao.Visible = false;
                lblClassificacao.Visible = false;
                txtConexao.Visible = false;
                lblConexao.Visible = false;

                txtHeteroAtomo.Visible = false;
                lblHeteroAtomo.Visible = false;
                txtCadeia.Text = "Aberta (ou Acíclica)";
                txtSaturacao.Text = "Saturada";

                txtNumCarbo.Text = "C8";
                txtFormula.Text = "C8H18";
                
                try
                {
                    switch (txtNome.Text)
                    {
                        case "Octano":
                            picFormula.Image = Image.FromFile(nome_arquivo + "\\Imagens\\Octano.png");
                            break;
                        default:
                            MessageBox.Show("não encontrado");
                            break;
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível encontrar a imagem.");
                }
            }

            if (txtNome.Text == "Heptano")
            {
                txtPrefixo.Text = "7 hept";
                txtInfixo.Text = "Alcano";
                txtLigacao.Text = "Simples";
                txtIntermediario.Text = "an";
                txtComposto.Text = "Alifático";
                txtAromatico.Text = "Não";
                txtClassificacao.Visible = false;
                lblClassificacao.Visible = false;
                txtConexao.Visible = false;
                lblConexao.Visible = false;

                txtHeteroAtomo.Visible = false;
                lblHeteroAtomo.Visible = false;
                txtCadeia.Text = "Aberta (ou Acíclica)";
                txtSaturacao.Text = "Saturada";

                txtNumCarbo.Text = "C7";
                txtFormula.Text = "C7H16";

                try
                {
                    switch (txtNome.Text)
                    {
                        case "Heptano":
                            picFormula.Image = Image.FromFile(nome_arquivo + "\\Imagens\\Heptano.png");
                            break;
                        default:
                            MessageBox.Show("não encontrado");
                            break;
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível encontrar a imagem.");
                }
            }
            
            if (txtNome.Text == "Isopentano" || txtNome.Text == "Metilbutano")
            {
                txtPrefixo.Text = "5 pent";
                txtInfixo.Text = "Alcano";
                txtLigacao.Text = "Simples";
                txtIntermediario.Text = "an";
                txtComposto.Text = "Alifático";
                txtAromatico.Text = "Não";
                txtClassificacao.Visible = false;
                lblClassificacao.Visible = false;
                txtConexao.Text = "Ramificada";

                txtHeteroAtomo.Visible = false;
                lblHeteroAtomo.Visible = false;
                txtCadeia.Text = "Aberta (ou Acíclica)";
                txtSaturacao.Text = "Saturada";

                txtNumCarbo.Text = "C5";
                txtFormula.Text = "C5H12";

                try
                {
                    switch (txtNome.Text)
                    {
                        case "Isopentano":
                            picFormula.Image = Image.FromFile(nome_arquivo + "\\Imagens\\Isopentano.png");
                            break;
                        case "Metilbutano":
                            picFormula.Image = Image.FromFile(nome_arquivo + "\\Imagens\\Isopentano.png");
                            break;
                        default:
                            MessageBox.Show("não encontrado");
                            break;
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível encontrar a imagem.");
                }
            }
            
            if (txtNome.Text == "Pentano")
            {
                txtPrefixo.Text = "5 pent";
                txtInfixo.Text = "Alcano";
                txtLigacao.Text = "Simples";
                txtIntermediario.Text = "an";
                txtComposto.Text = "Alifático";
                txtAromatico.Text = "Não";
                txtClassificacao.Visible = false;
                lblClassificacao.Visible = false;
                txtConexao.Visible = false;
                lblConexao.Visible = false;

                txtHeteroAtomo.Visible = false;
                lblHeteroAtomo.Visible = false;
                txtCadeia.Text = "Aberta (ou Acíclica)";
                txtSaturacao.Text = "Saturada";

                txtNumCarbo.Text = "C5";
                txtFormula.Text = "C5H12";

                try
                {
                    switch (txtNome.Text)
                    {
                        case "Pentano":
                            picFormula.Image = Image.FromFile(nome_arquivo + "\\Imagens\\Pentano.png");
                            break;
                        default:
                            MessageBox.Show("não encontrado");
                            break;
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível encontrar a imagem.");
                }
            }
            
            if (txtNome.Text == "Propano")
            {
                txtPrefixo.Text = "3 prop";
                txtInfixo.Text = "Alcano";
                txtLigacao.Text = "Simples";
                txtIntermediario.Text = "an";
                txtComposto.Text = "Alifático";
                txtAromatico.Text = "Não";
                txtClassificacao.Visible = false;
                lblClassificacao.Visible = false;
                txtConexao.Visible = false;
                lblConexao.Visible = false;

                txtHeteroAtomo.Visible = false;
                lblHeteroAtomo.Visible = false;
                txtCadeia.Text = "Aberta (ou Acíclica)";
                txtSaturacao.Text = "Saturada";

                txtNumCarbo.Text = "C5";
                txtFormula.Text = "C3H8";

                try
                {
                    switch (txtNome.Text)
                    {
                        case "Propano":
                            picFormula.Image = Image.FromFile(nome_arquivo + "\\Imagens\\Propano.png");
                            break;
                        default:
                            MessageBox.Show("não encontrado");
                            break;
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível encontrar a imagem.");
                }
            }
            
            if (txtNome.Text == "Etano")
            {
                txtPrefixo.Text = "2 et";
                txtInfixo.Text = "Alcano";
                txtLigacao.Text = "Simples";
                txtIntermediario.Text = "an";
                txtComposto.Text = "Alifático";
                txtAromatico.Text = "Não";
                txtClassificacao.Visible = false;
                lblClassificacao.Visible = false;
                txtConexao.Visible = false;
                lblConexao.Visible = false;

                txtHeteroAtomo.Visible = false;
                lblHeteroAtomo.Visible = false;
                txtCadeia.Text = "Aberta (ou Acíclica)";
                txtSaturacao.Text = "Saturada";

                txtNumCarbo.Text = "C2";
                txtFormula.Text = "C2H6";

                try
                {
                    switch (txtNome.Text)
                    {
                        case "Etano":
                            picFormula.Image = Image.FromFile(nome_arquivo + "\\Imagens\\Etano.png");
                            break;
                        default:
                            MessageBox.Show("não encontrado");
                            break;
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível encontrar a imagem.");
                }
            }
            
            if (txtNome.Text == "Eteno" || txtNome.Text == "Etileno")
            {
                txtPrefixo.Text = "2 et";
                txtInfixo.Text = "Alceno";
                txtLigacao.Text = "Dupla";
                txtIntermediario.Text = "en";
                txtComposto.Text = "Eteno";
                txtAromatico.Text = "Não";
                txtClassificacao.Visible = false;
                lblClassificacao.Visible = false;
                txtConexao.Visible = false;
                lblConexao.Visible = false;

                txtHeteroAtomo.Visible = false;
                lblHeteroAtomo.Visible = false;
                txtCadeia.Text = "Aberta (ou Acíclica)";
                txtSaturacao.Text = "Insaturada";

                txtNumCarbo.Text = "C2";
                txtFormula.Text = "C2H4";

                try
                {
                    switch (txtNome.Text)
                    {
                        case "Eteno":
                            picFormula.Image = Image.FromFile(nome_arquivo + "\\Imagens\\Eteno.png");
                            break;
                        case "Etileno":
                            picFormula.Image = Image.FromFile(nome_arquivo + "\\Imagens\\Eteno.png");
                            break;
                        default:
                            MessageBox.Show("não encontrado");
                            break;
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível encontrar a imagem.");
                }
            }

            if (txtNome.Text == "Etino" || txtNome.Text == "Acetileno")
            {
                txtPrefixo.Text = "2 et";
                txtInfixo.Text = "Alcino";
                txtLigacao.Text = "Tripla";
                txtIntermediario.Text = "in";
                txtComposto.Text = "Etino";
                txtAromatico.Text = "Não";
                txtClassificacao.Visible = false;
                lblClassificacao.Visible = false;
                txtConexao.Visible = false;
                lblConexao.Visible = false;

                txtHeteroAtomo.Visible = false;
                lblHeteroAtomo.Visible = false;
                txtCadeia.Text = "Aberta (ou Acíclica)";
                txtSaturacao.Text = "Insaturada";

                txtNumCarbo.Text = "C2";
                txtFormula.Text = "C2H2";

                try
                {
                    switch (txtNome.Text)
                    {
                        case "Etino":
                            picFormula.Image = Image.FromFile(nome_arquivo + "\\Imagens\\Etino.png");
                            break;
                        case "Acetileno":
                            picFormula.Image = Image.FromFile(nome_arquivo + "\\Imagens\\Etino.png");
                            break;
                        default:
                            MessageBox.Show("não encontrado");
                            break;
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível encontrar a imagem.");
                }
            }
            
            if (txtNome.Text == "Buteno")
            {
                txtPrefixo.Text = "4 but";
                txtInfixo.Text = "Alceno";
                txtLigacao.Text = "Dupla";
                txtIntermediario.Text = "en";
                txtComposto.Text = "1-buteno";
                txtAromatico.Text = "Não";
                txtClassificacao.Visible = false;
                lblClassificacao.Visible = false;
                txtConexao.Visible = false;
                lblConexao.Visible = false;

                txtHeteroAtomo.Visible = false;
                lblHeteroAtomo.Visible = false;
                txtCadeia.Text = "Aberta (ou Acíclica)";
                txtSaturacao.Text = "Insaturada";

                txtNumCarbo.Text = "C4";
                txtFormula.Text = "C4H8";

                try
                {
                    switch (txtNome.Text)
                    {
                        case "Buteno":
                            picFormula.Image = Image.FromFile(nome_arquivo + "\\Imagens\\Buteno.png");
                            break;
                        default:
                            MessageBox.Show("não encontrado");
                            break;
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível encontrar a imagem.");
                }
            }
            
            if (txtNome.Text == "Etilacetileno")
            {
                txtPrefixo.Text = "2 et";
                txtInfixo.Text = "Alcino";
                txtLigacao.Text = "Tripla";
                txtIntermediario.Text = "in";
                txtComposto.Text = "1-Butino";
                txtAromatico.Text = "Não";
                txtClassificacao.Visible = false;
                lblClassificacao.Visible = false;
                txtConexao.Visible = false;
                lblConexao.Visible = false;

                txtHeteroAtomo.Visible = false;
                lblHeteroAtomo.Visible = false;
                txtCadeia.Text = "Aberta (ou Acíclica)";
                txtSaturacao.Text = "Insaturada";

                txtNumCarbo.Text = "C4";
                txtFormula.Text = "C4H6";

                try
                {
                    switch (txtNome.Text)
                    {
                        case "Etilacetileno":
                            picFormula.Image = Image.FromFile(nome_arquivo + "\\Imagens\\Etilacetileno.png");
                            break;
                        default:
                            MessageBox.Show("não encontrado");
                            break;
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível encontrar a imagem.");
                }
            }
            
            if (txtNome.Text == "Propino" || txtNome.Text == "Metilacetileno")
            {
                txtPrefixo.Text = "3 prop";
                txtInfixo.Text = "Alcino";
                txtLigacao.Text = "Tripla";
                txtIntermediario.Text = "in";
                txtComposto.Text = "Prop1ino";
                txtAromatico.Text = "Não";
                txtClassificacao.Visible = false;
                lblClassificacao.Visible = false;
                txtConexao.Visible = false;
                lblConexao.Visible = false;

                txtHeteroAtomo.Visible = false;
                lblHeteroAtomo.Visible = false;
                txtCadeia.Text = "Aberta (ou Acíclica)";
                txtSaturacao.Text = "Insaturada";

                txtNumCarbo.Text = "C3";
                txtFormula.Text = "C3H4";

                try
                {
                    switch (txtNome.Text)
                    {
                        case "Propino":
                            picFormula.Image = Image.FromFile(nome_arquivo + "\\Imagens\\Propino.png");
                            break;
                        case "Metilacetileno":
                            picFormula.Image = Image.FromFile(nome_arquivo + "\\Imagens\\Propino.png");
                            break;
                        default:
                            MessageBox.Show("não encontrado");
                            break;
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível encontrar a imagem.");
                }
            }
            //////////////////////////////// CORRIGIDO ATÉ AQUI ^^^^^^^^
            if (txtNome.Text == "TESTE" || txtNome.Text == "TESTE")
            {
                txtPrefixo.Text = "";
                txtInfixo.Text = "Alc no";
                txtLigacao.Text = "";
                txtIntermediario.Text = " n";
                txtComposto.Text = " n o";
                txtAromatico.Text = "";
                txtClassificacao.Text = "";
                txtConexao.Text = "";

                txtHeteroAtomo.Visible = false;
                lblHeteroAtomo.Visible = false;
                txtCadeia.Text = "";
                txtSaturacao.Text = "";

                txtNumCarbo.Text = "C";
                txtFormula.Text = "C H ";

                try
                {
                    switch (txtNome.Text)
                    {
                        case "":
                            picFormula.Image = Image.FromFile(nome_arquivo + "\\Imagens\\.png");
                            break;
                        //case "":
                        //    picFormula.Image = Image.FromFile(nome_arquivo + "\\Imagens\\.png);
                        //    break;
                        default:
                            MessageBox.Show("não encontrado");
                            break;
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível encontrar a imagem.");
                }
            }
        }

        private void picFormula_Click(object sender, EventArgs e)
        {

        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            Lista = new Thread(List);
            Lista.SetApartmentState(ApartmentState.STA);
            Lista.Start();
        }

        private void List()
        {
            Application.Run(new frm_Lista());
        }

        public static IEnumerable<string> AcharArquivosComPermissaoRecursivamente(
        string caminhoRaiz,
        string padrao = ".png")
        {
            var caminhosPendentes = new Queue<string>();
            var arquivosAchados = new List<string>();

            caminhosPendentes.Enqueue(caminhoRaiz);

            while (caminhosPendentes.Count > 0)
            {
                var caminhoAtual = caminhosPendentes.Dequeue();

                try
                {
                    var listaArquivos = Directory.GetFiles(caminhoAtual, padrao);
                    arquivosAchados.AddRange(listaArquivos);

                    foreach (var subDiretorio in Directory.GetDirectories(caminhoAtual))
                        caminhosPendentes.Enqueue(subDiretorio);
                }
                catch (UnauthorizedAccessException)
                {
                    // Ignorar exceções sobre acesso não autorizado.
                }
            }

            return arquivosAchados;
        }
    }
}
