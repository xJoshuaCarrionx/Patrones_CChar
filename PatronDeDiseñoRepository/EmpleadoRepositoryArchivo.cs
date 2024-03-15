using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDeDiseñoRepository
{
    public class EmpleadoRepositoryArchivo : IObtenerEmpleadosRepository
    {
        private string _nombreArchivo;

        public EmpleadoRepositoryArchivo(string nombreEmpleaados)
        {
            _nombreArchivo = nombreEmpleaados;
        }

        public void GuardarTodo(List<Empleado> empleados)
        {
            try
            {
                using (StreamWriter na = new StreamWriter(_nombreArchivo))
                    foreach (Empleado empleado in empleados)
                    {
                        na.WriteLine($"{empleado.Nombre},{empleado.Edad},{empleado.Edad}");
                    }
            }
            catch (IOException e)
            {

                Console.WriteLine($"Error al cargar los datos {e.Message}");
            }
        }

        public List<Empleado> ObtenerTodos()
        {
            List<Empleado> empleados = new List<Empleado>();
            try
            {
                using (StreamReader em = new StreamReader(_nombreArchivo))
                {
                    string linea;
                    while ((linea = em.ReadLine()) != null)
                    {
                        string[] datos = linea.Split(',');
                        Empleado empleado = new Empleado
                        {
                            Nombre = datos[0],
                            Edad = Convert.ToDecimal(datos[1]),
                            Puesto = Convert.ToString(datos[2]),
                        }
                        ;
                        empleados.Add(empleado);
                    }
                }
            }
            catch (IOException e)
            {

                Console.WriteLine($"Error al leer el archivo: {e.Message}");
            }return empleados;


        }
    }
}
