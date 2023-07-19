using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Aseguradora
    {
        public static ML.Result Add(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();
            
            try
            {
                using (DLEF.JPiinedaProgramacionNCapas contex = new DLEF.JPiinedaProgramacionNCapas())
                {
                    int query = contex.AseguradoraAdd(aseguradora.Nombre,aseguradora.Usuario.IdUsuario);
                    
                    if (query>= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Ocurrio un error en la inserción";
                    }
                }
            }
            catch(Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }

            return result; 

        }
        public static ML.Result Update(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DLEF.JPiinedaProgramacionNCapas context = new DLEF.JPiinedaProgramacionNCapas())
                {
                    int query = context.AseguradoraUpdate(aseguradora.IdAseguradora,aseguradora.Nombre,
                        aseguradora.Usuario.IdUsuario);

                    if (query>=1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Ocurrio Un Error al Actualizar la Aseguradora";
                    }
                }
            }
            catch(Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }

            return result;

        }
        public static ML.Result Delete(int idAseguradora)
        {
            ML.Result result = new ML.Result();
            
            try
            {
                using (DLEF.JPiinedaProgramacionNCapas contex = new DLEF.JPiinedaProgramacionNCapas())
                {
                    int query = contex.AseguradoraDelete(idAseguradora);
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
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DLEF.JPiinedaProgramacionNCapas contex = new DLEF.JPiinedaProgramacionNCapas())
                {
                    var query = contex.AseguradoraGetAll().ToList();
                    if (query != null)
                    {
                        result.Objects = new List<object>();

                        foreach (var obj in query)
                        {
                            ML.Aseguradora aseguradora = new ML.Aseguradora();
                            aseguradora.IdAseguradora = obj.IdAseguradora;
                            aseguradora.Nombre = obj.Nombre;
                            aseguradora.FechaCreacion = obj.FechaCreacion.ToString();
                            aseguradora.FechaModificacion = obj.FechaModificacion.ToString();
                            aseguradora.Usuario = new ML.Usuario();
                            aseguradora.Usuario.IdUsuario = obj.IdUsuario;
                            aseguradora.Usuario.Nombre = obj.NombreUsuario;

                            
                            result.Objects.Add(aseguradora);

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
        public static ML.Result GetById(int IdAseguradora)
        {
            ML.Result result = new ML.Result();
            
            try
            {

                using (DLEF.JPiinedaProgramacionNCapas context = new DLEF.JPiinedaProgramacionNCapas())
                {

                    var query = context.AseguradoraGetById(IdAseguradora).FirstOrDefault();

                    if (query != null)
                    {
                        ML.Aseguradora aseguradora = new ML.Aseguradora();

                        aseguradora.IdAseguradora = query.IdAseguradora;
                        aseguradora.Nombre = query.Nombre;
                        aseguradora.FechaCreacion = query.FechaCreacion.ToString();
                        aseguradora.FechaModificacion = query.FechaModificacion.ToString();
                        aseguradora.Usuario = new ML.Usuario();
                        aseguradora.Usuario.IdUsuario = query.IdUsuario;
                        aseguradora.Usuario.Nombre = query.NombreUsuario;                   
                    
                        result.Object = aseguradora;

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
        // METODOS LINQ
        public static ML.Result AddLINQ(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DLEF.JPiinedaProgramacionNCapas contex = new DLEF.JPiinedaProgramacionNCapas())
                {

                    DLEF.Aseguradora aseguradoraEntity = new DLEF.Aseguradora();
                    aseguradoraEntity.Nombre = aseguradora.Nombre;
                    aseguradoraEntity.FechaCreacion = DateTime.ParseExact(aseguradora.FechaCreacion, "dd-MM-yyyy", null);
                    aseguradoraEntity.FechaModificacion = DateTime.ParseExact(aseguradora.FechaModificacion, "dd-MM-yyyy", null);
                    aseguradoraEntity.IdUsuario = aseguradora.Usuario.IdUsuario;
                    contex.Aseguradoras.Add(aseguradoraEntity);
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
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
        public static ML.Result UpdateLINQ(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DLEF.JPiinedaProgramacionNCapas contex = new DLEF.JPiinedaProgramacionNCapas())
                {


                    var query = (from aseguradorab in contex.Aseguradoras
                                 where aseguradorab.IdAseguradora == aseguradora.IdAseguradora
                                 select aseguradorab).SingleOrDefault();

                    if (query != null)
                    {

                        query.Nombre = aseguradora.Nombre;
                        query.FechaCreacion = DateTime.ParseExact(aseguradora.FechaCreacion, "dd-MM-yyyy", null);
                        query.FechaModificacion = DateTime.ParseExact(aseguradora.FechaModificacion, "dd-MM-yyyy", null);
                        query.IdUsuario = aseguradora.Usuario.IdUsuario;

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
        public static ML.Result DeleteLINQ(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DLEF.JPiinedaProgramacionNCapas context = new DLEF.JPiinedaProgramacionNCapas())
                {
                    var query = (from aseguradorab in context.Aseguradoras
                                 where aseguradorab.IdAseguradora == aseguradora.IdAseguradora
                                 select aseguradorab).First();

                    context.Aseguradoras.Remove(query);
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
                    var query = (from aseguradora in contex.Aseguradoras
                                 select new
                                 {
                                     IdAseguradora = aseguradora.IdAseguradora,
                                     Nombre = aseguradora.Nombre,
                                     FechaCreacion = aseguradora.FechaCreacion,
                                     FechaModificacion = aseguradora.FechaModificacion,
                                     IdUsuario= aseguradora.Usuario.IdUsuario, 
                                     NombreUsuario =aseguradora.Usuario.Nombre
                                     
                                 }
                               );
                    result.Objects = new List<object>();
                    if (query != null)
                    {
                        foreach (var obj in query)
                        {
                            ML.Aseguradora aseguradora = new ML.Aseguradora();
                            aseguradora.IdAseguradora = obj.IdAseguradora;
                            aseguradora.Nombre = obj.Nombre;
                            aseguradora.FechaCreacion = obj.FechaCreacion.ToString();                           
                            aseguradora.FechaModificacion = obj.FechaModificacion.ToString();
                            aseguradora.Usuario = new ML.Usuario();
                            aseguradora.Usuario.IdUsuario = obj.IdUsuario;
                            aseguradora.Usuario.Nombre = obj.NombreUsuario;

                            result.Objects.Add(aseguradora);

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
        public static ML.Result GetByIdLINQ(int IdAseguradora)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DLEF.JPiinedaProgramacionNCapas contex = new DLEF.JPiinedaProgramacionNCapas())
                {


                    var query = (from aseguradora in contex.Aseguradoras
                                 where aseguradora.IdAseguradora == IdAseguradora
                                 select new
                                 {
                                     IdAseguradora = aseguradora.IdAseguradora,
                                     Nombre = aseguradora.Nombre,
                                     FechaCreacion = aseguradora.FechaCreacion,
                                     FechaModificacion = aseguradora.FechaModificacion,
                                     IdUsuario = aseguradora.Usuario.IdUsuario,
                                     NombreUsuario = aseguradora.Usuario.Nombre
                                 }).FirstOrDefault();

                    if (query != null)
                    {

                        ML.Aseguradora aseguradora = new ML.Aseguradora();
                        aseguradora.IdAseguradora = query.IdAseguradora;
                        aseguradora.Nombre = query.Nombre;
                        aseguradora.FechaCreacion = query.FechaCreacion.ToString();
                        aseguradora.FechaModificacion = query.FechaModificacion.ToString();
                        aseguradora.Usuario = new ML.Usuario();
                        aseguradora.Usuario.IdUsuario = query.IdUsuario;
                        aseguradora.Usuario.Nombre = query.NombreUsuario;

                        result.Object = aseguradora;

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
    }
}
