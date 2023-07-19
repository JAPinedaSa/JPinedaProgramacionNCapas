using System;
using System.Collections.Generic;
using System.Linq;

namespace BL
{
    public class Usuario
    {
        // Add, Update, Delete, GetAll, GetById

        //public static ML.Result Add(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();


        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "INSERT INTO [Usuario]([Nombre],[ApellidoPaterno],[ApellidoMaterno],[Edad],[Correo],[IdRol])VALUES(@Nombre,@ApellidoPaterno,@ApellidoMaterno,@Edad,@Correo,@IdRol)";
        //            using (SqlCommand cmd = new SqlCommand())
        //            {
        //                cmd.CommandText = query;
        //                cmd.Connection = context;

        //                // Arreglo para almacenar los datos que fueron solicitados
        //                SqlParameter[] collection = new SqlParameter[6];

        //                collection[0] = new SqlParameter("Nombre", SqlDbType.VarChar);
        //                collection[0].Value = usuario.Nombre;

        //                collection[1] = new SqlParameter("ApellidoPaterno", SqlDbType.VarChar);
        //                collection[1].Value = usuario.ApellidoPaterno;

        //                collection[2] = new SqlParameter("ApellidoMaterno", SqlDbType.VarChar);
        //                collection[2].Value = usuario.ApellidoMaterno;

        //                collection[3] = new SqlParameter("Edad", SqlDbType.VarChar);
        //                collection[3].Value = usuario.Edad;

        //                collection[4] = new SqlParameter("Correo", SqlDbType.VarChar);
        //                collection[4].Value = usuario.Correo;

        //                collection[5] = new SqlParameter("IdRol", SqlDbType.VarChar);
        //                collection[5].Value = usuario.IdRol;

        //                cmd.Parameters.AddRange(collection);

        //                cmd.Connection.Open();

        //                int RowsAffected = cmd.ExecuteNonQuery(); //0 -no se insertó //>=1 se insertó

        //                if (RowsAffected >= 1)
        //                {
        //                    result.Correct = true;
        //                }
        //                else
        //                {
        //                    result.Correct = false;
        //                    result.ErrorMessage = "Ocurrió un error al ingresar la materia";
        //                }
        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //    }
        //    return result;


        //}

        //public static ML.Result Update(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();

        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "Update Usuario set Nombre = @Nombre, ApellidoPaterno=@ApellidoPaterno,ApellidoMaterno=@ApellidoMaterno,Edad = @Edad,Correo =@Correo,IdRol = @IdRol where IdUsuario = @IdUsuario;";
        //            using (SqlCommand cmd = new SqlCommand())
        //            {
        //                cmd.CommandText = query;
        //                cmd.Connection = context;

        //                // Arreglo para almacenar los datos que fueron solicitados
        //                SqlParameter[] collection = new SqlParameter[7];

        //                collection[0] = new SqlParameter("IdUsuario", SqlDbType.VarChar);
        //                collection[0].Value = usuario.IdUsuario;

        //                collection[1] = new SqlParameter("Nombre", SqlDbType.VarChar);
        //                collection[1].Value = usuario.Nombre;

        //                collection[2] = new SqlParameter("ApellidoPaterno", SqlDbType.VarChar);
        //                collection[2].Value = usuario.ApellidoPaterno;

        //                collection[3] = new SqlParameter("ApellidoMaterno", SqlDbType.VarChar);
        //                collection[3].Value = usuario.ApellidoMaterno;

        //                collection[4] = new SqlParameter("Edad", SqlDbType.VarChar);
        //                collection[4].Value = usuario.Edad;

        //                collection[5] = new SqlParameter("Correo", SqlDbType.VarChar);
        //                collection[5].Value = usuario.Correo;

        //                collection[6] = new SqlParameter("IdRol", SqlDbType.VarChar);
        //                collection[6].Value = usuario.IdRol;

        //                cmd.Parameters.AddRange(collection);

        //                cmd.Connection.Open();

        //                int RowsAffected = cmd.ExecuteNonQuery(); //0 -no se insertó //>=1 se insertó

        //                if (RowsAffected >= 1)
        //                {
        //                    result.Correct = true;
        //                }
        //                else
        //                {
        //                    result.Correct = false;
        //                    result.ErrorMessage = "Ocurrió un error al modificar el usuario";
        //                }
        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //    }
        //    return result;

