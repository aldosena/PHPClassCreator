using System.Windows.Forms;

namespace Gerador
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
            this.txClasse = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCampos = new System.Windows.Forms.TabPage();
            this.btFilterFilds = new System.Windows.Forms.Button();
            this.txMy = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbLimpaMy = new System.Windows.Forms.Label();
            this.btMysql = new System.Windows.Forms.Button();
            this.btCriar = new System.Windows.Forms.Button();
            this.lbLimpaCampos = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txIndex = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPdo = new System.Windows.Forms.CheckBox();
            this.cbPrivado = new System.Windows.Forms.CheckBox();
            this.txFields = new System.Windows.Forms.TextBox();
            this.txCampos = new System.Windows.Forms.TextBox();
            this.tabMetodos = new System.Windows.Forms.TabPage();
            this.btCrud = new System.Windows.Forms.Button();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.txMeto = new System.Windows.Forms.TextBox();
            this.tabEscola = new System.Windows.Forms.TabPage();
            this.btCriaEscola = new System.Windows.Forms.Button();
            this.txEscola = new System.Windows.Forms.TextBox();
            this.tabController = new System.Windows.Forms.TabPage();
            this.btControllerCriar = new System.Windows.Forms.Button();
            this.txController = new System.Windows.Forms.TextBox();
            this.tabModel = new System.Windows.Forms.TabPage();
            this.txModel = new System.Windows.Forms.TextBox();
            this.tabDao = new System.Windows.Forms.TabPage();
            this.btCriarDao = new System.Windows.Forms.Button();
            this.btPegaParaDAO = new System.Windows.Forms.Button();
            this.BoxCamposDao = new System.Windows.Forms.CheckedListBox();
            this.txDao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txAviso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txNamespace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txTabela = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGrauDao = new System.Windows.Forms.CheckBox();
            this.cbGrauModel = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txConexao = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabCampos.SuspendLayout();
            this.tabMetodos.SuspendLayout();
            this.tabEscola.SuspendLayout();
            this.tabController.SuspendLayout();
            this.tabModel.SuspendLayout();
            this.tabDao.SuspendLayout();
            this.SuspendLayout();
            // 
            // txClasse
            // 
            this.txClasse.Location = new System.Drawing.Point(16, 36);
            this.txClasse.Name = "txClasse";
            this.txClasse.Size = new System.Drawing.Size(255, 20);
            this.txClasse.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabCampos);
            this.tabControl1.Controls.Add(this.tabMetodos);
            this.tabControl1.Controls.Add(this.tabController);
            this.tabControl1.Controls.Add(this.tabEscola);
            this.tabControl1.Controls.Add(this.tabModel);
            this.tabControl1.Controls.Add(this.tabDao);
            this.tabControl1.Location = new System.Drawing.Point(8, 200);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1226, 409);
            this.tabControl1.TabIndex = 1;
            // 
            // tabCampos
            // 
            this.tabCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabCampos.Controls.Add(this.btFilterFilds);
            this.tabCampos.Controls.Add(this.txMy);
            this.tabCampos.Controls.Add(this.label8);
            this.tabCampos.Controls.Add(this.label9);
            this.tabCampos.Controls.Add(this.lbLimpaMy);
            this.tabCampos.Controls.Add(this.btMysql);
            this.tabCampos.Controls.Add(this.btCriar);
            this.tabCampos.Controls.Add(this.lbLimpaCampos);
            this.tabCampos.Controls.Add(this.checkBox1);
            this.tabCampos.Controls.Add(this.txIndex);
            this.tabCampos.Controls.Add(this.label6);
            this.tabCampos.Controls.Add(this.label5);
            this.tabCampos.Controls.Add(this.cbPdo);
            this.tabCampos.Controls.Add(this.cbPrivado);
            this.tabCampos.Controls.Add(this.txFields);
            this.tabCampos.Controls.Add(this.txCampos);
            this.tabCampos.Location = new System.Drawing.Point(4, 22);
            this.tabCampos.Name = "tabCampos";
            this.tabCampos.Padding = new System.Windows.Forms.Padding(3);
            this.tabCampos.Size = new System.Drawing.Size(1218, 383);
            this.tabCampos.TabIndex = 6;
            this.tabCampos.Text = "Campos";
            // 
            // btFilterFilds
            // 
            this.btFilterFilds.Location = new System.Drawing.Point(272, 333);
            this.btFilterFilds.Name = "btFilterFilds";
            this.btFilterFilds.Size = new System.Drawing.Size(135, 38);
            this.btFilterFilds.TabIndex = 24;
            this.btFilterFilds.Text = "Split - (Alter)";
            this.btFilterFilds.UseVisualStyleBackColor = true;
            this.btFilterFilds.Click += new System.EventHandler(this.btFilterFilds_Click);
            // 
            // txMy
            // 
            this.txMy.Location = new System.Drawing.Point(14, 39);
            this.txMy.Multiline = true;
            this.txMy.Name = "txMy";
            this.txMy.Size = new System.Drawing.Size(431, 291);
            this.txMy.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Linhas do MySql";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(932, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Campos da Classe";
            // 
            // lbLimpaMy
            // 
            this.lbLimpaMy.AutoSize = true;
            this.lbLimpaMy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLimpaMy.ForeColor = System.Drawing.Color.Red;
            this.lbLimpaMy.Location = new System.Drawing.Point(397, 21);
            this.lbLimpaMy.Name = "lbLimpaMy";
            this.lbLimpaMy.Size = new System.Drawing.Size(48, 13);
            this.lbLimpaMy.TabIndex = 20;
            this.lbLimpaMy.Text = "Limpar X";
            this.lbLimpaMy.Click += new System.EventHandler(this.lbLimpaMy_Click);
            // 
            // btMysql
            // 
            this.btMysql.Location = new System.Drawing.Point(14, 333);
            this.btMysql.Name = "btMysql";
            this.btMysql.Size = new System.Drawing.Size(133, 38);
            this.btMysql.TabIndex = 19;
            this.btMysql.Text = "Split - (Create)";
            this.btMysql.UseVisualStyleBackColor = true;
            this.btMysql.Click += new System.EventHandler(this.btMysql_Click);
            // 
            // btCriar
            // 
            this.btCriar.Location = new System.Drawing.Point(795, 137);
            this.btCriar.Name = "btCriar";
            this.btCriar.Size = new System.Drawing.Size(122, 107);
            this.btCriar.TabIndex = 18;
            this.btCriar.Text = "Criar";
            this.btCriar.UseVisualStyleBackColor = true;
            this.btCriar.Click += new System.EventHandler(this.btCriar_Click);
            // 
            // lbLimpaCampos
            // 
            this.lbLimpaCampos.AutoSize = true;
            this.lbLimpaCampos.ForeColor = System.Drawing.Color.Red;
            this.lbLimpaCampos.Location = new System.Drawing.Point(729, 21);
            this.lbLimpaCampos.Name = "lbLimpaCampos";
            this.lbLimpaCampos.Size = new System.Drawing.Size(48, 13);
            this.lbLimpaCampos.TabIndex = 12;
            this.lbLimpaCampos.Text = "Limpar X";
            this.lbLimpaCampos.Click += new System.EventHandler(this.lbLimpaCampos_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(795, 114);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Incluir $response";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txIndex
            // 
            this.txIndex.Location = new System.Drawing.Point(935, 37);
            this.txIndex.Name = "txIndex";
            this.txIndex.ReadOnly = true;
            this.txIndex.Size = new System.Drawing.Size(263, 20);
            this.txIndex.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(932, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Campo Index";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Campos da Tabela";
            // 
            // cbPdo
            // 
            this.cbPdo.AutoSize = true;
            this.cbPdo.Checked = true;
            this.cbPdo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPdo.Location = new System.Drawing.Point(796, 91);
            this.cbPdo.Name = "cbPdo";
            this.cbPdo.Size = new System.Drawing.Size(81, 17);
            this.cbPdo.TabIndex = 6;
            this.cbPdo.Text = "Incluir $pdo";
            this.cbPdo.UseVisualStyleBackColor = true;
            // 
            // cbPrivado
            // 
            this.cbPrivado.AutoSize = true;
            this.cbPrivado.Location = new System.Drawing.Point(795, 50);
            this.cbPrivado.Name = "cbPrivado";
            this.cbPrivado.Size = new System.Drawing.Size(138, 17);
            this.cbPrivado.TabIndex = 5;
            this.cbPrivado.Text = "Declarar como privados";
            this.cbPrivado.UseVisualStyleBackColor = true;
            // 
            // txFields
            // 
            this.txFields.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txFields.Location = new System.Drawing.Point(935, 76);
            this.txFields.Multiline = true;
            this.txFields.Name = "txFields";
            this.txFields.ReadOnly = true;
            this.txFields.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txFields.Size = new System.Drawing.Size(263, 301);
            this.txFields.TabIndex = 4;
            // 
            // txCampos
            // 
            this.txCampos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCampos.Location = new System.Drawing.Point(465, 37);
            this.txCampos.Multiline = true;
            this.txCampos.Name = "txCampos";
            this.txCampos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txCampos.Size = new System.Drawing.Size(312, 341);
            this.txCampos.TabIndex = 3;
            this.txCampos.TextChanged += new System.EventHandler(this.txCampos_TextChanged);
            // 
            // tabMetodos
            // 
            this.tabMetodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabMetodos.Controls.Add(this.btCrud);
            this.tabMetodos.Controls.Add(this.checkBox6);
            this.tabMetodos.Controls.Add(this.checkBox5);
            this.tabMetodos.Controls.Add(this.checkBox4);
            this.tabMetodos.Controls.Add(this.checkBox3);
            this.tabMetodos.Controls.Add(this.checkBox2);
            this.tabMetodos.Controls.Add(this.txMeto);
            this.tabMetodos.Location = new System.Drawing.Point(4, 22);
            this.tabMetodos.Name = "tabMetodos";
            this.tabMetodos.Padding = new System.Windows.Forms.Padding(3);
            this.tabMetodos.Size = new System.Drawing.Size(1218, 383);
            this.tabMetodos.TabIndex = 8;
            this.tabMetodos.Text = "Métodos";
            // 
            // btCrud
            // 
            this.btCrud.Location = new System.Drawing.Point(25, 134);
            this.btCrud.Name = "btCrud";
            this.btCrud.Size = new System.Drawing.Size(197, 23);
            this.btCrud.TabIndex = 7;
            this.btCrud.Text = "CRUD";
            this.btCrud.UseVisualStyleBackColor = true;
            this.btCrud.Click += new System.EventHandler(this.btCrud_Click);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(25, 111);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(57, 17);
            this.checkBox6.TabIndex = 6;
            this.checkBox6.Text = "Excluir";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(25, 88);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(53, 17);
            this.checkBox5.TabIndex = 6;
            this.checkBox5.Text = "Editar";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(25, 42);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(106, 17);
            this.checkBox4.TabIndex = 6;
            this.checkBox4.Text = "Selecionar por Id";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(25, 19);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(109, 17);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "Selecionar Todos";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(25, 65);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(54, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Inserir";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // txMeto
            // 
            this.txMeto.Location = new System.Drawing.Point(234, 17);
            this.txMeto.Multiline = true;
            this.txMeto.Name = "txMeto";
            this.txMeto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txMeto.Size = new System.Drawing.Size(965, 266);
            this.txMeto.TabIndex = 3;
            // 
            // tabEscola
            // 
            this.tabEscola.BackColor = System.Drawing.Color.Gold;
            this.tabEscola.Controls.Add(this.btCriaEscola);
            this.tabEscola.Controls.Add(this.txEscola);
            this.tabEscola.Location = new System.Drawing.Point(4, 22);
            this.tabEscola.Name = "tabEscola";
            this.tabEscola.Padding = new System.Windows.Forms.Padding(3);
            this.tabEscola.Size = new System.Drawing.Size(1218, 383);
            this.tabEscola.TabIndex = 10;
            this.tabEscola.Text = "Model V1";
            // 
            // btCriaEscola
            // 
            this.btCriaEscola.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCriaEscola.Location = new System.Drawing.Point(18, 16);
            this.btCriaEscola.Name = "btCriaEscola";
            this.btCriaEscola.Size = new System.Drawing.Size(146, 42);
            this.btCriaEscola.TabIndex = 4;
            this.btCriaEscola.Text = "Criar";
            this.btCriaEscola.UseVisualStyleBackColor = true;
            this.btCriaEscola.Click += new System.EventHandler(this.button4_Click);
            // 
            // txEscola
            // 
            this.txEscola.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txEscola.Location = new System.Drawing.Point(183, 6);
            this.txEscola.Multiline = true;
            this.txEscola.Name = "txEscola";
            this.txEscola.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txEscola.Size = new System.Drawing.Size(1029, 365);
            this.txEscola.TabIndex = 0;
            // 
            // tabController
            // 
            this.tabController.BackColor = System.Drawing.Color.Pink;
            this.tabController.Controls.Add(this.btControllerCriar);
            this.tabController.Controls.Add(this.txController);
            this.tabController.Location = new System.Drawing.Point(4, 22);
            this.tabController.Name = "tabController";
            this.tabController.Padding = new System.Windows.Forms.Padding(3);
            this.tabController.Size = new System.Drawing.Size(1218, 383);
            this.tabController.TabIndex = 2;
            this.tabController.Text = "Controller";
            // 
            // btControllerCriar
            // 
            this.btControllerCriar.Location = new System.Drawing.Point(6, 17);
            this.btControllerCriar.Name = "btControllerCriar";
            this.btControllerCriar.Size = new System.Drawing.Size(131, 23);
            this.btControllerCriar.TabIndex = 1;
            this.btControllerCriar.Text = "Criar";
            this.btControllerCriar.UseVisualStyleBackColor = true;
            this.btControllerCriar.Click += new System.EventHandler(this.btControllerCriar_Click);
            // 
            // txController
            // 
            this.txController.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txController.Location = new System.Drawing.Point(143, 6);
            this.txController.Multiline = true;
            this.txController.Name = "txController";
            this.txController.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txController.Size = new System.Drawing.Size(1069, 365);
            this.txController.TabIndex = 0;
            // 
            // tabModel
            // 
            this.tabModel.BackColor = System.Drawing.Color.Khaki;
            this.tabModel.Controls.Add(this.txModel);
            this.tabModel.Location = new System.Drawing.Point(4, 22);
            this.tabModel.Name = "tabModel";
            this.tabModel.Padding = new System.Windows.Forms.Padding(3);
            this.tabModel.Size = new System.Drawing.Size(1218, 383);
            this.tabModel.TabIndex = 0;
            this.tabModel.Text = "Model V2";
            // 
            // txModel
            // 
            this.txModel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txModel.Location = new System.Drawing.Point(6, 6);
            this.txModel.Multiline = true;
            this.txModel.Name = "txModel";
            this.txModel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txModel.Size = new System.Drawing.Size(1206, 365);
            this.txModel.TabIndex = 0;
            // 
            // tabDao
            // 
            this.tabDao.BackColor = System.Drawing.Color.Khaki;
            this.tabDao.Controls.Add(this.btCriarDao);
            this.tabDao.Controls.Add(this.btPegaParaDAO);
            this.tabDao.Controls.Add(this.BoxCamposDao);
            this.tabDao.Controls.Add(this.txDao);
            this.tabDao.Location = new System.Drawing.Point(4, 22);
            this.tabDao.Name = "tabDao";
            this.tabDao.Padding = new System.Windows.Forms.Padding(3);
            this.tabDao.Size = new System.Drawing.Size(1218, 383);
            this.tabDao.TabIndex = 1;
            this.tabDao.Text = "DAO";
            // 
            // btCriarDao
            // 
            this.btCriarDao.Location = new System.Drawing.Point(346, 41);
            this.btCriarDao.Name = "btCriarDao";
            this.btCriarDao.Size = new System.Drawing.Size(75, 23);
            this.btCriarDao.TabIndex = 3;
            this.btCriarDao.Text = "Criar DAO";
            this.btCriarDao.UseVisualStyleBackColor = true;
            this.btCriarDao.Click += new System.EventHandler(this.btCriarDao_Click);
            // 
            // btPegaParaDAO
            // 
            this.btPegaParaDAO.Location = new System.Drawing.Point(14, 12);
            this.btPegaParaDAO.Name = "btPegaParaDAO";
            this.btPegaParaDAO.Size = new System.Drawing.Size(108, 23);
            this.btPegaParaDAO.TabIndex = 2;
            this.btPegaParaDAO.Text = "Pegar Campos";
            this.btPegaParaDAO.UseVisualStyleBackColor = true;
            this.btPegaParaDAO.Click += new System.EventHandler(this.btPegaParaDAO_Click);
            // 
            // BoxCamposDao
            // 
            this.BoxCamposDao.FormattingEnabled = true;
            this.BoxCamposDao.Location = new System.Drawing.Point(14, 41);
            this.BoxCamposDao.Name = "BoxCamposDao";
            this.BoxCamposDao.Size = new System.Drawing.Size(307, 289);
            this.BoxCamposDao.TabIndex = 1;
            // 
            // txDao
            // 
            this.txDao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txDao.Location = new System.Drawing.Point(443, 6);
            this.txDao.Multiline = true;
            this.txDao.Name = "txDao";
            this.txDao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txDao.Size = new System.Drawing.Size(769, 365);
            this.txDao.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome da Classe:";
            // 
            // txAviso
            // 
            this.txAviso.Location = new System.Drawing.Point(937, 12);
            this.txAviso.Multiline = true;
            this.txAviso.Name = "txAviso";
            this.txAviso.ReadOnly = true;
            this.txAviso.Size = new System.Drawing.Size(290, 202);
            this.txAviso.TabIndex = 7;
            this.txAviso.Text = "Versao 3.0\r\n - Abr/2024";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Diretório do Namespace";
            // 
            // txNamespace
            // 
            this.txNamespace.Location = new System.Drawing.Point(16, 75);
            this.txNamespace.Name = "txNamespace";
            this.txNamespace.Size = new System.Drawing.Size(255, 20);
            this.txNamespace.TabIndex = 1;
            this.txNamespace.Text = "src\\Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tabela Referente a Classe";
            // 
            // txTabela
            // 
            this.txTabela.Location = new System.Drawing.Point(16, 114);
            this.txTabela.Name = "txTabela";
            this.txTabela.Size = new System.Drawing.Size(255, 20);
            this.txTabela.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(856, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Teste";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tipos de Classes";
            // 
            // cbGrauDao
            // 
            this.cbGrauDao.AutoSize = true;
            this.cbGrauDao.Checked = true;
            this.cbGrauDao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGrauDao.Location = new System.Drawing.Point(324, 97);
            this.cbGrauDao.Name = "cbGrauDao";
            this.cbGrauDao.Size = new System.Drawing.Size(49, 17);
            this.cbGrauDao.TabIndex = 16;
            this.cbGrauDao.Text = "DAO";
            this.cbGrauDao.UseVisualStyleBackColor = true;
            // 
            // cbGrauModel
            // 
            this.cbGrauModel.AutoSize = true;
            this.cbGrauModel.Checked = true;
            this.cbGrauModel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGrauModel.Location = new System.Drawing.Point(324, 75);
            this.cbGrauModel.Name = "cbGrauModel";
            this.cbGrauModel.Size = new System.Drawing.Size(55, 17);
            this.cbGrauModel.TabIndex = 18;
            this.cbGrauModel.Text = "Model";
            this.cbGrauModel.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Nome da Conexao";
            // 
            // txConexao
            // 
            this.txConexao.Location = new System.Drawing.Point(16, 153);
            this.txConexao.Name = "txConexao";
            this.txConexao.Size = new System.Drawing.Size(255, 20);
            this.txConexao.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1246, 621);
            this.Controls.Add(this.txConexao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbGrauModel);
            this.Controls.Add(this.cbGrauDao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txTabela);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txNamespace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txAviso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txClasse);
            this.Name = "Form1";
            this.Text = "Gerador de Classes PHP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabCampos.ResumeLayout(false);
            this.tabCampos.PerformLayout();
            this.tabMetodos.ResumeLayout(false);
            this.tabMetodos.PerformLayout();
            this.tabEscola.ResumeLayout(false);
            this.tabEscola.PerformLayout();
            this.tabController.ResumeLayout(false);
            this.tabController.PerformLayout();
            this.tabModel.ResumeLayout(false);
            this.tabModel.PerformLayout();
            this.tabDao.ResumeLayout(false);
            this.tabDao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txClasse;
        private TabControl tabControl1;
        private System.Windows.Forms.TabControl T;
        private System.Windows.Forms.TabPage tabModel;
        private System.Windows.Forms.TabPage tabDao;
        private System.Windows.Forms.TextBox txModel;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage tabController;
        private System.Windows.Forms.TextBox txController;
        private System.Windows.Forms.TextBox txAviso;
        private Label label2;
        private TextBox txNamespace;
        private TextBox txDao;
        private Label label3;
        private TextBox txTabela;
        private TabPage tabCampos;
        private TextBox txCampos;
        private TabPage tabMetodos;
        private TabPage tabEscola;
        private Button button1;
        private TextBox txEscola;
        private TextBox txFields;
        private CheckBox cbPrivado;
        private CheckBox cbPdo;
        private Label label5;
        private TextBox txMeto;
        private Label label4;
        private CheckBox cbGrauDao;
        private TextBox txIndex;
        private Label label6;
        private CheckBox cbGrauModel;
        private Label label7;
        private TextBox txConexao;
        private CheckBox checkBox1;
        private Label lbLimpaCampos;
        private Button btCriar;
        private Button btMysql;
        private TextBox txMy;
        private Label label8;
        private Label label9;
        private Label lbLimpaMy;
        private Button btCrud;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckedListBox BoxCamposDao;
        private Button btPegaParaDAO;
        private Button btCriaEscola;
        private Button btFilterFilds;
        private Button btControllerCriar;
        private Button btCriarDao;
    }
}

