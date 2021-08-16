using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterPostalAddresses.Services
{
    interface IProductService
    {
        public Task<List<Models.Product>> GetProductsAsync();  
    }
}
