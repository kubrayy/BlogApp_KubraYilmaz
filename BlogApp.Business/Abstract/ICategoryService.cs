using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Entity;

namespace BlogApp.Business.Abstract
{
	public interface ICategoryService
	{
		Category GetById(int id);
		List<Category> GetAll();
		void Create(Category entity);
		void Update(Category entity);
		void Delete(Category entity);

	}
}

