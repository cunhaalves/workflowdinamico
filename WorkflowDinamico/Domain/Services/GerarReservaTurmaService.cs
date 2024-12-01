using WorkflowDinamico.Domain.Interfaces;

namespace WorkflowDinamico.Domain.Services
{
    public class GerarReservaTurmaService : IGeracaoAlunoReservaDaTurma
    {
        async void IGeracaoAlunoReservaDaTurma.GerarReserva()
        {
            Console.WriteLine("Gerando 2 reservas na turma");
        }
    }
}
