using System;

namespace PL
{
    internal class Usuario
    {
        // Add, Update, Delete, GetAll, GetById
        
        public static void Add()
        {
            ML.Usuario usuario = new ML.Usuario();
            Console.WriteLine("Ingresa Tu Nombre(s): ");
            usuario.Nombre = Console.ReadLine();

            Console.WriteLine("Ingresa Tu Apellido Paterno:");
            usuario.ApellidoPaterno = Console.ReadLine();

            Console.WriteLine("Ingresa Tu Apellido Materno: ");
            usuario.ApellidoMaterno = Console.ReadLine();

            

            Console.WriteLine("Ingresa Tu Correo: ");
            usuario.Correo = Console.ReadLine();

            Console.WriteLine("Ingresa el Rol ");
            usuario.Rol = new ML.Rol();
            usuario.Rol.IdRol = int.Parse(Console.ReadLine()); 
            
            Console.WriteLine("Ingresa el User Name ");
            usuario.UserName = Console.ReadLine();

            Console.WriteLine("Ingresa La contraseña");
            usuario.Password = Console.ReadLine();

            Console.WriteLine("Ingresa tu Fecha de Nacimiento");
            usuario.FechaNacimiento = Console.ReadLine();

            Console.WriteLine("Ingresa tu Sexo");
            usuario.Sexo = Console.ReadLine();

            Console.WriteLine("Ingresa tu Numero de Telefono");
            usuario.Telefono = Console.ReadLine();

            Console.WriteLine("Ingresa tu Numero de Celular");
            usuario.Celular = Console.ReadLine();

            Console.WriteLine("Ingresa tu CURP");
            usuario.CURP = Console.ReadLine();

            ML.Result result = BL.Usuario.AddLINQ(usuario);
            

            // BL.Usuario.Add(usuario);

            if (result.Correct)
            {
                Console.WriteLine("El usuario fue agregado con éxito");
            }
            else
            {
                Console.WriteLine("Ocurrió un error" + result.ErrorMessage);
                Console.ReadKey();
            }
        }
        public static void Update()
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Ingresa el IdUsuario del usuario que deseas modificar: ");
            usuario.IdUsuario = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa Tu Nombre(s): ");
            usuario.Nombre = Console.ReadLine();

            Console.WriteLine("Ingresa Tu Apellido Paterno:");
            usuario.ApellidoPaterno = Console.ReadLine();

            Console.WriteLine("Ingresa Tu Apellido Materno: ");
            usuario.ApellidoMaterno = Console.ReadLine();

            Console.WriteLine("Ingresa Tu Correo: ");
            usuario.Correo = Console.ReadLine();

            Console.WriteLine("Ingresa el Rol ");
            usuario.Rol = new ML.Rol();
            usuario.Rol.IdRol = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el User Name ");
            usuario.UserName = Console.ReadLine();

            Console.WriteLine("Ingresa La contraseña");
            usuario.Password = Console.ReadLine();

            Console.WriteLine("Ingresa tu Fecha de Nacimiento");
            usuario.FechaNacimiento = Console.ReadLine();

            Console.WriteLine("Ingresa tu Sexo");
            usuario.Sexo = Console.ReadLine();

            Console.WriteLine("Ingresa tu Numero de Telefono");
            usuario.Telefono = Console.ReadLine();

            Console.WriteLine("Ingresa tu Numero de Celular");
            usuario.Celular = Console.ReadLine();

            Console.WriteLine("Ingresa tu CURP");
            usuario.CURP = Console.ReadLine();

            ML.Result result = BL.Usuario.UpdateLINQ(usuario);

            // BL.Usuario.Add(usuario);


            if (result.Correct)
            {
                Console.WriteLine("El usuario fue modificado  con éxito");
            }
            else
            {
                Console.WriteLine("Ocurrió un error" + result.ErrorMessage);
                Console.ReadKey();
            }

        }
        public static void Delete()
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Ingresa el IdUsuario del usuario que deseas Eliminar: ");
            usuario.IdUsuario = Int32.Parse(Console.ReadLine());

            ML.Result result = BL.Usuario.DeleteEF(usuario);

            // BL.Usuario.Add(usuario);


