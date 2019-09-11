using System;

namespace POO
{
    // * Classe que herda a classe concreta quadrado
    public class  Retangulo : Quadrado
    {
        // * Atributos
        double altura;

        // * Construtor super é o construtor da classe pai - Utilizando o atrivuto de uma classe herdada
        public Retangulo(double altura, double largura) : base(largura)
        {
            this.altura = altura;
            this.largura = largura;
        }

        // * Sobrescrita do método calcular área
        public override double calcularArea() => largura * altura;
    }
}