<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetailFilm.aspx.cs" Inherits="Films.DetailFilm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="max-width:1024px; margin-left:auto; margin-right:auto">
    <div style="float:left; width:500px; padding:-10px"><asp:Image runat="server" id="_affiche" CssClass="img-rounded" /></div>    
    <div style="padding-left:-15px">
        <h1><asp:Label runat="server" ID="_title" style="margin-left:auto; margin-right:auto"/></h1>
        <p><asp:Label runat="server" ID="_summary" /></p>
    </div>
                    
    </div>
    </form>
</body>
</html>
