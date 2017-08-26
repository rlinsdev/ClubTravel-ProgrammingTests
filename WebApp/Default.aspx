<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApp1.Default" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>..:Club Travel:..</title>
   <script data-main="Scripts/Controllers/main.js" src="Scripts/Vendors/requirejs/require.js" id="srcMainJS"></script>
	<link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css" />
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"/>
	<link rel="stylesheet" href="css/style.css" />
</head>
<body>
   <form runat="server">
   </form>
   <div class="header">
   </div>
   <div class="conteudo-principal">
      <div ui-view="conteudo-view"></div>
   </div>
</body>
</html>

