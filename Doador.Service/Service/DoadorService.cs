using Doador.Domain.Commands;
using Doador.Domain.Interface;

namespace Doador.Service.Service
{
    public class DoadorService : IDoadorService
    {
        public DoadorService(IDoadorRepository repository)
        {
            _repository = repository;
        }


  
        public Task<string> PostAsync(DoadorCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
