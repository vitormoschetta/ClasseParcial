using System;
using ClasseParcial.Validacoes;

namespace ClasseParcial.Entidades
{
    public class Usuario
    {
        public Usuario(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;

            Valida.MinimoCaracteres(nome, 3, "Nome tem que ter 3 caracteres no mínimo");
            Valida.MinimoInteiro(idade, 18, "Não permitido menor de idade");
        }
        public string Nome { get; set; }
        public int Idade { get; set; }


        public void MostraUsuario()
        {
            Console.WriteLine("Nome :" + Nome);
            Console.WriteLine("Idade: " + Idade);
        }
    }
}