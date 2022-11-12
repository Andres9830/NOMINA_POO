using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDLINQPOO.Controllers
{
    public class EmpleadosController
    {
        public EmpleadosController()
        {
            Empleado_ = new List<Empleados>();
        }   
        private List<Empleados> Empleado_;
        public List<Empleados> Empleados { get { return Empleado_; } }

        //Metodo Llenar Lista
        public void LlenarLista()
        {
            Empleados.Clear();
            Empleados.Add(new Empleados()
            {
                id = 1,
                nombre = "Rafael'",
                apellidos = "Orosco",
                direccion = "Kall 40",
                telefono = "3124354673",
                fecha_ing = new DateTime (2018/11/23),
                IdArea = 1
            });
            Empleados.Add(new Empleados()
            {
                id = 2,
                nombre = "Duque",
                apellidos = "Nuñes",
                direccion = "Call 42-4",
                telefono = "3112344673",
                fecha_ing = new DateTime(2020/ 01/ 03),
                IdArea = 2
            });
            Empleados.Add(new Empleados()
            {
                id = 3,
                nombre = "Daniel",
                apellidos = "Rodriguez",
                direccion = "Cll 12B",
                telefono = "3102343673",
                fecha_ing = new DateTime(2010/ 01/ 03),
                IdArea = 3
            });

        }
        #region mostrar_list
        public void get()
        {
            List<Empleados> lista = new List<Empleados>();
            lista.AddRange(from o in Empleados select o);
            
            if (lista.Count > 0)
            {
                ImprimirEmple.Imprimir(lista);
            }
            else
            {
                Console.WriteLine("[]");
            }
        }
        #endregion mostrar_list

        #region motrar_Xid
        public void getbyId(int id)
        {
            List<Empleados> lista = new List<Empleados>();
            lista.AddRange(from o in Empleados where o.id == id select o);
            
            if (lista.Count > 0)
            {
                ImprimirEmple.Imprimir(lista);
            }
            else
            {
                Console.WriteLine("No existe el ID : " + id + "En los registros");
            }
        }
        #endregion motrar_Xid

        #region agregar_elemento
        public void post(int id, string nombre, string apellidos, string direccion,
            string telefono, DateTime fecha, int IdArea )
        {
            var verificar = Empleados.Any(i => i.id == id);
            if (!verificar)
            {
                Empleados.Add(new Empleados()
                {
                    id = id,
                    nombre = nombre,
                    apellidos = apellidos,
                    direccion = direccion,
                    telefono = telefono,
                    fecha_ing = fecha,
                    IdArea = IdArea
                });

            }
            else
            {
                Console.WriteLine($"Este ID {id} ya existe");
            }

        }
        #endregion agregar_elemento

        #region actualizar_elemento
        public void update(int id, string nombre, string apellidos, string direccion,
            string telefono, DateTime fecha, int IdArea)
        {
            var ReplaceItem = new Empleados
            {
                id = id,
                nombre = nombre,
                apellidos = apellidos,
                direccion = direccion,
                telefono = telefono,
                fecha_ing = fecha,
                IdArea = IdArea

            };
            var element = Empleados.FirstOrDefault(i => i.id == ReplaceItem.id);
            if (element != null)
            {
                Empleados.Remove(element);
                Empleados.Add(ReplaceItem);
                Console.WriteLine("Registro actualizado Correctamente");
            }
            else
            {
                Console.WriteLine("No se encontro el registro");
            }


        }
        #endregion  actualizar_elemento

        #region eliminar_elemento
        public void DeletexId(int id)
        {
            //var EliminarItem = new Productos { id = id };
            var element = Empleados.FirstOrDefault(i => i.id == id);
            if (element != null)
            {
                Empleados.Remove(element);
                Console.WriteLine("Registro eliminado Correctamente");
            }
            else
            {
                Console.WriteLine("No se encontro el registro");
            }

        }
        #endregion  eliminar_elemento

    }

}
   