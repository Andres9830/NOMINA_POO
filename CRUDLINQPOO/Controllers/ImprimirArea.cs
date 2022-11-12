using System;
using System.Collections.Generic;
using System.Text;

namespace CRUDLINQPOO.Controllers
{
    public static class ImprimirArea
    {
        public static void Imprimir(List<Area> Area)
        {
            foreach (var item in Area)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("\n id: {0}  \n Nombre_area: {1}  ", item.id, item.nombre_area );
            }
        }

    }

}
