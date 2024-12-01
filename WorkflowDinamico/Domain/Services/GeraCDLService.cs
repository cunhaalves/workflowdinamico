using WorkflowDinamico.Domain.Interfaces;

namespace WorkflowDinamico.Domain.Services
{
    public class GeraCDLService : IGeraCDLService
    {
        public void GerarCDL()
        {
            Console.WriteLine("CDL gerado");
        }
    }
}
