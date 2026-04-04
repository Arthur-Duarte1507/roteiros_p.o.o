using System.Text.RegularExpressions;

namespace BibliotecaValidacoes;

public static class ValidadorCPF
{
    public static bool EhValido(string? cpf)
    {
        if (string.IsNullOrWhiteSpace(cpf))
        {
            return false;
        }

        string numeros = Regex.Replace(cpf, "[^0-9]", string.Empty);

        if (numeros.Length != 11)
        {
            return false;
        }

        if (numeros.Distinct().Count() == 1)
        {
            return false;
        }

        int digito1 = CalcularDigito(numeros, 9, 10);
        int digito2 = CalcularDigito(numeros, 10, 11);

        return numeros[9] - '0' == digito1 && numeros[10] - '0' == digito2;
    }

    private static int CalcularDigito(string numeros, int tamanhoBase, int pesoInicial)
    {
        int soma = 0;

        for (int i = 0; i < tamanhoBase; i++)
        {
            soma += (numeros[i] - '0') * (pesoInicial - i);
        }

        int resto = soma % 11;
        return resto < 2 ? 0 : 11 - resto;
    }
}
