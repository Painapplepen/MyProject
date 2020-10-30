using InnoflowServer.Infrastructure.Data;
using InnoflowServer.Services.Interfaces.Users;

namespace InnoflowServer.Infrastructure.Business.Users
{
    public class UserService //: IUserService Здесь уберить и делайте
    { 
        private readonly UnitOfWork db;
        public UserService(UnitOfWork uow)
        {
            db = uow;
        }
    }
}
