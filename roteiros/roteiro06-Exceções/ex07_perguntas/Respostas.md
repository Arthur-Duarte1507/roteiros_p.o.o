# Exercicio 7 - Respostas

1. **Por que usar excecao personalizada aqui?**

   Porque ela representa uma regra de negocio com clareza (ex.: limite de saque/deposito), deixando o erro mais especifico do que uma excecao generica.

2. **Qual a funcao do `InnerException`?**

   Guardar a excecao original quando voce lanca uma nova excecao com mais contexto. Assim, a causa raiz nao se perde.

3. **Onde o erro deve ser tratado: `Conta` ou `Main`?**

   `Conta` deve **validar e lancar** excecoes (regra de negocio). `Main` deve **tratar** (mensagem amigavel, log, decisao de fluxo).
