using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.ChangeTracking;
public interface IRepository<TEntity> where TEntity : BaseEntity
{
    TEntity Insert(TEntity entity, long userId);
    void InsertRange(ICollection<TEntity> entities, long userId);
    ValueTask<EntityEntry<TEntity>> InsertAsync(TEntity entity, long userId, CancellationToken cancellationToken = default);
    Task InsertRangeAsync(ICollection<TEntity> entities, long userId, CancellationToken cancellationToken = default);
    TEntity Update(TEntity entity, long userId);
    void UpdateRange(ICollection<TEntity> entities, long userId);
    void Delete(object id);
    void Delete(TEntity entity);
    void DeleteRange(ICollection<TEntity> entities);
    TEntity? Find(params object[] keyValues);
    ValueTask<TEntity?> FindAsync(params object[] keyValues);
    ValueTask<TEntity?> FindAsync(object[] keyValues, CancellationToken cancellationToken);
    IQueryable<TEntity> Queryable();
    IQueryable<TEntity> Queryable(Expression<Func<TEntity, bool>> predicate);
    IQueryable<TEntity> Queryable(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy);
    IQueryable<TEntity> Queryable(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy, string includeProperties);
}