using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ServiceAbstraction
{
    public interface IUserService
    {
        UserModel Login(string Username, string Password);
        UserModel Register(UserModel model);
    }
}
