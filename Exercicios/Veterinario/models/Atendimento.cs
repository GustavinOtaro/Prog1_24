using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Veterinario.models
{
    public class Atendimento
    {
        public int Id {get; set; }
        public DateTime DtAtendimento {get; set; }
        public Animal Animal {get; set; }
        public Veterinario veterinario {get; set; }
        public string Observacao {get; set; }

    }
}