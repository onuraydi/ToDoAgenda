using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoAgenda.DataAccess.Concrete.EntityFrameworkCore.ForEntity;
using TODoAgenda.Entities.Concrete;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using Task = System.Threading.Tasks.Task;


namespace ToDoAgenda.DataAccess.Tests;

[TestClass]
public class AddResultTest
{
    [TestMethod]
    public async Task Add_Result_Test()
    {
        EfCoreResultDal resultDal = new EfCoreResultDal();
        Result result = new Result();

        result.ResultType = "deneme";
        result.TrueCount = 30;
        result.FalseCount = 6;
        result.TotalNetCount = result.TrueCount - result.FalseCount / 4;

        await resultDal.Add(result);

        var item = await resultDal.GetAll();

        var addedItem = item.FirstOrDefault(x => x.ResultId == result.ResultId);

        Assert.IsNotNull(addedItem);
        Assert.AreEqual(result.ResultType, addedItem.ResultType);
        Assert.AreEqual(result.TotalNetCount, addedItem.TotalNetCount);
        Assert.AreEqual(result.FalseCount, addedItem.FalseCount);
        Assert.AreEqual(result.TrueCount, addedItem.TrueCount);
        Assert.AreEqual(1, item.Count);

    }
}
