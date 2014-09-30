<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <div>
    <form action="home/login" method="post">
        <% if (ViewData["openID"] as String != null) { %> 登陆成功:openid:<%:ViewData["openid"]%> <% }%>
        <% else if (ViewData["error"] as String != null) { %> 登陆失败:<br \>error:<%:ViewData["error"]%> <br \> error_description:<%:ViewData["error_description"]%> <% }%>
        <% else { %><button type="submit">登录</button><% } %>
    </form>
    </div>
</body>
</html>
