using CRUDLINQPOO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDLINQPOO.Controllers
{
    class NominaController
    {
        public NominaController()
        {
            Nomina_ = new List<Nomina>();
        }
        private List<Nomina> Nomina_;
        
        

        public List<Nomina> Nomina { get { return Nomina_; } }

        public void LlenarLista()
        { 
            
            Nomina.Clear();
            Nomina.Add(new Nomina()
            
            {
                id = 1,
                fecha = new DateTime(2018, 11, 23),
                IdEmpleado = 1,
                sueldo = 1250000,
                dias = 28,
                otros = 500000
            });

            Nomina.Add(new Nomina()

            {
                id = 2,
                fecha = new DateTime(2020, 08, 13),
                IdEmpleado = 2,
                sueldo = 1100000,
                dias = 30,
                otros = 220000
            });

            Nomina.Add(new Nomina()

            {
                id = 3,
                fecha = new DateTime(2028, 09, 23),
                IdEmpleado = 1,
                sueldo = 1500000,
                dias = 30,
                otros = 600000
            });

           
        }

        #region mostrar_list
        public void get()
        {
            List<Nomina> lista = new List<Nomina>();
            lista.AddRange(from o in Nomina select o);
            
            if (lista.Count > 0)
            {
                foreach (var item in Nomina)
                {
                    item.total_Basico = this.total_basico(item.sueldo, item.dias);
                    item.devengado = this.devengado1(item.sueldo, item.dias, item.otros);

                }
                ImprimirNomi.Imprimir(lista);
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
            List<Nomina> lista = new List<Nomina>();
            lista.AddRange(from o in Nomina where o.id == id select o);
            
            if (lista.Count > 0)
            {
                ImprimirNomi.Imprimir(lista);
            }
            else
            {
                Console.WriteLine("No existe el ID : " + id + "En los registros");
            }
        }
        #endregion motrar_Xid

        #region agregar_elemento
        public void post(int id, DateTime fecha, int IDEmpleado, double sueldo,
            double dias, double otros)

        {
            var verificar = Nomina.Any(i => i.id == id);
            if (!verificar)
            {
                Nomina.Add(new Nomina()
                {
                    id = id,
                    fecha = fecha,
                    IdEmpleado = IDEmpleado,
                    sueldo = sueldo,
                    dias = dias,
                    otros = otros
                });

            }
            else
            {
                Console.WriteLine($"Este ID {id} ya existe");
            }

        }
        #endregion agregar_elemento

        #region actualizar_elemento
        public void update(int id, DateTime fecha, int IDEmpleado, double sueldo,
            double dias, double otros)
        {
            var ReplaceItem = new Nomina
            {
                id = id,
                fecha = fecha,
                IdEmpleado = IDEmpleado,
                sueldo = sueldo,
                dias = dias,
                otros = otros

            };
            var element = Nomina.FirstOrDefault(i => i.id == ReplaceItem.id);
            if (element != null)
            {
                Nomina.Remove(element);
                Nomina.Add(ReplaceItem);
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
            var element = Nomina.FirstOrDefault(i => i.id == id);
            if (element != null)
            {
                Nomina.Remove(element);
                Console.WriteLine("Registro eliminado Correctamente");
            }
            else
            {
                Console.WriteLine("No se encontro el registro");
            }

        }
        #endregion  eliminar_elemento


        public double total_basico (double sueldo, double dia)
        {
            double sueldo_empleado = sueldo;
            double dias = dia;
            double total = sueldo_empleado * (dias / 30d); 
            return total;
        }
        public double devengado1 (double suel, double dia, double otro)
        {
            double total_b;
            double total_d;
            double sueldo_empleado = suel;
            double dias = dia;
            double otros = otro;

            total_b = sueldo_empleado * (dias / 30d);
            total_d = total_b + otros;
            return total_d;

        }
      
        

       
    }
}    
