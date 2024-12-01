using WorkflowDinamico.Domain.Interfaces;

namespace WorkflowDinamico.Domain.Services
{
    public class GeraMaloteService : IGeraMaloteService
    {
        public void GerarMalote()
        {
            Console.WriteLine("Malote gerado");
        }
    }
}
