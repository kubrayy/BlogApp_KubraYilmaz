using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BlogApp.Data.Abstract
{
	public interface IRepository<TEntity>
	{
        TEntity GetById(int id);
        List<TEntity> GetAll();
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}

