using MarkMe.API.Domain.Core;
using System.Collections.Generic;

namespace MarkMe.API.Domain
{
    public class TodoList : Entity
    {
        public string Nome { get; set; }

        public ICollection<Tarefa> Tarefas { get; set; }

        public void CriarTarefa(Tarefa tarefa)
        {
            if (Tarefas == null) Tarefas = new List<Tarefa>();

            Tarefas.Add(tarefa);
        }
    }
}
