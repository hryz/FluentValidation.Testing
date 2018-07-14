using Api.Models;
using FluentValidation;

namespace Api.Validators
{
    public class AValidator : AbstractValidator<A>
    {
        public AValidator()
        {
            RuleFor(x => x.Property).NotEmpty();
        }
    }
}
