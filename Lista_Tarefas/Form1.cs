using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_Tarefas
{
    public partial class Form1 : Form
    {
        int IdSelecionado = 0;
        public Form1()
        {
            InitializeComponent();
            Tarefas tarefas = new Tarefas();
            dgvTela.DataSource = tarefas.ListarTudo();
        }
        
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Caso os campos estejam vazios, correção do erro //
            if (txbNomeTFCadastrar.Text != "" && txbLocalCadastrar.Text != "" &&  txbObservacaoCadastrar.Text != "" && dtpDataCadastrar.Text != "")
            {
                //instanciar Cliente:
                 Tarefas tarefas = new Tarefas();

                //obter valores dos campos

                tarefas.Nome_tarefas = txbNomeTFCadastrar.Text;
                tarefas.Local = txbLocalCadastrar.Text;
                tarefas.Observacao = txbObservacaoCadastrar.Text;
                tarefas.Data_limite = dtpDataCadastrar.Value;


                if (tarefas.Cadastrar() == true)
                {
                    MessageBox.Show("Tarefa cadastrado com sucesso!");

                    //limpar os campos
                    txbNomeTFCadastrar.Clear();
                    txbLocalCadastrar.Clear();
                    txbObservacaoCadastrar.Clear();
                    

                    //atualizar dgv
                    dgvTela.DataSource = tarefas.ListarTudo();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar Tarefas");
                }
            }
            else
            {
                MessageBox.Show("Campos Vazios!", "Inválido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvTela_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ativar os groupbox editar e apagar
            gbApagar.Enabled = true;
            gbEditar.Enabled = true;

            //obter linha clicada
            int linhaSelecionada = dgvTela.CurrentCell.RowIndex;

            //armazenar os dados da linha clicada em linha (tipo um vetor)
            var linha = dgvTela.Rows[linhaSelecionada];

            txbNomeTRFEdit.Text = linha.Cells[1].Value.ToString();
            txbLocalEdit.Text = linha.Cells[2].Value.ToString();
            txbObservacaoEdit.Text = linha.Cells[3].Value.ToString();
            dtpEditar.Text = linha.Cells[4].Value.ToString();

            /*
            lblMensagem.Text = linha.Cells[0].Value.ToString() + " - " +
                linha.Cells[1].Value.ToString() + "  " +
                linha.Cells[2].Value.ToString();
            */
            //Salvar o id na variavel global
            IdSelecionado = (int)linha.Cells[0].Value;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //instanciar usuario
            Tarefas tarefas = new Tarefas();
            //obter valores dos campos
            tarefas.Nome_tarefas = txbNomeTRFEdit.Text;
            tarefas.Local = txbLocalEdit.Text;
            tarefas.Observacao = txbObservacaoEdit.Text;
            tarefas.Data_limite = dtpEditar.Value;
            tarefas.Id = IdSelecionado;

            if (tarefas.Editar() == true)
            {
                MessageBox.Show("Tarefa modificado!", "Sucesso!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // atualizar dgv
                dgvTela.DataSource = tarefas.ListarTudo();

                //limpar campos de edicao

                txbNomeTRFEdit.Clear();
                txbLocalEdit.Clear();
                txbObservacaoEdit.Clear();

                lblApagar.Text = "Selecione uma Tarefa para apagar:";

                //desabilitar group box edição e apagar
                gbEditar.Enabled = false;
                gbApagar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Falha ao modificar Tarefa!", "ERROR!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Tarefas tarefas = new Tarefas();
            tarefas.Id = IdSelecionado;

            //mostrar messagebox
            var r = MessageBox.Show("Tem certeza que deseja remover?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                //apagar
                if (tarefas.Apagar() == true)
                {
                    MessageBox.Show("Tarefa Removida!", "SUCESSO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // atualizar dgv
                    dgvTela.DataSource = tarefas.ListarTudo();

                    //limpar campos de edição
                    txbNomeTRFEdit.Clear();
                    txbLocalEdit.Clear();
                    txbObservacaoEdit.Clear();
                    lblApagar.Text = "Selecione uma Tarefa para apagar:";

                    //desabilitar group box edição e apagar
                    gbApagar.Enabled = false;
                    gbEditar.Enabled = false;
                    
                }
                else
                {
                    MessageBox.Show("Falha ao remover Tarefas!", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
    
}