        //}

        //public static ML.Result Delete(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();

        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "Delete  from Usuario where IdUsuario = @IdUsuario;";
        //            using (SqlCommand cmd = new SqlCommand())
        //            {
        //                cmd.CommandText = query;
        //                cmd.Connection = context;

        //                // Arreglo para almacenar los datos que fueron solicitados
        //                SqlParameter[] collection = new SqlParameter[1];

        //                collection[0] = new SqlParameter("IdUsuario", SqlDbType.VarChar);
        //                collection[0].Value = usuario.IdUsuario;



        //                cmd.Parameters.AddRange(collection);

        //                cmd.Connection.Open();

        //                int RowsAffected = cmd.ExecuteNonQuery(); //0 -no se insertó //>=1 se insertó

        //                if (RowsAffected >= 1)
        //                {
        //                    result.Correct = true;
        //                }
        //                else
        //                {
        //                    result.Correct = false;
        //                    result.ErrorMessage = "Ocurrió un error al Eliminar el usuario";
        //                }
        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //    }
        //    return result;

        //}


        //public static ML.Result GetAll()
        //{

        //    ML.Result result = new ML.Result();

        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "Select IdUsuario, Nombre, ApellidoPaterno, ApellidoMaterno,Edad,Correo,IdRol From Usuario;";
        //            using (SqlCommand cmd = new SqlCommand())
        //            {
        //                cmd.CommandText = query;
        //                cmd.Connection = context;


        //                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
        //                {
        //                    DataTable tablaUsuario = new DataTable("Tabla Usuario");

        //                    da.Fill(tablaUsuario);

        //                    if (tablaUsuario.Rows.Count > 0 )
        //                    {
        //                        result.Objects = new List<object>();
        //                        foreach (DataRow row in tablaUsuario.Rows)
        //                        {
        //                            ML.Usuario usuario = new ML.Usuario();

        //                            usuario.IdUsuario = int.Parse(row[0].ToString());
        //                            usuario.Nombre = row[1].ToString();
        //                            usuario.ApellidoPaterno = row[2].ToString();
        //                            usuario.ApellidoMaterno = row[3].ToString();
        //                            usuario.Edad = int.Parse(row[4].ToString());
        //                            usuario.Correo = row[5].ToString();
        //                            usuario.IdRol = int.Parse(row[6].ToString());
        //                            result.Objects.Add(usuario);
        //                        }
        //                        result.Correct = true;
        //                    }
        //                    else
        //                    {
        //                        result.Correct = false;
        //                        result.ErrorMessage = "No jalo este pedo banda ";
        //                    }


        //                }




        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //    }
        //    return result;

        //}
        //public static ML.Result GetById(int IdUsuario)
        //{

        //    ML.Result result = new ML.Result();

        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "Select  IdUsuario, Nombre, ApellidoPaterno, ApellidoMaterno,Edad,Correo, IdRol from Usuario where IdUsuario = @IdUsuario;";
        //            using (SqlCommand cmd = new SqlCommand())
        //            {
        //                cmd.CommandText = query;
        //                cmd.Connection = context;


        //                SqlParameter[] collection = new SqlParameter[1];

        //                collection[0] = new SqlParameter("IdUsuario", SqlDbType.VarChar);
        //                collection[0].Value = IdUsuario;

        //                cmd.Parameters.AddRange(collection);

        //                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
        //                {
        //                    DataTable tablaUsuario = new DataTable("Tabla Usuario");

        //                    da.Fill(tablaUsuario);

        //                    if (tablaUsuario.Rows.Count > 0)
        //                    {

        //                        DataRow row = tablaUsuario.Rows[0];
        //                        ML.Usuario usuario = new ML.Usuario();
        //                        // Luego para agregar la nueva fila al DataTable, utilizamos la fila y el nombre de la columna.
        //                        usuario.IdUsuario = int.Parse(row[0].ToString());
        //                        usuario.Nombre = row[1].ToString();
        //                        usuario.ApellidoPaterno = row[2].ToString();
        //                        usuario.ApellidoMaterno = row[3].ToString();
        //                        usuario.Edad = int.Parse(row[4].ToString());
        //                        usuario.Correo = row[5].ToString();
        //                        usuario.IdRol = int.Parse(row[6].ToString());

