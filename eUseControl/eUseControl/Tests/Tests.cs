
using eUseControl.BusinessLogic.LoginBL;
using eUseControl.Domain.Entities.User;
using NUnit.Framework;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Assert = NUnit.Framework.Assert;

namespace eUseControl.Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase] //verify if data was extraget from DB
        public void Test1()
        {
            GalerieBL galerieBl = new GalerieBL();
            var result = galerieBl.GetGalerieData().FirstOrDefault();
            Assert.NotNull(result);
        }

        [TestCase]   //register
        public async Task Test2()
        {
            var bl = new BussinesLogic.BussinesLogic();
            var _session = bl.GetSessionBL();
            URegisterData data = new URegisterData
            {
                Email = "ggggsddsgds@gamil.com",
                Credential = "andria",
                Password = "12345678",
                LoginDataTime = DateTime.Now
            };

            var userLogin = _session.UserRegister(data);
            Assert.True(userLogin.Status);
        }

        [TestCase]   //login
        public void Test3()
        {
            var bl = new BussinesLogic.BussinesLogic();
            var _session = bl.GetSessionBL();
            ULoginData data = new ULoginData
            {
                Credetial = "andria",
                Password = "12345678",
                LoginDataTime = DateTime.Now
            };

            var userLogin = _session.UserLogin(data);
            Assert.True(userLogin.Status);
        }
    }
}