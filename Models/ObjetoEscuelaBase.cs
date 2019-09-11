using System;

namespace Asp_.Net.Models
{
    public abstract class ObjetoEscuelaBase
    {
        public string Id { get;  set; }
        public string Nombre { get; set; }

        public ObjetoEscuelaBase()
        {
            
        }

        public override string ToString()
        {
            return $"{Nombre},{Id}";
        }
    }
}