namespace ConsultaCNPJ
{
    partial class frmConsulta
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label LblSituacao;
            mskCnpj = new MaskedTextBox();
            txtConsulta = new Label();
            lblNome = new Label();
            lblMotivo = new Label();
            lblLogradouro = new Label();
            lblNumero = new Label();
            lblBairro = new Label();
            lblAbertura = new Label();
            txtNome = new TextBox();
            txtSituacao = new TextBox();
            txtMotivo = new TextBox();
            txtAbertura = new TextBox();
            txtLogradouro = new TextBox();
            txtNumero = new TextBox();
            lblComplemento = new Label();
            txtComplemento = new TextBox();
            txtBairro = new TextBox();
            lblMunicipio = new Label();
            txtMunicipio = new TextBox();
            lblCep = new Label();
            txtCep = new TextBox();
            lblEstado = new Label();
            txtEstado = new TextBox();
            btnBuscar = new Button();
            LblSituacao = new Label();
            SuspendLayout();
            // 
            // LblSituacao
            // 
            LblSituacao.AutoSize = true;
            LblSituacao.Location = new Point(33, 166);
            LblSituacao.Name = "LblSituacao";
            LblSituacao.Size = new Size(52, 15);
            LblSituacao.TabIndex = 3;
            LblSituacao.Text = "Situação";
            // 
            // mskCnpj
            // 
            mskCnpj.Location = new Point(249, 76);
            mskCnpj.Mask = "##,###,###/####-##";
            mskCnpj.Name = "mskCnpj";
            mskCnpj.Size = new Size(116, 23);
            mskCnpj.TabIndex = 0;
            mskCnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtConsulta
            // 
            txtConsulta.AutoSize = true;
            txtConsulta.Location = new Point(262, 30);
            txtConsulta.Name = "txtConsulta";
            txtConsulta.Size = new Size(103, 15);
            txtConsulta.TabIndex = 1;
            txtConsulta.Text = "CONSULTAR CNPJ";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(44, 128);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Location = new Point(44, 205);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(45, 15);
            lblMotivo.TabIndex = 4;
            lblMotivo.Text = "Motivo";
            // 
            // lblLogradouro
            // 
            lblLogradouro.AutoSize = true;
            lblLogradouro.Location = new Point(21, 251);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(69, 15);
            lblLogradouro.TabIndex = 5;
            lblLogradouro.Text = "Logradouro";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(39, 288);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 6;
            lblNumero.Text = "Número";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(47, 327);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(38, 15);
            lblBairro.TabIndex = 7;
            lblBairro.Text = "Bairro";
            // 
            // lblAbertura
            // 
            lblAbertura.AutoSize = true;
            lblAbertura.Location = new Point(326, 166);
            lblAbertura.Name = "lblAbertura";
            lblAbertura.Size = new Size(53, 15);
            lblAbertura.TabIndex = 8;
            lblAbertura.Text = "Abertura";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(95, 120);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(553, 23);
            txtNome.TabIndex = 9;
            // 
            // txtSituacao
            // 
            txtSituacao.Location = new Point(95, 158);
            txtSituacao.Name = "txtSituacao";
            txtSituacao.Size = new Size(225, 23);
            txtSituacao.TabIndex = 10;
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(96, 197);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(553, 23);
            txtMotivo.TabIndex = 11;
            // 
            // txtAbertura
            // 
            txtAbertura.Location = new Point(385, 158);
            txtAbertura.Name = "txtAbertura";
            txtAbertura.Size = new Size(263, 23);
            txtAbertura.TabIndex = 12;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(96, 243);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(553, 23);
            txtLogradouro.TabIndex = 13;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(96, 280);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(224, 23);
            txtNumero.TabIndex = 14;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(334, 291);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(84, 15);
            lblComplemento.TabIndex = 15;
            lblComplemento.Text = "Complemento";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(424, 283);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(224, 23);
            txtComplemento.TabIndex = 16;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(95, 319);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(323, 23);
            txtBairro.TabIndex = 17;
            // 
            // lblMunicipio
            // 
            lblMunicipio.AutoSize = true;
            lblMunicipio.Location = new Point(29, 375);
            lblMunicipio.Name = "lblMunicipio";
            lblMunicipio.Size = new Size(61, 15);
            lblMunicipio.TabIndex = 18;
            lblMunicipio.Text = "Município";
            // 
            // txtMunicipio
            // 
            txtMunicipio.Location = new Point(100, 367);
            txtMunicipio.Name = "txtMunicipio";
            txtMunicipio.Size = new Size(318, 23);
            txtMunicipio.TabIndex = 19;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(460, 327);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(28, 15);
            lblCep.TabIndex = 20;
            lblCep.Text = "CEP";
            // 
            // txtCep
            // 
            txtCep.Location = new Point(494, 319);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(155, 23);
            txtCep.TabIndex = 21;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(491, 374);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 22;
            lblEstado.Text = "Estado";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(549, 367);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(100, 23);
            txtEstado.TabIndex = 23;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(385, 76);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 24;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // frmConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscar);
            Controls.Add(txtEstado);
            Controls.Add(lblEstado);
            Controls.Add(txtCep);
            Controls.Add(lblCep);
            Controls.Add(txtMunicipio);
            Controls.Add(lblMunicipio);
            Controls.Add(txtBairro);
            Controls.Add(txtComplemento);
            Controls.Add(lblComplemento);
            Controls.Add(txtNumero);
            Controls.Add(txtLogradouro);
            Controls.Add(txtAbertura);
            Controls.Add(txtMotivo);
            Controls.Add(txtSituacao);
            Controls.Add(txtNome);
            Controls.Add(lblAbertura);
            Controls.Add(lblBairro);
            Controls.Add(lblNumero);
            Controls.Add(lblLogradouro);
            Controls.Add(lblMotivo);
            Controls.Add(LblSituacao);
            Controls.Add(lblNome);
            Controls.Add(txtConsulta);
            Controls.Add(mskCnpj);
            Name = "frmConsulta";
            Text = "Consulta CNPJ na Receita";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mskCnpj;
        private Label txtConsulta;
        private Label lblNome;
        private Label LblSituacao;
        private Label lblMotivo;
        private Label lblLogradouro;
        private Label lblNumero;
        private Label lblBairro;
        private Label lblAbertura;
        private TextBox txtNome;
        private TextBox txtSituacao;
        private TextBox txtMotivo;
        private TextBox txtAbertura;
        private TextBox txtLogradouro;
        private TextBox txtNumero;
        private Label lblComplemento;
        private TextBox txtComplemento;
        private TextBox txtBairro;
        private Label lblMunicipio;
        private TextBox txtMunicipio;
        private Label lblCep;
        private TextBox txtCep;
        private Label lblEstado;
        private TextBox txtEstado;
        private Button btnBuscar;
    }
}
