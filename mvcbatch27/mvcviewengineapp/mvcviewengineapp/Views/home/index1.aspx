<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index1.aspx.cs" Inherits="mvcviewengineapp.Views.home.index1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <%
        int a = 100;
        int b = 200;
         %>
    <h2>
        sum:<%=(a+b) %>
    </h2>
    <%
        for(byte i=1;i<=10;i++)
        { 
             if(i%2==0)
             {
     %>
        <h3 style="color:blue">
            even:<%=i %>
        </h3>
    <%
    }
    else
    {
     %>
    <h3 style="color:red">
        odd:<%=i %>
    </h3>
    <%
    }//closing else
    }//closing for
      %>










    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>
