
using DAL.DTO;
using DAL.Infrastructure;
using Service.Models;
using Service.RepositoryAbstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.RepositoryImplementions
{
    public class UserRepository : RepositoryBase<UserModelDTO>, IUserRepository
    {
        IUnitOfWork _unitOfWork;
        public UserRepository(IDbFactory dbFactory, IUnitOfWork unitOfWork)
           : base(dbFactory, unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public UserModel CreateNew(UserModel model)
        {           
            var r_model = Add((AutoMapper.Mapper.Map<UserModelDTO>(model)));
            return AutoMapper.Mapper.Map<UserModel>(r_model);
        }

        public void Delete(long id)
        {            
            DeleteItem(AutoMapper.Mapper.Map<UserModelDTO>(GetById(id)));
        }

        public UserModel GetByActivationCode(string Activation)
        {
            return AutoMapper.Mapper.Map<UserModel>(DbContext.Users.Where(m => m.ActivationToken == Activation).FirstOrDefault());
        }

        public UserModel GetById(long id)
        {           
            return AutoMapper.Mapper.Map<UserModel>(GetId(id));
        }

        public UserModel GetUser(string username, string password)
        {
            return AutoMapper.Mapper.Map<UserModel>(GetMany(m => m.Username == username && m.Password == password).FirstOrDefault());
        }


        public UserModel Update(UserModel model)
        {
            return AutoMapper.Mapper.Map<UserModel>(UpdateItem(AutoMapper.Mapper.Map<UserModelDTO>(model))) ;
        }
    }
}
