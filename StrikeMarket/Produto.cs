using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pojo
{
    public class Produto
    {
        public int CodProduto { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public int EAN { get; set; }
        public decimal PrecoVenda { get; set; }
    }
}
