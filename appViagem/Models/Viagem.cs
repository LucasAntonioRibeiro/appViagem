using SQLite;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appViagem.Models
{
    public class Viagem
    {
        string _origem;
        string _destino;
        double _distancia;
        double _rendimento;
        double _valor_combus;

        [AutoIncrement, PrimaryKey]

        public static int id { get; set; }

        public string origem { get => _origem; set { if (value == null) throw new Exception("Origem invalida"); _origem = value; } }
        public string destino { get => _destino; set { if (value == null) throw new Exception("Destino Invalido"); _destino = value; } }
        public double distancia { get => _distancia; set { if (value == 0.0) throw new Exception("Distancia invalida"); _distancia = value; } }
        public double rendimento { get => _rendimento; set { if (value == 0.0) throw new Exception("Rendimento invalido"); _rendimento = value; } }
        public double valor_combus { get => _valor_combus; set { if (value == 0.0) throw new Exception("Valor do Combustivel"); _valor_combus = value; } }

    }
}
