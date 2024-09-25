using Microsoft.Extensions.Configuration;
using SharedMomentsBackend.App.Models.Entities;

namespace SharedMomentsBackend.App
{
    public class Constants
    {
        public const string htmlTemplate = @"
<!DOCTYPE html>
<html>
<head>
    <style>
        .container {{
            font-family: Arial, sans-serif;
            padding: 20px;
            border: 1px solid #ddd;
            border-radius: 5px;
            background-color: #f9f9f9;
        }}
        .header {{
            font-size: 24px;
            font-weight: bold;
            color: #333;
        }}
        .content {{
            margin-top: 20px;
            font-size: 16px;
            color: #555;
        }}
        .footer {{
            margin-top: 20px;
            font-size: 12px;
            color: #999;
        }}
    </style>
</head>
<body>
    <div class='container'>
        <div class='header'>{0}</div>
        <div class='content'>
            {1}
        </div>
        <div class='footer'>
            Este es un mensaje automático, por favor no responda a este correo.
        </div>
    </div>
</body>
</html>";
       public static string templateFriendRequest(string friendName,string userSentRequest,string url) => $@"Hola, {friendName},<br><br>{userSentRequest} te ha enviado una solicitud de amistad.<br><br><a href='{url}friends'>Ir a mi lista de amigos</a>";
       public static string templateAcceptedFriendRequest(string userSentRequest,string friendName, string url) => $@"Hola, {userSentRequest},<br><br>{friendName} ha aceptado tu solicitud de amistad.<br><br><a href='{url}friends'>Ir a mi lista de amigos</a>";
       public static string templateShareMoment(string sharedTo,string sharedBy,string momentTitle, string url) => $@"Hola, {sharedTo},<br><br>{sharedBy} ha compartido contigo el momento {momentTitle}.<br><br><a href='{url}shared-moments'>Ir a momentos compartidos</a>";
       public static string templateShareAlbum(string sharedTo, string sharedBy, string albumName, string url) => $@"Hola, {sharedTo},<br><br>{sharedBy} ha compartido contigo el albúm {albumName}.<br><br><a href='{url}shared-albums'>Ir a albumes compartidos</a>";
    }
}
