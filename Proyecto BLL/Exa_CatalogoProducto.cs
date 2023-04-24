using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_BLL
{
    public class Exa_CatalogoProducto
    {
        public static Proyecto_ENT.Result GetAll ()
        {
            Proyecto_ENT.Result result = new Proyecto_ENT.Result();
            try
            {
                using(Proyecto_DAL.VRodriguezEntimaEntities context = new Proyecto_DAL.VRodriguezEntimaEntities())
                {
                    var query = context.sp_GetAllCatalogoProd().ToList();
                    if(query != null)
                    {
                        result.Objects = new List<object>();
                        foreach( var obj in query)
                        {
                            Proyecto_ENT.Exa_CatalogoProducto exa_CatalogoProducto = new Proyecto_ENT.Exa_CatalogoProducto();
                            exa_CatalogoProducto.IdProducto = obj.IdProducto;
                            exa_CatalogoProducto.Descripcion = obj.Descripcion;
                            exa_CatalogoProducto.IdUsuario = obj.IdUsuario.Value;
                            exa_CatalogoProducto.FechaCreacion = obj.FechaCreacion.Value;

                            result.Objects.Add(exa_CatalogoProducto);
                        }
                        result.Correct = true;
                        
                    }
                    else
                    {
                        result.Correct = false;
                        result.Message = "No se puede mostrar los datos";
                    }
                }
            }
            catch(Exception ex)
            {
                result.Correct = false;
                result.Message = ex.Message;
            }
            return result;

        }

        public static Proyecto_ENT.Result Add(Proyecto_ENT.Exa_CatalogoProducto exa_CatalogoProducto)
        {
            Proyecto_ENT.Result result = new Proyecto_ENT.Result();
            try
            {
                using(Proyecto_DAL.VRodriguezEntimaEntities context = new Proyecto_DAL.VRodriguezEntimaEntities())
                {
                    int query = context.sp_InsCatalogoProd(exa_CatalogoProducto.Descripcion);
                    if(query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.Message = "No se pudo agregar";
                    }
                }
            }
            catch(Exception ex)
            {
                result.Correct = false;
                result.Message = ex.Message;
            }
            return result;
        }

            

    }
}
