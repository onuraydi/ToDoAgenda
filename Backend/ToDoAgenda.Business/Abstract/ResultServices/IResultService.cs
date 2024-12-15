using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using Task = System.Threading.Tasks.Task;
using TODoAgenda.Entities.Concrete;

namespace ToDoAgenda.Business.Abstract.ResutlServices
{
    public interface IResultService
    {
        Task<List<Result>> GetAll();
        Task<Result> GetById(int id);
        //Task<Result> GetByResultType(string name);   // diğer operasyonlar sonraki iş
        Task<Result> Add(Result result);
        Task<Result> Update(Result result);
        Task DeleteById(Result result);
    }
}
