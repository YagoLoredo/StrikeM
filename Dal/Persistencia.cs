using MySql.Data.MySqlClient;
using Pojo;
using StrikeMarket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class Persistencia
    {
        public static MySqlDataReader ExecutarSQL(string pSQL, object pEntidade)
        {
            MySqlCommand comando = new MySqlCommand(pSQL, Conexao.ConectarDB());
            if (pEntidade is Produto produto)
            {
                comando.Parameters.AddWithValue("@codproduto", produto.CodProduto);
                comando.Parameters.AddWithValue("@descricao", produto.Descricao);
                comando.Parameters.AddWithValue("@categoria", produto.Categoria);
                comando.Parameters.AddWithValue("@ean", produto.EAN);
                comando.Parameters.AddWithValue("@precoVenda", produto.PrecoVenda);
            }else 
                if (pEntidade is Cliente cliente)
            {
                comando.Parameters.AddWithValue("@CodCliente", cliente.CodCliente);
                comando.Parameters.AddWithValue("@Nome", cliente.Nome);
                comando.Parameters.AddWithValue("@CPF", cliente.CPF);
                comando.Parameters.AddWithValue("@Email", cliente.Email);
                comando.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                comando.Parameters.AddWithValue("@Sexo", cliente.Sexo);
                comando.Parameters.AddWithValue("@Endereco", cliente.Endereco);
            }
            // Retorna o resultado da execução do comando SQL
            MySqlDataReader dr = comando.ExecuteReader();
            return dr;
        }
        public static int RetornarProximoId(string pNomeTabela, string pNomeCampoCodigo)
        {
            var lSql = "Select Coalesce(Max(" + pNomeCampoCodigo + ")+1,1) as ProximoId from " + pNomeTabela;
            using (var dr = ExecutarSQL(lSql, null))
            {
                dr.Read();
                return Convert.ToInt32(dr["ProximoId"].ToString());
            }
        }
    }
}
