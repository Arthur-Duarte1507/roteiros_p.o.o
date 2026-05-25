using Exercicio01a07_R2;
using NLog;
using System;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    private static readonly Logger logger = LogManager.GetCurrentClassLogger();

    static void Main()
    {
        logger.Info("Início do programa");

        // Exercício 3 - Conversão de string para inteiro com log de erro
        try
        {
            string texto = "abc";
            int numero = int.Parse(texto);
            logger.Info("Conversão realizada com sucesso: {0}", numero);
        }
        catch (Exception ex)
        {
            logger.Error(ex, "Erro ao converter string para inteiro");
        }

        // Exercício 4 - Conta com tentativa de saque e erro de saldo insuficiente
        Conta conta1 = new Conta(100);
        Conta conta2 = new Conta(50);

        try
        {
            logger.Info("Tentando realizar saque de R$ 200,00");
            conta1.Sacar(200);
            logger.Info("Saque realizado com sucesso");
        }
        catch (Exception ex)
        {
            logger.Error(ex, "Erro ao realizar saque: saldo insuficiente ou valor inválido");
        }

        // Exercício 5 - Diferença entre Info, Warn e Error
        logger.Info("Operação normal realizada no sistema");
        logger.Warn("Tentativa inválida detectada, mas o sistema continua funcionando");

        try
        {
            int resultado = 10 / int.Parse("0");
        }
        catch (Exception ex)
        {
            logger.Error(ex, "Exceção encontrada durante a operação");
        }

        // Exercício 6 - Fluxo com depósito, saque e transferência
        try
        {
            logger.Info("Iniciando operação de depósito");
            conta1.Depositar(300);
            logger.Info("Depósito realizado com sucesso. Saldo atual: {0}", conta1.Saldo);
        }
        catch (Exception ex)
        {
            logger.Error(ex, "Erro ao realizar depósito");
        }

        try
        {
            logger.Info("Iniciando operação de saque");
            conta1.Sacar(100);
            logger.Info("Saque realizado com sucesso. Saldo atual: {0}", conta1.Saldo);
        }
        catch (Exception ex)
        {
            logger.Error(ex, "Erro ao realizar saque");
        }

        try
        {
            logger.Info("Iniciando operação de transferência");
            conta1.Transferir(conta2, 150);
            logger.Info("Transferência realizada com sucesso. Saldo conta origem: {0} | Saldo conta destino: {1}", conta1.Saldo, conta2.Saldo);
        }
        catch (Exception ex)
        {
            logger.Error(ex, "Erro ao realizar transferência");
        }

        logger.Info("Fim do programa");
    }
}

// Exercício 7 - Layout do log
/*
O layout foi configurado no NLog.config com:

${longdate} | ${level} | ${message} | ${exception:format=tostring}

Ele inclui:
- data
- nível do log
- mensagem
- exceção, quando existir
*/