        //                        result.Object = usuario;


        //                        result.Correct = true;
        //                    }
        //                    else
        //                    {
        //                        result.Correct = false;
        //                        result.ErrorMessage = "No jalo este pedo banda ";
        //                    }


        //                }

        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //    }
        //    return result;
        //}

        //// CONSULTAS CON STORED PROCEDURES
        //public static ML.Result SpAdd(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();

        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "UsuarioAdd";
        //            using (SqlCommand cmd = new SqlCommand())
        //            {
        //                cmd.CommandText = query;
        //                cmd.Connection = context;
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                // Arreglo para almacenar los datos que fueron solicitados
        //                SqlParameter[] collection = new SqlParameter[6];

        //                collection[0] = new SqlParameter("Nombre", SqlDbType.VarChar);
        //                collection[0].Value = usuario.Nombre;

        //                collection[1] = new SqlParameter("ApellidoPaterno", SqlDbType.VarChar);
        //                collection[1].Value = usuario.ApellidoPaterno;

        //                collection[2] = new SqlParameter("ApellidoMaterno", SqlDbType.VarChar);
        //                collection[2].Value = usuario.ApellidoMaterno;

        //                collection[3] = new SqlParameter("Edad", SqlDbType.VarChar);
        //                collection[3].Value = usuario.Edad;

        //                collection[4] = new SqlParameter("Correo", SqlDbType.VarChar);
        //                collection[4].Value = usuario.Correo;

        //                collection[5] = new SqlParameter("IdRol", SqlDbType.VarChar);
        //                collection[5].Value = usuario.IdRol;

        //                cmd.Parameters.AddRange(collection);

        //                cmd.Connection.Open();

        //                int RowsAffected = cmd.ExecuteNonQuery(); //0 -no se insertó //>=1 se insertó

        //                if (RowsAffected >= 1)
        //                {
        //                    result.Correct = true;
        //                }
        //                else
        //                {
        //                    result.Correct = false;
        //                    result.ErrorMessage = "Ocurrió un error al ingresar la materia";
        //                }
        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //    }
        //    return result;


        //}

        //public static ML.Result SpUpdate(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();

        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "UsuarioUpdate";
        //            using (SqlCommand cmd = new SqlCommand())
        //            {
        //                cmd.CommandText = query;
        //                cmd.Connection = context;
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                // Arreglo para almacenar los datos que fueron solicitados
        //                SqlParameter[] collection = new SqlParameter[7];

        //                collection[0] = new SqlParameter("IdUsuario", SqlDbType.VarChar);
        //                collection[0].Value = usuario.IdUsuario;

        //                collection[1] = new SqlParameter("Nombre", SqlDbType.VarChar);
        //                collection[1].Value = usuario.Nombre;

        //                collection[2] = new SqlParameter("ApellidoPaterno", SqlDbType.VarChar);
        //                collection[2].Value = usuario.ApellidoPaterno;

        //                collection[3] = new SqlParameter("ApellidoMaterno", SqlDbType.VarChar);
        //                collection[3].Value = usuario.ApellidoMaterno;

        //                collection[4] = new SqlParameter("Edad", SqlDbType.VarChar);
        //                collection[4].Value = usuario.Edad;

        //                collection[5] = new SqlParameter("Correo", SqlDbType.VarChar);
        //                collection[5].Value = usuario.Correo;

        //                collection[6] = new SqlParameter("IdRol", SqlDbType.VarChar);
        //                collection[6].Value = usuario.IdRol;

        //                cmd.Parameters.AddRange(collection);

        //                cmd.Connection.Open();

        //                int RowsAffected = cmd.ExecuteNonQuery(); //0 -no se insertó //>=1 se insertó

        //                if (RowsAffected >= 1)
        //                {
        //                    result.Correct = true;
        //                }
        //                else
        //                {
        //                    result.Correct = false;
        //                    result.ErrorMessage = "Ocurrió un error al modificar el usuario";
        //                }
        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //    }
        //    return result;

        //}

        //public static ML.Result SpDelete(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();

        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "UsuarioDelete";
        //            using (SqlCommand cmd = new SqlCommand())
        //            {
        //                cmd.CommandText = query;
        //                cmd.Connection = context;
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                // Arreglo para almacenar los datos que fueron solicitados
        //                SqlParameter[] collection = new SqlParameter[1];

