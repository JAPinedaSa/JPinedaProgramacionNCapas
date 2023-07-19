using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PLMVC.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        [HttpGet]
        public ActionResult GetAll()
        {
            ML.Usuario usuario = new ML.Usuario();
            ML.Result result = BL.Usuario.GetAllEF();
            usuario.Usuarios = result.Objects;

            return View(usuario);
           
        }
        [HttpGet]
        public ActionResult Form(int? idUsuario)
        {
            ML.Result resultRol = BL.Rol.GetAll();
            ML.Result resultPais = BL.Pais.GetAll();
            ML.Usuario usuario = new ML.Usuario();

            usuario.Rol = new ML.Rol();
 
            usuario.Direccion = new ML.Direccion();
            usuario.Direccion.Colonia = new ML.Colonia();
            usuario.Direccion.Colonia.Municipio = new ML.Municipio();
            usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();
            usuario.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();

            if (resultRol.Correct)
            {
                usuario.Rol.Roles = resultRol.Objects;
                usuario.Direccion.Colonia.Municipio.Estado.Pais.Paises = resultPais.Objects;
                
            }

            if (idUsuario == null)
            { 
                
                return View(usuario);
            }
            else
            {
                ML.Result result = BL.Usuario.GetByIdEF(idUsuario.Value);
                if (result.Correct) 
                {

                    usuario = (ML.Usuario)result.Object;

                    ML.Result resultColonia = BL.Colonia.GetByIdColonia(usuario.Direccion.Colonia.IdColonia);
                    ML.Result resultMunicipio = BL.Municipio.GetByIdMunicipio(usuario.Direccion.Colonia.Municipio.IdMunicipio);
                    ML.Result resultEstado = BL.Estado.GetByIdEstado(usuario.Direccion.Colonia.Municipio.Estado.IdEstado);
                    ML.Result resultPaises = BL.Pais.GetAll();
                    
                    usuario.Rol.Roles = resultRol.Objects;
                    usuario.Direccion.Colonia.Colonias = resultColonia.Objects;
                    usuario.Direccion.Colonia.Municipio.Municipios = resultMunicipio.Objects;
                    usuario.Direccion.Colonia.Municipio.Estado.Estados = resultEstado.Objects;
                    usuario.Direccion.Colonia.Municipio.Estado.Pais.Paises = resultPaises.Objects;



                    return View(usuario);
                }
                else
                {
                    ViewBag.Message = "Ocurrio un error al hacer la consulta:" + result.ErrorMessage;
                    return View("Modal");
                }
                
            }

            
        }

        [HttpPost]
        public ActionResult Form(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            if (usuario.IdUsuario == 0)
            {
                result = BL.Usuario.AddEF(usuario);
                if (result.Correct)
                {
                    ViewBag.Message = "El usuario a sido agrgado con exito";
                }
                else
                {
                    ViewBag.Message = "Ocurrio un error en la inserción:"+" "+result.ErrorMessage;
                }
            }
            else
            {
                result = BL.Usuario.UpdateEF(usuario);
                if (result.Correct)
                {
                    ViewBag.Message = "El usuario a sido Actualizado con exito";
                }
                else
                {
                    ViewBag.Message = "Ocurrio un error en la Actualizacion del usuario: " + result.ErrorMessage;
                }
            }
            return View("Modal");
        }



        [HttpGet]
        public ActionResult Delete(int IdUsuario)
        {
            ML.Usuario usuario = new ML.Usuario();
            usuario.IdUsuario = IdUsuario;
            ML.Result result = BL.Usuario.DeleteEF(usuario);

            if (result.Correct)
            {
                ViewBag.Message = "El usuario a sido Eliminado con exito";
            }
            else
            {
                ViewBag.Message = "Ocurrio un error al eliminar el usuario: " + result.ErrorMessage;
            }
            return View("Modal");
        }

        public JsonResult EstadoGetByIdPais(int idPais)
        {
            var result = BL.Estado.GetByIdEstado(idPais);

            //var result = BL.Grupo.GetByIdPlantel(idPlantel);

            return Json(result.Objects);
        }

        public JsonResult MunicipioGetByIdEstado(int idEstado)
        {
            var result = BL.Municipio.GetByIdMunicipio(idEstado);

            //var result = BL.Grupo.GetByIdPlantel(idPlantel);

            return Json(result.Objects);
        }

        public JsonResult ColoniaGetByIdMunicipio(int idMunicipio)
        {
            var result = BL.Colonia.GetByIdColonia(idMunicipio);

            //var result = BL.Grupo.GetByIdPlantel(idPlantel);

            return Json(result.Objects);
        }



    }
}