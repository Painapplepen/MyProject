using InnoflowServer.Domain.Core.Entities;
using InnoflowServer.Domain.Core.Messages;
using InnoflowServer.Domain.Core.Messages.Users;

namespace InnoflowServer.Services.Interfaces.Users
{
    public interface IUserService
    {
        UserCreateResponse CreateUser(User user, ModelStateDictionary modelState);

        UserResponse GetUser(int id);

        BaseResponse UpdateUser(int id, User user, ModelStateDictionary modelState);

        BaseResponse DeleteUser(int id);

        UsersResponse GetUsers();
    }
}
