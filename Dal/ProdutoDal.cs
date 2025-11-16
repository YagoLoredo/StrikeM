using Pojo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class ProdutoDal
    {
        public bool InserirProduto(Produto produto)
        {
            produto.CodProduto = Persistencia.RetornarProximoId("produto", "codproduto");
            return ((Persistencia.ExecutarSQL
                ("Insert into produto (codproduto, descricao, categoria, ean, precoVenda)" +
                "values (@codproduto, @descricao, @categoria, @EAN, @PrecoVenda)", produto)).RecordsAffected > 0);
        }
        public bool EditarProduto(Produto produto)
        {
            return ((Persistencia.ExecutarSQL("Update Produto set descricao=@descricao, categoria=@categoria, ean=@ean, precoVenda=@precoVenda", produto)).RecordsAffected > 0);
        }
        public bool ExcluirProduto(Produto produto)
        {
            return ((Persistencia.ExecutarSQL("Delete from Produto where codproduto=@codproduto", produto)).RecordsAffected > 0);
        }
        public List <Produto> ListarProdutos()
        {
            using (var dr = Persistencia.ExecutarSQL("Select codproduto, descricao, categoria, ean, precoVenda from produto", null))
            {
                List<Produto> produtos = new List<Produto>();
                while (dr.Read())
                {
                    Produto a = new Produto();
                    a.CodProduto = Convert.ToInt32(dr["codproduto"]);
                    a.Descricao = dr["descricao"].ToString();
                    a.Categoria = dr["categoria"].ToString();
                    a.EAN = Convert.ToInt32(dr["ean"]);
                    a.PrecoVenda = Convert.ToDecimal(dr["precovenda"]);

                    produtos.Add(a);

                }
                return produtos;
            }
        }
    }
}
