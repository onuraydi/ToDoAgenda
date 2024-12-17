using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoAgenda.Business.Abstract.ResutlServices;
using ToDoAgenda.DataAccess.Abstract.ForEntity;
using ToDoAgenda.DataAccess.Concrete.EntityFrameworkCore.ForEntity;
using TODoAgenda.Entities.Concrete;
using Task = System.Threading.Tasks.Task;

namespace ToDoAgenda.Business.Concrete.Managers.ResultManagers
{
    public class ResultManager : IResultService
    {
        private IResultDal _resultDal;
        private IMapper _mapper;

        public ResultManager(IResultDal resultDal, IMapper mapper)
        {
            _resultDal = resultDal;
            _mapper = mapper;
        }

        public async Task<Result> Add(Result result)
        {
            return await _resultDal.Add(result);
        }

        public async Task Delete(Result result)
        {
            await _resultDal.Delete(result);
        }

        public async Task<List<Result>> GetAll()
        {
            var values = await _resultDal.GetAll();
            return _mapper.Map<List<Result>>(values);   
        }

        public async Task<Result> GetById(int id)
        {
            return await _resultDal.Get(x => x.ResultId == id);
        }

        public async Task<Result> Update(Result result)
        {
            return await _resultDal.Update(result); 
        }
    }
}
