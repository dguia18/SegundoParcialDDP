using System;

namespace Domain.Behavioral.State
{
    public class Silencio : IPerfilDeAlerta
    {
        public void Alertar(Celular context)
        {
            Console.WriteLine("No estoy emitiendo alerta");
        }
    }
}
