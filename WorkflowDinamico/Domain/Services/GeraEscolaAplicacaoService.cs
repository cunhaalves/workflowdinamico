using WorkflowDinamico.Domain.Interfaces;

namespace WorkflowDinamico.Domain.Services
{
    public class GeraEscolaAplicacaoService : IGeraEscolaAplicacaoService
    {
        public void GerarEscolaAplicacao()
        {
            Console.WriteLine("Escola Aplicacao gerado");
        }
    }
}
