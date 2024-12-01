using WorkflowDinamico.Domain.Interfaces;

namespace WorkflowDinamico.Domain.Services
{
    public class GeraEnvelopeProvaAlfabetizaService : IGeraEnvelopeProvaService
    {
        public void GerarEnvelopeProva()
        {
            Console.WriteLine("Envelope de prova alfabetiza gerado");
        }
    }
}
