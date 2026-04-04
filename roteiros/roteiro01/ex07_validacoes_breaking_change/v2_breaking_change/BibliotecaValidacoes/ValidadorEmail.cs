using System.Text.RegularExpressions;

namespace BibliotecaValidacoes;

public static class ValidadorEmail
{
    private static readonly Regex RegexEmail = new(
        @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
        RegexOptions.Compiled | RegexOptions.CultureInvariant);

    public static bool EhValido(string? email)
    {
        return !string.IsNullOrWhiteSpace(email) && RegexEmail.IsMatch(email);
    }
}
