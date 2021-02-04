
namespace SOLID.DIP.Violacao
{
    public class ClienteService
    {
        public void Adicionar(Cliente cliente)
        {
            ClienteRepository clienteRepository = new ClienteRepository();

            clienteRepository.Adicionar(cliente);
        }
    }
}
