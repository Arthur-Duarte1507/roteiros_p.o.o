# Exercicio 5 - Tratamento correto

Trecho fornecido:

```csharp
catch (Exception ex)
{
    throw ex;
}
```

Correcao:

```csharp
catch (Exception)
{
    throw;
}
```

Motivo:

- `throw ex;` recria o ponto de lancamento da excecao e perde o stack trace original.
- `throw;` relanca a mesma excecao preservando a pilha completa, facilitando diagnostico.
