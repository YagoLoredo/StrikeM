using Bll;
using Pojo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace View
{
    public partial class ProdutoView : System.Web.UI.Page
    {
        private ProdutoBll _produtoBll;

        public ProdutoView()
        {
            _produtoBll = new ProdutoBll();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Lib.ExibirDados(_produtoBll, gvdProduto);
            }

        }
        private void ExibirMensagem(string mensagem)
        {
            string sJavaScript = "<script language=javascript>\n";
            sJavaScript += "alert('" + mensagem + "');";
            sJavaScript += "\n";
            sJavaScript += "</script>";
            ClientScript.RegisterStartupScript(typeof(string), "MessageBox", sJavaScript);
        }
        private void LimparCamposInsercao()
        {
            txtNovoDescricao.Text = string.Empty;
            txtNovoCategoria.Text = string.Empty;
            txtNovoEAN.Text = string.Empty;
            txtNovoPrecoVenda.Text = string.Empty;
        }
        private void PosicionarRegistroGrid(int pIndice)
        {
            gvdProduto.EditIndex = pIndice;
            Lib.ExibirDados(_produtoBll, gvdProduto);
        }
        private void Inserir()
        {
            Produto produto = new Produto();
            produto.Descricao = txtNovoDescricao.Text;
            produto.Categoria = txtNovoCategoria.Text;
            produto.EAN = Convert.ToInt32(txtNovoEAN.Text);
            produto.PrecoVenda = decimal.Parse(txtNovoPrecoVenda.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);

            if (_produtoBll.InserirProduto(produto))
            {
                ExibirMensagem("Produto inserido com sucesso");
                LimparCamposInsercao();
                Lib.ExibirDados(_produtoBll, gvdProduto);
            }
            else
            {
                ExibirMensagem("Erro ao inserir produto");
            }


        }
        private void Editar(int pIndice)
        {
          
            Produto produto = new Produto();
            Label lblCodProduto = gvdProduto.Rows[pIndice].FindControl("lblCodProduto") as Label;
            if (lblCodProduto != null)
            {
                produto.CodProduto = Convert.ToInt32(lblCodProduto.Text);
            }
            TextBox txtDescricao = gvdProduto.Rows[pIndice].FindControl("txtDescricao") as TextBox;
            if (txtDescricao != null)
            {
                produto.Descricao = txtDescricao.Text;
            }
            TextBox txtCategoria = gvdProduto.Rows[pIndice].FindControl("txtCategoria") as TextBox;
            if (txtCategoria != null)
            {
                produto.Categoria = txtCategoria.Text;
            }
            TextBox txtEAN = gvdProduto.Rows[pIndice].FindControl("txtEAN") as TextBox;
            if (txtEAN != null)
            {
                produto.EAN = Convert.ToInt32(txtEAN.Text);
            }
            TextBox txtPrecoVenda = gvdProduto.Rows[pIndice].FindControl("txtPrecoVenda") as TextBox;
            if (txtPrecoVenda != null)
            {
                produto.PrecoVenda = decimal.Parse(txtPrecoVenda.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);
            }
            _produtoBll.EditarProduto(produto);
            PosicionarRegistroGrid(-1);
            if (_produtoBll.EditarProduto(produto))
            {
                ExibirMensagem("Produto Editado com sucesso");
                LimparCamposInsercao();
                PosicionarRegistroGrid(-1);
            }
            else
            {
                ExibirMensagem("Erro ao Editar produto");
            }
        }
        private void Excluir(int pIndice)
        {
            Produto produto = new Produto();
            Label lblCodProduto = gvdProduto.Rows[pIndice].FindControl("lblCodProduto") as Label;
            produto.CodProduto = Convert.ToInt32(lblCodProduto.Text);
            if (_produtoBll.ExcluirProduto(produto))
            {
                ExibirMensagem("Produto excluído com sucesso");
                PosicionarRegistroGrid(-1);
            }
            else
            {
                ExibirMensagem("Erro ao excluir produto");
            }
        }

        protected void gvdProduto_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void gvdProduto_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            PosicionarRegistroGrid(-1);
        }

        protected void gvdProduto_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Excluir(e.RowIndex);
        }

        protected void gvdProduto_RowEditing(object sender, GridViewEditEventArgs e)
        {
            PosicionarRegistroGrid(e.NewEditIndex);
        }

        protected void gvdProduto_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Editar(e.RowIndex);
        }

        protected void Insert(object sender, EventArgs e)
        {
            Inserir();
        }
    }
}