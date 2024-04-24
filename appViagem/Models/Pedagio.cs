using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace appViagem.Models
{
    public class Pedagio
    {
        string _local;
        double _valor;

        [AutoIncrement, PrimaryKey]

        public int id {  get; set; }
        public string local { get => _local; set { _local = value; } }
        public double valor { get => _valor; set { _valor = value; } }
    }
}
