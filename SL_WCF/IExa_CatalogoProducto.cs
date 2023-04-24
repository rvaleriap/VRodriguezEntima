using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IExa_CatalogoProducto" in both code and config file together.
    [ServiceContract]
    public interface IExa_CatalogoProducto
    {
        [OperationContract]
        [ServiceKnownType(typeof(Proyecto_ENT.Exa_CatalogoProducto))]
        Proyecto_ENT.Result GetAll();

        [OperationContract]
        [ServiceKnownType(typeof(Proyecto_ENT.Exa_CatalogoProducto))]
        Proyecto_ENT.Result Add(Proyecto_ENT.Exa_CatalogoProducto exa_CatalogoProducto);
    }
}
