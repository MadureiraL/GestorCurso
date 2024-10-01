using System;
using GestorCurso.Models;

namespace GestorCurso
{
    class Program
    {
        public static void Main(string[] args)
        {


            // Instancia a classe curso
            Curso curso = new Curso();

            curso.Alunos = new List<Pessoa>();

            bool exibirMenu = true;

            while (exibirMenu)
            {
                Console.Clear();
                Console.WriteLine("Seja bem vindo \n" +
                "Digite sua opção\n");
                Console.WriteLine("1- Adicionar aluno");
                Console.WriteLine("2- Ver alunos matriculados ");
                Console.WriteLine("3- Listar alunos");
                Console.WriteLine("4- Remover alunos");
                Console.WriteLine("5- Encerrar");


                switch (Console.ReadLine())
                {
                    case "1":
                        curso.AdicionarAluno();
                        break;

                    case "2":
                        curso.AlunosMatriculados();
                        break;
                    case "3":
                        curso.QuantAlunosMatriculas();
                        break;
                    case "4":
                        curso.RemoverAluno();
                        break;
                    case "5":
                        exibirMenu = false;
                        break;

                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }
                Console.WriteLine("Pressione uma tecla para continuar");
                Console.ReadLine();
            }


            Console.WriteLine("O programa foi encerrado");

        }
    }
}