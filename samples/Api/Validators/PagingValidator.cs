using Api.Models;
using FluentValidation;

namespace Api.Validators
{
    public class PagingValidator : AbstractValidator<Paging>
    {
        public PagingValidator()
        {
            RuleFor(x => x.PageNo).GreaterThan(0);
            RuleFor(x => x.PageSize).InclusiveBetween(1, 100);
        }
    }
}