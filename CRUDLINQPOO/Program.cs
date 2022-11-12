using CRUDLINQPOO.Controllers;
using System;
using System.Linq;

namespace CRUDLINQPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaController AC = new AreaController();
            EmpleadosController EC = new EmpleadosController();
            NominaController NC = new NominaController();
            
            DateTime fecha_ing = new DateTime();
            string area,Nombre,Apellidos,Direcccion,Telefono = "";
            int opc, opc2, id, IdArea, IdEmpleado = 0;
            double sueldo, otros, dias = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Elija el CRUD que desea: ");
                Console.WriteLine("1. AREA");
                Console.WriteLine("2. EMPLEADOS");
                Console.WriteLine("3. NOMINA");
                Console.WriteLine("4. Salir");

                opc = Convert.ToInt32(Console.ReadLine());
                AC.LlenarLista();
                EC.LlenarLista();
                NC.LlenarLista();
                switch (opc)
                {
                    case 1:
                        do {
                            Console.Clear();
                            Console.WriteLine("Que Proceso deseas realizar AREA: ");
                            Console.WriteLine("1. Mostrar datos ");
                            Console.WriteLine("2. Mostrar datos por ID ");
                            Console.WriteLine("3. Insertar datos ");
                            Console.WriteLine("4. Actualizar datos ");
                            Console.WriteLine("5. Eliminar datos ");
                            Console.WriteLine("6. Salir ");
                            
                            opc2 = Convert.ToInt32(Console.ReadLine());
                                switch (opc2)

                                    {
                                        case 1:
                                            AC.get();
                                            Console.ReadKey();
                                            break;


                                        case 2:
                                            Console.WriteLine("Ingrese ID");
                                            id = Convert.ToInt32(Console.ReadLine());
                                            AC.getbyId(id);
                                            Console.ReadKey();
                                            break;

                                        case 3:
                                            Console.WriteLine("Ingrese ID");
                                            id = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Ingrese Nombre del Area");
                                            area = Console.ReadLine();
                                            AC.post(id, area);
                                            AC.get();
                                            break;

                                        case 4:
                                            Console.WriteLine("Ingrese ID ");
                                            id = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Ingrese Nombre del Area");
                                            area = Console.ReadLine();
                                            AC.update(id, area);
                                            AC.get();
                                    

                                            break;

                                        case 5:
                                            Console.WriteLine("Ingrese ID del registro a eliminar");
                                            id = Convert.ToInt32(Console.ReadLine());
                                            AC.DeletexId(id);
                                            AC.get();
                                    
                                            break;
                                        case 6:
                                            Console.WriteLine("bye");
                                            opc2 = 6;
                                            break;
                                        default:
                                            Console.WriteLine("opcion incorrecta, eliga otra");
                                            break;
                                }
                        } while (opc2 != 6);

                        break;

                    case 2:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Que Proceso deseas realizar de EMPLEADOS: ");
                            Console.WriteLine("1. Mostrar datos ");
                            Console.WriteLine("2. Mostrar datos por ID ");
                            Console.WriteLine("3. Insertar datos ");
                            Console.WriteLine("4. Actualizar datos ");
                            Console.WriteLine("5. Eliminar datos ");
                            Console.WriteLine("6. Salir ");

                            opc2 = Convert.ToInt32(Console.ReadLine());
                            
                            switch (opc2)

                            {
                                case 1:
                                    EC.get();
                                    Console.ReadKey();
                                    break;


                                case 2:
                                    Console.WriteLine("Ingrese ID");
                                    id = Convert.ToInt32(Console.ReadLine());
                                    EC.getbyId(id);
                                    Console.ReadKey();
                                    break;

                                case 3:
                                    Console.WriteLine("Ingrese ID");
                                    id = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Ingrese nombre del Empleado");
                                    Nombre = Console.ReadLine();
                                    Console.WriteLine("Ingrese apellidos del Empleado");
                                    Apellidos = Console.ReadLine();
                                    Console.WriteLine("Ingrese direccion del Empleado");
                                    Direcccion = Console.ReadLine();
                                    Console.WriteLine("Ingrese telefono del Empleado");
                                    Telefono = Console.ReadLine();
                                    Console.WriteLine("Ingrese Fecha de ingreso del Empleado");
                                    fecha_ing = DateTime.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese el ID Area del Empleado");
                                    IdArea = int.Parse(Console.ReadLine());
                                    EC.post(id, Nombre,Apellidos,Direcccion,Telefono,fecha_ing,IdArea );
                                    
                                    Console.ReadKey();

                                    break;

                                case 4:
                                    Console.WriteLine("Ingrese ID");
                                    id = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Ingrese nombre del Empleado");
                                    Nombre = Console.ReadLine();
                                    Console.WriteLine("Ingrese apellidos del Empleado");
                                    Apellidos = Console.ReadLine();
                                    Console.WriteLine("Ingrese direccion del Empleado");
                                    Direcccion = Console.ReadLine();
                                    Console.WriteLine("Ingrese telefono del Empleado");
                                    Telefono = Console.ReadLine();
                                    Console.WriteLine("Ingrese Fecha de ingreso del Empleado");
                                    fecha_ing = DateTime.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese el ID Area del Empleado");
                                    IdArea = int.Parse(Console.ReadLine());
                                    EC.update(id, Nombre, Apellidos, Direcccion, Telefono, fecha_ing, IdArea);
                                    
                                    Console.ReadKey();
                                    break;

                                case 5:
                                    Console.WriteLine("Ingrese ID del registro a eliminar");
                                    id = Convert.ToInt32(Console.ReadLine());
                                    EC.DeletexId(id);
                                    EC.get();
                                    Console.ReadKey();
                                    break;
                                case 6:
                                    Console.WriteLine("bye");
                                    opc2 = 6;
                                    break;
                                default:
                                    Console.WriteLine("opcion incorrecta, eliga otra");
                                    break;
                            }
                        } while (opc2 != 6);
                        break;

                    case 3:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Que Proceso deseas realizar de NOMINA: ");
                            Console.WriteLine("1. Mostrar datos ");
                            Console.WriteLine("2. Mostrar datos por ID ");
                            Console.WriteLine("3. Insertar datos ");
                            Console.WriteLine("4. Actualizar datos ");
                            Console.WriteLine("5. Eliminar datos ");
                            Console.WriteLine("6. Salir ");

                            opc2 = Convert.ToInt32(Console.ReadLine());
                            
                            switch (opc2)

                            {
                                case 1:
                                    NC.get();
                                    Console.ReadKey();
                                    break;


                                case 2:
                                    Console.WriteLine("Ingrese ID");
                                    id = Convert.ToInt32(Console.ReadLine());
                                    NC.getbyId(id);
                                    Console.ReadKey();
                                    break;

                                case 3:
                                    Console.WriteLine("Ingrese ID");
                                    id = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Ingrese Fecha ");
                                    fecha_ing = DateTime.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese el ID del Empleado");
                                    IdEmpleado = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese sueldo");
                                    sueldo = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese dias trabajados");
                                    dias = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese Valor Total de Horas extras");
                                    otros = double.Parse(Console.ReadLine());

                                    NC.post(id, fecha_ing, IdEmpleado, sueldo, dias,otros );
                                    //NC.get();
                                    Console.ReadKey();

                                    break;

                                case 4:
                                    Console.WriteLine("Ingrese ID");
                                    id = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Ingrese Fecha ");
                                    fecha_ing = DateTime.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese el ID del Empleado");
                                    IdEmpleado = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese sueldo");
                                    sueldo = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese dias trabajados");
                                    dias = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese Valor Total de Horas extras");
                                    otros = double.Parse(Console.ReadLine());

                                    NC.update(id, fecha_ing, IdEmpleado, sueldo, dias, otros);
                                    //NC.get();
                                    Console.ReadKey();
                                    break;

                                case 5:
                                    Console.WriteLine("Ingrese ID del registro a eliminar");
                                    id = Convert.ToInt32(Console.ReadLine());
                                    NC.DeletexId(id);
                                   // NC.get();
                                    Console.ReadKey();
                                    break;
                                case 6:
                                    Console.WriteLine("bye");
                                    opc2 = 6;
                                    break;
                                default:
                                    Console.WriteLine("opcion incorrecta, eliga otra");
                                    break;
                            }
                        } while (opc2 != 6);
                        break;
                    case 4:
                        Console.WriteLine("bye");
                        opc = 4;
                        break;

                    default:
                        Console.WriteLine("opcion incorrecta, eliga otra");
                        break;
                }

            } while (opc != 4);
        }
    }
}
        
    

