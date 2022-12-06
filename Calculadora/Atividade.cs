using System.Collections.Generic;
namespace Calculadora
{
    public class Atividade
    {
        public Atividade(string descricao, decimal caloriasMinuto)
        {
            Descricao = descricao;
            CaloriasMinuto = caloriasMinuto;
        }

        public string Descricao { get; set; }
        public decimal CaloriasMinuto { get; set; }
    }
}