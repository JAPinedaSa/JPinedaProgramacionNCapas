using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PLMVC.Controllers
{
    public class AseguradoraController : Controller
    {
        // GET: Aseguradora
        [HttpGet]
        public ActionResult GetAll()
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();

            //ML.Result result = BL.Aseguradora.GetAll();
            //aseguradora.Aseguradoras = result.Objects;            
            ServiceReferenceA.ServiceAseguradoraClient aseguradoraGetAll = new ServiceReferenceA.ServiceAseguradoraClient();
            var resultGetAll = aseguradoraGetAll.GetAll();

            if (resultGetAll.Correct)
            {
                aseguradora.Aseguradoras = resultGetAll.Objects.ToList();
                
            }
            else
            {
                ViewBag.Message = "Ocurrio un error al tratar de consultar la información";
            }
            return View(aseguradora);
        }
        [HttpGet]
        public ActionResult Form(int? idAseguradora)
        {
            ML.Result resultUsuario = BL.Usuario.GetAllEF();
            ML.Aseguradora aseguradoraUsuario = new ML.Aseguradora();
            aseguradoraUsuario.Usuario = new ML.Usuario();

            if (resultUsuario.Correct)
            {
                aseguradoraUsuario.Usuario.Usuarios = resultUsuario.Objects;
            }
            if (idAseguradora == null)
            {

                return View(aseguradoraUsuario);
            }
            else
            {
                //ML.Result result = BL.Aseguradora.GetById(idAseguradora.Value);
                ServiceReferenceA.ServiceAseguradoraClient aseguradoraGetAll = new ServiceReferenceA.ServiceAseguradoraClient();
                var resultGetAll = aseguradoraGetAll.GetById(idAseguradora.Value);
                if (resultGetAll.Correct)
                {
                    aseguradoraUsuario = (ML.Aseguradora)resultGetAll.Object;
                    aseguradoraUsuario.Usuario.Usuarios = resultUsuario.Objects;
                    return View(aseguradoraUsuario);
                }
                else
                {
                    ViewBag.Message = "Ocurrio un error al hacer la consulta:" + resultGetAll.ErrorMessage;
                    return View("Modal");
                }
                
            }


        }

        [HttpPost]
        public ActionResult Form(ML.Aseguradora aseguradora)
        {
            ServiceReferenceA.ServiceAseguradoraClient aseguradoraGetAll = new ServiceReferenceA.ServiceAseguradoraClient();
            //var resultAdd = aseguradoraGetAll.GetAll();
            //ML.Result result = new ML.Result();
            if (aseguradora.IdAseguradora == 0)
            {
                var resultAdd = aseguradoraGetAll.Add(aseguradora);
                //result = BL.Aseguradora.Add(aseguradora);
                if (resultAdd.Correct)
                {
                    ViewBag.Message = "El resigistro de Aseguradora a sido agrgado con exito";
                }
                else
                {
                    ViewBag.Message = "Ocurrio un error al insertar el registro" + " " + resultAdd.ErrorMessage;
                }
            }
            else
            {
                var resultUpdate = aseguradoraGetAll.Update(aseguradora);
                //result = BL.Aseguradora.Update(aseguradora);
                if (resultUpdate.Correct)
                {
                    ViewBag.Message = "El Registro de Aseguradora a sido Modificado con exito";
                }
                else
                {
                    ViewBag.Message = "Ocurrio un error al Modificar el registro" + " " + resultUpdate.ErrorMessage;
                }
            }
            return View("Modal");
        }

        [HttpGet]
        public ActionResult Delete(int idAseguradora)
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();
            //aseguradora.IdAseguradora = idAseguradora;
            //ML.Result result = BL.Aseguradora.Delete(aseguradora);
            ServiceReferenceA.ServiceAseguradoraClient aseguradoraDelete = new ServiceReferenceA.ServiceAseguradoraClient();
            var resultDelete = aseguradoraDelete.Delete(idAseguradora);

            if (resultDelete.Correct)
            {
                ViewBag.Message = "El registro de Aseguradora a sido Eliminado con exito";
            }
            else
            {
                ViewBag.Message = "Ocurrio un error al eliminar el registro: " + resultDelete.ErrorMessage;
            }
            return View("Modal");
        }
    }
}