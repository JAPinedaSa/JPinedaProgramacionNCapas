using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public  class ConsumoServicios
    {
        public static void Add()
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();
            Console.WriteLine("Ingresa el nombre de la aseguradora");
            aseguradora.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa el Id del Usuario Encargado");
            aseguradora.Usuario = new ML.Usuario();
            aseguradora.Usuario.IdUsuario = int.Parse(Console.ReadLine());

            ServiceAseguradora.ServiceAseguradoraClient aseguradoraAdd = new ServiceAseguradora.ServiceAseguradoraClient();
            ML.Result result = aseguradoraAdd.Add(aseguradora);

            if (result.Correct)
            {
                Console.WriteLine( "La Aseguradora a sido agregada con exito");
            }
            else
            {
                Console.WriteLine("Ocurrió un error" + result.ErrorMessage);
                Console.ReadKey();
            }
        }
        public static void Update()
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();
            Console.WriteLine("Ingrese el Id de la Aseguradora");
            aseguradora.IdAseguradora = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Nuevo Nombre de la Aseguradora");
            aseguradora.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa el Id del nuevo usuario");
            aseguradora.Usuario = new ML.Usuario();
            aseguradora.Usuario.IdUsuario = int.Parse(Console.ReadLine());

            ServiceAseguradora.ServiceAseguradoraClient aseguradoraUpdate = new ServiceAseguradora.ServiceAseguradoraClient();
            ML.Result result = aseguradoraUpdate.Update(aseguradora);

            if (result.Correct)
            {
                Console.WriteLine("La Aseguradora a sido Modificada con exito");
            }
            else
            {
                Console.WriteLine("Ocurrió un error" + result.ErrorMessage);
                Console.ReadKey();
            }
        }
        public static void Delete()
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();
            Console.WriteLine("Ingresa el Id de la Aseguradora que deseas eliminar");
            aseguradora.IdAseguradora = int.Parse(Console.ReadLine());

            ServiceAseguradora.ServiceAseguradoraClient aseguradoraDelete = new ServiceAseguradora.ServiceAseguradoraClient();
            ML.Result result = aseguradoraDelete.Delete(aseguradora);
            if (result.Correct)
            {
                Console.WriteLine("La Aseguradora a sido Eliminada con exito");
            }
            else
            {
                Console.WriteLine("Ocurrió un error" + result.ErrorMessage);
                Console.ReadKey();
            }
        }

        public static void GetAll()
        {

        }

        public static void GetById()
        {

        }
    }
}
