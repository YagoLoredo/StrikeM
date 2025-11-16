using Bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace View
{
    public class Lib
    {
        public static void ExibirDados(ProdutoBll produtoBll, GridView pGrid)
        {
            pGrid.DataSource = produtoBll.ListarProdutos();
            pGrid.DataBind();
        }
    }
}