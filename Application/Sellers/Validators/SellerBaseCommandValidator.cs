using Application.Sellers.Commands;
using FluentValidation;

namespace Application.Sellers.Validators
{
    public class SellerBaseCommandValidator : AbstractValidator<SellerBaseCommand>
    {
        public SellerBaseCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("The Seller's 'Name' should not be empty");
        }
    }
}
