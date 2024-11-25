using Microsoft.EntityFrameworkCore;
using backend.Models;
using backend.Services.Contrato;

namespace backend.Services.Implementacion
{
    public class EmpleadoService : iEmpleadoService
    {
        private dbempleadoContext _dbContext;

        public EmpleadoService(dbempleadoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Empleado>> GetList()
        {
            try
            {
                List<Empleado> list = new List<Empleado>();
                list = await _dbContext.Empleados.ToListAsync();

                return list;
            }
            catch (Exception ex) 
            { 
                throw ex;
            }
        }
    }
}
