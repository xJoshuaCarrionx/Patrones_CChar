using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDeDiseñoRepository
{
    public interface IObtenerEmpleadosRepository
    {
        List<Empleado> ObtenerTodos();
        void GuardarTodo(List<Empleado>empleados);
    }
}
