using FluentValidation;

namespace MarkMe.API.Domain
{
    public class TodoListValidation : AbstractValidator<TodoList>
    {
        public TodoListValidation()
        {
            ValidateNome();
        }

        private void ValidateNome()
        {
            RuleFor(todoList => todoList.Nome)
                .NotEmpty().WithMessage("Digite um nome.")
                .MaximumLength(100).WithMessage("Nome muito grande.");
        }
    }
}