        //                collection[0] = new SqlParameter("IdUsuario", SqlDbType.VarChar);
        //                collection[0].Value = usuario.IdUsuario;



        //                cmd.Parameters.AddRange(collection);

        //                cmd.Connection.Open();

        //                int RowsAffected = cmd.ExecuteNonQuery(); //0 -no se insertó //>=1 se insertó

        //                if (RowsAffected >= 1)
        //                {
        //                    result.Correct = true;
        //                }
        //                else
        //                {
        //                    result.Correct = false;
        //                    result.ErrorMessage = "Ocurrió un error al Eliminar el usuario";
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //    }


        //    return result;
        //}

        //public static ML.Result SpGetAll()
        //{

        //    ML.Result result = new ML.Result();

        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "UsuarioGetAll";
        //            using (SqlCommand cmd = new SqlCommand())
        //            {
        //                cmd.CommandText = query;
        //                cmd.Connection = context;
        //                cmd.CommandType = CommandType.StoredProcedure;


        //                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
        //                {
        //                    DataTable tablaUsuario = new DataTable("Tabla Usuario");

        //                    da.Fill(tablaUsuario);

        //                    if (tablaUsuario.Rows.Count > 0)
        //                    {
        //                        result.Objects = new List<object>();
        //                        foreach (DataRow row in tablaUsuario.Rows)
        //                        {
        //                            ML.Usuario usuario = new ML.Usuario();

        //                            usuario.IdUsuario = int.Parse(row[0].ToString());
        //                            usuario.Nombre = row[1].ToString();
        //                            usuario.ApellidoPaterno = row[2].ToString();
        //                            usuario.ApellidoMaterno = row[3].ToString();
        //                            usuario.Edad = int.Parse(row[4].ToString());
        //                            usuario.Correo = row[5].ToString();
        //                            result.Objects.Add(usuario);
        //                        }
        //                        result.Correct = true;
        //                    }
        //                    else
        //                    {
        //                        result.Correct = false;
        //                        result.ErrorMessage = "No jalo este pedo banda ";
        //                    }


        //                }

        //                cmd.Connection.Open();


        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //    }
        //    return result;

        //}

        //public static ML.Result SpGetById(int IdUsuario)
        //{
        //    ML.Result result = new ML.Result();

        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "UsuarioGetById";
        //            using (SqlCommand cmd = new SqlCommand())
        //            {
        //                cmd.CommandText = query;
        //                cmd.Connection = context;
        //                cmd.CommandType = CommandType.StoredProcedure;


        //                SqlParameter[] collection = new SqlParameter[1];

        //                collection[0] = new SqlParameter("IdUsuario", SqlDbType.VarChar);
        //                collection[0].Value = IdUsuario;

        //                cmd.Parameters.AddRange(collection);

        //                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
        //                {
        //                    DataTable tablaUsuario = new DataTable("Tabla Usuario");

        //                    da.Fill(tablaUsuario);

        //                    if (tablaUsuario.Rows.Count > 0)
        //                    {

        //                        DataRow row = tablaUsuario.Rows[0];
        //                        ML.Usuario usuario = new ML.Usuario();
        //                        // Luego para agregar la nueva fila al DataTable, utilizamos la fila y el nombre de la columna.
        //                        usuario.IdUsuario = int.Parse(row[0].ToString());
        //                        usuario.Nombre = row[1].ToString();
        //                        usuario.ApellidoPaterno = row[2].ToString();
        //                        usuario.ApellidoMaterno = row[3].ToString();
        //                        usuario.Edad = int.Parse(row[4].ToString());
        //                        usuario.Correo = row[5].ToString();
        //                        usuario.IdRol = int.Parse(row[6].ToString());

        //                        result.Object = usuario;


        //                        result.Correct = true;
        //                    }
        //                    else
        //                    {
        //                        result.Correct = false;
        //                        result.ErrorMessage = "No jalo este pedo banda ";
        //                    }


        //                }

        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //    }
        //    return result;

        //}

        //CONSULTAS CON ENTITY FRAMEWORK

