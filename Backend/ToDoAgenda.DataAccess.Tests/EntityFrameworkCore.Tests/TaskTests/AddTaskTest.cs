using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoAgenda.DataAccess.Concrete.EntityFrameworkCore.ForEntity;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using Task = System.Threading.Tasks.Task;
using TaskEntity = TODoAgenda.Entities.Concrete.Task;


namespace ToDoAgenda.DataAccess.Tests;

[TestClass]
public class AddTaskTest
{
    [TestMethod]
    public async Task Add_Task_Test()
    {
        EfCoreTaskDal taskDal = new EfCoreTaskDal();
        TaskEntity task = new TaskEntity();

        task.TaskName = "Deneme G�revi";
        task.TaskDescription = "Burada DataAcces katman�nda yazd���m�z generic metotlar� test ediyoruz. Businessda ise manager s�n�flar�nda yazd���m�z metotlar� test edeci�iz.";
        
        await taskDal.Add(task);


        var item = await taskDal.GetAll();
        var addedItem = item.FirstOrDefault(x=> x.TaskName == task.TaskName);


        Assert.IsNotNull(task);
        Assert.AreEqual(task.TaskName, addedItem.TaskName);
        Assert.AreEqual(task.TaskDescription, addedItem.TaskDescription);
        Assert.AreEqual(1, item.Count);
    }
}
