using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Exa_CatalogoProducto" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Exa_CatalogoProducto.svc or Exa_CatalogoProducto.svc.cs at the Solution Explorer and start debugging.
    public class Exa_CatalogoProducto : IExa_CatalogoProducto
    {
        public Proyecto_ENT.Result GetAll()
        {
            Proyecto_ENT.Result result = Proyecto_BLL.Exa_CatalogoProducto.GetAll();
            if (result.Correct)
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        public Proyecto_ENT.Result Add (Proyecto_ENT.Exa_CatalogoProducto exa_CatalogoProducto)
        {
            Proyecto_ENT.Result result = Proyecto_BLL.Exa_CatalogoProducto.Add(exa_CatalogoProducto);
            if (result.Correct)
            {
                return result;
            }
            else
            {
                return null;
            }
        }
       
    }
}
