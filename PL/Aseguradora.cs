using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Aseguradora
    {
        public static void Add()
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();
            Console.WriteLine("Por favor Ingresa el Nombre");
            aseguradora.Nombre = Console.ReadLine();
            Console.WriteLine("Digite la Fecha de Creacion");
            aseguradora.FechaCreacion = Console.ReadLine();
            Console.WriteLine("Digite la Fecha de Modificacion");
            aseguradora.FechaModificacion = Console.ReadLine();
            aseguradora.Usuario = new ML.Usuario();
            Console.WriteLine("El Id del Usuario");
            aseguradora.Usuario.IdUsuario = int.Parse(Console.ReadLine());

            ML.Result result = BL.Aseguradora.AddLINQ(aseguradora);

            if (result.Correct)
            {
                Console.WriteLine("La Aseguradora ha sido Agregada con éxito");
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
            Console.WriteLine("Ingrese el Id de la Aseguradora que desea Actualizar");
            aseguradora.IdAseguradora = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor Ingresa el Nombre");
            aseguradora.Nombre = Console.ReadLine();
            Console.WriteLine("Digite la Fecha de Creacion");
            aseguradora.FechaCreacion = Console.ReadLine();
            Console.WriteLine("Digite la Fecha de Modificacion");
            aseguradora.FechaModificacion = Console.ReadLine();
            aseguradora.Usuario = new ML.Usuario();
            Console.WriteLine("El Id del Usuario");
            aseguradora.Usuario.IdUsuario = int.Parse(Console.ReadLine());

            ML.Result result = BL.Aseguradora.Update(aseguradora);

            if (result.Correct)
            {
                Console.WriteLine("La aseguradora ha sido actuaizada con éxito");
            }
            else
            {
                Console.WriteLine("Ocurrió un error" + result.ErrorMessage);
                Console.ReadKey();
            }
        }

        //public static void Delete()
        //{
        //    ML.Aseguradora aseguradora = new ML.Aseguradora();

        //    Console.WriteLine("Ingresa el IdUsuario de la Aseguradora que deseas Eliminar: ");
        //    aseguradora.IdAseguradora = Int32.Parse(Console.ReadLine());

        //    ML.Result result = BL.Aseguradora.Delete(aseguradora);

        //    if (result.Correct)
        //    {
        //        Console.WriteLine("La Aseguradora fue Eliminada con éxito");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Ocurrió un error" + result.ErrorMessage);
        //        Console.ReadKey();
        //    }
        //}

        public static void GetAll()
        {
            ML.Result result = BL.Aseguradora.GetAllLINQ();
            if (result.Correct)
            {
                foreach (ML.Aseguradora aseguradora in result.Objects)
                {
                    Console.WriteLine("Id Aseguradora" + " " + aseguradora.IdAseguradora);
                    Console.WriteLine("Nombre:" + " " + aseguradora.Nombre);
                    Console.WriteLine("Fecha de Cracion:" + " " + aseguradora.FechaCreacion);
                    Console.WriteLine("Fecha de Modificacion:" + " " + aseguradora.FechaModificacion);
                    Console.WriteLine("Id Usuario:" + " " + aseguradora.Usuario.IdUsuario);
                    Console.WriteLine("Id Nombre:" + " " + aseguradora.Usuario.Nombre);
                }
            }
            else
            {
                Console.WriteLine("Ocurrió un error:" + " " + result.ErrorMessage);
                Console.ReadKey();
            }
        }

        public static void GetById()
        {
            Console.WriteLine("Ingresa el Id del usuario al que deseas mostrar ");
            int IdAseguradora = int.Parse(Console.ReadLine());
            ML.Result result = BL.Aseguradora.GetByIdLINQ(IdAseguradora);
            
            if (result.Correct)
            {
                ML.Aseguradora aseguradora = (ML.Aseguradora)result.Object;
                Console.WriteLine("Id Aseguradora" + " " + aseguradora.IdAseguradora);
                Console.WriteLine("Nombre:" + " " + aseguradora.Nombre);
                Console.WriteLine("Fecha de Cracion:" + " " + aseguradora.FechaCreacion);
                Console.WriteLine("Fecha de Modificacion:" + " " + aseguradora.FechaModificacion);
                Console.WriteLine("Id Usuario:" + " " + aseguradora.Usuario.IdUsuario);
                Console.WriteLine("Id Nombre:" + " " + aseguradora.Usuario.Nombre); ;

            }
            else
            {
                Console.WriteLine("Ocurrió un error:" + " " + result.ErrorMessage);
                Console.ReadKey();
            }

        }
    }
}
