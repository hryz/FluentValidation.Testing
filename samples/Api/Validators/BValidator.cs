using Api.Models;
using FluentValidation;

namespace Api.Validators
{
    public class BValidator : AbstractValidator<B>
    {
        public BValidator()
        {
            RuleFor(x => x.Property).NotEmpty();
        }
    }
}
