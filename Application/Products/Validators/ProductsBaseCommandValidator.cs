using Application.Products.Commands;
using FluentValidation;

namespace Application.Products.Validators
{
    public class ProductsBaseCommandValidator : AbstractValidator<ProductBaseCommand>
    {
        public ProductsBaseCommandValidator()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("Product's 'Name' should not be empty");
        }
    }
}
