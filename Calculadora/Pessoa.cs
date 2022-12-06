namespace Calculadora
{
    public class Pessoa
    {
        public Pessoa(EnumSexo sexo, int peso, int idade)
        {
            Sexo = sexo;
            Peso = peso;
            Idade = idade;
        }

        public EnumSexo Sexo { get; set; }
        public int Peso { get; set; }
        public int Idade { get; set; }

        public enum EnumSexo
        {
            Feminino = 1,
            Masculino = 2
        }
    }
}
