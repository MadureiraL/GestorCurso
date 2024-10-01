using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorCurso.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        private string _nome;
        private string _sobrenome;
        private int _idade;
        public string Nome
        {
            get => _nome;

            set
            {
                // "Nome" é um argumento para a variavel propriedade
                Validar(value, "Nome");

                _nome = value;
            }
        }

        public string Sobrenome
        {
            get => _sobrenome;

            set
            {
                // "Sobrenome" é um argumento para a variavel propriedade
                Validar(value, "Sobrenome");

                _sobrenome = value;
            }
        }
        public override string ToString()
        {
            return $"{Nome} {Sobrenome}";
        }

        public string NomeCompleto => $"{Nome} {Sobrenome}";
        public int Idade
        {
            get => _idade;

            set
            {
                if (value < 0 || value > 120)
                {
                    throw new ArgumentNullException("A idade não pode ser menor que zero");
                }
                _idade = value;
            }
        }
        //Valida os dados requeridos impedindo de ser NULL e Vazio
        public void Validar(string valor, string propriedade)
        {

            if (string.IsNullOrEmpty(valor))
            {
                throw new ArgumentException($"{propriedade} não pode ser vazio ");
            }
        }
    }
}