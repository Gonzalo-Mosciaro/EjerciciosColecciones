using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ClassLibrary1
{
    public class Empleados
    {
        /*Crear la clase Empleado con los siguientes atributos:
        -Nombre (String)
        -Sueldo (float)
        Puesto (Enumerado)*/

        #region -----ATRIBUTOS-----
        private EnumPuestos _puestos;
        private string _nombre;
        private double _sueldo;
        private string _mensaje;
        #endregion
        #region -----CONSTRUCTORES-----
        public Empleados()
        {

        }
        public Empleados(string nombre, double sueldo, EnumPuestos puestos)
        {
            this._nombre = nombre;
            this._sueldo = sueldo;
            this._puestos = puestos;
        }
        #endregion
        #region -----PROPERTIES-----
        public string Nombre
        {
            get
            {
                return _nombre;
            }
        }
        public double Sueldo
        {
            get
            {
                return _sueldo;
            }
        }
        public EnumPuestos Puestos
        {
            get
            {
                return _puestos;
            }
        }
        public string Mensaje
        {
            get
            {
                return this._mensaje = MostrarUnEmpleado();
            }
        }
        #endregion

        #region -----METODOS-----
        //crear metodo MostrarUnEmpleado
        public string MostrarUnEmpleado()
        {
            string mensaje;

            Console.WriteLine(mensaje = $"\tNombre: {this._nombre}\n\tSueldo: {this._sueldo}\n\tPuesto: {this._puestos}\n");

            return mensaje;
        }

        //crear metodo estatico MostrarTodosLosEmpleados
        public static void MostrarTodosLosEmpleados(List<Empleados> lista)
        {
            foreach (Empleados empleado in lista)
            {
                empleado.MostrarUnEmpleado();
            }
        }

        public static void MostrarTodosLosEmpleadosPorPuesto(List<Empleados> lista, EnumPuestos puesto)
        {
            foreach (Empleados empleado in lista)
            {
                if(empleado._puestos == puesto)
                {
                    empleado.MostrarUnEmpleado();
                }
            }
        }

        //Mostrar solo los empleados de un puesto en particular
        public static void MostrarEmpleadosPorPuesto(List<Empleados> lista) 
        {
            foreach (EnumPuestos puesto in Enum.GetValues(typeof(EnumPuestos)))
            {
                Console.WriteLine(puesto);
                
                Empleados.MostrarTodosLosEmpleadosPorPuesto(lista, puesto);
            }
        }

        public static double CalcularSueldos(List<Empleados> lista)
        {
            double sumaSueldos;
            sumaSueldos = 0;

            foreach(Empleados empleado in lista)
            {
                sumaSueldos += empleado._sueldo;
            }

            return sumaSueldos;
        }


        #endregion
    }
}