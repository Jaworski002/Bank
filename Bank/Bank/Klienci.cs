using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Klienci
    {
        public Klienci(string id, string name, string nrKonta, double saldo)
        {
            Id = id;
            Name = name;
            NrKonta = nrKonta;
            Saldo = saldo;
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public string NrKonta { get; set; }
        public double Saldo { get; set; }
        public Klienci()
        {

        }
        public override string ToString()
        {
            return $"{Saldo}";

        }
    }

}
