using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// para fazer o crud clicar com o botão direito na solução do projeto "Gerencia pacotes (é um ícone azul)" instalar o Mysql.data 
namespace CRUD
{
    public partial class FRM_ALUNO : Form
    {
        public FRM_ALUNO()
        {
            InitializeComponent();
        }
        conexao_aluno bd = new conexao_aluno();
        string tabela = "tbl_alunos";
        private void FRM_ALUNO_Load(object sender, EventArgs e)
        {
            bd.ConectarBD();
        }
        private void BTN_CADASTRA_Click(object sender, EventArgs e)
        {
            string inserir;
            string unidade = rbd_barroca.Checked ? "B" : "F";
            int serie = rbd_serie1.Checked ? 1 : rbd_serie2.Checked ? 2 : 3;
            string turma = cmb_seleciona.Text;
            int idade;
            if (TXT_NOME.Text !=""&& int.TryParse(TXT_idade.Text, out idade))
            {
                inserir = String.Format($"INSERT INTO {tabela} VALUES (null, '{TXT_NOME.Text}', '{idade}', '{unidade}', '{serie}', '{turma}')");
                bd.executar_comandos(inserir);
                Exibir_dados();
                limpa_tela();
            }
            else
            {
                MessageBox.Show("Informação inválida!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Exibir_dados()
        {
            //Preparar o comando
            string dados = $"select * from {tabela}";
            DataTable dt = bd.executar_consulta(dados);
            dtg_aluno.DataSource = dt.AsDataView();
        }
        private void limpa_tela()
        {
            TXT_NOME.Clear();
            TXT_idade.Clear();
            rbd_barroca.Checked = false;
            rbd_floresta.Checked = false;
            rbd_serie1.Checked = false;
            rbd_serie2.Checked = false;
            rbd_serie3.Checked = false;
            cmb_seleciona.Text = "";
            TXT_NOME.Focus();
        }
private void dtg_aluno_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            e.ToolTipText = "Clique em uma célula para preencher os campos do formulário";
        }

        private void BTN_PESQUISA_Click(object sender, EventArgs e)
        {
            Exibir_dados();
        }

        private void BTN_SAI_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtg_aluno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TXT_NOME.Text = dtg_aluno.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void rbd_floresta_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
