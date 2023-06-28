using Microsoft.AspNetCore.SignalR;

namespace AspFinalProject.Hubs
{
    public class ChatHub:Hub
    {

        //private IHttpContextAccessor _contextAccessor;
        //private SocialMediaContext _context;

        //public ChatHub(IHttpContextAccessor contextAccessor, SocialMediaContext context)
        //{
        //    _contextAccessor = contextAccessor;
        //    _context = context;
        //}

        //public async override Task OnDisconnectedAsync(Exception? exception)
        //{
        //    var user = await _userManager.GetUserAsync(_contextAccessor.HttpContext.User);
        //    if (user != null)
        //    {
        //        var userItem = _context.Users.SingleOrDefault(x => x.Id == user.Id);
        //        userItem.IsOnline = false;
        //        await _context.SaveChangesAsync();
        //        UserHelper.ActiveUsers.RemoveAll(u => u.Id == user.Id);
        //    }
        //    string info = user.UserName + " disconnected";
        //    await Clients.Others.SendAsync("Disconnect", info);
        //}

    }
}
