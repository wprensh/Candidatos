using PruebaTecnicaLibrary.Vo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPtWcf" in both code and config file together.
    [ServiceContract]
    public interface IPtWcf
    {
        [OperationContract]
        bool NuevaEntrevista(Entrevista entrevista);

        [OperationContract]
        bool EditarEntrevista(Entrevista entrevista);

        [OperationContract]
        List<Reclutadore> ObtenerReclutadores();

        [OperationContract]
        List<MyJsonData> ObtenerCandidatos();

        [OperationContract]
        List<Entrevista> ObtenerEntrevistas();

        [OperationContract]
        List<Tecnologia> ObtenerTecnologias();

        [OperationContract]
        List<TipoTecnologia> ObtenerTipoTecnologias();
    }
}
