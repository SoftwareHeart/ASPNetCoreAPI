using ETicaretAPI.Application.ViewModels.Products;
using FluentValidation;

namespace ETicaretAPI.Application.Validators.Products
{
    public class CreateProductValidator : AbstractValidator<VM_Create_Product>
    {
        public CreateProductValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Lütfen ürün adını boş geçmeyiniz.")
                .MaximumLength(150)
                .MinimumLength(5)
                    .WithMessage("Lütfen ürün adını 5 ile 150 karakter arasında giriniz.");

            RuleFor(p => p.Puan)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Lütfen puam bilgisini boş geçmeyiniz.")
                .Must(s => s >= 0)
                    .WithMessage("Puan bilgisi negatif olamaz!");

            RuleFor(p => p.Description)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Lütfen açıklama bilgisini boş geçmeyiniz.");
                
        }
    }
}
