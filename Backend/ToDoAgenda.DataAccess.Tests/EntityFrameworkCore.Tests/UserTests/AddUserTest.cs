using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoAgenda.DataAccess.Concrete.EntityFrameworkCore.ForEntity;
using TODoAgenda.Entities.Concrete;

namespace ToDoAgenda.DataAccess.Tests;

[TestClass]
public class AddUserTest
{
    [TestMethod]
    public async void Add_User()
    {
        EfCoreUserDal userDal = new EfCoreUserDal();
        User user = new User(); 
        user.UserId = 1;
        user.UserName = "deneme";
        user.UserSurname = "deneme";
        user.UserEmail = "deneme@gmail.com";

        await userDal.Add(user);
        // Assert
    }
}
