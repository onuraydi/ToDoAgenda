using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoAgenda.DataAccess.Concrete.EntityFrameworkCore.ForEntity;
using TODoAgenda.Entities.Concrete;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using Task = System.Threading.Tasks.Task;

namespace ToDoAgenda.DataAccess.Tests;

[TestClass]
public class AddImportanceLevelTest
{
    [TestMethod]
    public async Task Add_Importance_Level_Test()
    {
        EfCoreImportanceLevelDal importanceLevelDal = new EfCoreImportanceLevelDal();
        ImportanceLevel importanceLevel = new ImportanceLevel();

        importanceLevel.ImportanceLevelDegree = 5;

        await importanceLevelDal.Add(importanceLevel);

        var item = await importanceLevelDal.GetAll();

        var addedItem = item.FirstOrDefault(x => x.ImportanceLevelId == importanceLevel.ImportanceLevelId);

        Assert.IsNotNull(addedItem);
        Assert.AreEqual(1, item.Count);
        Assert.AreEqual(importanceLevel.ImportanceLevelDegree, addedItem.ImportanceLevelDegree);
    }
}
