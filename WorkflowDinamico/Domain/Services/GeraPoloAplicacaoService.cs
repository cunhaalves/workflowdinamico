using WorkflowDinamico.Domain.Interfaces;

namespace WorkflowDinamico.Domain.Services
{
    public class GeraPoloAplicacaoService : IGeraPoloAplicacaoService
    {
        public void GerarPoloAplicacao()
        {
            Console.WriteLine("Polo Aplicacao gerado");
        }
    }
}
