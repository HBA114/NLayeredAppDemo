using FluentValidation;
using Northwind.Entities.Concrete;

namespace Northwind.Business.ValidationRules.FluentValidation;

public class ProductValidator : AbstractValidator<Product>
{
    public ProductValidator()
    {
        RuleFor(p => p.ProductName).NotEmpty().WithMessage("Product Name Can not Be Empty!");
        RuleFor(p => p.CategoryId).NotEmpty();
        RuleFor(p => p.UnitPrice).NotEmpty().GreaterThan(0);
        RuleFor(p => p.QuantityPerUnit).NotEmpty();
        RuleFor(p => p.UnitsInStock).NotEmpty().GreaterThanOrEqualTo((short)0);

        RuleFor(p => p.UnitPrice).GreaterThan(10).When(p => p.CategoryId == 2);
    }
}