namespace ConsultaCNPJ
{
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ObterCnpj();
        }
        private void ObterCnpj()
        {
            var cnpj = Empresa.ObterCnpj(mskCnpj.Text);

            if (cnpj != null)
            {
                txtNome.Text = cnpj.nome;
                txtSituacao.Text = cnpj.situacao;
                txtAbertura.Text = cnpj.abertura;
                txtMotivo.Text = cnpj.motivo_situacao;
                txtLogradouro.Text = cnpj.logradouro;
                txtNumero.Text = cnpj.numero;
                txtComplemento.Text = cnpj.complemento;
                txtBairro.Text = cnpj.bairro;
                txtCep.Text = cnpj.cep;
                txtMunicipio.Text = cnpj.municipio;
                txtEstado.Text = cnpj.uf;

            }
        }

    }
}
