using WorkflowDinamico.Domain.Interfaces;

namespace WorkflowDinamico.Domain.Services
{
    public class GerarReservaTurmaEspecialService : IGeracaoAlunoReservaDaTurma
    {
        async void IGeracaoAlunoReservaDaTurma.GerarReserva()
        {
            Console.WriteLine("Gerando 3 reservas na turma");
        }
    }
}
