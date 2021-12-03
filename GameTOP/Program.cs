using System;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA("Ronaldo");

            jogo.Iniciarjogo();
        }
    }

    class JogoFODA
    {
        private readonly string _NomeJogador;

        public JogoFODA(String nome)
        {
            this._NomeJogador = nome;
        }

        public void Iniciarjogo()
        {   
            Console.Write($"{_NomeJogador} deu um passe");
        }
    }
}
