using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

public class ProductManager : IProductService
{
    private IProductDal productDal;

    public ProductManager(IProductDal productDal)
    {
        this.productDal = productDal;
    }

    public IDataResult<Product> GetById(int productId)
    {
        return new SuccessDataResult<Product>(this.productDal.Get(p => p.Id == productId));
    }

    public IDataResult<List<Product>> GetByName(string productName)
    {
        return new SuccessDataResult<List<Product>>(this.productDal.GetList(p => p.ProductName == productName).ToList());
    }

    public IDataResult<List<Product>> GetList()
    {
        return new SuccessDataResult<List<Product>>(this.productDal.GetList().ToList());
    }

    public IDataResult<List<Product>> GetListByCategory(int categoryId)
    {
        return new SuccessDataResult<List<Product>>(this.productDal.GetList(p => p.CategoryId == categoryId).ToList());
    }

    public IResult Add(Product product)
    {
        this.productDal.Add(product);
        return new SuccessResult();
    }

    public IResult Delete(Product product)
    {
        this.productDal.Delete(product);
        return new SuccessResult();
    }

    public IResult Update(Product product)
    {
        this.productDal.Update(product);
        return new SuccessResult();
    }
}