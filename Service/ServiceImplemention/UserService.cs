using Service.Models;
using Service.RepositoryAbstraction;
using Service.ServiceAbstraction;
using System;


namespace Service.ServiceImplemention
{
    public class UserService : IUserService
    {
        IUserRepository repo;
        IEmailService mailService;
        public UserService(IUserRepository _repo, IEmailService _mailService)
        {
            repo = _repo;
            mailService = _mailService;
        }
        public UserModel Login(string Username, string Password)
        {
            return repo.GetUser(Username,Password);
        }

        public UserModel Register(UserModel model)
        {
            if(model.Validate().IsValid)
            {
                repo.CreateNew(model);
                mailService.SendMail(model.Email, "Activation Link", "");
            }
            return null;
        }
    }
}
