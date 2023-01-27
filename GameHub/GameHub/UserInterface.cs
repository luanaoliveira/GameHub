using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub
{
    public class UserInterface
    {
        static public void Header()
        {
            Console.Clear();
            Console.WriteLine(">>>>> GAMEHUB <<<<<");
            // Console.WriteLine($"> JOGADOR: {player.userName} | SCORE: {player.score}");
            Console.WriteLine();
        }

        static public int MainMenu()
        {
            Console.WriteLine("1 - Criar jogador");
            Console.WriteLine("2 - Ver Ranking");
            Console.WriteLine("3 - Jogo da velha");
            Console.WriteLine();
            Console.Write("Opção: ");
            return int.Parse(Console.ReadLine());
        }

        /*

        static public Client InputClient()
        {
            Console.WriteLine("CADASTRO DE CLIENTE");
            Console.WriteLine();
            Client newClient = new Client();
            Console.Write("Digite o nome: ");
            newClient.name = Console.ReadLine();
            Console.Write("Digite o cpf: ");
            newClient.cpf = Console.ReadLine();
            Console.Write("Digite seu email: ");
            newClient.email = Console.ReadLine();
            Console.Write("Digite sua senha: ");
            newClient.password = Console.ReadLine();
            newClient.account.balance = 0;
            return newClient;
        }

        static public void ListClients(Client[] clients)
        {
            Console.WriteLine("TODOS CLIENTES DO SISTEMA");
            Console.WriteLine();
            for (int i = 0; i < clients.Length; i++)
            {
                Console.WriteLine($"# {i}");
                Console.WriteLine($"Nome: {clients[i].name}");
                Console.WriteLine($"CPF: {clients[i].cpf}");
                Console.WriteLine($"Email: {clients[i].email}");
                Console.WriteLine($"Saldo: {clients[i].account.balance}");
                Console.WriteLine("------------------------------");
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        static public void ShowLoginErrorMsg()
        {
            Console.WriteLine();
            Console.WriteLine("Cpf ou senha inválido, tente novamente!");
            Console.WriteLine();
        }

        static public LoginFields InputLogin()
        {
            LoginFields loginFields;
            Console.WriteLine(">>> Faça seu login <<<");
            Console.WriteLine();
            Console.Write("CPF: ");
            loginFields.cpf = Console.ReadLine();
            Console.Write("Senha: ");
            loginFields.password = Console.ReadLine();

            return loginFields;
        }

        static public double WithdrawInputAmount()
        {
            Console.WriteLine("SAQUE");
            Console.WriteLine();
            Console.Write("Valor: ");
            double amountToWithdraw = double.Parse(Console.ReadLine());
            Console.WriteLine();
            return amountToWithdraw;
        }

        static public double DepositInputAmount()
        {
            Console.WriteLine("DEPÓSITO");
            Console.WriteLine();
            Console.Write("Valor: ");
            double amountToDeposit = double.Parse(Console.ReadLine());
            Console.WriteLine();
            return amountToDeposit;
        }

        static public TransferFields InputTransfer()
        {
            Console.WriteLine("TRANSFERÊNCIA");
            Console.WriteLine();
            TransferFields transferFields = new TransferFields();
            Console.Write("CPF do destinatário: ");
            transferFields.cpf = Console.ReadLine();
            Console.Write("Valor: ");
            transferFields.amount = double.Parse(Console.ReadLine());

            return transferFields;
        }

        static public void TransferSuccessMsg()
        {
            Console.WriteLine();
            Console.WriteLine("Transferência realizada com sucesso!");
            Console.WriteLine();
        }

        static public void TransferErrorMsg()
        {
            Console.WriteLine();
            Console.WriteLine("Saldo insulficiente. Tente um valor menor.");
            Console.WriteLine();
        }

        static public void WithdrawErrorMsg()
        {
            Console.WriteLine();
            Console.WriteLine("Saldo insulficiente. Tente um valor menor.");
            Console.WriteLine();
        }*/
    }
}
