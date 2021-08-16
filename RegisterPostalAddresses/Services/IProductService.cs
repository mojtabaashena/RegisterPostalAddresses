using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterPostalAddresses.Services
{
    public interface IProductService
    {
        public Task<List<Models.Product>> GetProductsAsync();

        public Task<List<Models.Product>> GetProductForCombpAsync();
    }
}
