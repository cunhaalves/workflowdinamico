using WorkflowDinamico.Domain.Interfaces;

namespace WorkflowDinamico.Domain.Services
{
    public class GeraEnvelopeProvaSaebService : IGeraEnvelopeProvaService
    {
        public void GerarEnvelopeProva()
        {
            Console.WriteLine("Envelope de prova saeb gerado");
        }
    }
}
