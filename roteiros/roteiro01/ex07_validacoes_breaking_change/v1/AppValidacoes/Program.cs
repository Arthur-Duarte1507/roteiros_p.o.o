using BibliotecaValidacoes;

Console.WriteLine("Exercicio 7 - BibliotecaValidacoes (v1)");

Console.WriteLine($"CPF 111.444.777-35 valido? {ValidadorCPF.EhValido("111.444.777-35")}");
Console.WriteLine($"Email aluno@faculdade.edu valido? {ValidadorEmail.EhValido("aluno@faculdade.edu")}");
Console.WriteLine($"Senha 'Fraca123' valida? {ValidadorSenha.EhValida("Fraca123")}");
Console.WriteLine($"Senha 'F0rte#2026' valida? {ValidadorSenha.EhValida("F0rte#2026")}");
