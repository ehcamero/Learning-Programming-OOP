using System;

namespace POO
{
    public class  Quadrado : Poligono
    {
        // * Atributos
        public double largura;

        // * Construtor
        public Quadrado(double largura)
        {
            this.largura = largura;
        }

        // * Sobrescrita do método calcular área
        public override double calcularArea() => largura * largura;
    }
}