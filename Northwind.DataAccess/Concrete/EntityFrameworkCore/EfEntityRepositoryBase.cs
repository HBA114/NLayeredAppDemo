using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Northwind.DataAccess.Abstract;
using Northwind.Entities.Abstract;

namespace Northwind.DataAccess.Concrete.EntityFrameworkCore;

public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
where TEntity : class, IEntity, new()
where TContext : DbContext, new()
{
    private readonly NorthwindContext _context;

    public EfEntityRepositoryBase(NorthwindContext context)
    {
        _context = context;
    }

    public void Add(TEntity entity)
    {
        var addedEntity = _context.Entry(entity);
        addedEntity.State = EntityState.Added;
        _context.SaveChanges();
    }

    public void Delete(TEntity entity)
    {
        var deletedEntity = _context.Entry(entity);
        deletedEntity.State = EntityState.Deleted;
        _context.SaveChanges();
    }

    public TEntity Get(Expression<Func<TEntity, bool>> filter)
    {
        return _context.Set<TEntity>().SingleOrDefault(filter)!;
    }

    public List<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null)
    {
        return filter == null ?
            _context.Set<TEntity>().ToList() : 
            _context.Set<TEntity>().Where(filter).ToList();
    }

    public void Update(TEntity entity)
    {
        var updatedEntity = _context.Entry(entity);
        updatedEntity.State = EntityState.Modified;
        _context.SaveChanges();
    }
}