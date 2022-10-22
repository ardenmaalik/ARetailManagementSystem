using RetailManagerDesktopUI.Models;
using System.Threading.Tasks;

namespace RetailManagerDesktopUILibrary.Api
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
        Task GetLoggedInUserInfo(string token);
    }
}