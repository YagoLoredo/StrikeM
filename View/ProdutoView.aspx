<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProdutoView.aspx.cs" Inherits="View.ProdutoView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css" />


    <title>Gerenciar Alunos</title>
    <style type="text/css">
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f9;
            margin: 0;
            padding: 0;
            display: flex;
            flex-direction: column;
            align-items: center;
        }

        h1 {
            margin-top: 30px;
            color: #333;
        }

        #form1 {
            margin-top: 20px;
            background-color: #fff;
            border-radius: 10px;
            padding: 20px;
            box-shadow: 0 4px 10px rgba(0,0,0,0.1);
            width: 90%;
            max-width: 1200px;
        }

        /* GridView */
        #gvdAluno {
            width: 100%;
            border-collapse: collapse;
            margin-bottom: 20px;
        }

        #gvdAluno th {
            background-color: #4CAF50;
            color: white;
            text-align: left;
            padding: 8px;
        }

        #gvdAluno td {
            background-color: #f9f9f9;
            padding: 8px;
            border-bottom: 1px solid #ddd;
        }

        #gvdAluno tr:hover td {
            background-color: #f1f1f1;
        }

        /* Inputs e botões */
        table {
            width: 100%;
        }

        table td {
            padding: 5px;
        }

        input[type=text] {
            padding: 6px;
            border: 1px solid #ccc;
            border-radius: 5px;
            width: 95%;
            box-sizing: border-box;
        }

        input[type=submit],
        button,
        .aspNetButton {
            background-color: #01c0e8;
            color: white;
            border: none;
            padding: 8px 14px;
            border-radius: 5px;
            cursor: pointer;
        }


        input[type=submit]:hover,
        button:hover,
        .aspNetButton:hover {
            background-color: #45a049;
        }

        .actions {
            display: flex;
            gap: 10px;
        }
       .btn {
        display: inline-flex;
        align-items: center;
        gap: 6px;
        font-weight: 600;
        border: none;
        border-radius: 6px;
        padding: 6px 12px;
        cursor: pointer;
        color: white !important;
        text-decoration: none !important;
        transition: background-color 0.2s ease;
    }

    /* Cores personalizadas */
    .btn-success { background-color: #28a745; } /* verde */
    .btn-success:hover { background-color: #218838; }

    .btn-danger { background-color: #dc3545; } /* vermelho */
    .btn-danger:hover { background-color: #c82333; }

    .btn-primary { background-color: #007bff; } /* azul */
    .btn-primary:hover { background-color: #0069d9; }

    /* Ícones alinhados bonitos */
    .btn i {
        font-size: 14px;
    }

.btn:hover {
    opacity: 0.9;
}
 .table {
        border-radius: 8px;
        overflow: hidden;
        background-color: #fff;
    }

    .table th {
        background-color: #28a745 !important;
        color: white !important;
        text-align: left;
        padding: 10px;
    }

    .table td {
        vertical-align: middle;
        padding: 8px 12px;
    }

    .btn i {
        margin-right: 4px;
    }

    </style>
</head>

<body style="height: 195px">
    <form id="form1" runat="server">               
                <asp:GridView 
                ID="gvdProduto" 
                 runat="server" 
                 AutoGenerateColumns="False"
                 BorderColor="#e0e0e0" 
                 BorderStyle="Solid" 
                 BorderWidth="1px" 
                 CellPadding="5" 
                 CellSpacing="0" 
                 OnRowCancelingEdit="gvdProduto_RowCancelingEdit" 
                 OnRowDeleting="gvdProduto_RowDeleting" 
                 OnRowEditing="gvdProduto_RowEditing" 
                 OnRowUpdating="gvdProduto_RowUpdating"
                 CssClass="table table-bordered table-striped shadow-sm rounded"
                 Width="100%" OnRowCommand="gvdProduto_RowCommand">
            <Columns>
                <asp:TemplateField HeaderText="Código">
                    <EditItemTemplate>
                        <asp:Label ID="lblCodProduto" runat="server" Text='<%# Bind("codproduto") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblCodProduto" runat="server" Text='<%# Bind("codproduto") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Descricao">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtDescricao" runat="server" Text='<%# Bind("descricao") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblDescricao" runat="server" Text='<%# Bind("descricao") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Categoria">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtCategoria" runat="server" Text='<%# Bind("categoria") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblCategoria" runat="server" Text='<%# Bind("categoria") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="EAN">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtEAN" runat="server" Text='<%# Bind("ean") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblEAN" runat="server" Text='<%# Bind("ean") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Preço Venda">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtPrecoVenda" runat="server" Text='<%# Bind("precoVenda") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblPrecoVenda" runat="server" Text='<%# Bind("precoVenda") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

               <asp:TemplateField>
    <EditItemTemplate>
        <asp:LinkButton ID="btnSalvar" runat="server" CommandName="Update" CssClass="btn btn-success">
            <i class="fa-solid fa-floppy-disk"></i> Salvar
        </asp:LinkButton>

        <asp:LinkButton ID="btnCancelar" runat="server" CommandName="Cancel" CssClass="btn btn-danger">
            <i class="fa-solid fa-xmark"></i> Cancelar
        </asp:LinkButton>
    </EditItemTemplate>

    <ItemTemplate>
        <asp:LinkButton ID="btnEditar" runat="server" CommandName="Edit" CssClass="btn btn-primary">
            <i class="fa-solid fa-pen"></i> Editar
        </asp:LinkButton>

        <asp:LinkButton ID="btnExcluir" runat="server" CommandName="Delete" CssClass="btn btn-danger">
            <i class="fa-solid fa-trash"></i> Excluir
        </asp:LinkButton>
    </ItemTemplate>
</asp:TemplateField>


            </Columns>
               <HeaderStyle BackColor="#28a745" Font-Bold="True" ForeColor="White" />
    <RowStyle BackColor="White" ForeColor="#333" />
    <AlternatingRowStyle BackColor="#f9f9f9" />
    <SelectedRowStyle BackColor="#c3e6cb" Font-Bold="True" ForeColor="#155724" />
        </asp:GridView>    
        <p></p>
        <table border="0" cellpadding="0" cellspacing="0" style="border-collapse: collapse">
            <tr>                    
                <td style="width:300">
                    Descricao:<br/>
                    <asp:TextBox ID="txtNovoDescricao" runat="server" Width="300" />
                </td>
                <td style="width:120px">
                    Categoria:<br/>
                    <asp:TextBox ID="txtNovoCategoria" runat="server" Width="120"/>
                </td>
                <td style="width:180px">
                    EAN:<br/>
                    <asp:TextBox ID="txtNovoEAN" runat="server" Width="180"/>
                </td>
                <td style="width:180px">
                    Preço Venda:<br/>
                    <asp:TextBox ID="txtNovoPrecoVenda" runat="server" Width="180"/>
                </td>
                <td>
                    <asp:LinkButton ID="btnAdicionar" runat="server" OnClick="Insert" CssClass="btn btn-success">
                     <i class="fa-solid fa-plus"></i> Adicionar
                    </asp:LinkButton>
                </td>
            </tr>
        </table>                 
    </form>
</body>
</html>

