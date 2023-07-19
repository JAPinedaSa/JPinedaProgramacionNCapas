using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace PL
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool repetir = true;

            while (repetir)
            {
                Console.WriteLine("Por favor Seleccione alguna de las siguientes opciones:\n" +
                    "1. Agregar Usuario \n" +
                    "2. Actualizar Usuario\n" +
                    "3. Eliminar Usuario \n" +
                    "4. SALIR\n"
                    );
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\n Ingresa los datos de la Aseguradpra que deseas Ingresar: \n");
                        PL.ConsumoServicios.Add();

                        break;
                    case 2:
                        Console.WriteLine("Ingresa los datos de la Aseguradpra que deseas Modificar: \n");
                        PL.ConsumoServicios.Update();
                        break;
                    case 3:
                        Console.WriteLine("Ingresa los datos de la Aseguradpra que deseas Eliminar: \n");
                        PL.ConsumoServicios.Delete();

                        break;
                    case 4:
                        repetir = false;
                        break;

                    default:
                        Console.WriteLine("La opcion seleccionada no se encuentra dentro del menu, favor de rectificar");
                        Console.Clear();
                        break;
                }
            }





            //bool repetir = true;

            //while (repetir)
            //{
            //    Console.WriteLine("Por favor Seleccione alguna de las siguientes opciones:\n" +
            //        "1. Agregar Usuario \n" +
            //        "2. Actualizar Usuario\n" +
            //        "3. Eliminar Usuario \n" +
            //        "4. Mostrar Registros\n"+
            //        "5. Mostrar Registro de un Usuario \n" +
            //        "6. Agregar Aseguradora \n" +
            //        "7. Modificar Aseguradora  \n" +
            //        "8. Eliminar Aseguradora \n" +
            //        "9. Mostrar Aseguradoras \n" +
            //        "10. Mostrar Registro de una Aseguradora \n" +
            //        "11. SALIR\n"
            //        );
            //    int opcion = int.Parse(Console.ReadLine());
            //    switch (opcion)
            //    {
            //        case 1:
            //            Console.WriteLine("\n Ingresa los datos del Usuario que deseas Ingresar: \n");
            //            PL.Usuario.Add();

            //            break;
            //        case 2:
            //            Console.WriteLine("Ingresa los datos del Usuario que deseas Modificar: \n");
            //            PL.Usuario.Update();
            //            break;
            //        case 3:
            //            Console.WriteLine("Ingresa los datos del Usuario que deseas Eliminar: \n");
            //            PL.Usuario.Delete();

            //            break;

            //        case 4:
            //            Console.WriteLine("Los datos de la base de datos son: \n");
            //            PL.Usuario.GetAll();

            //            break;
            //        case 5:
            //            Console.WriteLine("Los datos del usuario son: \n");
            //            PL.Usuario.GetById();

            //            break;
            //        case 6:
            //            Console.WriteLine("Ingresa los datos de la Aseguradora que deseas Ingresar: \n");
            //            PL.Aseguradora.Add();

            //            break;
            //        case 7:
            //            Console.WriteLine("Ingresa los datos del Usuario que deseas Eliminar: \n");
            //            PL.Aseguradora.Update();

            //            break;
            //        case 8:
            //            Console.WriteLine("Los datos de la base de datos son: \n");
            //            PL.Aseguradora.Delete();

            //            break;

            //        case 9:
            //            Console.WriteLine("Los datos de la base de datos son: \n");
            //            PL.Aseguradora.GetAll();

            //            break;

            //        case 10:
            //            Console.WriteLine("Los datos de la base de datos son: \n");
            //            PL.Aseguradora.GetById();

            //            break;


            //        case 11:
            //            repetir = false;
            //            break;

            //        default:
            //            Console.WriteLine("La opcion seleccionada no se encuentra dentro del menu, favor de rectificar");
            //            Console.Clear();
            //            break;
            //    }
            //}


        }
    }
}
