using Microsoft.AspNetCore.SignalR;

namespace AspFinalProject.Hub
{
	public class MessageHub:Hub<IMessageHubClient>
	{
		public override Task OnConnectedAsync()
		{
			
			return base.OnConnectedAsync();
		}
	}
}
