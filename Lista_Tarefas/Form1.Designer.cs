namespace Lista_Tarefas
{
    partial class Form1
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
            this.dgvTela = new System.Windows.Forms.DataGridView();
            this.lblTarefas = new System.Windows.Forms.Label();
            this.gbCadastrar = new System.Windows.Forms.GroupBox();
            this.gbEditar = new System.Windows.Forms.GroupBox();
            this.gbApagar = new System.Windows.Forms.GroupBox();
            this.lblNomeTRF = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbTarefas = new System.Windows.Forms.TextBox();
            this.txbLocal = new System.Windows.Forms.TextBox();
            this.txbObservacao = new System.Windows.Forms.TextBox();
            this.txbData = new System.Windows.Forms.TextBox();
            this.txbDataEdit = new System.Windows.Forms.TextBox();
            this.txbObservacaoEdit = new System.Windows.Forms.TextBox();
            this.txbLocalEdit = new System.Windows.Forms.TextBox();
            this.txbNomeTRFEdit = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblDataEdit = new System.Windows.Forms.Label();
            this.lblObservacaoEdit = new System.Windows.Forms.Label();
            this.lblLocalEdit = new System.Windows.Forms.Label();
            this.lblNomeTFedit = new System.Windows.Forms.Label();
            this.lblApagar = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTela)).BeginInit();
            this.gbCadastrar.SuspendLayout();
            this.gbEditar.SuspendLayout();
            this.gbApagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTela
            // 
            this.dgvTela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTela.Location = new System.Drawing.Point(60, 106);
            this.dgvTela.Name = "dgvTela";
            this.dgvTela.Size = new System.Drawing.Size(990, 321);
            this.dgvTela.TabIndex = 0;
            // 
            // lblTarefas
            // 
            this.lblTarefas.AutoSize = true;
            this.lblTarefas.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarefas.Location = new System.Drawing.Point(448, 52);
            this.lblTarefas.Name = "lblTarefas";
            this.lblTarefas.Size = new System.Drawing.Size(234, 31);
            this.lblTarefas.TabIndex = 1;
            this.lblTarefas.Text = "Lista de Tarefas ";
            // 
            // gbCadastrar
            // 
            this.gbCadastrar.Controls.Add(this.txbData);
            this.gbCadastrar.Controls.Add(this.txbObservacao);
            this.gbCadastrar.Controls.Add(this.txbLocal);
            this.gbCadastrar.Controls.Add(this.txbTarefas);
            this.gbCadastrar.Controls.Add(this.btnCadastrar);
            this.gbCadastrar.Controls.Add(this.lblData);
            this.gbCadastrar.Controls.Add(this.lblObservacao);
            this.gbCadastrar.Controls.Add(this.lblLocal);
            this.gbCadastrar.Controls.Add(this.lblNomeTRF);
            this.gbCadastrar.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCadastrar.Location = new System.Drawing.Point(51, 451);
            this.gbCadastrar.Name = "gbCadastrar";
            this.gbCadastrar.Size = new System.Drawing.Size(296, 260);
            this.gbCadastrar.TabIndex = 2;
            this.gbCadastrar.TabStop = false;
            this.gbCadastrar.Text = "Cadastrar";
            // 
            // gbEditar
            // 
            this.gbEditar.Controls.Add(this.txbDataEdit);
            this.gbEditar.Controls.Add(this.btnEditar);
            this.gbEditar.Controls.Add(this.txbObservacaoEdit);
            this.gbEditar.Controls.Add(this.lblNomeTFedit);
            this.gbEditar.Controls.Add(this.txbLocalEdit);
            this.gbEditar.Controls.Add(this.lblLocalEdit);
            this.gbEditar.Controls.Add(this.txbNomeTRFEdit);
            this.gbEditar.Controls.Add(this.lblObservacaoEdit);
            this.gbEditar.Controls.Add(this.lblDataEdit);
            this.gbEditar.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEditar.Location = new System.Drawing.Point(386, 451);
            this.gbEditar.Name = "gbEditar";
            this.gbEditar.Size = new System.Drawing.Size(296, 260);
            this.gbEditar.TabIndex = 3;
            this.gbEditar.TabStop = false;
            this.gbEditar.Text = "Editar";
            // 
            // gbApagar
            // 
            this.gbApagar.Controls.Add(this.btnApagar);
            this.gbApagar.Controls.Add(this.lblApagar);
            this.gbApagar.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbApagar.Location = new System.Drawing.Point(745, 451);
            this.gbApagar.Name = "gbApagar";
            this.gbApagar.Size = new System.Drawing.Size(296, 260);
            this.gbApagar.TabIndex = 3;
            this.gbApagar.TabStop = false;
            this.gbApagar.Text = "Apagar";
            // 
            // lblNomeTRF
            // 
            this.lblNomeTRF.AutoSize = true;
            this.lblNomeTRF.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeTRF.Location = new System.Drawing.Point(13, 53);
            this.lblNomeTRF.Name = "lblNomeTRF";
            this.lblNomeTRF.Size = new System.Drawing.Size(95, 15);
            this.lblNomeTRF.TabIndex = 0;
            this.lblNomeTRF.Text = "Nome Tarefa:";
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.Location = new System.Drawing.Point(13, 95);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(46, 15);
            this.lblLocal.TabIndex = 1;
            this.lblLocal.Text = "Local:";
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.Location = new System.Drawing.Point(13, 134);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(93, 15);
            this.lblObservacao.TabIndex = 2;
            this.lblObservacao.Text = "Observação:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(13, 174);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(41, 15);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Data:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(86, 219);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(104, 26);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // txbTarefas
            // 
            this.txbTarefas.Location = new System.Drawing.Point(169, 42);
            this.txbTarefas.Name = "txbTarefas";
            this.txbTarefas.Size = new System.Drawing.Size(100, 26);
            this.txbTarefas.TabIndex = 5;
            // 
            // txbLocal
            // 
            this.txbLocal.Location = new System.Drawing.Point(169, 84);
            this.txbLocal.Name = "txbLocal";
            this.txbLocal.Size = new System.Drawing.Size(100, 26);
            this.txbLocal.TabIndex = 6;
            // 
            // txbObservacao
            // 
            this.txbObservacao.Location = new System.Drawing.Point(169, 123);
            this.txbObservacao.Name = "txbObservacao";
            this.txbObservacao.Size = new System.Drawing.Size(100, 26);
            this.txbObservacao.TabIndex = 7;
            // 
            // txbData
            // 
            this.txbData.Location = new System.Drawing.Point(169, 163);
            this.txbData.Name = "txbData";
            this.txbData.Size = new System.Drawing.Size(100, 26);
            this.txbData.TabIndex = 8;
            // 
            // txbDataEdit
            // 
            this.txbDataEdit.Location = new System.Drawing.Point(174, 163);
            this.txbDataEdit.Name = "txbDataEdit";
            this.txbDataEdit.Size = new System.Drawing.Size(100, 26);
            this.txbDataEdit.TabIndex = 17;
            // 
            // txbObservacaoEdit
            // 
            this.txbObservacaoEdit.Location = new System.Drawing.Point(174, 123);
            this.txbObservacaoEdit.Name = "txbObservacaoEdit";
            this.txbObservacaoEdit.Size = new System.Drawing.Size(100, 26);
            this.txbObservacaoEdit.TabIndex = 16;
            // 
            // txbLocalEdit
            // 
            this.txbLocalEdit.Location = new System.Drawing.Point(174, 84);
            this.txbLocalEdit.Name = "txbLocalEdit";
            this.txbLocalEdit.Size = new System.Drawing.Size(100, 26);
            this.txbLocalEdit.TabIndex = 15;
            // 
            // txbNomeTRFEdit
            // 
            this.txbNomeTRFEdit.Location = new System.Drawing.Point(174, 42);
            this.txbNomeTRFEdit.Name = "txbNomeTRFEdit";
            this.txbNomeTRFEdit.Size = new System.Drawing.Size(100, 26);
            this.txbNomeTRFEdit.TabIndex = 14;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(91, 219);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(104, 26);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // lblDataEdit
            // 
            this.lblDataEdit.AutoSize = true;
            this.lblDataEdit.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEdit.Location = new System.Drawing.Point(18, 174);
            this.lblDataEdit.Name = "lblDataEdit";
            this.lblDataEdit.Size = new System.Drawing.Size(41, 15);
            this.lblDataEdit.TabIndex = 12;
            this.lblDataEdit.Text = "Data:";
            // 
            // lblObservacaoEdit
            // 
            this.lblObservacaoEdit.AutoSize = true;
            this.lblObservacaoEdit.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacaoEdit.Location = new System.Drawing.Point(18, 134);
            this.lblObservacaoEdit.Name = "lblObservacaoEdit";
            this.lblObservacaoEdit.Size = new System.Drawing.Size(93, 15);
            this.lblObservacaoEdit.TabIndex = 11;
            this.lblObservacaoEdit.Text = "Observação:";
            // 
            // lblLocalEdit
            // 
            this.lblLocalEdit.AutoSize = true;
            this.lblLocalEdit.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalEdit.Location = new System.Drawing.Point(18, 95);
            this.lblLocalEdit.Name = "lblLocalEdit";
            this.lblLocalEdit.Size = new System.Drawing.Size(46, 15);
            this.lblLocalEdit.TabIndex = 10;
            this.lblLocalEdit.Text = "Local:";
            // 
            // lblNomeTFedit
            // 
            this.lblNomeTFedit.AutoSize = true;
            this.lblNomeTFedit.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeTFedit.Location = new System.Drawing.Point(18, 53);
            this.lblNomeTFedit.Name = "lblNomeTFedit";
            this.lblNomeTFedit.Size = new System.Drawing.Size(95, 15);
            this.lblNomeTFedit.TabIndex = 9;
            this.lblNomeTFedit.Text = "Nome Tarefa:";
            // 
            // lblApagar
            // 
            this.lblApagar.AutoSize = true;
            this.lblApagar.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApagar.Location = new System.Drawing.Point(94, 111);
            this.lblApagar.Name = "lblApagar";
            this.lblApagar.Size = new System.Drawing.Size(93, 15);
            this.lblApagar.TabIndex = 18;
            this.lblApagar.Text = "Observação:";
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(83, 174);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(104, 26);
            this.btnApagar.TabIndex = 18;
            this.btnApagar.Text = "Editar";
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 779);
            this.Controls.Add(this.gbApagar);
            this.Controls.Add(this.gbEditar);
            this.Controls.Add(this.gbCadastrar);
            this.Controls.Add(this.lblTarefas);
            this.Controls.Add(this.dgvTela);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTela)).EndInit();
            this.gbCadastrar.ResumeLayout(false);
            this.gbCadastrar.PerformLayout();
            this.gbEditar.ResumeLayout(false);
            this.gbEditar.PerformLayout();
            this.gbApagar.ResumeLayout(false);
            this.gbApagar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTela;
        private System.Windows.Forms.Label lblTarefas;
        private System.Windows.Forms.GroupBox gbCadastrar;
        private System.Windows.Forms.TextBox txbData;
        private System.Windows.Forms.TextBox txbObservacao;
        private System.Windows.Forms.TextBox txbLocal;
        private System.Windows.Forms.TextBox txbTarefas;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Label lblNomeTRF;
        private System.Windows.Forms.GroupBox gbEditar;
        private System.Windows.Forms.TextBox txbDataEdit;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txbObservacaoEdit;
        private System.Windows.Forms.Label lblNomeTFedit;
        private System.Windows.Forms.TextBox txbLocalEdit;
        private System.Windows.Forms.Label lblLocalEdit;
        private System.Windows.Forms.TextBox txbNomeTRFEdit;
        private System.Windows.Forms.Label lblObservacaoEdit;
        private System.Windows.Forms.Label lblDataEdit;
        private System.Windows.Forms.GroupBox gbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblApagar;
    }
}

