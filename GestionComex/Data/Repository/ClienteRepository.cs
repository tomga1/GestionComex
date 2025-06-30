using GestionComex.Data.Repository.Interfaces;
using GestionComex.Models;
using Microsoft.EntityFrameworkCore;


namespace GestionComex.Data.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ApplicationDbContext _context;
        public ClienteRepository(ApplicationDbContext context)
        {
            _context = context; 
        }

        public async Task<IEnumerable<Clientes>> GetAll()
        {
            var clientes = await _context.Clientes.ToListAsync();
            return clientes; 
        }

        public async Task Add(Clientes cliente)
        {
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();
        }

    }
}
