using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal categoryDal;

        public CategoryManager(ICategoryDal categoryService)
        {
            this.categoryDal = categoryService;
        }

        public IDataResult<List<Category>> GetList()
        {
            return new SuccessDataResult<List<Category>>(this.categoryDal.GetList().ToList());
        }

        public IResult Add(Category category)
        {
            this.categoryDal.Add(category);
            return new SuccessResult();
        }

        public IResult Delete(Category category)
        {
            this.categoryDal.Delete(category);
            return new SuccessResult();
        }

        public IResult Update(Category category)
        {
            this.categoryDal.Update(category);
            return new SuccessResult();
        }
    }
}