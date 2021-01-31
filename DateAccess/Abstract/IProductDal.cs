using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DateAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);

        //ürünleri kategorilere göre listele
        List<Product> GetAllByCategory(int categoryId); 
    }
}
