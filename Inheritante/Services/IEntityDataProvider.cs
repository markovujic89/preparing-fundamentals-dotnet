using Inheritante.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritante.Services
{
    public interface IEntityDataProvider<T> where T: BaseEntity
    {
        IList<T> GetAllEntitiest();

        T GetEntityById(long entityId);

        Task SaveEntity(T entity);

        Task DeleteEntity(long entityId);
    }
}
