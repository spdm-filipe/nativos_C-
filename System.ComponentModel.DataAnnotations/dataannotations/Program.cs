// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;

public class Produto
{
    [Range(1, 100, ErrorMessage = "O preço deve estar entre 1 e 100.")]
    public decimal Preco { get; set; }

     [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Formato de e-mail inválido.")]
    public string Email { get; set; }

     public string Senha { get; set; }

    [Compare("Senha", ErrorMessage = "As senhas não coincidem.")]
    public string ConfirmacaoSenha { get; set; }

        [Display(Name = "Nome do Produto")]
    public string Nome { get; set; }

       [MaiorDeIdade(ErrorMessage = "É necessário ser maior de idade.")]
    public int Idade { get; set; }
}


public class MaiorDeIdadeAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        int idade = (int)value;
        if (idade >= 18)
        {
            return ValidationResult.Success;
        }
        return new ValidationResult("O usuário deve ser maior de idade.");
    }
}