            if (result.Correct)
            {
                Console.WriteLine("El usuario fue Eliminado  con éxito");
            }
            else
            {
                Console.WriteLine("Ocurrió un error" + result.ErrorMessage);
                Console.ReadKey();
            }

        }
        public static void GetAll()
        {
                                   
            ML.Result result = BL.Usuario.GetAllLINQ();

            if (result.Correct)
            {
                foreach (ML.Usuario usuario in result.Objects)
                {
                    Console.WriteLine("Id Usuario"+ " " + usuario.IdUsuario );
                    Console.WriteLine("Nombre:" + " " +  usuario.Nombre );
                    Console.WriteLine("Apellido Paterno:" + " " + usuario.ApellidoPaterno );
                    Console.WriteLine("Apellido Materno:" + " " + usuario.ApellidoMaterno );
                    Console.WriteLine("Correo: " + " " + usuario.Correo );
                    Console.WriteLine("Id Rol: " + " " + usuario.Rol.IdRol );
                    Console.WriteLine("Username: " + " " + usuario.UserName );
                    Console.WriteLine("Fecha de Nacimiento: " + " " + usuario.FechaNacimiento);
                    Console.WriteLine("Sexo: " + " " + usuario.Sexo);
                    Console.WriteLine("Telefono: " + " " + usuario.Telefono);
                    Console.WriteLine("Celular: " + " " + usuario.Celular);
                    Console.WriteLine("CURP: " + " " + usuario.CURP);
                    Console.WriteLine("Password: " + " " + usuario.Password + "\n\n");
                    
                }
            }
            else
            {
                Console.WriteLine("Ocurrió un error:"+ " " + result.ErrorMessage);
                Console.ReadKey();
            }

        }
        public static void GetById()
        {
            Console.WriteLine("Ingresa el Id del usuario al que deseas mostrar ");
            int IdUsuario = int.Parse(Console.ReadLine());
            ML.Result result = BL.Usuario.GetByIdLINQ(IdUsuario);
            //ML.Result result = BL.Usuario.GetById(usuario);
            if (result.Correct)
            {
                ML.Usuario usuario = (ML.Usuario)result.Object;
                Console.WriteLine("Id Usuario" + " " + usuario.IdUsuario);
                Console.WriteLine("Nombre:" + " " + usuario.Nombre);
                Console.WriteLine("Apellido Paterno:" + " " + usuario.ApellidoPaterno);
                Console.WriteLine("Apellido Materno:" + " " + usuario.ApellidoMaterno);
                
                Console.WriteLine("Correo: " + " " + usuario.Correo);
                Console.WriteLine("Id Rol: " + " " + usuario.Rol.IdRol);
                Console.WriteLine("Username: " + " " + usuario.UserName);
                Console.WriteLine("Fecha de Nacimiento: " + " " + usuario.FechaNacimiento);
                Console.WriteLine("Sexo: " + " " + usuario.Sexo);
                Console.WriteLine("Telefono: " + " " + usuario.Telefono);
                Console.WriteLine("Celular: " + " " + usuario.Celular);
                Console.WriteLine("CURP: " + " " + usuario.CURP);
                Console.WriteLine("Password: " + " " + usuario.Password + "\n\n");
                

            }
            else
            {
                Console.WriteLine("Ocurrió un error:" + " " + result.ErrorMessage);
                Console.ReadKey();
            }
          
        }






        //public static void SpAdd()
        //{
        //    ML.Usuario usuario = new ML.Usuario();
        //    Console.WriteLine("Ingresa Tu Nombre(s): ");
        //    usuario.Nombre = Console.ReadLine();

        //    Console.WriteLine("Ingresa Tu Apellido Paterno:");
        //    usuario.ApellidoPaterno = Console.ReadLine();

        //    Console.WriteLine("Ingresa Tu Apellido Materno: ");
        //    usuario.ApellidoMaterno = Console.ReadLine();

        //    Console.WriteLine("Ingresa Tu Edad(s):");
        //    usuario.Edad = Int32.Parse(Console.ReadLine());

        //    Console.WriteLine("Ingresa Tu Correo: ");
        //    usuario.Correo = Console.ReadLine();

        //    Console.WriteLine("Ingresa el Rol ");
        //    usuario.IdRol = int.Parse(Console.ReadLine());



        //    ML.Result result = BL.Usuario.SpAdd(usuario);

        //    // BL.Usuario.Add(usuario);

        //    if (result.Correct)
        //    {
        //        Console.WriteLine("El usuario fue agregado con éxito");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Ocurrió un error" + result.ErrorMessage);
        //        Console.ReadKey();
        //    }
        //}

        //public static void SpUpdate()
        //{
        //    ML.Usuario usuario = new ML.Usuario();

        //    Console.WriteLine("Ingresa el IdUsuario del usuario que deseas modificar: ");
        //    usuario.IdUsuario = Int32.Parse(Console.ReadLine());

        //    Console.WriteLine("Ingresa Tu Nombre(s): ");
        //    usuario.Nombre = Console.ReadLine();

        //    Console.WriteLine("Ingresa Tu Apellido Paterno:");
        //    usuario.ApellidoPaterno = Console.ReadLine();

        //    Console.WriteLine("Ingresa Tu Apellido Materno: ");
        //    usuario.ApellidoMaterno = Console.ReadLine();

        //    Console.WriteLine("Ingresa Tu Edad(s):");
        //    usuario.Edad = Int32.Parse(Console.ReadLine());

        //    Console.WriteLine("Ingresa Tu Correo: ");
        //    usuario.Correo = Console.ReadLine();

        //    Console.WriteLine("Ingresa el Rol ");
        //    usuario.IdRol = int.Parse(Console.ReadLine());

        //    ML.Result result = BL.Usuario.SpUpdate(usuario);

        //    // BL.Usuario.Add(usuario);


        //    if (result.Correct)
        //    {
        //        Console.WriteLine("El usuario fue modificado  con éxito");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Ocurrió un error" + result.ErrorMessage);
        //        Console.ReadKey();
        //    }

        //}
        //public static void SpDelete()
        //{
        //    ML.Usuario usuario = new ML.Usuario();

        //    Console.WriteLine("Ingresa el IdUsuario del usuario que deseas Eliminar: ");
        //    usuario.IdUsuario = Int32.Parse(Console.ReadLine());

        //    ML.Result result = BL.Usuario.SpDelete(usuario);

        //    // BL.Usuario.Add(usuario);


        //    if (result.Correct)
        //    {
        //        Console.WriteLine("El usuario fue Eliminado  con éxito");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Ocurrió un error" + result.ErrorMessage);
        //        Console.ReadKey();
        //    }

        //}

        //public static void SpGetAll()
        //{
        //    ML.Result result = BL.Usuario.SpGetAll();

        //    if (result.Correct)
        //    {
        //        foreach (ML.Usuario usuario in result.Objects)
        //        {
        //            Console.WriteLine("Id Usuario" + " " + usuario.IdUsuario);
        //            Console.WriteLine("Nombre:" + " " + usuario.Nombre);
        //            Console.WriteLine("Apellido Paterno:" + " " + usuario.ApellidoPaterno);
        //            Console.WriteLine("Apellido Materno:" + " " + usuario.ApellidoMaterno);
        //            Console.WriteLine("Edad: " + " " + usuario.Edad);
        //            Console.WriteLine("Correo: " + " " + usuario.Correo + "\n");
        //            Console.WriteLine("IdRol: " + " " + usuario.IdRol + "\n\n");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Ocurrió un error:" + " " + result.ErrorMessage);
        //        Console.ReadKey();
        //    }
        //}

        //public static void SpGetById()
        //{
        //    Console.WriteLine("Ingresa el Id del usuario al que deseas mostrar ");
        //    int IdUsuario = int.Parse(Console.ReadLine());
        //    ML.Result result = BL.Usuario.SpGetById(IdUsuario);


        //    //ML.Result result = BL.Usuario.GetById(usuario);
        //    if (result.Correct)
        //    {
        //        ML.Usuario usuario = (ML.Usuario)result.Object;
        //        Console.WriteLine("Id Usuario" + " " + usuario.IdUsuario);
        //        Console.WriteLine("Nombre:" + " " + usuario.Nombre);
        //        Console.WriteLine("Apellido Paterno:" + " " + usuario.ApellidoPaterno);
        //        Console.WriteLine("Apellido Materno:" + " " + usuario.ApellidoMaterno);
        //        Console.WriteLine("Edad: " + " " + usuario.Edad);
        //        Console.WriteLine("Correo: " + " " + usuario.Correo);
        //        Console.WriteLine("IdRol: " + " " + usuario.IdRol + "\n\n");

        //    }
        //    else
        //    {
        //        Console.WriteLine("Ocurrió un error:" + " " + result.ErrorMessage);
        //        Console.ReadKey();
        //    }

        //}
        


    }
}
