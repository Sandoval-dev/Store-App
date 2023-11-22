using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly IProductRepository _productRepository;

        public RepositoryManager(IProductRepository productRepository, RepositoryContext context)
        {
            _productRepository = productRepository;
            _context = context;
        }

        public IProductRepository Product => _productRepository;

        public ICategoryRepository Category => throw new NotImplementedException();

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
