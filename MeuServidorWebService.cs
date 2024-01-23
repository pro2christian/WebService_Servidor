using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace _0._0._0_Para_Estudar
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class MeuServidorWebService: IContratoServidor
    {
        ServiceHost serviceHost;
        public bool EnviaStrToServidor(string pMensagemEnviada)
        {
            Console.WriteLine(pMensagemEnviada);
            return true;
        }
       
       public  string PegaStrFromServidor()
        {
            return "mensagem do servidor para o cliente".ToUpper();
        }
        public MeuServidorWebService(string pURL)
        {
            Uri uri = new Uri(pURL);
            Console.WriteLine("Inciando o servidor WebService...");
            serviceHost = new ServiceHost(this, uri);
            ServiceMetadataBehavior metadataBehavior = serviceHost.Description.Behaviors.Find<ServiceMetadataBehavior>();
            if(metadataBehavior ==null)
                metadataBehavior = new ServiceMetadataBehavior();
            metadataBehavior.HttpGetEnabled = true;
            metadataBehavior.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
            serviceHost.Description.Behaviors.Add(metadataBehavior);
            serviceHost.AddServiceEndpoint(ServiceMetadataBehavior.MexContractName, MetadataExchangeBindings.CreateMexHttpBinding(),"mex");
            ServiceEndpoint endPoint = serviceHost.AddServiceEndpoint(typeof(IContratoServidor), new BasicHttpBinding(), uri);
            serviceHost.Open();
            Console.WriteLine("servidor iniciado em: ".ToUpper()+ pURL);
        }
    }
}
