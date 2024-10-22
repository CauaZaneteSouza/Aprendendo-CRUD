namespace CRUD
{
    partial class FRM_ALUNO
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbd_floresta = new System.Windows.Forms.RadioButton();
            this.rbd_barroca = new System.Windows.Forms.RadioButton();
            this.TXT_NOME = new System.Windows.Forms.TextBox();
            this.TXT_idade = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbd_serie3 = new System.Windows.Forms.RadioButton();
            this.rbd_serie2 = new System.Windows.Forms.RadioButton();
            this.rbd_serie1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_SAI = new System.Windows.Forms.Button();
            this.BTN_PESQUISA = new System.Windows.Forms.Button();
            this.BTN_EXCLUI = new System.Windows.Forms.Button();
            this.BTN_ALTERA = new System.Windows.Forms.Button();
            this.BTN_CADASTRA = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtg_aluno = new System.Windows.Forms.DataGridView();
            this.cmb_seleciona = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_aluno)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbd_floresta);
            this.panel1.Controls.Add(this.rbd_barroca);
            this.panel1.Location = new System.Drawing.Point(70, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 57);
            this.panel1.TabIndex = 5;
            // 
            // rbd_floresta
            // 
            this.rbd_floresta.AutoSize = true;
            this.rbd_floresta.Location = new System.Drawing.Point(94, 14);
            this.rbd_floresta.Name = "rbd_floresta";
            this.rbd_floresta.Size = new System.Drawing.Size(62, 17);
            this.rbd_floresta.TabIndex = 1;
            this.rbd_floresta.Text = "Floresta";
            this.rbd_floresta.UseVisualStyleBackColor = true;
            this.rbd_floresta.CheckedChanged += new System.EventHandler(this.rbd_floresta_CheckedChanged);
            // 
            // rbd_barroca
            // 
            this.rbd_barroca.AutoSize = true;
            this.rbd_barroca.Checked = true;
            this.rbd_barroca.Location = new System.Drawing.Point(3, 14);
            this.rbd_barroca.Name = "rbd_barroca";
            this.rbd_barroca.Size = new System.Drawing.Size(62, 17);
            this.rbd_barroca.TabIndex = 0;
            this.rbd_barroca.TabStop = true;
            this.rbd_barroca.Text = "Barroca";
            this.rbd_barroca.UseVisualStyleBackColor = true;
            // 
            // TXT_NOME
            // 
            this.TXT_NOME.Location = new System.Drawing.Point(70, 48);
            this.TXT_NOME.Name = "TXT_NOME";
            this.TXT_NOME.Size = new System.Drawing.Size(504, 20);
            this.TXT_NOME.TabIndex = 6;
            // 
            // TXT_idade
            // 
            this.TXT_idade.Location = new System.Drawing.Point(598, 48);
            this.TXT_idade.Name = "TXT_idade";
            this.TXT_idade.Size = new System.Drawing.Size(100, 20);
            this.TXT_idade.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbd_serie3);
            this.panel2.Controls.Add(this.rbd_serie2);
            this.panel2.Controls.Add(this.rbd_serie1);
            this.panel2.Location = new System.Drawing.Point(297, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 57);
            this.panel2.TabIndex = 6;
            // 
            // rbd_serie3
            // 
            this.rbd_serie3.AutoSize = true;
            this.rbd_serie3.Location = new System.Drawing.Point(123, 14);
            this.rbd_serie3.Name = "rbd_serie3";
            this.rbd_serie3.Size = new System.Drawing.Size(35, 17);
            this.rbd_serie3.TabIndex = 3;
            this.rbd_serie3.TabStop = true;
            this.rbd_serie3.Text = "3ª";
            this.rbd_serie3.UseVisualStyleBackColor = true;
            // 
            // rbd_serie2
            // 
            this.rbd_serie2.AutoSize = true;
            this.rbd_serie2.Location = new System.Drawing.Point(69, 14);
            this.rbd_serie2.Name = "rbd_serie2";
            this.rbd_serie2.Size = new System.Drawing.Size(35, 17);
            this.rbd_serie2.TabIndex = 2;
            this.rbd_serie2.TabStop = true;
            this.rbd_serie2.Text = "2ª";
            this.rbd_serie2.UseVisualStyleBackColor = true;
            // 
            // rbd_serie1
            // 
            this.rbd_serie1.AutoSize = true;
            this.rbd_serie1.Location = new System.Drawing.Point(9, 14);
            this.rbd_serie1.Name = "rbd_serie1";
            this.rbd_serie1.Size = new System.Drawing.Size(35, 17);
            this.rbd_serie1.TabIndex = 1;
            this.rbd_serie1.TabStop = true;
            this.rbd_serie1.Text = "1ª";
            this.rbd_serie1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // BTN_SAI
            // 
            this.BTN_SAI.Location = new System.Drawing.Point(550, 307);
            this.BTN_SAI.Name = "BTN_SAI";
            this.BTN_SAI.Size = new System.Drawing.Size(75, 23);
            this.BTN_SAI.TabIndex = 14;
            this.BTN_SAI.Text = "Sair";
            this.BTN_SAI.UseVisualStyleBackColor = true;
            this.BTN_SAI.Click += new System.EventHandler(this.BTN_SAI_Click);
            // 
            // BTN_PESQUISA
            // 
            this.BTN_PESQUISA.Location = new System.Drawing.Point(420, 307);
            this.BTN_PESQUISA.Name = "BTN_PESQUISA";
            this.BTN_PESQUISA.Size = new System.Drawing.Size(75, 23);
            this.BTN_PESQUISA.TabIndex = 13;
            this.BTN_PESQUISA.Text = "Pesquisar ";
            this.BTN_PESQUISA.UseVisualStyleBackColor = true;
            this.BTN_PESQUISA.Click += new System.EventHandler(this.BTN_PESQUISA_Click);
            // 
            // BTN_EXCLUI
            // 
            this.BTN_EXCLUI.Location = new System.Drawing.Point(297, 307);
            this.BTN_EXCLUI.Name = "BTN_EXCLUI";
            this.BTN_EXCLUI.Size = new System.Drawing.Size(75, 23);
            this.BTN_EXCLUI.TabIndex = 12;
            this.BTN_EXCLUI.Text = "Excluir";
            this.BTN_EXCLUI.UseVisualStyleBackColor = true;
            // 
            // BTN_ALTERA
            // 
            this.BTN_ALTERA.Location = new System.Drawing.Point(182, 307);
            this.BTN_ALTERA.Name = "BTN_ALTERA";
            this.BTN_ALTERA.Size = new System.Drawing.Size(75, 23);
            this.BTN_ALTERA.TabIndex = 11;
            this.BTN_ALTERA.Text = "Alterar";
            this.BTN_ALTERA.UseVisualStyleBackColor = true;
            // 
            // BTN_CADASTRA
            // 
            this.BTN_CADASTRA.Location = new System.Drawing.Point(70, 307);
            this.BTN_CADASTRA.Name = "BTN_CADASTRA";
            this.BTN_CADASTRA.Size = new System.Drawing.Size(75, 23);
            this.BTN_CADASTRA.TabIndex = 10;
            this.BTN_CADASTRA.Text = "Cadastrar";
            this.BTN_CADASTRA.UseVisualStyleBackColor = true;
            this.BTN_CADASTRA.Click += new System.EventHandler(this.BTN_CADASTRA_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Unidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Série:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(598, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Idade:";
            // 
            // dtg_aluno
            // 
            this.dtg_aluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_aluno.Location = new System.Drawing.Point(70, 161);
            this.dtg_aluno.Name = "dtg_aluno";
            this.dtg_aluno.Size = new System.Drawing.Size(510, 130);
            this.dtg_aluno.TabIndex = 19;
            this.dtg_aluno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_aluno_CellClick);
            // 
            // cmb_seleciona
            // 
            this.cmb_seleciona.FormattingEnabled = true;
            this.cmb_seleciona.Items.AddRange(new object[] {
            "1A",
            "1B",
            "1C",
            "2A",
            "2B",
            "2C",
            "3A",
            "3B",
            "3C"});
            this.cmb_seleciona.Location = new System.Drawing.Point(601, 134);
            this.cmb_seleciona.Name = "cmb_seleciona";
            this.cmb_seleciona.Size = new System.Drawing.Size(121, 21);
            this.cmb_seleciona.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(601, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Turma";
            // 
            // FRM_ALUNO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_seleciona);
            this.Controls.Add(this.dtg_aluno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_SAI);
            this.Controls.Add(this.BTN_PESQUISA);
            this.Controls.Add(this.BTN_EXCLUI);
            this.Controls.Add(this.BTN_ALTERA);
            this.Controls.Add(this.BTN_CADASTRA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TXT_idade);
            this.Controls.Add(this.TXT_NOME);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_ALUNO";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FRM_ALUNO_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_aluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbd_floresta;
        private System.Windows.Forms.RadioButton rbd_barroca;
        private System.Windows.Forms.TextBox TXT_NOME;
        private System.Windows.Forms.TextBox TXT_idade;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbd_serie1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_SAI;
        private System.Windows.Forms.Button BTN_PESQUISA;
        private System.Windows.Forms.Button BTN_EXCLUI;
        private System.Windows.Forms.Button BTN_ALTERA;
        private System.Windows.Forms.Button BTN_CADASTRA;
        private System.Windows.Forms.RadioButton rbd_serie3;
        private System.Windows.Forms.RadioButton rbd_serie2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtg_aluno;
        private System.Windows.Forms.ComboBox cmb_seleciona;
        private System.Windows.Forms.Label label6;
    }
}

