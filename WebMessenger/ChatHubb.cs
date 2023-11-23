using Microsoft.AspNetCore.SignalR;

namespace WebMessenger
{
    public class ChatHubb : Hub
    {
        private readonly ILogger<ChatHubb> _logger;

        public ChatHubb(ILogger<ChatHubb> logger)
        {
            _logger = logger;
        }

        public async Task SendMessage(string text)
        {
            _logger.LogInformation(text);
            await this.Clients.All.SendAsync("NewMessage", text);
        }
    }
}
