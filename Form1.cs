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
        conexao_aluno c = new conexao_aluno();
        private void FRM_ALUNO_Load(object sender, EventArgs e)
        {
            c.ConectarBD();
        }
        private void BTN_CADASTRA_Click(object sender, EventArgs e)
        {
            string inserir;
            string unidade = rbd_barroca.Checked ? "B" : "F";
            int serie = rbd_serie1.Checked ? 1 : rbd_serie2.Checked ? 2 : 3;
            string turma = cmb_seleciona.Text;
            int idade;
            if (TXT_NOME.Text ==""&& int.TryParse(TXT_idade.Text, out idade))
            {
                inserir = String.Format($"INSERT INTO tbl_alunos VALUES (null, '{TXT_NOME.Text}', '{idade}', '{unidade}', '{serie}', '{turma}')");
                c.executar_comandos(inserir);
            }
            else
            {
                MessageBox.Show("Informação inválida!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
