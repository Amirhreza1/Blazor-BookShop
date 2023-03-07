using Blazor.Client.Pages;
using Blazor.Server.Services;
using Microsoft.AspNetCore.SignalR;

namespace Blazor.Server.Hubs
{
    public class BookSgtHub : Hub
    {
        private readonly IReposetory<BookSegesstion> _messageRepository;

        public BookSgtHub(IReposetory<BookSegesstion> messageRepository)
        {
            _messageRepository = messageRepository;
        }
        public async Task SendMessage(BookSegesstion message)
        {
            await _messageRepository.AddAsync(message);
            await Clients.All.SendAsync("SendMessage", message);
        }
    }
}
