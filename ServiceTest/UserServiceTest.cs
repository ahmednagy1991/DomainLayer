using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Service.Models;
using Service.ServiceAbstraction;

namespace ServiceTest
{
    [TestClass]
    public class UserServiceTest
    {
      

        [TestMethod]
        public void RegisterTest1()
        {
            var mockUserService = new Mock<IUserService>();
            var model = new UserModel();
            model.Email = "test4";
            model.Username = "test user4";
            model.Password = "test password2";
            var val = model.Validate();
            Assert.AreEqual(val.IsValid, true);
            if (val.IsValid)
            {
                mockUserService.Setup(x => x.Register(model)).Returns(model);
                var rmodel=mockUserService.Object.Register(model);
                Assert.AreEqual(rmodel.Id, model.Id);
                Assert.AreEqual(rmodel.Password, model.Password);
                Assert.AreEqual(rmodel.IsActive, false);            
                Assert.AreEqual(rmodel.Email, model.Email);
            }

            
        }


        [TestMethod]
        public void RegisterTest2()
        {
            var mockUserService = new Mock<IUserService>();
            var model = new UserModel();
            
            model.Username = "test user4";
            model.Password = "test password2";
            var val = model.Validate();
            Assert.AreEqual(val.IsValid, false);
            Assert.AreEqual(val.Errors.Contains("Email is required"), true);


        }


        [TestMethod]
        public void RegisterTest3()
        {
            var mockUserService = new Mock<IUserService>();
            var model = new UserModel();
            model.Email = "test4";
            //model.Username = "test user4";
            model.Password = "test password2";
            var val = model.Validate();
            Assert.AreEqual(val.IsValid, false);
            Assert.AreEqual(val.Errors.Contains("Username is required"), true);


        }

        [TestMethod]
        public void RegisterTest4()
        {
            var mockUserService = new Mock<IUserService>();
            var model = new UserModel();
            model.Email = "test4";
            model.Username = "test user4";
            //model.Password = "test password2";
            var val = model.Validate();
            Assert.AreEqual(val.IsValid, false);
            Assert.AreEqual(val.Errors.Contains("Password is required"), true);


        }


    }
}
