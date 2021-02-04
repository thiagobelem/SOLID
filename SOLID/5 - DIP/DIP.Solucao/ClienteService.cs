
namespace SOLID.DIP.Solucao
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public void Adicionar(Cliente cliente)
        {
            _clienteRepository.Adicionar(cliente);
        }
    }
}
