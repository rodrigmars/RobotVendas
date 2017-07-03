using System.Collections.Generic;

namespace RobotVendas.Domain.Interfaces
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);

        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);
    }
}
