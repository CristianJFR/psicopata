using Application.Common.Enums;
using Application.Sellers.Commands;
using FluentValidation;

namespace Application.Sellers.Validators
{
    public class SellerBaseCommandValidator : AbstractValidator<SellerBaseCommand>
    {
        public SellerBaseCommandValidator()
        {
            RuleFor(s => s.Id)
                .NotEmpty()
                .WithMessage("The Seller's 'Id' should not be empty")
                .When(s => s.ActionType != ActionTypes.Create);

            RuleFor(s => s.Name)
                .NotEmpty()
                .WithMessage("The Seller's 'Name' should not be empty")
                .When(s => s.ActionType != ActionTypes.Delete); ;
        }
    }
}
