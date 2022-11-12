using CRUDLINQPOO.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUDLINQPOO.Controllers
{
    class ImprimirNomi
    {
        public static void Imprimir(List<Nomina> Nomina)
        {
            foreach (var item in Nomina)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine
                    ("\nid: {0} \nfecha: {1} \nIdEmpleado: {2} \nsueldo: {3} \ndias: {4} \ntotal_Basico: {5} \notros: {6} \ndevengado: {7}  "
                    , item.id, item.fecha, item.IdEmpleado, item.sueldo, item.dias, item.total_Basico, item.otros, item.devengado);
            }
        }
    }
}
