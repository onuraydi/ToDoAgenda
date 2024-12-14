using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoAgenda.DataAccess.Concrete.EntityFrameworkCore.ForEntity;
using TODoAgenda.Entities.Concrete;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

using Task = System.Threading.Tasks.Task;

namespace ToDoAgenda.DataAccess.Tests;

[TestClass]
public class AddUserTest
{
    [TestMethod]
    public async Task Add_User()
    {
        // Arrange
        EfCoreUserDal userDal = new EfCoreUserDal();
        User user = new User
        {
            UserName = "deneme",
            UserSurname = "deneme",
            UserEmail = "deneme@gmail.com"
        };

        // Act
        await userDal.Add(user);

        // Assert
        var items = await userDal.GetAll();

        var addedUser = items.FirstOrDefault(u => u.UserEmail == user.UserEmail);
        Assert.IsNotNull(addedUser); 
        Assert.AreEqual(user.UserName, addedUser.UserName); 
        Assert.AreEqual(user.UserSurname, addedUser.UserSurname); 
        Assert.AreEqual(user.UserEmail, addedUser.UserEmail); 
        Assert.AreEqual(1, items.Count); 
    }

}
