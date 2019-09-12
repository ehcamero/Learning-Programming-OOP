using System;

namespace POO
{
    public class Pessoa
    {
        // * Variáveis , Atributos
        private String nome {get; set;}
        private double peso {get; set;}
        private double altura {get; set;}

        // * Construtores de Pessoa
        public Pessoa (string nome, double peso, double altura)
        {
            this.nome = nome;
            this.peso = peso;
            this.altura = altura;
        }

        public Pessoa (string nome, double peso)
        {
            this.nome = nome;
            this.peso = peso;
        }

        public Pessoa (double peso, double altura)
        {
            this.peso = peso;
            this.altura = altura;
        }

        // * Método que calcula o IMC da Pessoa
        double calcularIMC() => peso / (altura * altura);

        // * Método que retorna uma classificação de acordo com o IMC
        String classificar(double imc)
        {
            if(imc < 18.5)
            {
            return "Abaixo do peso";
            } else if (imc < 25.0)
            {
                return "Peso Normal";
            } else if (imc < 30.0)
            {
                return "Sobrepeso";
            } else if (imc < 35.0)
            {
                return "Obesidade grau 1";
            } else if (imc < 40.0)
            {
                return "Obesidade grau 2";
            } else
            {
                return "Obesidade grau 3";
            }
        }

        // * Método que retorna todas as informações da Pessoa.
        void exibirInformacoes()
        {
            // * Informações básicas
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Peso: {peso}  kg");
            Console.WriteLine($"Altura: {altura} m");

            // * Informações calculadas
            // ! "F" é uma regra padrão do standard numeric
            Console.WriteLine($"IMC: {calcularIMC().ToString("F")}");
            Console.WriteLine($"Classificacao: {classificar(calcularIMC())}");    
        }

        static void Main()
        {
            // * Criando a pessoa 1 
            Pessoa p1 = new Pessoa(85, 1.85);

            // * Pular linha
            Console.Write("\n");

            // * Exibindo os dados da primeira pessoa (p1)
            Console.WriteLine($"Peso: {p1.peso}  kg");
            Console.WriteLine($"Altura: {p1.altura} m\n");

            // * Criando a pessoa 2
            var p2 = new Pessoa("Marcos", 90.1, 1.92);

            // * Exibindo os dados da segunda pessoa (p2)
            Console.WriteLine($"Peso: {p2.peso}  kg");
            Console.WriteLine($"Altura: {p2.altura} m");
            Console.WriteLine($"Nome: {p2.nome}\n");

            // * Exibindo todas as informações de p2
            p2.exibirInformacoes();
        }
    }
}
