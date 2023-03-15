namespace Lanchonete.Telas
{
    partial class F_CadClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dg_cliente = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apelido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfcnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_incluir = new System.Windows.Forms.Button();
            this.bt_alterar = new System.Windows.Forms.Button();
            this.bt_desativa = new System.Windows.Forms.Button();
            this.bt_voltar = new System.Windows.Forms.Button();
            this.p_cadastrocli = new System.Windows.Forms.Panel();
            this.lb_status = new System.Windows.Forms.Label();
            this.gb_cadrastrocli = new System.Windows.Forms.GroupBox();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.gb_dadoscli = new System.Windows.Forms.GroupBox();
            this.msk_celular2 = new System.Windows.Forms.MaskedTextBox();
            this.lb_celular2 = new System.Windows.Forms.Label();
            this.msk_telefone2 = new System.Windows.Forms.MaskedTextBox();
            this.lb_telefone2 = new System.Windows.Forms.Label();
            this.msk_celular = new System.Windows.Forms.MaskedTextBox();
            this.lb_celular = new System.Windows.Forms.Label();
            this.msk_telefone = new System.Windows.Forms.MaskedTextBox();
            this.lb_telefone = new System.Windows.Forms.Label();
            this.lb_contato = new System.Windows.Forms.Label();
            this.tb_contato = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lb_complemento = new System.Windows.Forms.Label();
            this.bt_cep = new System.Windows.Forms.Button();
            this.tb_complemento = new System.Windows.Forms.TextBox();
            this.tb_cidade = new System.Windows.Forms.TextBox();
            this.lb_cidade = new System.Windows.Forms.Label();
            this.tb_bairro = new System.Windows.Forms.TextBox();
            this.lb_bairro = new System.Windows.Forms.Label();
            this.tb_numero = new System.Windows.Forms.TextBox();
            this.lb_numero = new System.Windows.Forms.Label();
            this.msk_cep = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.lb_endereco = new System.Windows.Forms.Label();
            this.tb_rg = new System.Windows.Forms.TextBox();
            this.lb_rg = new System.Windows.Forms.Label();
            this.msk_cpfcnpj = new System.Windows.Forms.MaskedTextBox();
            this.tb_apelido = new System.Windows.Forms.TextBox();
            this.lb_apelido = new System.Windows.Forms.Label();
            this.lb_cpfcnpj = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.lb_nome = new System.Windows.Forms.Label();
            this.bt_confirmar = new System.Windows.Forms.Button();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.lb_codigo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_statuscli = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_visualizar = new System.Windows.Forms.Button();
            this.bt_alternar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dg_cliente)).BeginInit();
            this.p_cadastrocli.SuspendLayout();
            this.gb_cadrastrocli.SuspendLayout();
            this.gb_dadoscli.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_cliente
            // 
            this.dg_cliente.AllowUserToAddRows = false;
            this.dg_cliente.AllowUserToDeleteRows = false;
            this.dg_cliente.AllowUserToOrderColumns = true;
            this.dg_cliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_cliente.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_cliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_cliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.apelido,
            this.cpfcnpj,
            this.ie,
            this.endereco,
            this.num,
            this.bairro,
            this.cidade,
            this.cep});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_cliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_cliente.Location = new System.Drawing.Point(162, 37);
            this.dg_cliente.Name = "dg_cliente";
            this.dg_cliente.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_cliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dg_cliente.Size = new System.Drawing.Size(743, 403);
            this.dg_cliente.TabIndex = 0;
            this.dg_cliente.SelectionChanged += new System.EventHandler(this.dg_cliente_SelectionChanged_1);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "nome";
            this.Nome.HeaderText = "Nome / Razao Social";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // apelido
            // 
            this.apelido.DataPropertyName = "apelido";
            this.apelido.HeaderText = "Apelido / Fantasia";
            this.apelido.Name = "apelido";
            this.apelido.ReadOnly = true;
            // 
            // cpfcnpj
            // 
            this.cpfcnpj.DataPropertyName = "cpfcnpj";
            this.cpfcnpj.HeaderText = "Cpf/Cnpj";
            this.cpfcnpj.Name = "cpfcnpj";
            this.cpfcnpj.ReadOnly = true;
            // 
            // ie
            // 
            this.ie.DataPropertyName = "rg";
            this.ie.HeaderText = "IE-RG";
            this.ie.Name = "ie";
            this.ie.ReadOnly = true;
            // 
            // endereco
            // 
            this.endereco.DataPropertyName = "endereco";
            this.endereco.HeaderText = "Endereço";
            this.endereco.Name = "endereco";
            this.endereco.ReadOnly = true;
            // 
            // num
            // 
            this.num.DataPropertyName = "endnum";
            this.num.HeaderText = "Numero";
            this.num.Name = "num";
            this.num.ReadOnly = true;
            // 
            // bairro
            // 
            this.bairro.DataPropertyName = "bairro";
            this.bairro.HeaderText = "Bairro";
            this.bairro.Name = "bairro";
            this.bairro.ReadOnly = true;
            // 
            // cidade
            // 
            this.cidade.DataPropertyName = "cidade";
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            // 
            // cep
            // 
            this.cep.DataPropertyName = "cep";
            this.cep.HeaderText = "CEP";
            this.cep.Name = "cep";
            this.cep.ReadOnly = true;
            // 
            // bt_incluir
            // 
            this.bt_incluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_incluir.Location = new System.Drawing.Point(35, 56);
            this.bt_incluir.Name = "bt_incluir";
            this.bt_incluir.Size = new System.Drawing.Size(105, 40);
            this.bt_incluir.TabIndex = 1;
            this.bt_incluir.Text = "Incluir";
            this.bt_incluir.UseVisualStyleBackColor = true;
            this.bt_incluir.Click += new System.EventHandler(this.bt_incluir_Click);
            // 
            // bt_alterar
            // 
            this.bt_alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_alterar.Location = new System.Drawing.Point(12, 69);
            this.bt_alterar.Name = "bt_alterar";
            this.bt_alterar.Size = new System.Drawing.Size(105, 40);
            this.bt_alterar.TabIndex = 2;
            this.bt_alterar.Text = "Alterar";
            this.bt_alterar.UseVisualStyleBackColor = true;
            this.bt_alterar.Click += new System.EventHandler(this.bt_alterar_Click);
            // 
            // bt_desativa
            // 
            this.bt_desativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_desativa.Location = new System.Drawing.Point(11, 162);
            this.bt_desativa.Name = "bt_desativa";
            this.bt_desativa.Size = new System.Drawing.Size(105, 40);
            this.bt_desativa.TabIndex = 3;
            this.bt_desativa.Text = "Desativar";
            this.bt_desativa.UseVisualStyleBackColor = true;
            this.bt_desativa.Click += new System.EventHandler(this.bt_desativa_Click);
            // 
            // bt_voltar
            // 
            this.bt_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_voltar.Location = new System.Drawing.Point(11, 367);
            this.bt_voltar.Name = "bt_voltar";
            this.bt_voltar.Size = new System.Drawing.Size(105, 40);
            this.bt_voltar.TabIndex = 4;
            this.bt_voltar.Text = "Voltar";
            this.bt_voltar.UseVisualStyleBackColor = true;
            this.bt_voltar.Click += new System.EventHandler(this.bt_voltar_Click);
            // 
            // p_cadastrocli
            // 
            this.p_cadastrocli.Controls.Add(this.lb_status);
            this.p_cadastrocli.Controls.Add(this.gb_cadrastrocli);
            this.p_cadastrocli.Location = new System.Drawing.Point(0, 0);
            this.p_cadastrocli.Name = "p_cadastrocli";
            this.p_cadastrocli.Size = new System.Drawing.Size(926, 497);
            this.p_cadastrocli.TabIndex = 5;
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.ForeColor = System.Drawing.Color.Red;
            this.lb_status.Location = new System.Drawing.Point(20, 12);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(82, 25);
            this.lb_status.TabIndex = 6;
            this.lb_status.Text = "Alterar";
            // 
            // gb_cadrastrocli
            // 
            this.gb_cadrastrocli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_cadrastrocli.Controls.Add(this.bt_cancelar);
            this.gb_cadrastrocli.Controls.Add(this.gb_dadoscli);
            this.gb_cadrastrocli.Controls.Add(this.bt_confirmar);
            this.gb_cadrastrocli.Controls.Add(this.tb_codigo);
            this.gb_cadrastrocli.Controls.Add(this.lb_codigo);
            this.gb_cadrastrocli.Location = new System.Drawing.Point(24, 40);
            this.gb_cadrastrocli.Name = "gb_cadrastrocli";
            this.gb_cadrastrocli.Size = new System.Drawing.Size(894, 448);
            this.gb_cadrastrocli.TabIndex = 0;
            this.gb_cadrastrocli.TabStop = false;
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.Location = new System.Drawing.Point(789, 409);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(94, 33);
            this.bt_cancelar.TabIndex = 19;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // gb_dadoscli
            // 
            this.gb_dadoscli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_dadoscli.Controls.Add(this.msk_celular2);
            this.gb_dadoscli.Controls.Add(this.lb_celular2);
            this.gb_dadoscli.Controls.Add(this.msk_telefone2);
            this.gb_dadoscli.Controls.Add(this.lb_telefone2);
            this.gb_dadoscli.Controls.Add(this.msk_celular);
            this.gb_dadoscli.Controls.Add(this.lb_celular);
            this.gb_dadoscli.Controls.Add(this.msk_telefone);
            this.gb_dadoscli.Controls.Add(this.lb_telefone);
            this.gb_dadoscli.Controls.Add(this.lb_contato);
            this.gb_dadoscli.Controls.Add(this.tb_contato);
            this.gb_dadoscli.Controls.Add(this.lb_email);
            this.gb_dadoscli.Controls.Add(this.tb_email);
            this.gb_dadoscli.Controls.Add(this.lb_complemento);
            this.gb_dadoscli.Controls.Add(this.bt_cep);
            this.gb_dadoscli.Controls.Add(this.tb_complemento);
            this.gb_dadoscli.Controls.Add(this.tb_cidade);
            this.gb_dadoscli.Controls.Add(this.lb_cidade);
            this.gb_dadoscli.Controls.Add(this.tb_bairro);
            this.gb_dadoscli.Controls.Add(this.lb_bairro);
            this.gb_dadoscli.Controls.Add(this.tb_numero);
            this.gb_dadoscli.Controls.Add(this.lb_numero);
            this.gb_dadoscli.Controls.Add(this.msk_cep);
            this.gb_dadoscli.Controls.Add(this.label2);
            this.gb_dadoscli.Controls.Add(this.tb_endereco);
            this.gb_dadoscli.Controls.Add(this.lb_endereco);
            this.gb_dadoscli.Controls.Add(this.tb_rg);
            this.gb_dadoscli.Controls.Add(this.lb_rg);
            this.gb_dadoscli.Controls.Add(this.msk_cpfcnpj);
            this.gb_dadoscli.Controls.Add(this.tb_apelido);
            this.gb_dadoscli.Controls.Add(this.lb_apelido);
            this.gb_dadoscli.Controls.Add(this.lb_cpfcnpj);
            this.gb_dadoscli.Controls.Add(this.tb_nome);
            this.gb_dadoscli.Controls.Add(this.lb_nome);
            this.gb_dadoscli.Location = new System.Drawing.Point(15, 58);
            this.gb_dadoscli.Name = "gb_dadoscli";
            this.gb_dadoscli.Size = new System.Drawing.Size(868, 345);
            this.gb_dadoscli.TabIndex = 25;
            this.gb_dadoscli.TabStop = false;
            // 
            // msk_celular2
            // 
            this.msk_celular2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.msk_celular2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_celular2.Location = new System.Drawing.Point(719, 254);
            this.msk_celular2.Mask = "(00) 00000-0000";
            this.msk_celular2.Name = "msk_celular2";
            this.msk_celular2.Size = new System.Drawing.Size(116, 24);
            this.msk_celular2.TabIndex = 16;
            // 
            // lb_celular2
            // 
            this.lb_celular2.AutoSize = true;
            this.lb_celular2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_celular2.Location = new System.Drawing.Point(661, 257);
            this.lb_celular2.Name = "lb_celular2";
            this.lb_celular2.Size = new System.Drawing.Size(54, 18);
            this.lb_celular2.TabIndex = 33;
            this.lb_celular2.Text = "Celular";
            // 
            // msk_telefone2
            // 
            this.msk_telefone2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.msk_telefone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_telefone2.Location = new System.Drawing.Point(531, 252);
            this.msk_telefone2.Mask = "(00) 0000-0000";
            this.msk_telefone2.Name = "msk_telefone2";
            this.msk_telefone2.Size = new System.Drawing.Size(109, 24);
            this.msk_telefone2.TabIndex = 15;
            // 
            // lb_telefone2
            // 
            this.lb_telefone2.AutoSize = true;
            this.lb_telefone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_telefone2.Location = new System.Drawing.Point(460, 256);
            this.lb_telefone2.Name = "lb_telefone2";
            this.lb_telefone2.Size = new System.Drawing.Size(65, 18);
            this.lb_telefone2.TabIndex = 31;
            this.lb_telefone2.Text = "Telefone";
            // 
            // msk_celular
            // 
            this.msk_celular.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.msk_celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_celular.Location = new System.Drawing.Point(321, 253);
            this.msk_celular.Mask = "(00) 00000-0000";
            this.msk_celular.Name = "msk_celular";
            this.msk_celular.Size = new System.Drawing.Size(119, 24);
            this.msk_celular.TabIndex = 14;
            // 
            // lb_celular
            // 
            this.lb_celular.AutoSize = true;
            this.lb_celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_celular.Location = new System.Drawing.Point(263, 256);
            this.lb_celular.Name = "lb_celular";
            this.lb_celular.Size = new System.Drawing.Size(54, 18);
            this.lb_celular.TabIndex = 29;
            this.lb_celular.Text = "Celular";
            // 
            // msk_telefone
            // 
            this.msk_telefone.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.msk_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_telefone.Location = new System.Drawing.Point(144, 254);
            this.msk_telefone.Mask = "(00) 0000-0000";
            this.msk_telefone.Name = "msk_telefone";
            this.msk_telefone.Size = new System.Drawing.Size(109, 24);
            this.msk_telefone.TabIndex = 13;
            // 
            // lb_telefone
            // 
            this.lb_telefone.AutoSize = true;
            this.lb_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_telefone.Location = new System.Drawing.Point(73, 258);
            this.lb_telefone.Name = "lb_telefone";
            this.lb_telefone.Size = new System.Drawing.Size(65, 18);
            this.lb_telefone.TabIndex = 27;
            this.lb_telefone.Text = "Telefone";
            // 
            // lb_contato
            // 
            this.lb_contato.AutoSize = true;
            this.lb_contato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_contato.Location = new System.Drawing.Point(83, 287);
            this.lb_contato.Name = "lb_contato";
            this.lb_contato.Size = new System.Drawing.Size(61, 18);
            this.lb_contato.TabIndex = 26;
            this.lb_contato.Text = "Contato";
            // 
            // tb_contato
            // 
            this.tb_contato.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_contato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_contato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_contato.Location = new System.Drawing.Point(145, 284);
            this.tb_contato.Name = "tb_contato";
            this.tb_contato.Size = new System.Drawing.Size(690, 24);
            this.tb_contato.TabIndex = 17;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.Location = new System.Drawing.Point(88, 224);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(50, 18);
            this.lb_email.TabIndex = 24;
            this.lb_email.Text = "E-mail";
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(145, 222);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(690, 24);
            this.tb_email.TabIndex = 12;
            // 
            // lb_complemento
            // 
            this.lb_complemento.AutoSize = true;
            this.lb_complemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_complemento.Location = new System.Drawing.Point(30, 198);
            this.lb_complemento.Name = "lb_complemento";
            this.lb_complemento.Size = new System.Drawing.Size(102, 18);
            this.lb_complemento.TabIndex = 22;
            this.lb_complemento.Text = "Complemento";
            // 
            // bt_cep
            // 
            this.bt_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cep.Location = new System.Drawing.Point(279, 162);
            this.bt_cep.Name = "bt_cep";
            this.bt_cep.Size = new System.Drawing.Size(47, 27);
            this.bt_cep.TabIndex = 8;
            this.bt_cep.Text = "CEP";
            this.bt_cep.UseVisualStyleBackColor = true;
            this.bt_cep.Click += new System.EventHandler(this.bt_cep_Click);
            // 
            // tb_complemento
            // 
            this.tb_complemento.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_complemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_complemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_complemento.Location = new System.Drawing.Point(145, 193);
            this.tb_complemento.Name = "tb_complemento";
            this.tb_complemento.Size = new System.Drawing.Size(690, 24);
            this.tb_complemento.TabIndex = 11;
            // 
            // tb_cidade
            // 
            this.tb_cidade.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_cidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cidade.Location = new System.Drawing.Point(644, 164);
            this.tb_cidade.Name = "tb_cidade";
            this.tb_cidade.Size = new System.Drawing.Size(191, 24);
            this.tb_cidade.TabIndex = 10;
            // 
            // lb_cidade
            // 
            this.lb_cidade.AutoSize = true;
            this.lb_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cidade.Location = new System.Drawing.Point(588, 167);
            this.lb_cidade.Name = "lb_cidade";
            this.lb_cidade.Size = new System.Drawing.Size(54, 18);
            this.lb_cidade.TabIndex = 19;
            this.lb_cidade.Text = "Cidade";
            // 
            // tb_bairro
            // 
            this.tb_bairro.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_bairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_bairro.Location = new System.Drawing.Point(396, 164);
            this.tb_bairro.Name = "tb_bairro";
            this.tb_bairro.Size = new System.Drawing.Size(179, 24);
            this.tb_bairro.TabIndex = 9;
            // 
            // lb_bairro
            // 
            this.lb_bairro.AutoSize = true;
            this.lb_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bairro.Location = new System.Drawing.Point(342, 167);
            this.lb_bairro.Name = "lb_bairro";
            this.lb_bairro.Size = new System.Drawing.Size(48, 18);
            this.lb_bairro.TabIndex = 17;
            this.lb_bairro.Text = "Bairro";
            // 
            // tb_numero
            // 
            this.tb_numero.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_numero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_numero.Location = new System.Drawing.Point(771, 134);
            this.tb_numero.Name = "tb_numero";
            this.tb_numero.Size = new System.Drawing.Size(64, 24);
            this.tb_numero.TabIndex = 6;
            // 
            // lb_numero
            // 
            this.lb_numero.AutoSize = true;
            this.lb_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_numero.Location = new System.Drawing.Point(706, 137);
            this.lb_numero.Name = "lb_numero";
            this.lb_numero.Size = new System.Drawing.Size(62, 18);
            this.lb_numero.TabIndex = 15;
            this.lb_numero.Text = "Numero";
            // 
            // msk_cep
            // 
            this.msk_cep.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.msk_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_cep.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.msk_cep.Location = new System.Drawing.Point(144, 163);
            this.msk_cep.Mask = "00000-000";
            this.msk_cep.Name = "msk_cep";
            this.msk_cep.Size = new System.Drawing.Size(109, 24);
            this.msk_cep.TabIndex = 7;
            this.msk_cep.Validating += new System.ComponentModel.CancelEventHandler(this.msk_cep_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "CEP";
            // 
            // tb_endereco
            // 
            this.tb_endereco.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_endereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_endereco.Location = new System.Drawing.Point(144, 134);
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.Size = new System.Drawing.Size(546, 24);
            this.tb_endereco.TabIndex = 5;
            // 
            // lb_endereco
            // 
            this.lb_endereco.AutoSize = true;
            this.lb_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_endereco.Location = new System.Drawing.Point(66, 136);
            this.lb_endereco.Name = "lb_endereco";
            this.lb_endereco.Size = new System.Drawing.Size(72, 18);
            this.lb_endereco.TabIndex = 11;
            this.lb_endereco.Text = "Endereço";
            // 
            // tb_rg
            // 
            this.tb_rg.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_rg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_rg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_rg.Location = new System.Drawing.Point(665, 99);
            this.tb_rg.Name = "tb_rg";
            this.tb_rg.Size = new System.Drawing.Size(170, 24);
            this.tb_rg.TabIndex = 4;
            // 
            // lb_rg
            // 
            this.lb_rg.AutoSize = true;
            this.lb_rg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rg.Location = new System.Drawing.Point(530, 101);
            this.lb_rg.Name = "lb_rg";
            this.lb_rg.Size = new System.Drawing.Size(129, 18);
            this.lb_rg.TabIndex = 9;
            this.lb_rg.Text = "Rg / Inscricao Est.";
            // 
            // msk_cpfcnpj
            // 
            this.msk_cpfcnpj.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.msk_cpfcnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_cpfcnpj.Location = new System.Drawing.Point(144, 99);
            this.msk_cpfcnpj.Name = "msk_cpfcnpj";
            this.msk_cpfcnpj.Size = new System.Drawing.Size(180, 24);
            this.msk_cpfcnpj.TabIndex = 3;
            this.msk_cpfcnpj.Leave += new System.EventHandler(this.msk_cpfcnpj_Leave);
            this.msk_cpfcnpj.Validating += new System.ComponentModel.CancelEventHandler(this.msk_cpfcnpj_Validating);
            // 
            // tb_apelido
            // 
            this.tb_apelido.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_apelido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_apelido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_apelido.Location = new System.Drawing.Point(144, 68);
            this.tb_apelido.Name = "tb_apelido";
            this.tb_apelido.Size = new System.Drawing.Size(691, 24);
            this.tb_apelido.TabIndex = 2;
            // 
            // lb_apelido
            // 
            this.lb_apelido.AutoSize = true;
            this.lb_apelido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_apelido.Location = new System.Drawing.Point(17, 69);
            this.lb_apelido.Name = "lb_apelido";
            this.lb_apelido.Size = new System.Drawing.Size(124, 18);
            this.lb_apelido.TabIndex = 6;
            this.lb_apelido.Text = "Apelido / Fantasia";
            // 
            // lb_cpfcnpj
            // 
            this.lb_cpfcnpj.AutoSize = true;
            this.lb_cpfcnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cpfcnpj.Location = new System.Drawing.Point(66, 101);
            this.lb_cpfcnpj.Name = "lb_cpfcnpj";
            this.lb_cpfcnpj.Size = new System.Drawing.Size(65, 18);
            this.lb_cpfcnpj.TabIndex = 5;
            this.lb_cpfcnpj.Text = "Cpf/Cnpj";
            // 
            // tb_nome
            // 
            this.tb_nome.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nome.Location = new System.Drawing.Point(143, 40);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(692, 24);
            this.tb_nome.TabIndex = 1;
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(26, 42);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(105, 18);
            this.lb_nome.TabIndex = 2;
            this.lb_nome.Text = "Nome / Razão";
            // 
            // bt_confirmar
            // 
            this.bt_confirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_confirmar.Location = new System.Drawing.Point(690, 409);
            this.bt_confirmar.Name = "bt_confirmar";
            this.bt_confirmar.Size = new System.Drawing.Size(94, 33);
            this.bt_confirmar.TabIndex = 18;
            this.bt_confirmar.Text = "Confirmar";
            this.bt_confirmar.UseVisualStyleBackColor = true;
            this.bt_confirmar.Click += new System.EventHandler(this.bt_confirmar_Click);
            // 
            // tb_codigo
            // 
            this.tb_codigo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_codigo.Location = new System.Drawing.Point(86, 25);
            this.tb_codigo.MaxLength = 9;
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(85, 24);
            this.tb_codigo.TabIndex = 1;
            this.tb_codigo.Text = "000000000";
            this.tb_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_codigo
            // 
            this.lb_codigo.AutoSize = true;
            this.lb_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_codigo.Location = new System.Drawing.Point(24, 27);
            this.lb_codigo.Name = "lb_codigo";
            this.lb_codigo.Size = new System.Drawing.Size(56, 18);
            this.lb_codigo.TabIndex = 0;
            this.lb_codigo.Text = "Codigo";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lb_statuscli);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(908, 478);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // lb_statuscli
            // 
            this.lb_statuscli.AutoSize = true;
            this.lb_statuscli.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_statuscli.ForeColor = System.Drawing.Color.Navy;
            this.lb_statuscli.Location = new System.Drawing.Point(583, 440);
            this.lb_statuscli.Name = "lb_statuscli";
            this.lb_statuscli.Size = new System.Drawing.Size(211, 25);
            this.lb_statuscli.TabIndex = 6;
            this.lb_statuscli.Text = "CLIENTES ATIVOS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_visualizar);
            this.groupBox2.Controls.Add(this.bt_alternar);
            this.groupBox2.Controls.Add(this.bt_alterar);
            this.groupBox2.Controls.Add(this.bt_voltar);
            this.groupBox2.Controls.Add(this.bt_desativa);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 436);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opções";
            // 
            // bt_visualizar
            // 
            this.bt_visualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_visualizar.Location = new System.Drawing.Point(11, 116);
            this.bt_visualizar.Name = "bt_visualizar";
            this.bt_visualizar.Size = new System.Drawing.Size(105, 40);
            this.bt_visualizar.TabIndex = 6;
            this.bt_visualizar.Text = "Visualizar";
            this.bt_visualizar.UseVisualStyleBackColor = true;
            this.bt_visualizar.Click += new System.EventHandler(this.bt_visualizar_Click);
            // 
            // bt_alternar
            // 
            this.bt_alternar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_alternar.Location = new System.Drawing.Point(12, 208);
            this.bt_alternar.Name = "bt_alternar";
            this.bt_alternar.Size = new System.Drawing.Size(105, 40);
            this.bt_alternar.TabIndex = 5;
            this.bt_alternar.Text = "Alternar";
            this.bt_alternar.UseVisualStyleBackColor = true;
            this.bt_alternar.Click += new System.EventHandler(this.bt_alternar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // F_CadClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(933, 507);
            this.Controls.Add(this.p_cadastrocli);
            this.Controls.Add(this.bt_incluir);
            this.Controls.Add(this.dg_cliente);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_CadClientes";
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.f_CadClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_cliente)).EndInit();
            this.p_cadastrocli.ResumeLayout(false);
            this.p_cadastrocli.PerformLayout();
            this.gb_cadrastrocli.ResumeLayout(false);
            this.gb_cadrastrocli.PerformLayout();
            this.gb_dadoscli.ResumeLayout(false);
            this.gb_dadoscli.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_cliente;
        private System.Windows.Forms.Button bt_incluir;
        private System.Windows.Forms.Button bt_alterar;
        private System.Windows.Forms.Button bt_desativa;
        private System.Windows.Forms.Button bt_voltar;
        private System.Windows.Forms.Panel p_cadastrocli;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_confirmar;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.GroupBox gb_cadrastrocli;
        private System.Windows.Forms.Label lb_codigo;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label lb_cpfcnpj;
        private System.Windows.Forms.MaskedTextBox msk_cpfcnpj;
        private System.Windows.Forms.TextBox tb_apelido;
        private System.Windows.Forms.Label lb_apelido;
        private System.Windows.Forms.TextBox tb_endereco;
        private System.Windows.Forms.Label lb_endereco;
        private System.Windows.Forms.TextBox tb_rg;
        private System.Windows.Forms.Label lb_rg;
        private System.Windows.Forms.Button bt_cep;
        private System.Windows.Forms.MaskedTextBox msk_cep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_bairro;
        private System.Windows.Forms.Label lb_bairro;
        private System.Windows.Forms.TextBox tb_numero;
        private System.Windows.Forms.Label lb_numero;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lb_complemento;
        private System.Windows.Forms.TextBox tb_complemento;
        private System.Windows.Forms.TextBox tb_cidade;
        private System.Windows.Forms.Label lb_cidade;
        private System.Windows.Forms.GroupBox gb_dadoscli;
        private System.Windows.Forms.Label lb_contato;
        private System.Windows.Forms.TextBox tb_contato;
        private System.Windows.Forms.MaskedTextBox msk_celular;
        private System.Windows.Forms.Label lb_celular;
        private System.Windows.Forms.MaskedTextBox msk_telefone;
        private System.Windows.Forms.Label lb_telefone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox msk_celular2;
        private System.Windows.Forms.Label lb_celular2;
        private System.Windows.Forms.MaskedTextBox msk_telefone2;
        private System.Windows.Forms.Label lb_telefone2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn apelido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfcnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn ie;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep;
        private System.Windows.Forms.Label lb_statuscli;
        private System.Windows.Forms.Button bt_alternar;
        private System.Windows.Forms.Button bt_visualizar;
    }
}