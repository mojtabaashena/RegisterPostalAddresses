using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegisterPostalAddresses.Models;

namespace RegisterPostalAddresses.Services
{
    public class ProductService : IProductService
    {
         async Task<List<Product>> IProductService.GetProductsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
