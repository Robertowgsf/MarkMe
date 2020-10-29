using FluentValidation;

namespace MarkMe.API.Domain
{
    public class TarefaValidation : AbstractValidator<Tarefa>
    {
        public TarefaValidation()
        {
            ValidateDescricao();
        }

        private void ValidateDescricao()
        {
            RuleFor(tarefa => tarefa.Descricao)
                .NotEmpty().WithMessage("Digite uma descrição.")
                .MaximumLength(100).WithMessage("Descrição muito grande.");
        }
    }
}
