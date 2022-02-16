using MaisBlack.Models;

namespace MaisBlack.Data.Repositories
{
    public class ClienteRepository
    {
        private MyContext _context;

        public ClienteRepository(MyContext context)
        {
            _context = context;
        }

        public List<Cliente> GetAll()
        {
            return _context.Clientes.ToList();
        }

        public void Add(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }
    }
}
