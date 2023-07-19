using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Municipio
    {
     
            public static ML.Result GetByIdMunicipio(int idMunicipio)
            {
                ML.Result result = new ML.Result();

                try
                {
                    using (DLEF.JPiinedaProgramacionNCapas contex = new DLEF.JPiinedaProgramacionNCapas())
                    {
                        var municipioList = contex.MunicipioGetByIdEstado(idMunicipio).ToList();

                        result.Objects = new List<object>();

                        foreach (var row in municipioList)
                        {
                            ML.Municipio municipio = new ML.Municipio();

                            municipio.IdMunicipio = row.IdMunicipio;
                            municipio.Nombre = row.Nombre;

                            result.Objects.Add(municipio);

                        }

                        result.Correct = true;
                    }

                }
                catch (Exception ex)
                {
                    result.Correct = false;
                    result.Ex = ex;
                    result.ErrorMessage = ex.Message;

                }
                return result;
            }
        }
    
}
