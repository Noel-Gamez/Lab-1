<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Agregar</title>
    <link href="../../Content/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <a href="/Video/Index">Index Video</a>
    <br />
    <form action="/Video/Agregar" method="post">
    <fieldset>
        <legend>Datos Video</legend>
        <label for="idVideo">idVideo</label>
            <input type="text" name="idVideo" />
        <label for="titulo">Titulo</label>
            <input type="text" name="titulo" />
        <label for="reproducciones">Reproducciones</label>
            <input type="text" name="reproducciones" />
        <label for="url">Url</label>
            <input type="text" name="url" />
        <label for="creador">Creador</label>
            <input type="text" name="creador" />
        <br />
        <br /> 

        <input type="submit" value="Registrar Video" />
    </fieldset>
    </form>
</body>
</html>