        public static ML.Result AddEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {

                using (DLEF.JPiinedaProgramacionNCapas contex = new DLEF.JPiinedaProgramacionNCapas())
                {
                    int RowsAffected = contex.UsuarioAdd(usuario.Nombre, usuario.ApellidoPaterno,
                        usuario.ApellidoMaterno, usuario.Correo, usuario.Rol.IdRol,
                        usuario.UserName, usuario.FechaNacimiento, usuario.Sexo, usuario.Telefono,
                        usuario.Celular, usuario.CURP, usuario.Password);

                    if (RowsAffected >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Ocurrió un error al ingresar el usuario";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }

            return result;

        }

        public static ML.Result UpdateEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DLEF.JPiinedaProgramacionNCapas contex = new DLEF.JPiinedaProgramacionNCapas())
                {
                    int RowsAffected = contex.UsuarioUpdate(usuario.IdUsuario, usuario.Nombre, usuario.ApellidoPaterno,
                        usuario.ApellidoMaterno, usuario.Correo, usuario.Rol.IdRol,
                        usuario.UserName, usuario.FechaNacimiento, usuario.Sexo, usuario.Telefono,
                        usuario.Celular, usuario.CURP, usuario.Password);

                    if (RowsAffected >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Ocurrió un error al Actualizar el usuario";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static ML.Result DeleteEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DLEF.JPiinedaProgramacionNCapas contex = new DLEF.JPiinedaProgramacionNCapas())
                {
                    int query = contex.UsuarioDelete(usuario.IdUsuario);
                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Ocurrio un error al eliminar el Usuario";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static ML.Result GetAllEF()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DLEF.JPiinedaProgramacionNCapas contex = new DLEF.JPiinedaProgramacionNCapas())
                {
                    var query = contex.UsuarioGetAll().ToList();    
                    if (query != null)
                    {
                        result.Objects = new List<object>();

                        foreach (var obj in query)
                        {
                            ML.Usuario usuario = new ML.Usuario();
                            usuario.IdUsuario = obj.IdUsuario;
                            usuario.Nombre = obj.Nombre;
                            usuario.ApellidoPaterno = obj.ApellidoPaterno;
                            usuario.ApellidoMaterno = obj.ApellidoMaterno;                            
                            usuario.Correo = obj.Correo;
                            usuario.Rol = new ML.Rol();
                            usuario.Rol.IdRol = obj.IdRol;
                            usuario.UserName = obj.UserName;
                            usuario.FechaNacimiento = obj.FechaNacimiento.ToString();
                            usuario.Sexo = obj.Sexo;
                            usuario.Telefono = obj.Telefono;
                            usuario.Celular = obj.Celular;
                            usuario.CURP = obj.CURP;
                            usuario.Password = obj.Password;
                            //usuario.Imagen = obj.Imagen;

                            //usuario.Direccion = new ML.Direccion();
                            //usuario.Direccion.Calle = obj.Calle;

                            //usuario.Direccion.Colonia = new ML.Colonia();
                            //usuario.Direccion.Colonia.IdColonia = obj.IdColonia;
                            //usuario.Direccion.Colonia.Nombre = obj.Colonia;

                            //usuario.Direccion.Colonia.Municipio = new ML.Municipio();
                            //usuario.Direccion.Colonia.Municipio.IdMunicipio = obj.IdMunicipio;
                            //usuario.Direccion.Colonia.Municipio.Nombre = obj.Municipio;

                            
                            result.Objects.Add(usuario);

                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result GetPartialEF()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DLEF.JPiinedaProgramacionNCapas contex = new DLEF.JPiinedaProgramacionNCapas())
                {
                    var query = contex.UsuarioGetAll().ToList();
                    if (query != null)
                    {
                        result.Objects = new List<object>();

                        foreach (var obj in query)
                        {
                            ML.Usuario usuario = new ML.Usuario();
                            usuario.IdUsuario = obj.IdUsuario;
                            usuario.Nombre = obj.Nombre;
                            

                            result.Objects.Add(usuario);

                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result GetByIdEF(int IdUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {

                using (DLEF.JPiinedaProgramacionNCapas context = new DLEF.JPiinedaProgramacionNCapas())
                {

                    var query = context.UsuarioGetById(IdUsuario).FirstOrDefault();

                    if (query != null)
                    {
                        ML.Usuario usuario = new ML.Usuario();

                        usuario.IdUsuario = query.IdUsuario;
                        usuario.Nombre = query.Nombre;
                        usuario.ApellidoPaterno = query.ApellidoPaterno;
                        usuario.ApellidoMaterno = query.ApellidoMaterno;                        
                        usuario.Correo = query.Correo;
                        usuario.Rol = new ML.Rol();
                        usuario.Rol.IdRol = query.IdRol;
                        usuario.UserName = query.UserName;
                        usuario.FechaNacimiento = query.FechaNacimiento.ToString();
                        usuario.Sexo = query.Sexo;
                        usuario.Telefono = query.Telefono;
                        usuario.Celular = query.Celular;
                        usuario.CURP = query.CURP;
                        usuario.Password = query.Password;
                        //usuario.Imagen = query.Imagen;

                        //usuario.Direccion = new ML.Direccion();
                        //usuario.Direccion.Calle = query.Calle;
                        //usuario.Direccion.NumeroInterior = query.NumeroInterior;
                        //usuario.Direccion.NumeroExterior = query.NumeroExterior;

                        //usuario.Direccion.Colonia = new ML.Colonia();
                        //usuario.Direccion.Colonia.Nombre = query.Colonia;
                        //usuario.Direccion.Colonia.IdColonia = query.IdColonia;

                        //usuario.Direccion.Colonia.Municipio = new ML.Municipio();
                        //usuario.Direccion.Colonia.Municipio.Nombre = query.Municipio;
                        //usuario.Direccion.Colonia.Municipio.IdMunicipio = query.IdMunicipio;

                        //usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();
                        //usuario.Direccion.Colonia.Municipio.Estado.IdEstado = query.IdEstado;
                        //usuario.Direccion.Colonia.Municipio.Estado.Nombre = query.Estado;

                        //usuario.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();
                        //usuario.Direccion.Colonia.Municipio.Estado.Pais.IdPais = query.IdPais;
                        //usuario.Direccion.Colonia.Municipio.Estado.Pais.Nombre = query.Pais;

                        result.Object = usuario;

                        result.Correct = true;
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }


        public static ML.Result AddLINQ(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DLEF.JPiinedaProgramacionNCapas contex = new DLEF.JPiinedaProgramacionNCapas())
                {

                    DLEF.Usuario usuarioEntity = new DLEF.Usuario();
                    usuarioEntity.Nombre = usuario.Nombre;
                    usuarioEntity.ApellidoPaterno = usuario.ApellidoPaterno;
                    usuarioEntity.ApellidoMaterno = usuario.ApellidoMaterno;
                    usuarioEntity.Correo = usuario.Correo;
                    usuarioEntity.IdRol = usuario.Rol.IdRol;
                    usuarioEntity.UserName = usuario.UserName;
                    usuarioEntity.FechaNacimiento = DateTime.ParseExact(usuario.FechaNacimiento, "dd-MM-yyyy", null);
                    usuarioEntity.Sexo = usuario.Sexo;
                    usuarioEntity.Telefono = usuario.Telefono;
                    usuarioEntity.Celular = usuario.Celular;
                    usuarioEntity.CURP = usuario.CURP;
                    usuarioEntity.Password = usuario.Password;
                   

                    contex.Usuarios.Add(usuarioEntity);
                    var RowsAffected = contex.SaveChanges();

                    if (RowsAffected > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;

                    }
                   

                }
            }
            catch(Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result UpdateLINQ(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DLEF.JPiinedaProgramacionNCapas contex = new DLEF.JPiinedaProgramacionNCapas())
                {

                    
                    var query = (from usuarioa in contex.Usuarios
                                 where usuarioa.IdUsuario == usuario.IdUsuario
                                 select usuarioa).SingleOrDefault();

                    if (query != null)
                    {
                        
                        query.Nombre = usuario.Nombre;
                        query.ApellidoPaterno = usuario.ApellidoPaterno;
                        query.ApellidoMaterno = usuario.ApellidoMaterno;
                        query.Correo = usuario.Correo;
                        query.IdRol = usuario.Rol.IdRol;
                        query.UserName = usuario.UserName;
                        query.FechaNacimiento = DateTime.ParseExact(usuario.FechaNacimiento, "dd-MM-yyyy", null);
                        query.Sexo = usuario.Sexo;
                        query.Telefono = usuario.Telefono;
                        query.Celular = usuario.Celular;
                        query.CURP = usuario.CURP;
                        query.Password = usuario.Password;
                        


                        contex.SaveChanges();



                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;

                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result DeleteLINQ(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DLEF.JPiinedaProgramacionNCapas context = new DLEF.JPiinedaProgramacionNCapas())
                {
                    var query = (from a in context.Usuarios
                                 where a.IdUsuario == usuario.IdUsuario
                                 select a).First();

                    context.Usuarios.Remove(query);
                    context.SaveChanges();
                }
            }

            catch (Exception ex)
            {
                

                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        public static ML.Result GetAllLINQ()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DLEF.JPiinedaProgramacionNCapas contex = new DLEF.JPiinedaProgramacionNCapas())
                {
                    var query=(from usuario  in contex.Usuarios
                               select new { IdUsuario = usuario.IdUsuario, Nombre = usuario.Nombre,
                               ApellidoPaterno = usuario.ApellidoPaterno,ApellidoMaterno = usuario.ApellidoMaterno,
                               IdRol= usuario.IdRol,UserName = usuario.UserName, FechaNacimiento = usuario.FechaNacimiento,
                               Sexo= usuario.Sexo, Telefono = usuario.Telefono, Celular = usuario.Celular,CURP = usuario.CURP,
                               Password = usuario.Password}
                               );
                    result.Objects = new List<object>();
                    if (query != null )
                    {
                        foreach (var obj in query)
                        {
                            ML.Usuario usuario = new ML.Usuario();
                            usuario.IdUsuario = obj.IdUsuario;
                            usuario.Nombre = obj.Nombre;
                            usuario.ApellidoPaterno = obj.ApellidoPaterno;
                            usuario.ApellidoMaterno = obj.ApellidoMaterno;
                            usuario.Rol = new ML.Rol();
                            usuario.Rol.IdRol = obj.IdRol;
                            usuario.UserName = obj.UserName;
                            usuario.FechaNacimiento = obj.FechaNacimiento.ToString();
                            usuario.Sexo = obj.Sexo;
                            usuario.Telefono = obj.Telefono;
                            usuario.Celular = obj.Celular;
                            usuario.CURP = obj.CURP;
                            usuario.Password = obj.Password;
                            

                            result.Objects.Add(usuario);

                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }

            return result;
        }

        public static ML.Result GetByIdLINQ(int usuarioa)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DLEF.JPiinedaProgramacionNCapas contex = new DLEF.JPiinedaProgramacionNCapas())
                {


                    var query = (from usuario in contex.Usuarios
                                 where usuario.IdUsuario == usuarioa
                                 select new
                                 {
                                     IdUsuario = usuario.IdUsuario,
                                     Nombre = usuario.Nombre,
                                     ApellidoPaterno = usuario.ApellidoPaterno,
                                     ApellidoMaterno = usuario.ApellidoMaterno,
                                     IdRol = usuario.IdRol,
                                     UserName = usuario.UserName,
                                     FechaNacimiento = usuario.FechaNacimiento,
                                     Sexo = usuario.Sexo,
                                     Telefono = usuario.Telefono,
                                     Celular = usuario.Celular,
                                     CURP = usuario.CURP,
                                     Password = usuario.Password
                                    
                                 }).FirstOrDefault();

                    if (query != null)
                    {
                     
                        ML.Usuario usuario = new ML.Usuario();
                        usuario.IdUsuario = query.IdUsuario;
                        usuario.Nombre = query.Nombre;
                        usuario.ApellidoPaterno = query.ApellidoPaterno;
                        usuario.ApellidoMaterno = query.ApellidoMaterno;
                        usuario.Rol = new ML.Rol();
                        usuario.Rol.IdRol = query.IdRol;
                        usuario.UserName = query.UserName;
                        usuario.FechaNacimiento = query.FechaNacimiento.ToString();
                        usuario.Sexo = query.Sexo;
                        usuario.Telefono = query.Telefono;
                        usuario.Celular = query.Celular;
                        usuario.CURP = query.CURP;
                        usuario.Password = query.Password;
                        

                        result.Object = usuario;

                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }

                }
            }
            catch
            {

            }

            return result;
        }

    }



}
