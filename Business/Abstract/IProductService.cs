using Core.Utilities.Results;
using Entities.Concrete;

public interface IProductService
{
    IDataResult<Product> GetById(int productId);
    IDataResult<List<Product>> GetByName(string productName);
    IDataResult<List<Product>> GetList();
    IDataResult<List<Product>> GetListByCategory(int categoryId);
    IResult Add(Product product);
    IResult Delete(Product product);
    IResult Update(Product product);
}