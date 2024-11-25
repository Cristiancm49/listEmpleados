using Microsoft.EntityFrameworkCore;
using backend.Models;
using backend.Services.Contrato;
using Microsoft.AspNetCore.Identity;

namespace backend.Services.Implementacion
{
    public class DepartametnoService : iDepartamentoService
    {
        private dbempleadoContext _dbContext;

        public DepartametnoService(dbempleadoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Departamento> Get(int idEmpleado)
        {
            try
            {
                Departamento? encontrado = new Departamento();
                encontrado = await _dbContext.Departamentos.Include(dpt => dpt.idDepartamentoNavigation).
                    Where(e => e.IdDepartaemtno == idEmpleado).FirstOrDefaultAsync();

                return encontrado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Departamento>> GetList()
        {
            try
            {
                List<Departamento> list = new List<Departamento>();
                list = await _dbContext.Departamentos.Include(dpt => dpt.idDepartamentoNavigation).ToListAsync();

                return list;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Departamento> Add(Departamento modelo)
        {
            try
            {
                _dbContext.Departamentos.Add(modelo);
                await _dbContext.SaveChangesAsync();
                return modelo;
            }
            catch (Exception ex) { 
                throw ex;
            }
                
        }

        public async Task<bool> Update(Departamento modelo)
        {
            try
            {
                _dbContext.Departamentos.Update(modelo);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public async Task<bool> Delete(Departamento modelo)
        {
            try
            {
                _dbContext.Departamentos.Remove(modelo);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
