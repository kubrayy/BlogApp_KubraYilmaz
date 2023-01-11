using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Data.Abstract;
using BlogApp.Entity;

namespace BlogApp.Data.Concrete.EfCore
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category>, ICategoryRepository
    {
        public EfCoreCategoryRepository(BlogAppContext _dbContext) : base(_dbContext)
        {

        }

        private BlogAppContext context
        {
            get { return _dbContext as BlogAppContext; }
        }

        public List<Category> GetCategoriesWithArticle()
        {
            throw new NotImplementedException();
        }

    }
}

