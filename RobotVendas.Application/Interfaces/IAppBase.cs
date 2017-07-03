using System.Collections.Generic;

namespace RobotVendas.Application.Interfaces
{
    public interface IAppBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);

        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);
    }
}
