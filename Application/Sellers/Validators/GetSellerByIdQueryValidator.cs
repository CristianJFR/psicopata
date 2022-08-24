using Application.Sellers.Queries;
using FluentValidation;

namespace Application.Sellers.Validators
{
    public class GetSellerByIdQueryValidator : AbstractValidator<GetSellerByIdQuery>
    {
        public GetSellerByIdQueryValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("The 'Id' is necessary for search");
        }
    }
}
