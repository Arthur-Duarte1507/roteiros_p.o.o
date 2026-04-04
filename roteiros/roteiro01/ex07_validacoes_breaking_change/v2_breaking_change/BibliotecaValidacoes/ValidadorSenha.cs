namespace BibliotecaValidacoes;

public static class ValidadorSenha
{
    public static bool EhValida(string? senha)
    {
        if (string.IsNullOrWhiteSpace(senha) || senha.Length < 8)
        {
            return false;
        }

        bool temMaiuscula = senha.Any(char.IsUpper);
        bool temMinuscula = senha.Any(char.IsLower);
        bool temNumero = senha.Any(char.IsDigit);
        bool temEspecial = senha.Any(ch => !char.IsLetterOrDigit(ch));

        return temMaiuscula && temMinuscula && temNumero && temEspecial;
    }
}
