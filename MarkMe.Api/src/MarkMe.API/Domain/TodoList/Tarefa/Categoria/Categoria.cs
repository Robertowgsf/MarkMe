using MarkMe.API.Domain.Core;

namespace MarkMe.API.Domain
{
    public class Categoria : Entity
    {
        public string Nome { get; set; }
        public string Cor { get; set;  }
        public long TarefaId { get; set; }
        public Tarefa Tarefa { get; set; }
    }
}
