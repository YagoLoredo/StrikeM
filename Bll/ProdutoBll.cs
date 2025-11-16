using Dal;
using Pojo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class ProdutoBll
    {
        private ProdutoDal _produtoDal;

        public ProdutoBll()
        {
            _produtoDal = new ProdutoDal();
        }
        public bool InserirProduto(Produto produto)
        {
            return _produtoDal.InserirProduto(produto);
        }
        public bool EditarProduto (Produto produto)
        {
            return _produtoDal.EditarProduto(produto);
        }
        public bool ExcluirProduto (Produto produto)
        {
            return _produtoDal.ExcluirProduto(produto);
        }
        public List<Produto> ListarProdutos()
        {
            return _produtoDal.ListarProdutos();
        }
    }
}
