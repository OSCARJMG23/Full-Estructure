using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;
using Aplicacion.Repository;

namespace Applicacion.Repository
{
    public class RolRepository : GenericRepository<Rol>, IRolRepository
    {
        private readonly ApiContext _context;

        public RolRepository(ApiContext context) : base(context)
        {
            _context = context;
        }
    }
}