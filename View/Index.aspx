<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="View.Index" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Web Form com Menu</title>
    <link rel="stylesheet" type="text/css" href="Styles.css" />
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <div class="menu">
                <ul>
                    <li><a href="ProdutoView.aspx">Produtos</a></li>    
                    <li><a href="ClienteView.aspx">Clientes</a></li>
                    <li><a href="CategoriaView.aspx">Categorias</a></li>

                </ul>
            </div>
        </header>
        <div class="content">
        </div>
        <footer>
            <p>&copy; ADS/FASM - 2025. Todos os direitos reservados.</p>
        </footer>
    </form>
    <script src="script.js"></script>
</body>
</html>