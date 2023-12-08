using ClassLibrary1;

namespace Ejercicio_01
{
    internal class Program
    {
        /*  metodo estatico MostrarEmpleadosPorPuesto
            ------------------------------------
            En el main

            Calcular la suma de sueldos
            */

        static void Main(string[] args)
        {
            //En el main Crear una lista de empleados con 5 empleados
            List<Empleados> miListaDeEmpleados = new List<Empleados>();

            Empleados primerEmpleado = new Empleados("Gonzalo", 1500, EnumPuestos.Recepcionista);
            Empleados segundoEmpleado = new Empleados("Elizabeth", 2000, EnumPuestos.Analista);
            Empleados tercerEmpleado = new Empleados("Marcelo", 2500, EnumPuestos.Gerente);
            Empleados cuartoEmpleado = new Empleados("Melina", 3500, EnumPuestos.RRHH);
            Empleados quintoEmpleado = new Empleados("Aurelio", 4000, EnumPuestos.Analista);

            miListaDeEmpleados.Add(primerEmpleado);
            miListaDeEmpleados.Add(segundoEmpleado);
            miListaDeEmpleados.Add(tercerEmpleado);
            miListaDeEmpleados.Add(cuartoEmpleado);
            miListaDeEmpleados.Add(quintoEmpleado);

            // Mostrar todos los empleados
            Console.WriteLine("Los datos de todos los empleados son: ");
            Empleados.MostrarTodosLosEmpleados(miListaDeEmpleados);

            Console.WriteLine("Los empleados por puesto son: ");
            Empleados.MostrarEmpleadosPorPuesto(miListaDeEmpleados);

            Console.WriteLine($"El total de todos los sueldos es {Empleados.CalcularSueldos(miListaDeEmpleados)}");
            
        }
    }
}