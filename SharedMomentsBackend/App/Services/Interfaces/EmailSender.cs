namespace SharedMomentsBackend.App.Services.Interfaces
{
    public interface IEmailSender
    {
        Task SendEmail(string emailTo, string body, string subject);
    }
}
