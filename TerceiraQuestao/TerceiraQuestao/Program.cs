using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TerceiraQuestao
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0;
            while (opc != 4)
            {
                Console.WriteLine("Ecolha uma opçao do menu abaixo.");
                Console.WriteLine("1 - Popular banco de dados");
                Console.WriteLine("2 - Listar CPFs");
                Console.WriteLine("3 - Consertar as máscaras");
                Console.WriteLine("4 - Sair");

                opc = Int32.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        PopularBanco();
                        break;

                    case 2:
                        ListarCpf();
                        break;

                    case 3:
                        ConsertaMascara();
                        break;

                    case 4:
                        Console.WriteLine("Encerrando operações...");
                        break;

                    default:
                        Console.WriteLine("\nEscolha uma das opções a cima.\n");
                        break;
                }
            }
        }  
        

        private static void ListarCpf()
        {
            using (var contexto = new RadixContext())
            {
                var clientes = contexto
                    .Clientes
                    .Include(c => c.Cpf)
                    .ToList();

                foreach (var cliente in clientes)
                {
                    Console.WriteLine($"Nome: {cliente.Name}  Cpf: {cliente.Cpf.Cpf}");
                }
                Console.WriteLine();
            }
        }

        private static void PopularBanco()
        {
            var cliente = new Cliente();
            string cpf;

            Console.WriteLine("Digite seu Nome.");
            cliente.Name = Console.ReadLine();

            Console.WriteLine("Digite seu cpf");
            cpf = Console.ReadLine();

            cliente.Cpf = new Pessoa()
            {
                Cpf = cpf
            };

            using (var contexto = new RadixContext())
            {
                contexto.Clientes.Add(cliente);
                contexto.SaveChanges();
            }

            Console.WriteLine("\nCliente incluso!\n");

        }

        private static void ConsertaMascara()
        {
            using (var contexto = new RadixContext())
            {
                var clientes = contexto
                    .Clientes
                    .Include(c => c.Cpf)
                    .ToList();

                foreach (var cliente in clientes)
                {
                    if (cliente.Cpf.Cpf.Length == 14)
                    {
                        continue;
                    }
                    else
                    {
                        string cpf = cliente.Cpf.Cpf;
                        cpf = cpf.Insert(3, ".").Insert(7, ".").Insert(11, "-");

                        cliente.Cpf.Cpf = cpf;

                        contexto.Clientes.Update(cliente);
                        contexto.SaveChanges();
                    }
                }

            }
        }
    }
}