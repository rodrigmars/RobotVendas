using System;
using System.Collections.Generic;
using RobotVendas.Domain.Interfaces;

namespace RobotVendas.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public void Add(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
