using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronDeDiseñoRepository;

namespace PatronDeDiseñoRepository
{
    public class GestorEmpleados
    {
        private IObtenerEmpleadosRepository _repository;
        public GestorEmpleados(IObtenerEmpleadosRepository repository)
        {
            _repository = repository;
        }
        public List<Empleado> ObtenerTodosLosEmpleados()
        {
            return _repository.ObtenerTodos();
        }
        public void AgregarEmpleados(Empleado empleado)
        {
            List<Empleado> empleados = _repository.ObtenerTodos();
            empleados.Add(empleado);
            _repository.GuardarTodo(empleados);
        }


        
    }
}
