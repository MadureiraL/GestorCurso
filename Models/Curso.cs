using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorCurso.Models
{
    public class Curso
    {
        public List<Pessoa> Alunos { get; set; }

        Pessoa aluno = new Pessoa();
        public void AdicionarAluno()
        {
            aluno = new Pessoa();
            Console.WriteLine("Digite o nome do aluno");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite o sobrenome do aluno");
            aluno.Sobrenome = Console.ReadLine();

            Alunos.Add(aluno);
            Console.WriteLine($"{aluno.NomeCompleto} foi adcionado");


        }
        public void AlunosMatriculados()
        {

            if (Alunos.Any())
            {
                Console.WriteLine("O alunos matriculados são:");
                foreach (var aluno in Alunos)
                {
                    Console.WriteLine($"{aluno.NomeCompleto}");
                }
            }
            else
            {
                Console.WriteLine("Alunos não encontrados");
            }
        }

        public int QuantAlunosMatriculas()
        {
            int quantidade = Alunos.Count;
            Console.WriteLine($"A quantidade de alunos é {quantidade}");
            return quantidade;
        }
        public bool RemoverAluno()
        {
            aluno = new Pessoa();

            Console.WriteLine("Digite o nome do aluno a remover");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite o sobrenome do aluno a remover");
            aluno.Sobrenome = Console.ReadLine();

            var AlunoRemov = Alunos.FirstOrDefault(x => x.Nome == aluno.Nome && x.Sobrenome == aluno.Sobrenome);

            if (AlunoRemov != null)
            {
                Alunos.Remove(AlunoRemov);
                Console.WriteLine($"O aluno {aluno.NomeCompleto} foi removido com sucesso");
            }
            else
            {
                Console.WriteLine("O aluno não foi encontrado");
            }
            return true;

        }
    }
}