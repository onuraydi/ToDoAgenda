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

        // Kullan�c�n�n �zelliklerini kar��la�t�rarak do�rulama yap�yoruz
        var addedUser = items.FirstOrDefault(u => u.UserEmail == user.UserEmail);
        Assert.IsNotNull(addedUser); // Kullan�c� eklenmi� olmal�
        Assert.AreEqual(user.UserName, addedUser.UserName); // �simler e�it mi?
        Assert.AreEqual(user.UserSurname, addedUser.UserSurname); // Soyad e�it mi?
        Assert.AreEqual(user.UserEmail, addedUser.UserEmail); // E-mail e�it mi?
        Assert.AreEqual(1, items.Count); // Listede sadece 1 kullan�c� olmal�
    }

}
