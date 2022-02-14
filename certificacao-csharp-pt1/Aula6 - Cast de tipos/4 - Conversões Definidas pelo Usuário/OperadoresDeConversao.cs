using System;

namespace certificacao_csharp_roteiro.Aula6___Cast_de_tipos._4___Conversões_Definidas_pelo_Usuário
{
    public class OperadoresDeConversao : IAulaItem
    {
        public void Executar()
        {
            AnguloEmGraus anguloEmGraus = 45;
            Console.WriteLine(anguloEmGraus);

            AnguloEmRadianos anguloEmRadianos = (AnguloEmRadianos)15;
            Console.WriteLine(anguloEmRadianos);

            double graus = anguloEmGraus;

            anguloEmRadianos = anguloEmGraus;
            anguloEmGraus = anguloEmRadianos;
            System.Console.WriteLine($"anguloEmGraus: {anguloEmGraus}");
            System.Console.WriteLine($"anguloEmRadianos: {anguloEmRadianos}");
        }
    }
    
    public struct AnguloEmRadianos
    {
        public double Radianos { get; }

        public AnguloEmRadianos(double radianos)
        {
            this.Radianos = radianos;
        }

        // implicit operator - conversão implicita
        public static implicit operator AnguloEmRadianos(AnguloEmGraus graus)
        {
            return new AnguloEmRadianos(graus.Graus * System.Math.PI / 180);
        }

        // explicit operator - conversão explícita (cast)
        public static explicit operator AnguloEmRadianos(double radianos)
        {
            return new AnguloEmRadianos(radianos);
        }

        public static implicit operator double(AnguloEmRadianos radianos)
        {
            return radianos.Radianos;
        }

        public override string ToString()
        {
            return string.Format("{0} radianos", this.Radianos);
        }
    }

    public struct AnguloEmGraus
    {
        public double Graus { get; }

        public AnguloEmGraus(double graus) { this.Graus = graus; }

        public static implicit operator AnguloEmGraus(AnguloEmRadianos radianos)
        {
            return new AnguloEmGraus(radianos.Radianos * 180 / System.Math.PI);
        }

        public static implicit operator AnguloEmGraus(double graus)
        {
            return new AnguloEmGraus(graus);
        }

        public static implicit operator double(AnguloEmGraus graus)
        {
            return graus.Graus;
        }

        public override string ToString()
        {
            return string.Format("{0} graus", this.Graus);
        }
    }
}