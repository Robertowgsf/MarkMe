using System;
using System.Collections.Generic;
using MarkMe.API.Domain.Core;

namespace MarkMe.API.Domain
{
    public class Tarefa : Entity
    {
        public string Descricao { get; set; }
        public bool Concluida { get; set; }
        public DateTime? DataDeEntrega { get; set; }
        public long TodoListId { get; set; }
        public TodoList TodoList { get; set; }
        public IEnumerable<Categoria> Categorias { get; set; }
    }
}
