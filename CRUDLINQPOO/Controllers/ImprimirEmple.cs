using System;
using System.Collections.Generic;
using System.Text;

namespace CRUDLINQPOO.Controllers
{
    class ImprimirEmple
    {
        public static void Imprimir(List<Empleados> Empleados)
        {
            foreach (var item in Empleados)
            {
                
                Console.WriteLine("\nid: {0} \nnombre: {1} \napellido: {2} \ndireccion: {3} \ntelefono: {4} \nfecha_ing: {5} \nIdArea: {6}"
                    , item.id, item.nombre, item.apellidos, item.direccion, item.telefono, item.fecha_ing, item.IdArea);
            }
        }

    
    }
}
