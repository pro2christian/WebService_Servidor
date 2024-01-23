using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace _0._0._0_Para_Estudar
{
    [ServiceContract]
    public interface IContratoServidor
    {
        [OperationContract]
        bool EnviaStrToServidor(string pMensagemEnviada);
        [OperationContract]
        string PegaStrFromServidor();
    }
}
