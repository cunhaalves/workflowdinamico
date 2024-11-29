using WorkflowDinamico.Domain.Interfaces;

namespace WorkflowDinamico.Domain.Services
{
    public class GeraEnvelopeProvaSaebService : IGeraEnvelopeProvaService
    {
        public void GeraEnvelopeProva()
        {
            Console.WriteLine("Envelope de prova saeb gerado");
        }
    }
}
