using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using ToDoAgenda.DataAccess.Concrete.EntityFrameworkCore.ForEntity;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using Timer = TODoAgenda.Entities.Concrete.Timer;

using Task = System.Threading.Tasks.Task;

namespace ToDoAgenda.DataAccess.Tests;

[TestClass]
public class AddTimerTest
{
    [TestMethod]
    public async Task Add_Timer_Test()
    {
        EfCoreTimerDal timerDal = new EfCoreTimerDal();
        Timer timer = new Timer();
        TimeSpan timeSpan = new TimeSpan(0,25,0);

        timer.targetTime = timeSpan;
        timer.CompleteTime = timeSpan;

        await timerDal.Add(timer);

        var item = await timerDal.GetAll();

        var addedTimer = item.FirstOrDefault(x => x.TimerId == timer.TimerId);

        Assert.IsNotNull(item);
        Assert.AreEqual(1, item.Count);
        Assert.AreEqual(timer.CompleteTime, addedTimer.CompleteTime);
        Assert.AreEqual(timer.targetTime, addedTimer.targetTime);
    }
}
