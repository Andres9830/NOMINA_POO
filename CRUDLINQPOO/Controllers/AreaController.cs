using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDLINQPOO.Controllers
{
    class AreaController
    {
        public AreaController()
        {
            _Area = new List<Area>();
        }
        private List<Area> _Area;
        public List<Area> Area { get { return _Area; } }


        #region LLENAR_LISTA
        public void LlenarLista()
        {
            Area.Clear();
            Area.Add(new Area()
            {
                id = 1,
                nombre_area = "Administrativa"

            });
            Area.Add(new Area()
            {
                id = 2,
                nombre_area = "Recursos Humanos"
            });
            Area.Add(new Area()
            {
                id = 3,
                nombre_area = "Sistemas"
            });
        }
        #endregion LLENAR_LISTA
        
        #region mostrar_list
        public void get()
        {
            List<Area> lista = new List<Area>();
            lista.AddRange(from o in Area select o);
            
            if (lista.Count > 0)
            {
                ImprimirArea.Imprimir(lista);
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
            List<Area> lista = new List<Area>();
            lista.AddRange(from o in Area where o.id == id select o);
            
            if (lista.Count > 0)
            {
                ImprimirArea.Imprimir(lista);
            }
            else
            {
                Console.WriteLine("No existe el ID : "+ id + "En los registros");
            }
        }
        #endregion motrar_Xid

        #region agregar_elemento
        public void post(int id, string nombre)
        {
            var verificar = Area.Any(i => i.id == id);
            if (!verificar)
            {
                Area.Add(new Area()
                {
                    id = id,
                    nombre_area = nombre
                });
                
            }
            else
            {
                Console.WriteLine($"Este ID {id} Ya esxiste");
            }
                
        }
        #endregion agregar_elemento
       
        #region actualizar_elemento
        public void update(int id, string nombre)
        {
            var ReplaceItem = new Area
            {
                id = id,
                nombre_area = nombre,
                
            };
            var element = Area.FirstOrDefault(i => i.id == ReplaceItem.id);
            if(element != null)
            {
                Area.Remove(element);
                Area.Add(ReplaceItem);
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
            var element = Area.FirstOrDefault(i => i.id == id);
            if (element != null)
            {
                Area.Remove(element);
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
