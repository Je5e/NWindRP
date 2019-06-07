using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace NWind.Repository
{
   public interface IRepository:IDisposable
    {
        // Para agregar una nueva entidada a la Bd.
        TEntity Create<TEntity>(TEntity newEntity) 
            where TEntity : class;

        // Para eliminar una entidad
        bool Delete<TEntity>(TEntity toDelete) //Generic
            where TEntity : class;

        // Para actualizar una entidad
        bool Update<TEntity>(TEntity toUpdated)
            where TEntity : class;

        // Para recuperar una entidad en base a un criterio
        TEntity Retrieve<TEntity>
            (Expression<Func<TEntity, bool>> criteria)
            where TEntity : class;

        // Para recuperar un conjunto de entidades
        // que cumplan con un criterio de búsqueda.
        List<TEntity> Filter<TEntity>
            (Expression<Func<TEntity, bool>> criteria)
            where TEntity : class;
    }
}
