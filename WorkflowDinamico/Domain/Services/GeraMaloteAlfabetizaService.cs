using WorkflowDinamico.Domain.Interfaces;

namespace WorkflowDinamico.Domain.Services
{
    public class GeraMaloteAlfabetizaService : IGeraMaloteService
    {
        public void GerarMalote()
        {
            Console.WriteLine("Malote gerado");
        }
    }
}
