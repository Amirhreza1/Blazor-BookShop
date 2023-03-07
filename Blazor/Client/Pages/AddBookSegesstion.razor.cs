using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;

namespace Blazor.Client.Pages
{
    public partial class AddBookSegesstion : ComponentBase
    {
        BookSegesstion CurrentMessage { get; set; }
        List<BookSegesstion> AllMessages { get; set; } = new();

        HubConnection _chatConnection;

        protected override async Task OnInitializedAsync()
        {
            CurrentMessage = new BookSegesstion();
            var res = await _client.GetFromJsonAsync<ServiceResponse<List<BookSegesstion>>>("api/BookSgt/GetAllSgt");
            AllMessages = res.Data;

            _chatConnection = new HubConnectionBuilder().WithUrl(_navigationManager.BaseUri + "hubs/BookSgtHub").Build();
            _chatConnection.On<BookSegesstion>("SendMessage", (message) =>
            {
                AllMessages.Add(message);
                StateHasChanged();

            });
            await _chatConnection.StartAsync();

            await base.OnInitializedAsync();
        }
        private void SendMessage()
        {
            CurrentMessage.TimeSent = DateTime.Now;
            _chatConnection.SendAsync("SendMessage", CurrentMessage);
            CurrentMessage = new BookSegesstion();
        }

    }
}
