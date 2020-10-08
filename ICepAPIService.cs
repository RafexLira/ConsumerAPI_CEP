using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumerAPI
{
    public interface ICepAPIService
    {
        [Get("/ws/{cep}/json")]
        Task<CepResponse> GetAddressAsync(string cep);
         
    }
}
