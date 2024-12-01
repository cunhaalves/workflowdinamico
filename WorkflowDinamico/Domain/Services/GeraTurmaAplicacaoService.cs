using WorkflowDinamico.Domain.Interfaces;

namespace WorkflowDinamico.Domain.Services
{
    public class GeraTurmaAplicacaoService : IGeraTurmaAplicacaoService
    {
        public void GerarTurmaAplicacao()
        {
            Console.WriteLine("Turma aplicacao gerado");
        }
    }
}
