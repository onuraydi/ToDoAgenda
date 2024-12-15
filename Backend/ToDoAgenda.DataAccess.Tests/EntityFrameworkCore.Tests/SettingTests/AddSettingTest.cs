using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoAgenda.DataAccess.Concrete.EntityFrameworkCore.ForEntity;
using TODoAgenda.Entities.Concrete;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using Task = System.Threading.Tasks.Task;


namespace ToDoAgenda.DataAccess.Tests;

[TestClass]
public class AddSettingTest
{
    [TestMethod]
    public async Task Add_Setting_Test()
    {
        EfCoreSettingDal settingDal = new EfCoreSettingDal();
        Setting setting = new Setting();
        
        await settingDal.Add(setting);
        var item = await settingDal.GetAll();

        Assert.IsNotNull(setting);
        Assert.AreEqual(1, item.Count);
        
    }
}
