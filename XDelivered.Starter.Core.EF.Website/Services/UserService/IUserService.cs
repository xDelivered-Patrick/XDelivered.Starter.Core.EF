using System.Collections.Generic;
using System.Threading.Tasks;
using XDelivered.StarterKits.NgCoreEF.Data;
using XDelivered.StarterKits.NgCoreEF.Modals;

namespace XDelivered.StarterKits.NgCoreEF.Services
{
    public interface IUserService
    {
        Task<List<UserModel>> GetAllUsers();
        Task DeleteUser(User user);
        Task EditUser(UserModel userModel);
        Task<UserModel> GetUser(string id);
    }
}