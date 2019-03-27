using System;
using System.Collections.Generic;
using System.Text;

namespace DBServer.Domain
{
    public class Lancamentos
    {
        public int idTransaction { get; set; }
        public ContaCorrente AccountSource { get; set; }
        public ContaCorrente AccountTarget { get; set; }
        public decimal valueTransaction { get; set; }
        
    }
}
