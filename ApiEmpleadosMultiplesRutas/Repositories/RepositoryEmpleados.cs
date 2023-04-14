using ApiEmpleadosMultiplesRutas.Data;
using ApiEmpleadosMultiplesRutas.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiEmpleadosMultiplesRutas.Repositories
{
    public class RepositoryEmpleado
    {
        private EmpleadosContext context;



        public RepositoryEmpleado(EmpleadosContext context)
        {
            this.context = context;
        }



        public async Task<List<Empleado>> GetEmpleadosAsync()
        {
            return await this.context.Empleados.ToListAsync();
            
        }



        public async Task<Empleado> FindEmpleadoAsync(int id)
        {
            return await this.context.Empleados
            .FirstOrDefaultAsync(x => x.IdEmpleado == id);
        }
    }
}
