using Core.Models;
using Core.RepositoryAbstract;
using Data.DAL;
using System.Data;

namespace Data.RepositoryConcretes
{
    public class ProductRepository : IProductRepository
    {
        AppDbContext _appDbContext = new AppDbContext();
        public void Add(string command)
        {
            _appDbContext.NonQuery(command);
        }

        public void Delete(string command)
        {
            _appDbContext.NonQuery(command);
        }

        public Product Get(string command) 
        {
            var dt = _appDbContext.Query(command);
            Product product = null;
            foreach (DataRow item in dt.Rows)
            {
                product = new Product
                {
                    Id = int.Parse(item[0].ToString()),
                    Name = item[1].ToString(),
                    Price = double.Parse(item[2].ToString())
                };
            }

            return product;
        }

        public List<Product> GetAll(string command)
        {
            var dt = _appDbContext.Query(command);
            List<Product> products = new List<Product>();

            foreach (DataRow item in dt.Rows)
            {
                Product product = new Product
                {
                    Id = int.Parse(item[0].ToString()),
                    Name = item[1].ToString(),
                    Price = double.Parse(item[2].ToString())
                };

                products.Add(product);
            }

            return products;
        }


        Product IProductRepository.Get(string command)
        {
            var dt = _appDbContext.Query(command);
            Product product = null;
            foreach (DataRow item in dt.Rows)
            {
                product = new Product
                {
                    Id = int.Parse(item[0].ToString()),
                    Name = item[1].ToString(),
                    Price = double.Parse(item[2].ToString())
                };
            }

            return product;
        }

        List<Product> IProductRepository.GetAll(string command)
        {
            var dt = _appDbContext.Query(command);
            List<Product> products = new List<Product>();

            foreach (DataRow item in dt.Rows)
            {
                Product student = new Product
                {
                    Id = int.Parse(item[0].ToString()),
                    Name = item[1].ToString(),
                    Price = double.Parse(item[2].ToString())
                };

                products.Add(student);
            }

            return products;
        }
        public void Update(string command)
        {
            _appDbContext.NonQuery(command);
        }
    }
}
