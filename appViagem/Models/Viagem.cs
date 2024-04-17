using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appViagem.Models
{
    internal class Viagem
    {
        string _origem;
        string _destino;
        double _distancia;
        double _rendimento;
        double _valor_combus;

        [AutoIncrement, PrimaryKey]

        public static int id { get; set; }

        public string origem { get => _origem; set { if (value == null) throw new Exception ("Origem invalida")
    }
}
