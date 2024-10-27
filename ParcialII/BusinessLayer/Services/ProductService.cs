using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities;
using DataAccessLayer.Repositories;

namespace BusinessLayer.Services
{
    public class ProductService
    {
        private ProductRepository _productRepository;
        private CategoryRepository _categoryRepository;

        public ProductService()
        {
            _productRepository = new ProductRepository();
        }

        public DataTable GetAllCategory()
        {
            return _categoryRepository.GetCategory();
        }

        public DataTable GetProduct()
        {
            return _productRepository.GetProduct();
        }

        public void AddProduct(Product product)
        {
            _productRepository.AddProduct(product);
        }

        public void EditProduct(Product product)
        {
            _productRepository.UpdateProduct(product);
        }

        public void DeleteProduct(int id)
        {
            _productRepository.DeleteProduct(id);
        }
    }

}
