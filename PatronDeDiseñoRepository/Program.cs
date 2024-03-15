using PatronDeDiseñoRepository;

string archivoEmpleados = "empleados.txt";

IObtenerEmpleadosRepository empleadosRepository = new EmpleadoRepositoryArchivo(archivoEmpleados);

GestorEmpleados gestorempleados =
    new GestorEmpleados(empleadosRepository);

gestorempleados.AgregarEmpleados
    (new Empleado { Nombre = "Joshua", Edad = 21, Puesto = "Ingeniero" });
gestorempleados.AgregarEmpleados
    (new Empleado { Nombre = "Milena", Edad = 18, Puesto = "Ingeniera" });

Console.WriteLine("Todos los empleados");
foreach (var empleados in gestorempleados.ObtenerTodosLosEmpleados())
{
    Console.WriteLine($"Nombre: {empleados.Nombre}," + $"Edad: {empleados.Edad}," + $"Puesto: {empleados.Puesto}");
}
