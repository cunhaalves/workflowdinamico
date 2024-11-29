using WorkflowDinamico.Domain.Interfaces;

namespace WorkflowDinamico.Domain.Services
{
    public class GeraEnvelopeProvaAlfabetizaService : IGeraEnvelopeProvaService
    {
        public void GeraEnvelopeProva()
        {
            Console.WriteLine("Envelope de prova alfabetiza gerado");
        }
    }
}
