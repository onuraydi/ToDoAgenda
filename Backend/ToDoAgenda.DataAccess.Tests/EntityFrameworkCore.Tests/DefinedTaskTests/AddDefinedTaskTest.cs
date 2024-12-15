using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoAgenda.DataAccess.Concrete.EntityFrameworkCore.ForEntity;
using TODoAgenda.Entities.Concrete;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using Task = System.Threading.Tasks.Task;

namespace ToDoAgenda.DataAccess.Tests;

[TestClass]
public class AddDefinedTaskTest
{
    [TestMethod]
    public async Task Add_Defined_Task_Test()
    {
        EfCoreDefinedTaskDal definedTaskDal = new EfCoreDefinedTaskDal();
        DefinedTask definedTask = new DefinedTask();

        await definedTaskDal.Add(definedTask);

        var item = await definedTaskDal.GetAll();

        Assert.IsNotNull(definedTask);
        Assert.AreEqual(1, item.Count);
    }
}
