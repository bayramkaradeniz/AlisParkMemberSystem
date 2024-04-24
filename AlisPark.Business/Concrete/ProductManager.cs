using AlisPark.Business.Abstract;
using AlisPark.Business.Utilities;
using AlisPark.Business.ValidationRules.FluentValidation;
using AlisPark.DataAccess.Abstract;
using AlisPark.DataAccess.Concrete;
using AlisPark.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AlisPark.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //Business code            
            return _productDal.GetAll(); 
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == categoryId);
        }

        public List<Product> GetProductsByName(string productName)
        {
            return _productDal.GetAll(p => p.Name.ToLower().Contains(productName.ToLower()));
        }

        public Product GetProductByName(string productName)
        {
            return _productDal.Get(p => p.Name.ToLower().Contains(productName.ToLower()));
        }

        public void Add(Product product)
        {
        //    ValidationTools.FluentValidate(new ProductValidator(), member);
            _productDal.Add(product);
        }

        public void Update(Product product)
        {
        //    ValidationTools.FluentValidate(new ProductValidator(), product);
            _productDal.Update(product);
        }

        public void Delete(Product product)
        {
            try
            {
                _productDal.Delete(product);
            }
            catch
            {
                throw new Exception("Couldn't delete.");
            }
        }

        public void GetProductsByMemberName(string text)
        {
            throw new NotImplementedException();
        }


        List<Product> IProductService.GetProductsByProductName(string productName)
        {
            return _productDal.GetAll(p => p.Name.ToLower().Contains(productName.ToLower()));
        }
    }
}
