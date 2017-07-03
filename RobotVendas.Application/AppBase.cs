using RobotVendas.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace RobotVendas.Application
{
    public class AppBase<TEntity> : IAppBase<TEntity> where TEntity : class
    {
        readonly IAppBase<TEntity> _appBase;

        public AppBase(IAppBase<TEntity> appBase)
        {
            _appBase = appBase;
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
